using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LinqMvcdbfirst.Models;

public partial class LinqDbContext : DbContext
{
    public LinqDbContext()
    {
    }

    public LinqDbContext(DbContextOptions<LinqDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:mycon");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__student__CA1E5D7857367C9F");

            entity.ToTable("student");

            entity.Property(e => e.Sid).ValueGeneratedNever();
            entity.Property(e => e.Sname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
