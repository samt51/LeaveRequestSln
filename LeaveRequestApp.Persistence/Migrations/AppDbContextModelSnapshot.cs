﻿// <auto-generated />
using System;
using LeaveRequestApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeaveRequestApp.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LeaveRequestApp.Domain.Entites.CumulativeLeaveRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LeaveType")
                        .HasColumnType("int");

                    b.Property<int>("TotalHours")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CumulativeLeaveRequests");

                    b.HasData(
                        new
                        {
                            Id = new Guid("85a3bd68-2f6b-49f8-9f03-2cb0eaa54d13"),
                            CreatedDate = new DateTime(2024, 2, 20, 3, 54, 22, 689, DateTimeKind.Local).AddTicks(9774),
                            IsDeleted = false,
                            LeaveType = 10,
                            TotalHours = 80,
                            UserId = new Guid("e21cd525-031c-4364-b173-4150a4e18c37"),
                            Year = 2023
                        },
                        new
                        {
                            Id = new Guid("dc808a4f-8ae8-4d7a-b228-e1cb957f815d"),
                            CreatedDate = new DateTime(2024, 2, 20, 3, 54, 22, 689, DateTimeKind.Local).AddTicks(9802),
                            IsDeleted = false,
                            LeaveType = 20,
                            TotalHours = 60,
                            UserId = new Guid("59fb152a-2d59-435d-8fc1-cbc35c0f1d82"),
                            Year = 2023
                        },
                        new
                        {
                            Id = new Guid("f47b75ae-6318-413c-ab36-ad82d380c0dd"),
                            CreatedDate = new DateTime(2024, 2, 20, 3, 54, 22, 689, DateTimeKind.Local).AddTicks(9804),
                            IsDeleted = false,
                            LeaveType = 10,
                            TotalHours = 32,
                            UserId = new Guid("23591451-1cf1-46a5-907a-ee3e52abe394"),
                            Year = 2023
                        },
                        new
                        {
                            Id = new Guid("7fa9f56c-a54e-49ae-a9bf-2266a449992b"),
                            CreatedDate = new DateTime(2024, 2, 20, 3, 54, 22, 689, DateTimeKind.Local).AddTicks(9806),
                            IsDeleted = false,
                            LeaveType = 20,
                            TotalHours = 16,
                            UserId = new Guid("23591451-1cf1-46a5-907a-ee3e52abe394"),
                            Year = 2023
                        });
                });

            modelBuilder.Entity("LeaveRequestApp.Domain.Entites.LeaveRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AssignedUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("LastModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LeaveType")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UsersId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("WorkflowStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("LastModifiedById");

                    b.HasIndex("UsersId");

                    b.HasIndex("UsersId1");

                    b.ToTable("LeaveRequests");
                });

            modelBuilder.Entity("LeaveRequestApp.Domain.Entites.Notifications", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CumulativeLeaveRequestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CumulativeLeaveRequestId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0422b3bb-7618-43d2-b694-3229396d724b"),
                            CreatedDate = new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CumulativeLeaveRequestId = new Guid("7fa9f56c-a54e-49ae-a9bf-2266a449992b"),
                            IsDeleted = false,
                            Message = "Kalan ExcusedAbsence 8 saat",
                            UserId = new Guid("23591451-1cf1-46a5-907a-ee3e52abe394")
                        },
                        new
                        {
                            Id = new Guid("b89210d0-541f-4718-854a-e0d2d64c9f75"),
                            CreatedDate = new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CumulativeLeaveRequestId = new Guid("85a3bd68-2f6b-49f8-9f03-2cb0eaa54d13"),
                            IsDeleted = false,
                            Message = "Aşılan AnnualLeave 1 gün",
                            UserId = new Guid("e21cd525-031c-4364-b173-4150a4e18c37")
                        },
                        new
                        {
                            Id = new Guid("405287b8-2321-4d22-b96f-15f36afb9b3e"),
                            CreatedDate = new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Message = "Kalan AnnualLeave 2 gün ",
                            UserId = new Guid("59fb152a-2d59-435d-8fc1-cbc35c0f1d82")
                        });
                });

            modelBuilder.Entity("LeaveRequestApp.Domain.Entites.Permissions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LeaveTypeEnum")
                        .HasColumnType("int");

                    b.Property<decimal>("RemainderPermission")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPermission")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("LeaveRequestApp.Domain.Entites.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e21cd525-031c-4364-b173-4150a4e18c37"),
                            CreatedDate = new DateTime(2024, 2, 20, 3, 54, 22, 690, DateTimeKind.Local).AddTicks(3257),
                            Email = "munir.ozkul@negzel.net",
                            FirstName = "Münir",
                            IsDeleted = false,
                            LastName = "Özkul",
                            ManagerId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserType = 30
                        },
                        new
                        {
                            Id = new Guid("59fb152a-2d59-435d-8fc1-cbc35c0f1d82"),
                            CreatedDate = new DateTime(2024, 2, 20, 3, 54, 22, 690, DateTimeKind.Local).AddTicks(3264),
                            Email = "sener.sen@negzel.net ",
                            FirstName = "Şener",
                            IsDeleted = false,
                            LastName = "Şen",
                            ManagerId = new Guid("e21cd525-031c-4364-b173-4150a4e18c37"),
                            UserType = 10
                        },
                        new
                        {
                            Id = new Guid("23591451-1cf1-46a5-907a-ee3e52abe394"),
                            CreatedDate = new DateTime(2024, 2, 20, 3, 54, 22, 690, DateTimeKind.Local).AddTicks(3267),
                            Email = "kemal.sunal@negzel.net",
                            FirstName = "Kemal",
                            IsDeleted = false,
                            LastName = "Sunal",
                            ManagerId = new Guid("59fb152a-2d59-435d-8fc1-cbc35c0f1d82"),
                            UserType = 20
                        });
                });

            modelBuilder.Entity("LeaveRequestApp.Domain.Entites.CumulativeLeaveRequest", b =>
                {
                    b.HasOne("LeaveRequestApp.Domain.Entites.Users", "Users")
                        .WithMany("CumulativeLeaveRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("LeaveRequestApp.Domain.Entites.LeaveRequest", b =>
                {
                    b.HasOne("LeaveRequestApp.Domain.Entites.Users", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeaveRequestApp.Domain.Entites.Users", "Users")
                        .WithMany("AssignedUsers")
                        .HasForeignKey("Id");

                    b.HasOne("LeaveRequestApp.Domain.Entites.Users", "LastModifiedByUser")
                        .WithMany()
                        .HasForeignKey("LastModifiedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeaveRequestApp.Domain.Entites.Users", null)
                        .WithMany("CreatedByIds")
                        .HasForeignKey("UsersId");

                    b.HasOne("LeaveRequestApp.Domain.Entites.Users", null)
                        .WithMany("LastModifiedByIds")
                        .HasForeignKey("UsersId1");

                    b.Navigation("CreatedByUser");

                    b.Navigation("LastModifiedByUser");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("LeaveRequestApp.Domain.Entites.Notifications", b =>
                {
                    b.HasOne("LeaveRequestApp.Domain.Entites.CumulativeLeaveRequest", "CumulativeLeaveRequest")
                        .WithMany("Notifications")
                        .HasForeignKey("CumulativeLeaveRequestId");

                    b.HasOne("LeaveRequestApp.Domain.Entites.Users", "Users")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CumulativeLeaveRequest");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("LeaveRequestApp.Domain.Entites.Permissions", b =>
                {
                    b.HasOne("LeaveRequestApp.Domain.Entites.Users", "Users")
                        .WithMany("Permissions")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("LeaveRequestApp.Domain.Entites.CumulativeLeaveRequest", b =>
                {
                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("LeaveRequestApp.Domain.Entites.Users", b =>
                {
                    b.Navigation("AssignedUsers");

                    b.Navigation("CreatedByIds");

                    b.Navigation("CumulativeLeaveRequests");

                    b.Navigation("LastModifiedByIds");

                    b.Navigation("Notifications");

                    b.Navigation("Permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
