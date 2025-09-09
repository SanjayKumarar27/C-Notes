using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebMVCEnitity.Models;

public partial class EnityDbContext : DbContext
{
    public EnityDbContext()
    {
    }

    public EnityDbContext(DbContextOptions<EnityDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("Name=ConnectionStrings:mycon");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Student__CA1959700344CAC8");

            entity.ToTable("Student");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("SID");
            entity.Property(e => e.Sname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
