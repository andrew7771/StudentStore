﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentStore.Models;

namespace StudentStore.Migrations
{
    [DbContext(typeof(TotalJournalContext))]
    [Migration("20200213175232_Updates_04")]
    partial class Updates_04
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentStore.Models.AttendanceDates", b =>
                {
                    b.Property<int>("AttendanceDateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("AttendanceDateId")
                        .HasName("PK_dbo.AttendanceDates");

                    b.HasIndex("SubjectId")
                        .HasName("IX_SubjectId");

                    b.ToTable("AttendanceDates");
                });

            modelBuilder.Entity("StudentStore.Models.Attendances", b =>
                {
                    b.Property<int>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AttendanceID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ClassDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<bool>("IsVisited")
                        .HasColumnType("bit");

                    b.Property<string>("RecordBookNumberId")
                        .HasColumnName("RecordBookNumberID")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("SubjectId")
                        .HasColumnName("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("AttendanceId")
                        .HasName("PK_dbo.Attendances");

                    b.HasIndex("RecordBookNumberId")
                        .HasName("IX_RecordBookNumberID");

                    b.HasIndex("SubjectId")
                        .HasName("IX_SubjectID");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("StudentStore.Models.CourseProjectLines", b =>
                {
                    b.Property<int>("CourseProjectLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CourseProjectLineID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfPassing")
                        .HasColumnType("datetime");

                    b.Property<int>("LineIndex")
                        .HasColumnType("int");

                    b.Property<string>("LineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordBookNumberId")
                        .HasColumnName("RecordBookNumberID")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("SubjectCpId")
                        .HasColumnName("SubjectCP_ID")
                        .HasColumnType("int");

                    b.Property<int>("TheMark")
                        .HasColumnType("int");

                    b.HasKey("CourseProjectLineId")
                        .HasName("PK_dbo.CourseProjectLines");

                    b.HasIndex("RecordBookNumberId")
                        .HasName("IX_RecordBookNumberID");

                    b.HasIndex("SubjectCpId")
                        .HasName("IX_SubjectCP_ID");

                    b.ToTable("CourseProjectLines");
                });

            modelBuilder.Entity("StudentStore.Models.CplineMaxPoints", b =>
                {
                    b.Property<int>("CplineMaxPointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CPLineMaxPointID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LineIndex")
                        .HasColumnType("int");

                    b.Property<string>("LineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxPoint")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectCpSubjectCpId")
                        .HasColumnName("SubjectCP_SubjectCP_ID")
                        .HasColumnType("int");

                    b.Property<int>("SubjectCpid")
                        .HasColumnName("SubjectCPID")
                        .HasColumnType("int");

                    b.HasKey("CplineMaxPointId")
                        .HasName("PK_dbo.CPLineMaxPoints");

                    b.HasIndex("SubjectCpSubjectCpId")
                        .HasName("IX_SubjectCP_SubjectCP_ID");

                    b.ToTable("CPLineMaxPoints");
                });

            modelBuilder.Entity("StudentStore.Models.FreeMarkFieldMaxPoints", b =>
                {
                    b.Property<int>("FreeMarkFieldMaxPointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FreeMarkFieldMaxPointID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FieldName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FieldNumber")
                        .HasColumnType("int");

                    b.Property<int>("MaxPoint")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnName("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("FreeMarkFieldMaxPointId")
                        .HasName("PK_dbo.FreeMarkFieldMaxPoints");

                    b.HasIndex("SubjectId")
                        .HasName("IX_SubjectID");

                    b.ToTable("FreeMarkFieldMaxPoints");
                });

            modelBuilder.Entity("StudentStore.Models.FreeMarkFields", b =>
                {
                    b.Property<int>("FreeMarkFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FreeMarkFieldID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FieldName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FieldNumber")
                        .HasColumnType("int");

                    b.Property<int>("FieldPoint")
                        .HasColumnType("int");

                    b.Property<string>("RecordBookNumberId")
                        .HasColumnName("RecordBookNumberID")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("SubjectId")
                        .HasColumnName("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("FreeMarkFieldId")
                        .HasName("PK_dbo.FreeMarkFields");

                    b.HasIndex("RecordBookNumberId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("FieldNumber", "RecordBookNumberId", "SubjectId")
                        .IsUnique()
                        .HasName("IX_FieldsNumberRecordBookNumberIDSubjectID")
                        .HasFilter("[RecordBookNumberID] IS NOT NULL");

                    b.ToTable("FreeMarkFields");
                });

            modelBuilder.Entity("StudentStore.Models.GroupSubjects", b =>
                {
                    b.Property<string>("GroupGroupId")
                        .HasColumnName("Group_GroupID")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<int>("SubjectSubjectId")
                        .HasColumnName("Subject_SubjectID")
                        .HasColumnType("int");

                    b.HasKey("GroupGroupId", "SubjectSubjectId")
                        .HasName("PK_dbo.GroupSubjects");

                    b.HasIndex("GroupGroupId")
                        .HasName("IX_Group_GroupID");

                    b.HasIndex("SubjectSubjectId")
                        .HasName("IX_Subject_SubjectID");

                    b.ToTable("GroupSubjects");
                });

            modelBuilder.Entity("StudentStore.Models.Groups", b =>
                {
                    b.Property<string>("GroupId")
                        .HasColumnName("GroupID")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<int>("CourseNumber")
                        .HasColumnType("int");

                    b.HasKey("GroupId")
                        .HasName("PK_dbo.Groups");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("StudentStore.Models.HomeWorks", b =>
                {
                    b.Property<int>("HomeWorkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("HomeWorkID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfProgram")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateOfReport")
                        .HasColumnType("datetime");

                    b.Property<int>("Hwnumber")
                        .HasColumnName("HWNumber")
                        .HasColumnType("int");

                    b.Property<int>("Hwpoint")
                        .HasColumnName("HWPoint")
                        .HasColumnType("int");

                    b.Property<string>("RecordBookNumberId")
                        .HasColumnName("RecordBookNumberID")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("SubjectId")
                        .HasColumnName("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("HomeWorkId")
                        .HasName("PK_dbo.HomeWorks");

                    b.HasIndex("SubjectId");

                    b.HasIndex("RecordBookNumberId", "SubjectId", "Hwpoint", "Hwnumber")
                        .IsUnique()
                        .HasName("IX_RecordBookNumberIDSubjectIDHomeWorkIDHWNumber")
                        .HasFilter("[RecordBookNumberID] IS NOT NULL");

                    b.ToTable("HomeWorks");
                });

            modelBuilder.Entity("StudentStore.Models.HwmaxPoints", b =>
                {
                    b.Property<int>("HwmaxPointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("HWMaxPointID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Hwnumber")
                        .HasColumnName("HWNumber")
                        .HasColumnType("int");

                    b.Property<int>("MaxPoint")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnName("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("HwmaxPointId")
                        .HasName("PK_dbo.HWMaxPoints");

                    b.HasIndex("SubjectId")
                        .HasName("IX_SubjectID");

                    b.ToTable("HWMaxPoints");
                });

            modelBuilder.Entity("StudentStore.Models.LabMaxPoints", b =>
                {
                    b.Property<int>("LabMaxPointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LabMaxPointID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LabNumber")
                        .HasColumnType("int");

                    b.Property<int>("MaxPoint")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnName("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("LabMaxPointId")
                        .HasName("PK_dbo.LabMaxPoints");

                    b.HasIndex("SubjectId")
                        .HasName("IX_SubjectID");

                    b.ToTable("LabMaxPoints");
                });

            modelBuilder.Entity("StudentStore.Models.Marks", b =>
                {
                    b.Property<int>("MarkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MarkID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfProgram")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateOfReport")
                        .HasColumnType("datetime");

                    b.Property<int>("LabNumber")
                        .HasColumnType("int");

                    b.Property<string>("RecordBookNumberId")
                        .HasColumnName("RecordBookNumberID")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("SubjectId")
                        .HasColumnName("SubjectID")
                        .HasColumnType("int");

                    b.Property<int>("TheMark")
                        .HasColumnType("int");

                    b.HasKey("MarkId")
                        .HasName("PK_dbo.Marks");

                    b.HasIndex("RecordBookNumberId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("LabNumber", "RecordBookNumberId", "SubjectId")
                        .IsUnique()
                        .HasName("IX_LabNumberRecordBookNumberIDSubjectID")
                        .HasFilter("[RecordBookNumberID] IS NOT NULL");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("StudentStore.Models.ModuleMaxPoints", b =>
                {
                    b.Property<int>("ModuleMaxPointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModuleMaxPointID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxPoint")
                        .HasColumnType("int");

                    b.Property<int>("ModuleNumber")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnName("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("ModuleMaxPointId")
                        .HasName("PK_dbo.ModuleMaxPoints");

                    b.HasIndex("SubjectId")
                        .HasName("IX_SubjectID");

                    b.ToTable("ModuleMaxPoints");
                });

            modelBuilder.Entity("StudentStore.Models.Modules", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModuleID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ModuleNumber")
                        .HasColumnType("int");

                    b.Property<int>("ModulePoint")
                        .HasColumnType("int");

                    b.Property<string>("RecordBookNumberId")
                        .HasColumnName("RecordBookNumberID")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("SubjectId")
                        .HasColumnName("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("ModuleId")
                        .HasName("PK_dbo.Modules");

                    b.HasIndex("SubjectId");

                    b.HasIndex("RecordBookNumberId", "SubjectId", "ModulePoint", "ModuleNumber")
                        .IsUnique()
                        .HasName("IX_RecordBookNumberIDModuleIDModuleModulePoint")
                        .HasFilter("[RecordBookNumberID] IS NOT NULL");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("StudentStore.Models.OneItemPoints", b =>
                {
                    b.Property<int>("OneItemPointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OneItemPointID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OneItemPointId")
                        .HasName("PK_dbo.OneItemPoints");

                    b.HasIndex("SubjectId")
                        .HasName("IX_SubjectId");

                    b.ToTable("OneItemPoints");
                });

            modelBuilder.Entity("StudentStore.Models.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("Id")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupId")
                        .HasColumnName("GroupID")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_dbo.Students");

                    b.HasIndex("GroupId")
                        .HasName("IX_GroupID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentStore.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudentId")
                        .HasColumnName("Student_StudentId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectType")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnName("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_dbo.Subjects");

                    b.HasIndex("StudentId")
                        .HasName("IX_Student_StudentId");

                    b.HasIndex("TeacherId")
                        .HasName("IX_TeacherId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("StudentStore.Models.SubjectCp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectCpname")
                        .HasColumnName("SubjectCPName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnName("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("Term")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_dbo.SubjectCPs");

                    b.HasIndex("TeacherId")
                        .HasName("IX_TeacherId");

                    b.ToTable("SubjectCPs");
                });

            modelBuilder.Entity("StudentStore.Models.SubjectCpGroup", b =>
                {
                    b.Property<int>("SubjectCpId")
                        .HasColumnName("SubjectCP_SubjectCP_ID")
                        .HasColumnType("int");

                    b.Property<string>("GroupId")
                        .HasColumnName("Group_GroupID")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.HasKey("SubjectCpId", "GroupId")
                        .HasName("PK_dbo.SubjectCPGroups");

                    b.HasIndex("GroupId")
                        .HasName("IX_Group_GroupID");

                    b.HasIndex("SubjectCpId")
                        .HasName("IX_SubjectCP_SubjectCP_ID");

                    b.ToTable("SubjectCPGroups");
                });

            modelBuilder.Entity("StudentStore.Models.SubjectCpstudent", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("SubjectCP_SubjectCP_ID")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .HasColumnName("Student_StudentId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("Id", "StudentId")
                        .HasName("PK_dbo.SubjectCPStudents");

                    b.HasIndex("Id")
                        .HasName("IX_SubjectCP_SubjectCP_ID");

                    b.HasIndex("StudentId")
                        .HasName("IX_Student_StudentId");

                    b.ToTable("SubjectCPStudents");
                });

            modelBuilder.Entity("StudentStore.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcadDegree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_dbo.Teachers");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("StudentStore.Models.AttendanceDates", b =>
                {
                    b.HasOne("StudentStore.Models.Subject", "Subject")
                        .WithMany("AttendanceDates")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_dbo.AttendanceDates_dbo.Subjects_SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.Attendances", b =>
                {
                    b.HasOne("StudentStore.Models.Student", "RecordBookNumber")
                        .WithMany("Attendances")
                        .HasForeignKey("RecordBookNumberId")
                        .HasConstraintName("FK_dbo.Attendances_dbo.Students_RecordBookNumberID");

                    b.HasOne("StudentStore.Models.Subject", "Subject")
                        .WithMany("Attendances")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_dbo.Attendances_dbo.Subjects_SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.CourseProjectLines", b =>
                {
                    b.HasOne("StudentStore.Models.Student", "RecordBookNumber")
                        .WithMany("CourseProjectLines")
                        .HasForeignKey("RecordBookNumberId")
                        .HasConstraintName("FK_dbo.CourseProjectLines_dbo.Students_RecordBookNumberID");

                    b.HasOne("StudentStore.Models.SubjectCp", "SubjectCp")
                        .WithMany("CourseProjectLines")
                        .HasForeignKey("SubjectCpId")
                        .HasConstraintName("FK_dbo.CourseProjectLines_dbo.SubjectCPs_SubjectCP_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.CplineMaxPoints", b =>
                {
                    b.HasOne("StudentStore.Models.SubjectCp", "SubjectCpSubjectCp")
                        .WithMany("CplineMaxPoints")
                        .HasForeignKey("SubjectCpSubjectCpId")
                        .HasConstraintName("FK_dbo.CPLineMaxPoints_dbo.SubjectCPs_SubjectCP_SubjectCP_ID");
                });

            modelBuilder.Entity("StudentStore.Models.FreeMarkFieldMaxPoints", b =>
                {
                    b.HasOne("StudentStore.Models.Subject", "Subject")
                        .WithMany("FreeMarkFieldMaxPoints")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_dbo.FreeMarkFieldMaxPoints_dbo.Subjects_SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.FreeMarkFields", b =>
                {
                    b.HasOne("StudentStore.Models.Student", "RecordBookNumber")
                        .WithMany("FreeMarkFields")
                        .HasForeignKey("RecordBookNumberId")
                        .HasConstraintName("FK_dbo.FreeMarkFields_dbo.Students_RecordBookNumberID");

                    b.HasOne("StudentStore.Models.Subject", "Subject")
                        .WithMany("FreeMarkFields")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_dbo.FreeMarkFields_dbo.Subjects_SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.GroupSubjects", b =>
                {
                    b.HasOne("StudentStore.Models.Groups", "GroupGroup")
                        .WithMany("GroupSubjects")
                        .HasForeignKey("GroupGroupId")
                        .HasConstraintName("FK_dbo.GroupSubjects_dbo.Groups_Group_GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentStore.Models.Subject", "SubjectSubject")
                        .WithMany("GroupSubjects")
                        .HasForeignKey("SubjectSubjectId")
                        .HasConstraintName("FK_dbo.GroupSubjects_dbo.Subjects_Subject_SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.HomeWorks", b =>
                {
                    b.HasOne("StudentStore.Models.Student", "RecordBookNumber")
                        .WithMany("HomeWorks")
                        .HasForeignKey("RecordBookNumberId")
                        .HasConstraintName("FK_dbo.HomeWorks_dbo.Students_RecordBookNumberID");

                    b.HasOne("StudentStore.Models.Subject", "Subject")
                        .WithMany("HomeWorks")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_dbo.HomeWorks_dbo.Subjects_SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.HwmaxPoints", b =>
                {
                    b.HasOne("StudentStore.Models.Subject", "Subject")
                        .WithMany("HwmaxPoints")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_dbo.HWMaxPoints_dbo.Subjects_SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.LabMaxPoints", b =>
                {
                    b.HasOne("StudentStore.Models.Subject", "Subject")
                        .WithMany("LabMaxPoints")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_dbo.LabMaxPoints_dbo.Subjects_SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.Marks", b =>
                {
                    b.HasOne("StudentStore.Models.Student", "RecordBookNumber")
                        .WithMany("Marks")
                        .HasForeignKey("RecordBookNumberId")
                        .HasConstraintName("FK_dbo.Marks_dbo.Students_RecordBookNumberID");

                    b.HasOne("StudentStore.Models.Subject", "Subject")
                        .WithMany("Marks")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_dbo.Marks_dbo.Subjects_SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.ModuleMaxPoints", b =>
                {
                    b.HasOne("StudentStore.Models.Subject", "Subject")
                        .WithMany("ModuleMaxPoints")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_dbo.ModuleMaxPoints_dbo.Subjects_SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.Modules", b =>
                {
                    b.HasOne("StudentStore.Models.Student", "RecordBookNumber")
                        .WithMany("Modules")
                        .HasForeignKey("RecordBookNumberId")
                        .HasConstraintName("FK_dbo.Modules_dbo.Students_RecordBookNumberID");

                    b.HasOne("StudentStore.Models.Subject", "Subject")
                        .WithMany("Modules")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_dbo.Modules_dbo.Subjects_SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.OneItemPoints", b =>
                {
                    b.HasOne("StudentStore.Models.Subject", "Subject")
                        .WithMany("OneItemPoints")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_dbo.OneItemPoints_dbo.Subjects_SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.Student", b =>
                {
                    b.HasOne("StudentStore.Models.Groups", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK_dbo.Students_dbo.Groups_GroupID");
                });

            modelBuilder.Entity("StudentStore.Models.Subject", b =>
                {
                    b.HasOne("StudentStore.Models.Student", "Student")
                        .WithMany("Subjects")
                        .HasForeignKey("StudentId");

                    b.HasOne("StudentStore.Models.Teacher", "Teacher")
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.SubjectCp", b =>
                {
                    b.HasOne("StudentStore.Models.Teacher", "Teacher")
                        .WithMany("SubjectCps")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("FK_dbo.SubjectCPs_dbo.Teachers_TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.SubjectCpGroup", b =>
                {
                    b.HasOne("StudentStore.Models.Groups", "Group")
                        .WithMany("SubjectCpgroups")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK_dbo.SubjectCPGroups_dbo.Groups_Group_GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentStore.Models.SubjectCp", "SubjectCp")
                        .WithMany("SubjectCpgroups")
                        .HasForeignKey("SubjectCpId")
                        .HasConstraintName("FK_dbo.SubjectCPGroups_dbo.SubjectCPs_SubjectCP_SubjectCP_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Models.SubjectCpstudent", b =>
                {
                    b.HasOne("StudentStore.Models.SubjectCp", "SubjectCpSubjectCp")
                        .WithMany("SubjectCpstudents")
                        .HasForeignKey("Id")
                        .HasConstraintName("FK_dbo.SubjectCPStudents_dbo.SubjectCPs_SubjectCP_SubjectCP_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentStore.Models.Student", "Student")
                        .WithMany("SubjectCpstudents")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK_dbo.SubjectCPStudents_dbo.Students_Student_StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
