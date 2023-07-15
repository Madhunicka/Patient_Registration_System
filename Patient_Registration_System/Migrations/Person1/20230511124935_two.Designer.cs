﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Patient_Registration_System.Views;

#nullable disable

namespace Patient_Registration_System.Migrations.Person1
{
    [DbContext(typeof(Person1Context))]
    [Migration("20230511124935_two")]
    partial class two
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Patient_Registration_System.Views.Person1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContNo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("SurDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SurgentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Surgeries");
                });
#pragma warning restore 612, 618
        }
    }
}
