using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Repository.Models
{
    public partial class LIBRARYDBContext : DbContext
    {
        public LIBRARYDBContext()
        {
        }

        public LIBRARYDBContext(DbContextOptions<LIBRARYDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Docgium> Docgia { get; set; }
        public virtual DbSet<Loaisach> Loaisaches { get; set; }
        public virtual DbSet<Muontra> Muontras { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Nhaxuatban> Nhaxuatbans { get; set; }
        public virtual DbSet<Phat> Phats { get; set; }
        public virtual DbSet<Quyensach> Quyensaches { get; set; }
        public virtual DbSet<Taikhoan> Taikhoans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        public static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:BankAccountTypeDB"];
            return strConn;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Docgium>(entity =>
            {
                entity.ToTable("DOCGIA");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.TenDocGia)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Loaisach>(entity =>
            {
                entity.ToTable("LOAISACH");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.LoaiSach1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LoaiSach");
            });

            modelBuilder.Entity<Muontra>(entity =>
            {
                entity.ToTable("MUONTRA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Docgiaid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCGIAID")
                    .IsFixedLength(true);

                entity.Property(e => e.HanTra).HasColumnType("date");

                entity.Property(e => e.NgayMuon).HasColumnType("date");

                entity.Property(e => e.NgayTra).HasColumnType("date");

                entity.Property(e => e.Nhanvienid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NHANVIENID")
                    .IsFixedLength(true);

                entity.Property(e => e.Phatid).HasColumnName("PHATID");

                entity.Property(e => e.Quyensachid).HasColumnName("QUYENSACHID");

                entity.HasOne(d => d.Docgia)
                    .WithMany(p => p.Muontras)
                    .HasForeignKey(d => d.Docgiaid)
                    .HasConstraintName("FK__MUONTRA__DOCGIAI__34C8D9D1");

                entity.HasOne(d => d.Nhanvien)
                    .WithMany(p => p.Muontras)
                    .HasForeignKey(d => d.Nhanvienid)
                    .HasConstraintName("FK__MUONTRA__NHANVIE__36B12243");

                entity.HasOne(d => d.Phat)
                    .WithMany(p => p.Muontras)
                    .HasForeignKey(d => d.Phatid)
                    .HasConstraintName("FK__MUONTRA__PHATID__37A5467C");

                entity.HasOne(d => d.Quyensach)
                    .WithMany(p => p.Muontras)
                    .HasForeignKey(d => d.Quyensachid)
                    .HasConstraintName("FK__MUONTRA__QUYENSA__35BCFE0A");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.ToTable("NHANVIEN");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.DienThoaiNv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DienThoaiNV")
                    .IsFixedLength(true);

                entity.Property(e => e.HoTenNv)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HoTenNV")
                    .IsFixedLength(true);

                entity.Property(e => e.NgaySinhNv)
                    .HasColumnType("date")
                    .HasColumnName("NgaySinhNV");

                entity.Property(e => e.NgayVaoLam).HasColumnType("date");
            });

            modelBuilder.Entity<Nhaxuatban>(entity =>
            {
                entity.ToTable("NHAXUATBAN");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.DiaChiNxb)
                    .HasMaxLength(200)
                    .HasColumnName("DiaChiNXB");

                entity.Property(e => e.EmailNxb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmailNXB")
                    .IsFixedLength(true);

                entity.Property(e => e.TenNxb)
                    .HasMaxLength(200)
                    .HasColumnName("TenNXB");
            });

            modelBuilder.Entity<Phat>(entity =>
            {
                entity.ToTable("PHAT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NguyenNhan).HasMaxLength(200);
            });

            modelBuilder.Entity<Quyensach>(entity =>
            {
                entity.ToTable("QUYENSACH");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Loaisachid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOAISACHID")
                    .IsFixedLength(true);

                entity.Property(e => e.Nhaxuatbanid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NHAXUATBANID")
                    .IsFixedLength(true);

                entity.Property(e => e.TenSach)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenTacGia).HasMaxLength(100);

                entity.HasOne(d => d.Loaisach)
                    .WithMany(p => p.Quyensaches)
                    .HasForeignKey(d => d.Loaisachid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__QUYENSACH__LOAIS__2B3F6F97");

                entity.HasOne(d => d.Nhaxuatban)
                    .WithMany(p => p.Quyensaches)
                    .HasForeignKey(d => d.Nhaxuatbanid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__QUYENSACH__NHAXU__2A4B4B5E");
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.HasKey(e => e.TenTk)
                    .HasName("PK__TAIKHOAN__4CF9E776F0F2EFC6");

                entity.ToTable("TAIKHOAN");

                entity.Property(e => e.TenTk)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TenTK")
                    .IsFixedLength(true);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Nhanvienid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NHANVIENID")
                    .IsFixedLength(true);

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Nhanvien)
                    .WithMany(p => p.Taikhoans)
                    .HasForeignKey(d => d.Nhanvienid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TAIKHOAN__NHANVI__300424B4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
