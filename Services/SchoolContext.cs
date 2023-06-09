﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication2.Models
{
    public partial class SchoolContext : DbContext
    {
        public SchoolContext()
        {
        }

        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=MSI;Database=SchoolSystem;Trusted_Connection=True;Integrated Security=True");
            }
        }
   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Department>(entity =>
            //{
            //    entity.Property(e => e.Id).ValueGeneratedNever();
            //});

            //modelBuilder.Entity<Student>(entity =>
            //{
            //    entity.HasOne(d => d.DeptNoNavigation)
            //        .WithMany(p => p.Students)
            //        .HasForeignKey(d => d.DeptNo)
            //        .HasConstraintName("FK_Student_Department");
            //});

            //OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
            }
        }