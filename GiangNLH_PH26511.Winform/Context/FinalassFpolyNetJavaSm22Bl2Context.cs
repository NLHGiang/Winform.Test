using System;
using System.Collections.Generic;
using GiangNLH_PH26511.Winform.Domain;
using Microsoft.EntityFrameworkCore;

namespace GiangNLH_PH26511.Winform.Context;

public partial class FinalassFpolyNetJavaSm22Bl2Context : DbContext
{
    public FinalassFpolyNetJavaSm22Bl2Context()
    {
    }

    public FinalassFpolyNetJavaSm22Bl2Context(DbContextOptions<FinalassFpolyNetJavaSm22Bl2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Ban> Bans { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<LoaiSp> LoaiSps { get; set; }

    public virtual DbSet<LoaiXm> LoaiXms { get; set; }

    public virtual DbSet<MoiQuanHe> MoiQuanHes { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Nxb> Nxbs { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<XeMay> XeMays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=FINALASS_FPOLY_NET_JAVA_SM22_BL2;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ban>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ban__3214EC07DADDCD29");

            entity.ToTable("Ban");

            entity.HasIndex(e => e.Ma, "UQ__Ban__3214CC9E49D2F001").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GioiTinh).HasDefaultValueSql("((0))");
            entity.Property(e => e.IdMqh).HasColumnName("IdMQH");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.SoThich).HasMaxLength(30);
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdMqhNavigation).WithMany(p => p.Bans)
                .HasForeignKey(d => d.IdMqh)
                .HasConstraintName("FK1_MQH");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChucVu__3214EC076AF6B99A");

            entity.ToTable("ChucVu");

            entity.HasIndex(e => e.Ma, "UQ__ChucVu__3214CC9E6D5187F0").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<LoaiSp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoaiSP__3214EC07BFBF7623");

            entity.ToTable("LoaiSP");

            entity.HasIndex(e => e.Ma, "UQ__LoaiSP__3214CC9E98C9F58F").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<LoaiXm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoaiXM__3214EC07D1F5F8D2");

            entity.ToTable("LoaiXM");

            entity.HasIndex(e => e.Ma, "UQ__LoaiXM__3214CC9EDCC2B470").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<MoiQuanHe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MoiQuanH__3214EC07963C9D78");

            entity.ToTable("MoiQuanHe");

            entity.HasIndex(e => e.Ma, "UQ__MoiQuanH__3214CC9E0A62DD26").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NhanVien__3214EC07A3C86F3C");

            entity.ToTable("NhanVien");

            entity.HasIndex(e => e.Ma, "UQ__NhanVien__3214CC9EF3C24D75").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.Ho).HasMaxLength(30);
            entity.Property(e => e.IdCv).HasColumnName("IdCV");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MatKhau).IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TenDem).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdCvNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdCv)
                .HasConstraintName("FK1_NV");
        });

        modelBuilder.Entity<Nxb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NXB__3214EC075B594C71");

            entity.ToTable("NXB");

            entity.HasIndex(e => e.Ma, "UQ__NXB__3214CC9EEC162042").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sach__3214EC0772E8CB36");

            entity.ToTable("Sach");

            entity.HasIndex(e => e.Ma, "UQ__Sach__3214CC9E9062B7FE").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DonGia)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.IdNxb).HasColumnName("IdNXB");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NgayXuatBan).HasColumnType("date");
            entity.Property(e => e.SoTrang).HasDefaultValueSql("((0))");
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdNxbNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.IdNxb)
                .HasConstraintName("FK1_NXB");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SanPham__3214EC07A2CEC7DB");

            entity.ToTable("SanPham");

            entity.HasIndex(e => e.Ma, "UQ__SanPham__3214CC9E9E10337E").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GiaBan)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.IdLoaiSp).HasColumnName("IdLoaiSP");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mota).HasMaxLength(30);
            entity.Property(e => e.NgaySx)
                .HasColumnType("date")
                .HasColumnName("NgaySX");
            entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            entity.Property(e => e.Website).HasMaxLength(30);

            entity.HasOne(d => d.IdLoaiSpNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdLoaiSp)
                .HasConstraintName("FK1_LSP");
        });

        modelBuilder.Entity<XeMay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__XeMay__3214EC07A216EA25");

            entity.ToTable("XeMay");

            entity.HasIndex(e => e.Ma, "UQ__XeMay__3214CC9EB126980F").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GiaBan)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.GiaNhap)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.IdLxm).HasColumnName("IdLXM");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mota).HasMaxLength(30);
            entity.Property(e => e.NgaySx)
                .HasColumnType("date")
                .HasColumnName("NgaySX");
            entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            entity.Property(e => e.Website).HasMaxLength(30);

            entity.HasOne(d => d.IdLxmNavigation).WithMany(p => p.XeMays)
                .HasForeignKey(d => d.IdLxm)
                .HasConstraintName("FK1_LXM");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
