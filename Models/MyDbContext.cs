using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DotNETCoreWebAPI.Models;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-A3153GQ;  Database=MyDB;  trusted_connection=true;  TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StId).HasName("PK__students__312C03EF15B13415");

            entity.ToTable("students");

            entity.Property(e => e.StId).HasColumnName("stId");
            entity.Property(e => e.StClass)
                .HasMaxLength(50)
                .HasColumnName("stClass");
            entity.Property(e => e.StName)
                .HasMaxLength(100)
                .HasColumnName("stName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
