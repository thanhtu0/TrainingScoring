﻿// <auto-generated />
using System;
using ChamDiemRenLuyen.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChamDiemRenLuyen.Data.Migrations
{
    [DbContext(typeof(TrainingScroingDBContext))]
    [Migration("20240423045828_AddBirthDateForStudentAndLecturerTable")]
    partial class AddBirthDateForStudentAndLecturerTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.AcademicYear", b =>
                {
                    b.Property<int>("AcademicYearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AcademicYearId"), 1L, 1);

                    b.Property<string>("AcademicYearName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AcademicYearId");

                    b.ToTable("AcademicYear");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Advisor", b =>
                {
                    b.Property<string>("LecturerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndYear")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartYear")
                        .HasColumnType("datetime2");

                    b.HasKey("LecturerId", "GradeId");

                    b.HasIndex("GradeId");

                    b.ToTable("Advisor");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.ClassCommittee", b =>
                {
                    b.Property<int>("ClassCommitteeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassCommitteeId"), 1L, 1);

                    b.Property<string>("ClassCommitteeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ClassCommitteeId");

                    b.ToTable("ClassCommittee");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("EndYear")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartYear")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.EvaluationForm", b =>
                {
                    b.Property<int>("EvalutionFormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EvalutionFormId"), 1L, 1);

                    b.Property<int>("AcademicYearId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateFinished")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStarted")
                        .HasColumnType("datetime2");

                    b.Property<string>("EvaluationFormName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.HasKey("EvalutionFormId");

                    b.HasIndex("AcademicYearId");

                    b.HasIndex("SemesterId");

                    b.ToTable("EvaluationForm");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeId"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("GradeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MajorId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPupils")
                        .HasColumnType("int");

                    b.HasKey("GradeId");

                    b.HasIndex("CourseId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("MajorId");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Lecturer", b =>
                {
                    b.Property<string>("LecturerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LecturerId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Lecturer");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.LecturerRoleAssignment", b =>
                {
                    b.Property<string>("LecturerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("LecturerId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("LecturerRoleAssignment");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Major", b =>
                {
                    b.Property<int>("MajorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MajorId"), 1L, 1);

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("MajorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MajorId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Major");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.ProcessDetail", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailId"), 1L, 1);

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("DetailId");

                    b.HasIndex("ProcessId");

                    b.HasIndex("RoleId");

                    b.ToTable("ProcessDetail");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Proof", b =>
                {
                    b.Property<int>("ProofId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProofId"), 1L, 1);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSizeByte")
                        .HasColumnType("bigint");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProofId");

                    b.ToTable("Proof");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Score", b =>
                {
                    b.Property<int>("ScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScoreId"), 1L, 1);

                    b.Property<int>("AcademicYearId")
                        .HasColumnType("int");

                    b.Property<int>("EvalutionFormId")
                        .HasColumnType("int");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.Property<int>("ScoreDetailId")
                        .HasColumnType("int");

                    b.Property<int>("ScoringProcessProcessId")
                        .HasColumnType("int");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ScoreId");

                    b.HasIndex("AcademicYearId");

                    b.HasIndex("EvalutionFormId");

                    b.HasIndex("ScoreDetailId");

                    b.HasIndex("ScoringProcessProcessId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("StudentId");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.ScoreDetail", b =>
                {
                    b.Property<int>("ScoreDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScoreDetailId"), 1L, 1);

                    b.Property<DateTime>("ScoreDetailDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ScoreDetailValue")
                        .HasColumnType("int");

                    b.HasKey("ScoreDetailId");

                    b.ToTable("ScoreDetail");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.ScoringProcess", b =>
                {
                    b.Property<int>("ProcessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProcessId"), 1L, 1);

                    b.Property<string>("ProcessName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProcessId");

                    b.ToTable("ScoringProcess");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Semester", b =>
                {
                    b.Property<int>("SemesterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SemesterId"), 1L, 1);

                    b.Property<string>("SemesterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SemesterId");

                    b.ToTable("Semester");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("GradeId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.StudentClassCommittee", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ClassCommitteeId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "ClassCommitteeId");

                    b.HasIndex("ClassCommitteeId");

                    b.ToTable("StudentClassCommittee");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.TrainingContent", b =>
                {
                    b.Property<int>("TrainingContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainingContentId"), 1L, 1);

                    b.Property<bool>("IsProof")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxScore")
                        .HasColumnType("int");

                    b.Property<string>("TrainingContentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrainingDirectoryId")
                        .HasColumnType("int");

                    b.HasKey("TrainingContentId");

                    b.HasIndex("TrainingDirectoryId");

                    b.ToTable("TrainingContent");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.TrainingContentProof", b =>
                {
                    b.Property<int>("TrainingContentId")
                        .HasColumnType("int");

                    b.Property<int>("ProofId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("TrainingContentId", "ProofId");

                    b.HasIndex("ProofId")
                        .IsUnique();

                    b.ToTable("TrainingContentProof");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.TrainingDetail", b =>
                {
                    b.Property<int>("TrainingDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainingDetailId"), 1L, 1);

                    b.Property<bool>("IsProof")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxScore")
                        .HasColumnType("int");

                    b.Property<int>("TrainingContentId")
                        .HasColumnType("int");

                    b.Property<string>("TrainingDetailName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TrainingDetailId");

                    b.HasIndex("TrainingContentId");

                    b.ToTable("TrainingDetail");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.TrainingDirectory", b =>
                {
                    b.Property<int>("TrainingDirectoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainingDirectoryId"), 1L, 1);

                    b.Property<int>("EvaluationFormId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxScore")
                        .HasColumnType("int");

                    b.Property<string>("TrainingDirectoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TrainingDirectoryId");

                    b.HasIndex("EvaluationFormId");

                    b.ToTable("TrainingDirectory");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.TraniningDetailProof", b =>
                {
                    b.Property<int>("TrainingDetailId")
                        .HasColumnType("int");

                    b.Property<int>("ProofId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("TrainingDetailId", "ProofId");

                    b.HasIndex("ProofId")
                        .IsUnique();

                    b.ToTable("TraniningDetailProof");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Advisor", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.Grade", "Grade")
                        .WithMany("Advisors")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.Lecturer", "Lecturer")
                        .WithMany("Advisors")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Grade");

                    b.Navigation("Lecturer");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.EvaluationForm", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.AcademicYear", "AcademicYear")
                        .WithMany("EvaluationForms")
                        .HasForeignKey("AcademicYearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.Semester", "Semester")
                        .WithMany("EvaluationForms")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AcademicYear");

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Grade", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.Course", "Course")
                        .WithMany("Grades")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.Department", "Department")
                        .WithMany("Grades")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.Major", "Major")
                        .WithMany("Grades")
                        .HasForeignKey("MajorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");

                    b.Navigation("Major");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Lecturer", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.Department", "Department")
                        .WithMany("Lecturers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.LecturerRoleAssignment", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.Lecturer", "Lecturer")
                        .WithMany("LecturerRoleAssignments")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.Role", "Role")
                        .WithMany("LecturerRoleAssignments")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecturer");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Major", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.Department", null)
                        .WithMany("Majors")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.ProcessDetail", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.ScoringProcess", "ScoringProcess")
                        .WithMany("ProcessDetail")
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.Role", "Role")
                        .WithMany("ProcessDetail")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("ScoringProcess");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Score", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.AcademicYear", "AcademicYear")
                        .WithMany("Scores")
                        .HasForeignKey("AcademicYearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.EvaluationForm", "EvaluationForm")
                        .WithMany("Scores")
                        .HasForeignKey("EvalutionFormId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.ScoreDetail", "ScoreDetail")
                        .WithMany("Scores")
                        .HasForeignKey("ScoreDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.ScoringProcess", "ScoringProcess")
                        .WithMany("Scores")
                        .HasForeignKey("ScoringProcessProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.Semester", "Semester")
                        .WithMany("Scores")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.Student", "Student")
                        .WithMany("Scores")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AcademicYear");

                    b.Navigation("EvaluationForm");

                    b.Navigation("ScoreDetail");

                    b.Navigation("ScoringProcess");

                    b.Navigation("Semester");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Student", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.StudentClassCommittee", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.ClassCommittee", "ClassCommittee")
                        .WithMany("StudentClassCommittees")
                        .HasForeignKey("ClassCommitteeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.Student", "Student")
                        .WithMany("StudentClassCommittees")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassCommittee");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.TrainingContent", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.TrainingDirectory", "TrainingDirectory")
                        .WithMany("TrainingContents")
                        .HasForeignKey("TrainingDirectoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrainingDirectory");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.TrainingContentProof", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.Proof", "Proof")
                        .WithOne("TrainingContentProofs")
                        .HasForeignKey("ChamDiemRenLuyen.DomainModels.TrainingContentProof", "ProofId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.TrainingContent", "TrainingContent")
                        .WithMany("TrainingContentProofs")
                        .HasForeignKey("TrainingContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proof");

                    b.Navigation("TrainingContent");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.TrainingDetail", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.TrainingContent", "TrainingContent")
                        .WithMany("TrainingDetails")
                        .HasForeignKey("TrainingContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrainingContent");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.TrainingDirectory", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.EvaluationForm", "EvaluationForm")
                        .WithMany("TrainingDirectories")
                        .HasForeignKey("EvaluationFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EvaluationForm");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.TraniningDetailProof", b =>
                {
                    b.HasOne("ChamDiemRenLuyen.DomainModels.Proof", "Proof")
                        .WithOne("TraniningDetailProofs")
                        .HasForeignKey("ChamDiemRenLuyen.DomainModels.TraniningDetailProof", "ProofId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChamDiemRenLuyen.DomainModels.TrainingDetail", "TrainingDetail")
                        .WithMany("TraniningDetailProofs")
                        .HasForeignKey("TrainingDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proof");

                    b.Navigation("TrainingDetail");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.AcademicYear", b =>
                {
                    b.Navigation("EvaluationForms");

                    b.Navigation("Scores");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.ClassCommittee", b =>
                {
                    b.Navigation("StudentClassCommittees");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Course", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Department", b =>
                {
                    b.Navigation("Grades");

                    b.Navigation("Lecturers");

                    b.Navigation("Majors");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.EvaluationForm", b =>
                {
                    b.Navigation("Scores");

                    b.Navigation("TrainingDirectories");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Grade", b =>
                {
                    b.Navigation("Advisors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Lecturer", b =>
                {
                    b.Navigation("Advisors");

                    b.Navigation("LecturerRoleAssignments");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Major", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Proof", b =>
                {
                    b.Navigation("TrainingContentProofs")
                        .IsRequired();

                    b.Navigation("TraniningDetailProofs")
                        .IsRequired();
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Role", b =>
                {
                    b.Navigation("LecturerRoleAssignments");

                    b.Navigation("ProcessDetail");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.ScoreDetail", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.ScoringProcess", b =>
                {
                    b.Navigation("ProcessDetail");

                    b.Navigation("Scores");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Semester", b =>
                {
                    b.Navigation("EvaluationForms");

                    b.Navigation("Scores");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.Student", b =>
                {
                    b.Navigation("Scores");

                    b.Navigation("StudentClassCommittees");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.TrainingContent", b =>
                {
                    b.Navigation("TrainingContentProofs");

                    b.Navigation("TrainingDetails");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.TrainingDetail", b =>
                {
                    b.Navigation("TraniningDetailProofs");
                });

            modelBuilder.Entity("ChamDiemRenLuyen.DomainModels.TrainingDirectory", b =>
                {
                    b.Navigation("TrainingContents");
                });
#pragma warning restore 612, 618
        }
    }
}
