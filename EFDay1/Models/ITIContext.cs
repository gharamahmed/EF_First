// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFDay1.Models;

public partial class ITIContext : DbContext
{
    public ITIContext()
    {
    }

    public ITIContext(DbContextOptions<ITIContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Ins_Course> Ins_Courses { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-SGU21BB\\SS17;Initial Catalog=ITI;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasOne(d => d.Top).WithMany(p => p.Courses).HasConstraintName("FK_Course_Topic");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.Property(e => e.Dept_Id).ValueGeneratedNever();

            entity.HasOne(d => d.Dept_ManagerNavigation).WithMany(p => p.Departments).HasConstraintName("FK_Department_Instructor");
        });

        modelBuilder.Entity<Ins_Course>(entity =>
        {
            entity.HasOne(d => d.Crs).WithMany(p => p.Ins_Courses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ins_Course_Course");

            entity.HasOne(d => d.Ins).WithMany(p => p.Ins_Courses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ins_Course_Instructor");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.Property(e => e.Password).IsFixedLength();

            entity.HasOne(d => d.Dept).WithMany(p => p.Instructors).HasConstraintName("FK_Instructor_Department");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}