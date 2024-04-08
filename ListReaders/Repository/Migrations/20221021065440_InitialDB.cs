using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DOCGIA",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: false),
                    TenDocGia = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOCGIA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LOAISACH",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: false),
                    LoaiSach = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOAISACH", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: false),
                    HoTenNV = table.Column<string>(type: "char(100)", unicode: false, fixedLength: true, maxLength: 100, nullable: true),
                    NgaySinhNV = table.Column<DateTime>(type: "date", nullable: true),
                    DienThoaiNV = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    NgayVaoLam = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHANVIEN", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NHAXUATBAN",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: false),
                    TenNXB = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DiaChiNXB = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmailNXB = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHAXUATBAN", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PHAT",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: false),
                    NguyenNhan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHAT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TAIKHOAN",
                columns: table => new
                {
                    TenTK = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    Ten = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    IDNHANVIEN = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TAIKHOAN__4CF9E776603D563D", x => x.TenTK);
                    table.ForeignKey(
                        name: "FK__TAIKHOAN__IDNHAN__300424B4",
                        column: x => x.IDNHANVIEN,
                        principalTable: "NHANVIEN",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QUYENSACH",
                columns: table => new
                {
                    ID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: false),
                    TenSach = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    TenTacGia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NHAXUATBANID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    LOAISACHID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUYENSACH", x => x.ID);
                    table.ForeignKey(
                        name: "FK__QUYENSACH__LOAIS__2B3F6F97",
                        column: x => x.LOAISACHID,
                        principalTable: "LOAISACH",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__QUYENSACH__NHAXU__2A4B4B5E",
                        column: x => x.NHAXUATBANID,
                        principalTable: "NHAXUATBAN",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MUONTRA",
                columns: table => new
                {
                    DOCGIAID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    NgayMuon = table.Column<DateTime>(type: "date", nullable: true),
                    NgayTra = table.Column<DateTime>(type: "date", nullable: true),
                    HanTra = table.Column<DateTime>(type: "date", nullable: true),
                    TinhTrangMuon = table.Column<bool>(type: "bit", nullable: true),
                    TinhTrangTra = table.Column<bool>(type: "bit", nullable: true),
                    QUYENSACHID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    NHANVIENID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true),
                    PHATID = table.Column<string>(type: "char(50)", unicode: false, fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__MUONTRA__DOCGIAI__33D4B598",
                        column: x => x.DOCGIAID,
                        principalTable: "DOCGIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__MUONTRA__NHANVIE__35BCFE0A",
                        column: x => x.NHANVIENID,
                        principalTable: "NHANVIEN",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__MUONTRA__PHATID__36B12243",
                        column: x => x.PHATID,
                        principalTable: "PHAT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__MUONTRA__QUYENSA__34C8D9D1",
                        column: x => x.QUYENSACHID,
                        principalTable: "QUYENSACH",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MUONTRA_DOCGIAID",
                table: "MUONTRA",
                column: "DOCGIAID");

            migrationBuilder.CreateIndex(
                name: "IX_MUONTRA_NHANVIENID",
                table: "MUONTRA",
                column: "NHANVIENID");

            migrationBuilder.CreateIndex(
                name: "IX_MUONTRA_PHATID",
                table: "MUONTRA",
                column: "PHATID");

            migrationBuilder.CreateIndex(
                name: "IX_MUONTRA_QUYENSACHID",
                table: "MUONTRA",
                column: "QUYENSACHID");

            migrationBuilder.CreateIndex(
                name: "IX_QUYENSACH_LOAISACHID",
                table: "QUYENSACH",
                column: "LOAISACHID");

            migrationBuilder.CreateIndex(
                name: "IX_QUYENSACH_NHAXUATBANID",
                table: "QUYENSACH",
                column: "NHAXUATBANID");

            migrationBuilder.CreateIndex(
                name: "IX_TAIKHOAN_IDNHANVIEN",
                table: "TAIKHOAN",
                column: "IDNHANVIEN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MUONTRA");

            migrationBuilder.DropTable(
                name: "TAIKHOAN");

            migrationBuilder.DropTable(
                name: "DOCGIA");

            migrationBuilder.DropTable(
                name: "PHAT");

            migrationBuilder.DropTable(
                name: "QUYENSACH");

            migrationBuilder.DropTable(
                name: "NHANVIEN");

            migrationBuilder.DropTable(
                name: "LOAISACH");

            migrationBuilder.DropTable(
                name: "NHAXUATBAN");
        }
    }
}
