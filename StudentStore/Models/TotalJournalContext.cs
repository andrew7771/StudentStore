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

        public virtual DbSet<AttendanceDates> AttendanceDates { get; set; }
        public virtual DbSet<Attendances> Attendances { get; set; }
        public virtual DbSet<CourseProjectLines> CourseProjectLines { get; set; }
        public virtual DbSet<CplineMaxPoints> CplineMaxPoints { get; set; }
        public virtual DbSet<FreeMarkFieldMaxPoints> FreeMarkFieldMaxPoints { get; set; }
        public virtual DbSet<FreeMarkFields> FreeMarkFields { get; set; }
        public virtual DbSet<GroupSubjects> GroupSubjects { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<HomeWorks> HomeWorks { get; set; }
        public virtual DbSet<HwmaxPoints> HwmaxPoints { get; set; }
        public virtual DbSet<LabMaxPoints> LabMaxPoints { get; set; }
        public virtual DbSet<Marks> Marks { get; set; }
        public virtual DbSet<ModuleMaxPoints> ModuleMaxPoints { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<OneItemPoints> OneItemPoints { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<SubjectCpgroups> SubjectCpgroups { get; set; }
        public virtual DbSet<SubjectCps> SubjectCps { get; set; }
        public virtual DbSet<SubjectCpstudents> SubjectCpstudents { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttendanceDates>(entity =>
            {
                entity.HasKey(e => e.AttendanceDateId)
                    .HasName("PK_dbo.AttendanceDates");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.AttendanceDates)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.AttendanceDates_dbo.Subjects_SubjectId");
            });

            modelBuilder.Entity<Attendances>(entity =>
            {
                entity.HasKey(e => e.AttendanceId)
                    .HasName("PK_dbo.Attendances");

                entity.HasIndex(e => e.RecordBookNumberId)
                    .HasName("IX_RecordBookNumberID");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectID");

                entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");

                entity.Property(e => e.ClassDate).HasColumnType("datetime");

                entity.Property(e => e.RecordBookNumberId)
                    .HasColumnName("RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.RecordBookNumber)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.RecordBookNumberId)
                    .HasConstraintName("FK_dbo.Attendances_dbo.Students_RecordBookNumberID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.Attendances_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<CourseProjectLines>(entity =>
            {
                entity.HasKey(e => e.CourseProjectLineId)
                    .HasName("PK_dbo.CourseProjectLines");

                entity.HasIndex(e => e.RecordBookNumberId)
                    .HasName("IX_RecordBookNumberID");

                entity.HasIndex(e => e.SubjectCpId)
                    .HasName("IX_SubjectCP_ID");

                entity.Property(e => e.CourseProjectLineId).HasColumnName("CourseProjectLineID");

                entity.Property(e => e.DateOfPassing).HasColumnType("datetime");

                entity.Property(e => e.RecordBookNumberId)
                    .HasColumnName("RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectCpId).HasColumnName("SubjectCP_ID");

                entity.HasOne(d => d.RecordBookNumber)
                    .WithMany(p => p.CourseProjectLines)
                    .HasForeignKey(d => d.RecordBookNumberId)
                    .HasConstraintName("FK_dbo.CourseProjectLines_dbo.Students_RecordBookNumberID");

                entity.HasOne(d => d.SubjectCp)
                    .WithMany(p => p.CourseProjectLines)
                    .HasForeignKey(d => d.SubjectCpId)
                    .HasConstraintName("FK_dbo.CourseProjectLines_dbo.SubjectCPs_SubjectCP_ID");
            });

            modelBuilder.Entity<CplineMaxPoints>(entity =>
            {
                entity.HasKey(e => e.CplineMaxPointId)
                    .HasName("PK_dbo.CPLineMaxPoints");

                entity.ToTable("CPLineMaxPoints");

                entity.HasIndex(e => e.SubjectCpSubjectCpId)
                    .HasName("IX_SubjectCP_SubjectCP_ID");

                entity.Property(e => e.CplineMaxPointId).HasColumnName("CPLineMaxPointID");

                entity.Property(e => e.SubjectCpSubjectCpId).HasColumnName("SubjectCP_SubjectCP_ID");

                entity.Property(e => e.SubjectCpid).HasColumnName("SubjectCPID");

                entity.HasOne(d => d.SubjectCpSubjectCp)
                    .WithMany(p => p.CplineMaxPoints)
                    .HasForeignKey(d => d.SubjectCpSubjectCpId)
                    .HasConstraintName("FK_dbo.CPLineMaxPoints_dbo.SubjectCPs_SubjectCP_SubjectCP_ID");
            });

            modelBuilder.Entity<FreeMarkFieldMaxPoints>(entity =>
            {
                entity.HasKey(e => e.FreeMarkFieldMaxPointId)
                    .HasName("PK_dbo.FreeMarkFieldMaxPoints");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectID");

                entity.Property(e => e.FreeMarkFieldMaxPointId).HasColumnName("FreeMarkFieldMaxPointID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.FreeMarkFieldMaxPoints)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.FreeMarkFieldMaxPoints_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<FreeMarkFields>(entity =>
            {
                entity.HasKey(e => e.FreeMarkFieldId)
                    .HasName("PK_dbo.FreeMarkFields");

                entity.HasIndex(e => new { e.FieldNumber, e.RecordBookNumberId, e.SubjectId })
                    .HasName("IX_FieldsNumberRecordBookNumberIDSubjectID")
                    .IsUnique();

                entity.Property(e => e.FreeMarkFieldId).HasColumnName("FreeMarkFieldID");

                entity.Property(e => e.RecordBookNumberId)
                    .HasColumnName("RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.RecordBookNumber)
                    .WithMany(p => p.FreeMarkFields)
                    .HasForeignKey(d => d.RecordBookNumberId)
                    .HasConstraintName("FK_dbo.FreeMarkFields_dbo.Students_RecordBookNumberID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.FreeMarkFields)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.FreeMarkFields_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<GroupSubjects>(entity =>
            {
                entity.HasKey(e => new { e.GroupGroupId, e.SubjectSubjectId })
                    .HasName("PK_dbo.GroupSubjects");

                entity.HasIndex(e => e.GroupGroupId)
                    .HasName("IX_Group_GroupID");

                entity.HasIndex(e => e.SubjectSubjectId)
                    .HasName("IX_Subject_SubjectID");

                entity.Property(e => e.GroupGroupId)
                    .HasColumnName("Group_GroupID")
                    .HasMaxLength(6);

                entity.Property(e => e.SubjectSubjectId).HasColumnName("Subject_SubjectID");

                entity.HasOne(d => d.GroupGroup)
                    .WithMany(p => p.GroupSubjects)
                    .HasForeignKey(d => d.GroupGroupId)
                    .HasConstraintName("FK_dbo.GroupSubjects_dbo.Groups_Group_GroupID");

                entity.HasOne(d => d.SubjectSubject)
                    .WithMany(p => p.GroupSubjects)
                    .HasForeignKey(d => d.SubjectSubjectId)
                    .HasConstraintName("FK_dbo.GroupSubjects_dbo.Subjects_Subject_SubjectID");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_dbo.Groups");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<HomeWorks>(entity =>
            {
                entity.HasKey(e => e.HomeWorkId)
                    .HasName("PK_dbo.HomeWorks");

                entity.HasIndex(e => new { e.RecordBookNumberId, e.SubjectId, e.Hwpoint, e.Hwnumber })
                    .HasName("IX_RecordBookNumberIDSubjectIDHomeWorkIDHWNumber")
                    .IsUnique();

                entity.Property(e => e.HomeWorkId).HasColumnName("HomeWorkID");

                entity.Property(e => e.DateOfProgram).HasColumnType("datetime");

                entity.Property(e => e.DateOfReport).HasColumnType("datetime");

                entity.Property(e => e.Hwnumber).HasColumnName("HWNumber");

                entity.Property(e => e.Hwpoint).HasColumnName("HWPoint");

                entity.Property(e => e.RecordBookNumberId)
                    .HasColumnName("RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.RecordBookNumber)
                    .WithMany(p => p.HomeWorks)
                    .HasForeignKey(d => d.RecordBookNumberId)
                    .HasConstraintName("FK_dbo.HomeWorks_dbo.Students_RecordBookNumberID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.HomeWorks)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.HomeWorks_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<HwmaxPoints>(entity =>
            {
                entity.HasKey(e => e.HwmaxPointId)
                    .HasName("PK_dbo.HWMaxPoints");

                entity.ToTable("HWMaxPoints");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectID");

                entity.Property(e => e.HwmaxPointId).HasColumnName("HWMaxPointID");

                entity.Property(e => e.Hwnumber).HasColumnName("HWNumber");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.HwmaxPoints)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.HWMaxPoints_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<LabMaxPoints>(entity =>
            {
                entity.HasKey(e => e.LabMaxPointId)
                    .HasName("PK_dbo.LabMaxPoints");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectID");

                entity.Property(e => e.LabMaxPointId).HasColumnName("LabMaxPointID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.LabMaxPoints)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.LabMaxPoints_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<Marks>(entity =>
            {
                entity.HasKey(e => e.MarkId)
                    .HasName("PK_dbo.Marks");

                entity.HasIndex(e => new { e.LabNumber, e.RecordBookNumberId, e.SubjectId })
                    .HasName("IX_LabNumberRecordBookNumberIDSubjectID")
                    .IsUnique();

                entity.Property(e => e.MarkId).HasColumnName("MarkID");

                entity.Property(e => e.DateOfProgram).HasColumnType("datetime");

                entity.Property(e => e.DateOfReport).HasColumnType("datetime");

                entity.Property(e => e.RecordBookNumberId)
                    .HasColumnName("RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.RecordBookNumber)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.RecordBookNumberId)
                    .HasConstraintName("FK_dbo.Marks_dbo.Students_RecordBookNumberID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.Marks_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<ModuleMaxPoints>(entity =>
            {
                entity.HasKey(e => e.ModuleMaxPointId)
                    .HasName("PK_dbo.ModuleMaxPoints");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectID");

                entity.Property(e => e.ModuleMaxPointId).HasColumnName("ModuleMaxPointID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.ModuleMaxPoints)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.ModuleMaxPoints_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<Modules>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK_dbo.Modules");

                entity.HasIndex(e => new { e.RecordBookNumberId, e.SubjectId, e.ModulePoint, e.ModuleNumber })
                    .HasName("IX_RecordBookNumberIDModuleIDModuleModulePoint")
                    .IsUnique();

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.RecordBookNumberId)
                    .HasColumnName("RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.RecordBookNumber)
                    .WithMany(p => p.Modules)
                    .HasForeignKey(d => d.RecordBookNumberId)
                    .HasConstraintName("FK_dbo.Modules_dbo.Students_RecordBookNumberID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Modules)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.Modules_dbo.Subjects_SubjectID");
            });

            modelBuilder.Entity<OneItemPoints>(entity =>
            {
                entity.HasKey(e => e.OneItemPointId)
                    .HasName("PK_dbo.OneItemPoints");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IX_SubjectId");

                entity.Property(e => e.OneItemPointId).HasColumnName("OneItemPointID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.OneItemPoints)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_dbo.OneItemPoints_dbo.Subjects_SubjectId");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.RecordBookNumberId)
                    .HasName("PK_dbo.Students");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupID");

                entity.Property(e => e.RecordBookNumberId)
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

            modelBuilder.Entity<SubjectCpgroups>(entity =>
            {
                entity.HasKey(e => new { e.SubjectCpSubjectCpId, e.GroupGroupId })
                    .HasName("PK_dbo.SubjectCPGroups");

                entity.ToTable("SubjectCPGroups");

                entity.HasIndex(e => e.GroupGroupId)
                    .HasName("IX_Group_GroupID");

                entity.HasIndex(e => e.SubjectCpSubjectCpId)
                    .HasName("IX_SubjectCP_SubjectCP_ID");

                entity.Property(e => e.SubjectCpSubjectCpId).HasColumnName("SubjectCP_SubjectCP_ID");

                entity.Property(e => e.GroupGroupId)
                    .HasColumnName("Group_GroupID")
                    .HasMaxLength(6);

                entity.HasOne(d => d.GroupGroup)
                    .WithMany(p => p.SubjectCpgroups)
                    .HasForeignKey(d => d.GroupGroupId)
                    .HasConstraintName("FK_dbo.SubjectCPGroups_dbo.Groups_Group_GroupID");

                entity.HasOne(d => d.SubjectCpSubjectCp)
                    .WithMany(p => p.SubjectCpgroups)
                    .HasForeignKey(d => d.SubjectCpSubjectCpId)
                    .HasConstraintName("FK_dbo.SubjectCPGroups_dbo.SubjectCPs_SubjectCP_SubjectCP_ID");
            });

            modelBuilder.Entity<SubjectCps>(entity =>
            {
                entity.HasKey(e => e.SubjectCpId)
                    .HasName("PK_dbo.SubjectCPs");

                entity.ToTable("SubjectCPs");

                entity.HasIndex(e => e.TeacherId)
                    .HasName("IX_TeacherID");

                entity.Property(e => e.SubjectCpId).HasColumnName("SubjectCP_ID");

                entity.Property(e => e.SubjectCpname).HasColumnName("SubjectCPName");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.SubjectCps)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_dbo.SubjectCPs_dbo.Teachers_TeacherID");
            });

            modelBuilder.Entity<SubjectCpstudents>(entity =>
            {
                entity.HasKey(e => new { e.SubjectCpSubjectCpId, e.StudentRecordBookNumberId })
                    .HasName("PK_dbo.SubjectCPStudents");

                entity.ToTable("SubjectCPStudents");

                entity.HasIndex(e => e.StudentRecordBookNumberId)
                    .HasName("IX_Student_RecordBookNumberID");

                entity.HasIndex(e => e.SubjectCpSubjectCpId)
                    .HasName("IX_SubjectCP_SubjectCP_ID");

                entity.Property(e => e.SubjectCpSubjectCpId).HasColumnName("SubjectCP_SubjectCP_ID");

                entity.Property(e => e.StudentRecordBookNumberId)
                    .HasColumnName("Student_RecordBookNumberID")
                    .HasMaxLength(128);

                entity.HasOne(d => d.StudentRecordBookNumber)
                    .WithMany(p => p.SubjectCpstudents)
                    .HasForeignKey(d => d.StudentRecordBookNumberId)
                    .HasConstraintName("FK_dbo.SubjectCPStudents_dbo.Students_Student_RecordBookNumberID");

                entity.HasOne(d => d.SubjectCpSubjectCp)
                    .WithMany(p => p.SubjectCpstudents)
                    .HasForeignKey(d => d.SubjectCpSubjectCpId)
                    .HasConstraintName("FK_dbo.SubjectCPStudents_dbo.SubjectCPs_SubjectCP_SubjectCP_ID");
            });

            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.HasKey(e => e.SubjectId)
                    .HasName("PK_dbo.Subjects");

                entity.HasIndex(e => e.StudentRecordBookNumberId)
                    .HasName("IX_Student_RecordBookNumberID");

                entity.HasIndex(e => e.TeacherId)
                    .HasName("IX_TeacherID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.StudentRecordBookNumberId)
                    .HasColumnName("Student_RecordBookNumberID")
                    .HasMaxLength(128);

                entity.Property(e => e.SubjectName).IsRequired();

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.HasOne(d => d.StudentRecordBookNumber)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.StudentRecordBookNumberId)
                    .HasConstraintName("FK_dbo.Subjects_dbo.Students_Student_RecordBookNumberID");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_dbo.Subjects_dbo.Teachers_TeacherID");
            });

            modelBuilder.Entity<Teachers>(entity =>
            {
                entity.HasKey(e => e.TeacherId)
                    .HasName("PK_dbo.Teachers");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

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
