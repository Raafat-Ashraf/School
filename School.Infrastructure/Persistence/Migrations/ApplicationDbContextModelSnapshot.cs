﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Infrastructure.Persistence;

#nullable disable

namespace School.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("School.Data.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("School.Data.Entities.DepartmentSubject", b =>
                {
                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("DepartmentSubjects");
                });

            modelBuilder.Entity("School.Data.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("School.Data.Entities.StudentSubject", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentSubjects");
                });

            modelBuilder.Entity("School.Data.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Period")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("School.Data.Entities.DepartmentSubject", b =>
                {
                    b.HasOne("School.Data.Entities.Department", "Department")
                        .WithMany("DepartmentSubjects")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Data.Entities.Subject", "Subject")
                        .WithMany("DepartmentSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("School.Data.Entities.Student", b =>
                {
                    b.HasOne("School.Data.Entities.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("School.Data.Entities.StudentSubject", b =>
                {
                    b.HasOne("School.Data.Entities.Student", "Student")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Data.Entities.Subject", "Subject")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("School.Data.Entities.Department", b =>
                {
                    b.Navigation("DepartmentSubjects");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("School.Data.Entities.Student", b =>
                {
                    b.Navigation("StudentSubjects");
                });

            modelBuilder.Entity("School.Data.Entities.Subject", b =>
                {
                    b.Navigation("DepartmentSubjects");

                    b.Navigation("StudentSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
