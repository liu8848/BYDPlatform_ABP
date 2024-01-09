﻿// <auto-generated />
using BYDPlatform.EntityFrameworkCore.EntityFrameWorkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BYDPlatform.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(BYDPlatformDbContext))]
    partial class BYDPlatformDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BYDPlatform.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("password")
                        .HasComment("密码");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("user_name")
                        .HasComment("用户名");

                    b.Property<string>("UserNickName")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("user_nick_name")
                        .HasComment("用户别名");

                    b.HasKey("Id");

                    b.ToTable("user");
                });
#pragma warning restore 612, 618
        }
    }
}
