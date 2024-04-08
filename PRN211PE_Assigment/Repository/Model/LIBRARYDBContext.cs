using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Repository.Model
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

        public virtual DbSet<Chitietmuontra> Chitietmuontras { get; set; }
        public virtual DbSet<Docgium> Docgia { get; set; }
        public virtual DbSet<Loaisach> Loaisaches { get; set; }
        public virtual DbSet<Muontra> Muontras { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Nhaxuatban> Nhaxuatbans { get; set; }
        public virtual DbSet<Phat> Phats { get; set; }
        public virtual DbSet<Quyensach> Quyensaches { get; set; }
        public virtual DbSet<Taikhoan> Taikhoans { get; set; }
        public virtual DbSet<Trasach> Trasaches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:LIBRARYDB"];
            return strConn;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Chitietmuontra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CHITIETMUONTRA");

                entity.Property(e => e.HanTra).HasColumnType("date");

                entity.Property(e => e.MaMuonTra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaSach)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NgayMuon).HasColumnType("date");

                entity.HasOne(d => d.MaMuonTraNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaMuonTra)
                    .HasConstraintName("FK__CHITIETMU__MaMuo__32E0915F");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaSach)
                    .HasConstraintName("FK__CHITIETMU__MaSac__33D4B598");
            });

            modelBuilder.Entity<Docgium>(entity =>
            {
                entity.HasKey(e => e.MaDocGia)
                    .HasName("PK__DOCGIA__F165F9458B9F84F0");

                entity.ToTable("DOCGIA");

                entity.Property(e => e.MaDocGia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.TenDocGia)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Loaisach>(entity =>
            {
                entity.HasKey(e => e.MaLoaiSach)
                    .HasName("PK__LOAISACH__2F9B373FEB5E4C2F");

                entity.ToTable("LOAISACH");

                entity.Property(e => e.MaLoaiSach)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LoaiSach1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LoaiSach");
            });

            modelBuilder.Entity<Muontra>(entity =>
            {
                entity.HasKey(e => e.MaMuonTra)
                    .HasName("PK__MUONTRA__2E4C717EFF723F81");

                entity.ToTable("MUONTRA");

                entity.Property(e => e.MaMuonTra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaDocGia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Msnv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSNV")
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaDocGiaNavigation)
                    .WithMany(p => p.Muontras)
                    .HasForeignKey(d => d.MaDocGia)
                    .HasConstraintName("FK__MUONTRA__MaDocGi__300424B4");

                entity.HasOne(d => d.MsnvNavigation)
                    .WithMany(p => p.Muontras)
                    .HasForeignKey(d => d.Msnv)
                    .HasConstraintName("FK__MUONTRA__MSNV__30F848ED");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Msnv)
                    .HasName("PK__NHANVIEN__6CB3885F6E6AD849");

                entity.ToTable("NHANVIEN");

                entity.Property(e => e.Msnv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSNV")
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
                entity.HasKey(e => e.Msnxb)
                    .HasName("PK__NHAXUATB__2153250154C95669");

                entity.ToTable("NHAXUATBAN");

                entity.Property(e => e.Msnxb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSNXB")
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
                entity.HasNoKey();

                entity.ToTable("PHAT");

                entity.Property(e => e.MaDocGia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NguyenNhan).HasMaxLength(200);

                entity.HasOne(d => d.MaDocGiaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaDocGia)
                    .HasConstraintName("FK__PHAT__MaDocGia__37A5467C");
            });

            modelBuilder.Entity<Quyensach>(entity =>
            {
                entity.HasKey(e => e.MaSach)
                    .HasName("PK__QUYENSAC__B235742D33CB485C");

                entity.ToTable("QUYENSACH");

                entity.Property(e => e.MaSach)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaLoaiSach)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Msnxb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSNXB")
                    .IsFixedLength(true);

                entity.Property(e => e.TenSach)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenTacGia).HasMaxLength(100);

                entity.HasOne(d => d.MaLoaiSachNavigation)
                    .WithMany(p => p.Quyensaches)
                    .HasForeignKey(d => d.MaLoaiSach)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__QUYENSACH__MaLoa__2B3F6F97");

                entity.HasOne(d => d.MsnxbNavigation)
                    .WithMany(p => p.Quyensaches)
                    .HasForeignKey(d => d.Msnxb)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__QUYENSACH__MSNXB__2A4B4B5E");
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.HasKey(e => e.TenTK)
                    .HasName("PK__TAIKHOAN__D5B8C7F1FB35BF70");

                entity.ToTable("TAIKHOAN");

                entity.Property(e => e.TenTK)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Trasach>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TRASACH");

                entity.Property(e => e.MaMuonTra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MaSach)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Msnv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MSNV")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayTra).HasColumnType("date");

                entity.HasOne(d => d.MaMuonTraNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaMuonTra)
                    .HasConstraintName("FK__TRASACH__MaMuonT__3A81B327");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaSach)
                    .HasConstraintName("FK__TRASACH__MaSach__398D8EEE");

                entity.HasOne(d => d.MsnvNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Msnv)
                    .HasConstraintName("FK__TRASACH__MSNV__3B75D760");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
