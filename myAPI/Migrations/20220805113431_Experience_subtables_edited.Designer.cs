// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myAPI.DataAccessLayer.Contexts;

#nullable disable

namespace myAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220805113431_Experience_subtables_edited")]
    partial class Experience_subtables_edited
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("myAPI.EntityLayer.Concrete.Experience", b =>
                {
                    b.Property<int>("ExperienceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .HasColumnType("longtext");

                    b.Property<string>("Date")
                        .HasColumnType("longtext");

                    b.Property<string>("Department")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("Website")
                        .HasColumnType("longtext");

                    b.HasKey("ExperienceID");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("myAPI.EntityLayer.Concrete.ExperienceProject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ExperienceID")
                        .HasColumnType("int");

                    b.Property<string>("Project")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("ExperienceID");

                    b.ToTable("ExperienceProjects");
                });

            modelBuilder.Entity("myAPI.EntityLayer.Concrete.ExperienceResponsibility", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ExperienceID")
                        .HasColumnType("int");

                    b.Property<string>("Responsibility")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("ExperienceID");

                    b.ToTable("ExperienceResponsibilities");
                });

            modelBuilder.Entity("myAPI.EntityLayer.Concrete.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CodeUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Detail")
                        .HasColumnType("longtext");

                    b.Property<string>("LiveUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("longtext");

                    b.HasKey("ProjectID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("myAPI.EntityLayer.Concrete.ExperienceProject", b =>
                {
                    b.HasOne("myAPI.EntityLayer.Concrete.Experience", null)
                        .WithMany("ExperienceProjects")
                        .HasForeignKey("ExperienceID");
                });

            modelBuilder.Entity("myAPI.EntityLayer.Concrete.ExperienceResponsibility", b =>
                {
                    b.HasOne("myAPI.EntityLayer.Concrete.Experience", null)
                        .WithMany("ExperienceResponsibilities")
                        .HasForeignKey("ExperienceID");
                });

            modelBuilder.Entity("myAPI.EntityLayer.Concrete.Experience", b =>
                {
                    b.Navigation("ExperienceProjects");

                    b.Navigation("ExperienceResponsibilities");
                });
#pragma warning restore 612, 618
        }
    }
}
