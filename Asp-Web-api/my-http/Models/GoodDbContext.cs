using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace my_http.Models;

public partial class GoodDbContext : DbContext
{
    public GoodDbContext()
    {
    }

    public GoodDbContext(DbContextOptions<GoodDbContext> options)
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
            entity.HasKey(e => e.Sid).HasName("PK__student__CA1E5D78AA128F7B");

            entity.ToTable("student");

            entity.Property(e => e.Sid).ValueGeneratedNever();
            entity.Property(e => e.Sname)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
