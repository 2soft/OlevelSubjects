﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlevelSubjects.Data;

namespace OlevelSubjects.Migrations
{
    [DbContext(typeof(OdinaryContext))]
    [Migration("20200309190919_mimi")]
    partial class mimi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OlevelSubjects.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassName");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("OlevelSubjects.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<DateTime>("Expaire");

                    b.Property<string>("Status");

                    b.Property<string>("Text");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("OlevelSubjects.Models.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Form");

                    b.Property<string>("NoteName");

                    b.Property<int>("SubjectId");

                    b.Property<string>("Url");

                    b.HasKey("NoteId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("OlevelSubjects.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClassId");

                    b.Property<string>("SubjectName");

                    b.HasKey("SubjectId");

                    b.HasIndex("ClassId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("OlevelSubjects.Models.User", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("MessageId");

                    b.HasKey("Email");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OlevelSubjects.Models.Note", b =>
                {
                    b.HasOne("OlevelSubjects.Models.Subject", "Subject")
                        .WithMany("Notes")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OlevelSubjects.Models.Subject", b =>
                {
                    b.HasOne("OlevelSubjects.Models.Class")
                        .WithMany("Subjects")
                        .HasForeignKey("ClassId");
                });
#pragma warning restore 612, 618
        }
    }
}
