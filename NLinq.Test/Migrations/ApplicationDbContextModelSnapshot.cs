﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLinq.Test;

namespace NLinq.Test.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NLinq.Test.CPKeyModel", b =>
                {
                    b.Property<Guid>("Id1");

                    b.Property<Guid>("Id2");

                    b.HasKey("Id1", "Id2");

                    b.ToTable("CompositeKeyModels");
                });

            modelBuilder.Entity("NLinq.Test.EntityMonitorModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProductName");

                    b.HasKey("Id");

                    b.ToTable("EntityMonitorModels");
                });

            modelBuilder.Entity("NLinq.Test.FreeModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("FreeModels");
                });

            modelBuilder.Entity("NLinq.Test.SimpleModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("NickName");

                    b.Property<string>("RealName");

                    b.HasKey("Id");

                    b.ToTable("SimpleModels");
                });

            modelBuilder.Entity("NLinq.Test.TrackModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Automatic");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("ForCondensed");

                    b.Property<string>("ForLower");

                    b.Property<string>("ForTrim");

                    b.Property<string>("ForUpper");

                    b.Property<DateTime>("LastWriteTime");

                    b.HasKey("Id");

                    b.ToTable("TrackModels");
                });
#pragma warning restore 612, 618
        }
    }
}
