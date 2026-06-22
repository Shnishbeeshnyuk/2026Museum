using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _2026Museum.Models;

public partial class _262ba515be31f79b7562ba36a7218e83СтантЛето2026язаебусьПроектированиеИсЛукановИТдProga2026museum2026museumMuseumdbMdfContext : DbContext
{
    public _262ba515be31f79b7562ba36a7218e83СтантЛето2026язаебусьПроектированиеИсЛукановИТдProga2026museum2026museumMuseumdbMdfContext()
    {
    }

    public _262ba515be31f79b7562ba36a7218e83СтантЛето2026язаебусьПроектированиеИсЛукановИТдProga2026museum2026museumMuseumdbMdfContext(DbContextOptions<_262ba515be31f79b7562ba36a7218e83СтантЛето2026язаебусьПроектированиеИсЛукановИТдProga2026museum2026museumMuseumdbMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Excursion> Excursions { get; set; }

    public virtual DbSet<Exhibit> Exhibits { get; set; }

    public virtual DbSet<Hall> Halls { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<VisitedExhibit> VisitedExhibits { get; set; }

    public virtual DbSet<Visitor> Visitors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\MakSSSim\\Desktop\\снова дистант\\лето2026язАебусь\\_проектирование ИС Луканов и тд\\proga\\2026Museum\\2026Museum\\MuseumDB.mdf\";Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF1FA500401");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FullName)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Position)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Excursion>(entity =>
        {
            entity.HasKey(e => e.ExcursionId).HasName("PK__Excursio__E39B682D44D162EE");

            entity.Property(e => e.ExcursionId).HasColumnName("ExcursionID");
            entity.Property(e => e.ExcursionDate).HasColumnType("datetime");
            entity.Property(e => e.ExcursionName)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.GuideId).HasColumnName("GuideID");

            entity.HasOne(d => d.Guide).WithMany(p => p.Excursions)
                .HasForeignKey(d => d.GuideId)
                .HasConstraintName("FK__Excursion__Guide__440B1D61");
        });

        modelBuilder.Entity<Exhibit>(entity =>
        {
            entity.HasKey(e => e.ExhibitId).HasName("PK__Exhibits__E89D7F653DBA4EB4");

            entity.HasIndex(e => e.UniqueNumber, "UQ__Exhibits__61DD9BC19FB922A5").IsUnique();

            entity.Property(e => e.ExhibitId).HasColumnName("ExhibitID");
            entity.Property(e => e.ExhibitName)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ExhibitType)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HallId).HasColumnName("HallID");
            entity.Property(e => e.UniqueNumber)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.Hall).WithMany(p => p.Exhibits)
                .HasForeignKey(d => d.HallId)
                .HasConstraintName("FK__Exhibits__HallID__3B75D760");
        });

        modelBuilder.Entity<Hall>(entity =>
        {
            entity.HasKey(e => e.HallId).HasName("PK__Halls__7E60E27459ACF179");

            entity.Property(e => e.HallId).HasColumnName("HallID");
            entity.Property(e => e.HallName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Theme)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__Tickets__712CC627EBF743B8");

            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.SaleDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TicketType)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.VisitorId).HasColumnName("VisitorID");

            entity.HasOne(d => d.Visitor).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.VisitorId)
                .HasConstraintName("FK__Tickets__Visitor__412EB0B6");
        });

        modelBuilder.Entity<VisitedExhibit>(entity =>
        {
            entity.HasKey(e => new { e.VisitorId, e.ExhibitId, e.VisitDate }).HasName("PK__VisitedE__56F55359E6EF1CEE");

            entity.Property(e => e.VisitorId).HasColumnName("VisitorID");
            entity.Property(e => e.ExhibitId).HasColumnName("ExhibitID");
            entity.Property(e => e.VisitDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Exhibit).WithMany(p => p.VisitedExhibits)
                .HasForeignKey(d => d.ExhibitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VisitedEx__Exhib__47DBAE45");

            entity.HasOne(d => d.Visitor).WithMany(p => p.VisitedExhibits)
                .HasForeignKey(d => d.VisitorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VisitedEx__Visit__46E78A0C");
        });

        modelBuilder.Entity<Visitor>(entity =>
        {
            entity.HasKey(e => e.VisitorId).HasName("PK__Visitors__B121AFA8DAB3D402");

            entity.Property(e => e.VisitorId).HasColumnName("VisitorID");
            entity.Property(e => e.FullName)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
