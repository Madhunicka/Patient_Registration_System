﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Patient_Registration_System.Views;

#nullable disable

namespace Patient_Registration_System.Migrations.Bill
{
    [DbContext(typeof(BillContext))]
    [Migration("20230603071131_Go1")]
    partial class Go1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Patient_Registration_System.Views.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AdditionalCharge")
                        .HasColumnType("REAL");

                    b.Property<double>("DoctorCharge")
                        .HasColumnType("REAL");

                    b.Property<double>("LabTests")
                        .HasColumnType("REAL");

                    b.Property<double>("MedicationCost")
                        .HasColumnType("REAL");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("ServiceCharges")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
