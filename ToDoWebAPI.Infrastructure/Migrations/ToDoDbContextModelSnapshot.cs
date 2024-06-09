﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoWebAPI.Infrastructure.Data;

#nullable disable

namespace ToDoWebAPI.Infrastructure.Migrations
{
    [DbContext(typeof(ToDoDbContext))]
    partial class ToDoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ToDoWebAPI.Domain.Entities.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToDoStatusesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ToDoStatusesId");

                    b.ToTable("ToDos");
                });

            modelBuilder.Entity("ToDoWebAPI.Domain.Entities.ToDoStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ToDoStatuses");
                });

            modelBuilder.Entity("ToDoWebAPI.Domain.Entities.ToDo", b =>
                {
                    b.HasOne("ToDoWebAPI.Domain.Entities.ToDoStatus", "ToDoStatuses")
                        .WithMany("ToDos")
                        .HasForeignKey("ToDoStatusesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ToDoStatuses");
                });

            modelBuilder.Entity("ToDoWebAPI.Domain.Entities.ToDoStatus", b =>
                {
                    b.Navigation("ToDos");
                });
#pragma warning restore 612, 618
        }
    }
}
