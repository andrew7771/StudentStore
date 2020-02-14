using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudentStore.Models
{
    public partial class TotalJournalContext : DbContext
    {
        public TotalJournalContext()
        {
        }

        public TotalJournalContext(DbContextOptions<TotalJournalContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<AttendanceDate> AttendanceDates { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<CourseProjectLine> CourseProjectLines { get; set; }
        public virtual DbSet<CplineMaxPoint> CplineMaxPoints { get; set; }
        public virtual DbSet<FreeMarkFieldMaxPoint> FreeMarkFieldMaxPoints { get; set; }
        public virtual DbSet<FreeMarkField> FreeMarkFields { get; set; }
        public virtual DbSet<GroupSubjects> GroupSubjects { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<HomeWorks> HomeWorks { get; set; }
        public virtual DbSet<HwmaxPoint> HwmaxPoints { get; set; }
        public virtual DbSet<LabMaxPoint> LabMaxPoints { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<ModuleMaxPoint> ModuleMaxPoints { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<OneItemPoint> OneItemPoints { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<SubjectCpGroup> SubjectCpgroups { get; set; }
        public virtual DbSet<SubjectCp> SubjectCps { get; set; }
        public virtual DbSet<SubjectCpstudent> SubjectCpstudents { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttendanceDate>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.AttendanceDates");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.AttendanceDates)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.AttendanceDates_dbo.Subjects_SubjectId");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.Attendances");

                entity.HasIndex(e => e.StudentId)
                    .HasName("IX_RecordBookNumberID");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectID");

                entity.Property(e => e.Id).HasColumnName("AttendanceID");

                entity.Property(e => e.ClassDate).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .HasColumnName("RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_dbo.Attendances_dbo.Students_RecordBookNumberID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.Attendances_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<CourseProjectLine>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.CourseProjectLines");

                entity.HasIndex(e => e.StudentId)
                    .HasName("IX_RecordBookNumberID");

                entity.HasIndex(e => e.SubjectCpId)
                    .HasName("IX_SubjectCP_ID");

                entity.Property(e => e.Id).HasColumnName("CourseProjectLineID");

                entity.Property(e => e.DateOfPassing).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .HasColumnName("RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectCpId).HasColumnName("SubjectCP_ID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.CourseProjectLines)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_dbo.CourseProjectLines_dbo.Students_RecordBookNumberID");

                entity.HasOne(d => d.SubjectCp)
                    .WithMany(p => p.CourseProjectLines)
                    .HasForeignKey(d => d.SubjectCpId)
                    .HasConstraintName("FK_dbo.CourseProjectLines_dbo.SubjectCPs_SubjectCP_ID");
            });

            modelBuilder.Entity<CplineMaxPoint>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.CPLineMaxPoints");

                entity.ToTable("CPLineMaxPoints");

                entity.HasIndex(e => e.SubjectCpId)
                    .HasName("IX_SubjectCP_SubjectCP_ID");

                entity.Property(e => e.Id).HasColumnName("CPLineMaxPointID");

                entity.Property(e => e.SubjectCpId).HasColumnName("SubjectCP_SubjectCP_ID");

                entity.Property(e => e.SubjectCpid).HasColumnName("SubjectCPID");

                entity.HasOne(d => d.SubjectCp)
                    .WithMany(p => p.CplineMaxPoints)
                    .HasForeignKey(d => d.SubjectCpId)
                    .HasConstraintName("FK_dbo.CPLineMaxPoints_dbo.SubjectCPs_SubjectCP_SubjectCP_ID");
            });

            modelBuilder.Entity<FreeMarkFieldMaxPoint>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.FreeMarkFieldMaxPoints");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectID");

                entity.Property(e => e.Id).HasColumnName("FreeMarkFieldMaxPointID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.FreeMarkFieldMaxPoints)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.FreeMarkFieldMaxPoints_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<FreeMarkField>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.FreeMarkFields");

                entity.HasIndex(e => new { e.FieldNumber, e.StudentId, e.SubjectId })
                    .HasName("IX_FieldsNumberRecordBookNumberIDSubjectID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("FreeMarkFieldID");

                entity.Property(e => e.StudentId)
                    .HasColumnName("RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.FreeMarkFields)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_dbo.FreeMarkFields_dbo.Students_RecordBookNumberID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.FreeMarkFields)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.FreeMarkFields_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<GroupSubjects>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.SubjectId })
                    .HasName("PK_dbo.GroupSubjects");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_Group_GroupID");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_Subject_SubjectID");

                entity.Property(e => e.GroupId)
                    .HasColumnName("Group_GroupID")
                    .HasMaxLength(6);

                entity.Property(e => e.SubjectId).HasColumnName("Subject_SubjectID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupSubjects)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_dbo.GroupSubjects_dbo.Groups_Group_GroupID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.GroupSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.GroupSubjects_dbo.Subjects_Subject_SubjectID");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.Groups");

                entity.Property(e => e.Id)
                    .HasColumnName("GroupID")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<HomeWorks>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.HomeWorks");

                entity.HasIndex(e => new { e.StudentId, e.SubjectId, e.Hwpoint, e.Hwnumber })
                    .HasName("IX_RecordBookNumberIDSubjectIDHomeWorkIDHWNumber")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("HomeWorkID");

                entity.Property(e => e.DateOfProgram).HasColumnType("datetime");

                entity.Property(e => e.DateOfReport).HasColumnType("datetime");

                entity.Property(e => e.Hwnumber).HasColumnName("HWNumber");

                entity.Property(e => e.Hwpoint).HasColumnName("HWPoint");

                entity.Property(e => e.StudentId)
                    .HasColumnName("RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.HomeWorks)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_dbo.HomeWorks_dbo.Students_RecordBookNumberID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.HomeWorks)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.HomeWorks_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<HwmaxPoint>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.HWMaxPoints");

                entity.ToTable("HWMaxPoints");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectID");

                entity.Property(e => e.Id).HasColumnName("HWMaxPointID");

                entity.Property(e => e.Hwnumber).HasColumnName("HWNumber");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.HwmaxPoints)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.HWMaxPoints_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<LabMaxPoint>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.LabMaxPoints");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectID");

                entity.Property(e => e.Id).HasColumnName("LabMaxPointID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.LabMaxPoints)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.LabMaxPoints_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.Marks");

                entity.HasIndex(e => new { e.LabNumber, e.StudentId, e.SubjectId })
                    .HasName("IX_LabNumberRecordBookNumberIDSubjectID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("MarkID");

                entity.Property(e => e.DateOfProgram).HasColumnType("datetime");

                entity.Property(e => e.DateOfReport).HasColumnType("datetime");

                entity.Property(e => e.StudentId)
                    .HasColumnName("RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_dbo.Marks_dbo.Students_RecordBookNumberID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.Marks_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<ModuleMaxPoint>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.ModuleMaxPoints");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectID");

                entity.Property(e => e.Id).HasColumnName("ModuleMaxPointID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.ModuleMaxPoints)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.ModuleMaxPoints_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.Modules");

                entity.HasIndex(e => new { e.StudentId, e.SubjectId, e.ModulePoint, e.ModuleNumber })
                    .HasName("IX_RecordBookNumberIDModuleIDModuleModulePoint")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ModuleID");

                entity.Property(e => e.StudentId)
                    .HasColumnName("RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Modules)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_dbo.Modules_dbo.Students_RecordBookNumberID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Modules)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.Modules_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<OneItemPoint>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.OneItemPoints");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectId");

                entity.Property(e => e.Id).HasColumnName("OneItemPointID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.OneItemPoints)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.OneItemPoints_dbo.Subjects_SubjectId");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.Students");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupID");

                entity.Property(e => e.Id)
                    .HasColumnName("RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasMaxLength(6);

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.MiddleName).IsRequired();

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_dbo.Students_dbo.Groups_GroupID");
            });

            modelBuilder.Entity<SubjectCpGroup>(entity =>
            {
                entity.HasKey(e => new { e.SubjectCpId, e.GroupId })
                    .HasName("PK_dbo.SubjectCPGroups");

                entity.ToTable("SubjectCPGroups");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_Group_GroupID");

                entity.HasIndex(e => e.SubjectCpId)
                    .HasName("IX_SubjectCP_SubjectCP_ID");

                entity.Property(e => e.SubjectCpId).HasColumnName("SubjectCP_SubjectCP_ID");

                entity.Property(e => e.GroupId)
                    .HasColumnName("Group_GroupID")
                    .HasMaxLength(6);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.SubjectCpgroups)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_dbo.SubjectCPGroups_dbo.Groups_Group_GroupID");

                entity.HasOne(d => d.SubjectCp)
                    .WithMany(p => p.SubjectCpgroups)
                    .HasForeignKey(d => d.SubjectCpId)
                    .HasConstraintName("FK_dbo.SubjectCPGroups_dbo.SubjectCPs_SubjectCP_SubjectCP_ID");
            });

            modelBuilder.Entity<SubjectCp>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.SubjectCPs");

                entity.ToTable("SubjectCPs");

                entity.HasIndex(e => e.TeacherId)
                    .HasName("IX_TeacherId");

                entity.Property(e => e.SubjectCpname).HasColumnName("SubjectCPName");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherId");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.SubjectCps)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_dbo.SubjectCPs_dbo.Teachers_TeacherId");
            });

            modelBuilder.Entity<SubjectCpstudent>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.StudentId })
                    .HasName("PK_dbo.SubjectCPStudents");

                entity.ToTable("SubjectCPStudents");

                entity.HasIndex(e => e.StudentId)
                    .HasName("IX_Student_StudentId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_SubjectCP_SubjectCP_ID");

                entity.Property(e => e.Id).HasColumnName("SubjectCP_SubjectCP_ID");

                entity.Property(e => e.StudentId)
                    .HasColumnName("Student_StudentId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.SubjectCpstudents)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_dbo.SubjectCPStudents_dbo.Students_Student_StudentId");

                entity.HasOne(d => d.SubjectCpSubjectCp)
                    .WithMany(p => p.SubjectCpstudents)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_dbo.SubjectCPStudents_dbo.SubjectCPs_SubjectCP_SubjectCP_ID");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.Subjects");

                entity.HasIndex(e => e.StudentId)
                    .HasName("IX_Student_StudentId");

                entity.HasIndex(e => e.TeacherId)
                    .HasName("IX_TeacherId");

                entity.Property(e => e.StudentId)
                    .HasColumnName("Student_StudentId")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectName).IsRequired();

                entity.Property(e => e.TeacherId).HasColumnName("TeacherId");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.StudentId);

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.TeacherId);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.Teachers");

                entity.Property(e => e.AcadDegree).IsRequired();
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.MiddleName).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
