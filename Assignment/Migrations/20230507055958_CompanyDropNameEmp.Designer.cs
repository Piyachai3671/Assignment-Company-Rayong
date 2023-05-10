﻿// <auto-generated />
using Assignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230507055958_CompanyDropNameEmp")]
    partial class CompanyDropNameEmp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment.Data.ModelData.TableCompany", b =>
                {
                    b.Property<int>("IDCompany")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDCompany"));

                    b.Property<int>("IDMember5")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDCompany");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Assignment.Data.ModelData.TableEmployee", b =>
                {
                    b.Property<int>("IDEmployee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDEmployee"));

                    b.Property<int>("IDCompany")
                        .HasColumnType("int");

                    b.Property<string>("IDMember5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDEmployee");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
