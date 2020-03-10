﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentStore.DAL;

namespace StudentStore.DAL.Migrations
{
    [DbContext(typeof(StudentStoreContext))]
    partial class StudentStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("StudentStore.Data.Entities.Group", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CourseNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = "611п",
                            CourseNumber = 1
                        },
                        new
                        {
                            Id = "612п",
                            CourseNumber = 1
                        },
                        new
                        {
                            Id = "621п",
                            CourseNumber = 2
                        },
                        new
                        {
                            Id = "622п",
                            CourseNumber = 2
                        },
                        new
                        {
                            Id = "611пст",
                            CourseNumber = 2
                        },
                        new
                        {
                            Id = "631п",
                            CourseNumber = 3
                        },
                        new
                        {
                            Id = "632п",
                            CourseNumber = 3
                        },
                        new
                        {
                            Id = "621пст",
                            CourseNumber = 3
                        },
                        new
                        {
                            Id = "641п",
                            CourseNumber = 4
                        },
                        new
                        {
                            Id = "642п",
                            CourseNumber = 4
                        },
                        new
                        {
                            Id = "631пст",
                            CourseNumber = 4
                        });
                });

            modelBuilder.Entity("StudentStore.Data.Entities.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = "436001",
                            FirstName = "Катерина",
                            GroupId = "641п",
                            LastName = "Андрющенко",
                            MiddleName = "Сергеевна"
                        },
                        new
                        {
                            Id = "436002",
                            FirstName = "Денис",
                            GroupId = "641п",
                            LastName = "Билецкий",
                            MiddleName = "Романович"
                        },
                        new
                        {
                            Id = "436003",
                            FirstName = "Илья",
                            GroupId = "641п",
                            LastName = "Вирич",
                            MiddleName = "Васильевич"
                        },
                        new
                        {
                            Id = "436004",
                            FirstName = "Роман",
                            GroupId = "641п",
                            LastName = "Гайдук",
                            MiddleName = "Валерьевич"
                        },
                        new
                        {
                            Id = "436005",
                            FirstName = "Борис",
                            GroupId = "641п",
                            LastName = "Головкин",
                            MiddleName = "Анатольевич"
                        },
                        new
                        {
                            Id = "436006",
                            FirstName = "Артур",
                            GroupId = "641п",
                            LastName = "Гулеватый",
                            MiddleName = "Игоревич"
                        },
                        new
                        {
                            Id = "436007",
                            FirstName = "Виталий",
                            GroupId = "641п",
                            LastName = "Дворник",
                            MiddleName = "Юрьевич"
                        },
                        new
                        {
                            Id = "436008",
                            FirstName = "Михаил",
                            GroupId = "641п",
                            LastName = "Дронов",
                            MiddleName = "Эдуардович"
                        },
                        new
                        {
                            Id = "436009",
                            FirstName = "Владислав",
                            GroupId = "631пст",
                            LastName = "Колесник",
                            MiddleName = "Юрьевич"
                        },
                        new
                        {
                            Id = "436010",
                            FirstName = "Артем",
                            GroupId = "631пст",
                            LastName = "Мирошниченко",
                            MiddleName = "Валерьевич"
                        },
                        new
                        {
                            Id = "436011",
                            FirstName = "Евгений",
                            GroupId = "631пст",
                            LastName = "Могилевский",
                            MiddleName = "Романович"
                        },
                        new
                        {
                            Id = "436012",
                            FirstName = "Катерина",
                            GroupId = "631пст",
                            LastName = "Плитник",
                            MiddleName = "Витальевна"
                        },
                        new
                        {
                            Id = "436013",
                            FirstName = "Вадим",
                            GroupId = "641п",
                            LastName = "Рачков",
                            MiddleName = "Сергеевич"
                        },
                        new
                        {
                            Id = "436014",
                            FirstName = "Дмитрий",
                            GroupId = "641п",
                            LastName = "Руденок",
                            MiddleName = "Юрьевич"
                        },
                        new
                        {
                            Id = "436015",
                            FirstName = "Оксана",
                            GroupId = "642п",
                            LastName = "Ткаченко",
                            MiddleName = "Витальевна"
                        },
                        new
                        {
                            Id = "436016",
                            FirstName = "Артем",
                            GroupId = "642п",
                            LastName = "Чуглазов",
                            MiddleName = "Васильевич"
                        },
                        new
                        {
                            Id = "436017",
                            FirstName = "Ростислав",
                            GroupId = "642п",
                            LastName = "Шурухин",
                            MiddleName = "Юрьевич"
                        },
                        new
                        {
                            Id = "436018",
                            FirstName = "Александр",
                            GroupId = "642п",
                            LastName = "Яценко",
                            MiddleName = "Сергеевич"
                        },
                        new
                        {
                            Id = "436019",
                            FirstName = "Евгений",
                            GroupId = "642п",
                            LastName = "Виноградный",
                            MiddleName = "Олегович"
                        },
                        new
                        {
                            Id = "436020",
                            FirstName = "Валерий",
                            GroupId = "642п",
                            LastName = "Глянцев",
                            MiddleName = "Олегович"
                        },
                        new
                        {
                            Id = "436021",
                            FirstName = "Диана",
                            GroupId = "642п",
                            LastName = "Грушко",
                            MiddleName = "Александровна"
                        });
                });

            modelBuilder.Entity("StudentStore.Data.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("StudentStore.Data.Entities.SubjectGroup", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SubjectId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("SubjectGroup");
                });

            modelBuilder.Entity("StudentStore.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("StudentStore.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StudentStore.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentStore.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StudentStore.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStore.Data.Entities.Student", b =>
                {
                    b.HasOne("StudentStore.Data.Entities.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("StudentStore.Data.Entities.SubjectGroup", b =>
                {
                    b.HasOne("StudentStore.Data.Entities.Group", "Book")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentStore.Data.Entities.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
