using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DbFirstComplexDatatypes.Models;

namespace DbFirstComplexDatatypes.Models;

public partial class HrContext : DbContext
{
    public HrContext()
    {
    }

    public HrContext(DbContextOptions<HrContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    public virtual DbSet<EmpHistory> EmpHistories { get; set; }

    public virtual DbSet<Loc> Locs { get; set; }

    public virtual DbSet<Rank> Ranks { get; set; }

    public virtual DbSet<Vw> Vws { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:mycon");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.Did).HasName("PK_Dept_DID");

            entity.ToTable("Dept");

            entity.Property(e => e.Did)
                .ValueGeneratedNever()
                .HasColumnName("DID");
            entity.Property(e => e.Dname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lid).HasColumnName("LID");

            entity.HasOne(d => d.LidNavigation).WithMany(p => p.Depts)
                .HasForeignKey(d => d.Lid)
                .HasConstraintName("FK_Dept_LID");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK_EMP_EID");

            entity.ToTable("Emp");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("EID");
            entity.Property(e => e.Comm).HasColumnType("money");
            entity.Property(e => e.Did).HasColumnName("DID");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Doj).HasColumnName("DOJ");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Jobs)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Sal).HasColumnType("money");

            entity.HasOne(d => d.DidNavigation).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Did)
                .HasConstraintName("FK_Emp_DID");

            entity.HasOne(d => d.MidNavigation).WithMany(p => p.InverseMidNavigation)
                .HasForeignKey(d => d.Mid)
                .HasConstraintName("FK_Emp_EID");
        });

        modelBuilder.Entity<EmpHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("emp_history");

            entity.Property(e => e.Eid).HasColumnName("eid");
            entity.Property(e => e.Fd).HasColumnName("fd");
            entity.Property(e => e.Job)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("job");
            entity.Property(e => e.Sal)
                .HasColumnType("money")
                .HasColumnName("sal");
            entity.Property(e => e.Td).HasColumnName("td");
        });

        modelBuilder.Entity<Loc>(entity =>
        {
            entity.HasKey(e => e.Lid).HasName("PK_Loc_LID");

            entity.ToTable("Loc");

            entity.Property(e => e.Lid)
                .ValueGeneratedNever()
                .HasColumnName("LID");
            entity.Property(e => e.City).HasMaxLength(50);
        });

        modelBuilder.Entity<Rank>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ranks");

            entity.Property(e => e.Firstname).HasMaxLength(50);
            entity.Property(e => e.Rank1).HasColumnName("Rank");
            entity.Property(e => e.Sal)
                .HasColumnType("money")
                .HasColumnName("sal");
        });

        modelBuilder.Entity<Vw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw");

            entity.Property(e => e.Comm).HasColumnType("money");
            entity.Property(e => e.Did).HasColumnName("DID");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Doj).HasColumnName("DOJ");
            entity.Property(e => e.Eid).HasColumnName("EID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Jobs)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Mid).HasColumnName("MID");
            entity.Property(e => e.Sal).HasColumnType("money");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

public DbSet<DbFirstComplexDatatypes.Models.DtoClass> DtoClass { get; set; } = default!;

public DbSet<DbFirstComplexDatatypes.Models.EmpMgrDtoClass> EmpMgrDtoClass { get; set; } = default!;
}
