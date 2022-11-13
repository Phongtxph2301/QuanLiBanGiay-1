using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable


namespace ADAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.CreateTable(
                name: "ChieuCaoDeGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKichCo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KichCo = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ChieuCaoDeGiay", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaChucVu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "CuaHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCuaHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenCuaHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_CuaHang", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Giay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGiay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenGiay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Giay", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "HangGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHangGiay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenHangGiay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_HangGiay", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKhachHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoCCCD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaMauSac = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenMauSac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Nsx",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNsx = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNsx = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Nsx", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "PhuongThucThanhToan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNsx = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenNsx = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_PhuongThucThanhToan", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "QuyDoi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaQuyDoi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TiLeQuyDoi = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_QuyDoi", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGiamGia = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenChuongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LuaChonGiamGia = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Sale", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSize = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoSize = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Size", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaTheLoai = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenTheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPhanCap = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_TheLoai", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_TheLoai_TheLoai_IdPhanCap",
                        column: x => x.IdPhanCap,
                        principalTable: "TheLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCuaHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_NhanVien", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdChucVu",
                        column: x => x.IdChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_NhanVien_CuaHang_IdCuaHang",
                        column: x => x.IdCuaHang,
                        principalTable: "CuaHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "DiemTieuDung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaDiemTieuDung = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoDiem = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_DiemTieuDung", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_DiemTieuDung_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "ChiTietGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNsx = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHangGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChieuCaoDeGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaBan = table.Column<float>(type: "real", nullable: false),
                    GiaNhap = table.Column<float>(type: "real", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ChiTietGiay", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_ChieuCaoDeGiay_IdChieuCaoDeGiay",
                        column: x => x.IdChieuCaoDeGiay,
                        principalTable: "ChieuCaoDeGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_Giay_IdGiay",
                        column: x => x.IdGiay,
                        principalTable: "Giay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_HangGiay_IdHangGiay",
                        column: x => x.IdHangGiay,
                        principalTable: "HangGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_MauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_Nsx_IdNsx",
                        column: x => x.IdNsx,
                        principalTable: "Nsx",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietGiay_Size_IdSize",
                        column: x => x.IdSize,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "GiaoCa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVienTiepQuan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGiaoCa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TienLai = table.Column<float>(type: "real", nullable: false),
                    TienDuTru = table.Column<float>(type: "real", nullable: false),
                    TienPhatSinh = table.Column<float>(type: "real", nullable: false),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_GiaoCa", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_GiaoCa_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_GiaoCa_NhanVien_IdNhanVienTiepQuan",
                        column: x => x.IdNhanVienTiepQuan,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHoaDon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiamGia = table.Column<float>(type: "real", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_HoaDon", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "ChiTietSale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSale = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ChiTietSale", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietSale_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietSale_Sale_IdSale",
                        column: x => x.IdSale,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "ChiTietTheLoai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTheLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ChiTietTheLoai", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietTheLoai_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietTheLoai_TheLoai_IdTheLoai",
                        column: x => x.IdTheLoai,
                        principalTable: "TheLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "ChiTietThanhToan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhuongThucThanhToan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoTienThanhToan = table.Column<float>(type: "real", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ChiTietThanhToan", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietThanhToan_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_ChiTietThanhToan_PhuongThucThanhToan_IdPhuongThucThanhToan",
                        column: x => x.IdPhuongThucThanhToan,
                        principalTable: "PhuongThucThanhToan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_HoaDonChiTiet", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ChiTietGiay_IdChiTietGiay",
                        column: x => x.IdChiTietGiay,
                        principalTable: "ChiTietGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.CreateTable(
                name: "LichSuDiemTieuDung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDiemTieuDung = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdQuyDoi = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiaTriQuyDoi = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_LichSuDiemTieuDung", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_DiemTieuDung_IdDiemTieuDung",
                        column: x => x.IdDiemTieuDung,
                        principalTable: "DiemTieuDung",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    _ = table.ForeignKey(
                        name: "FK_LichSuDiemTieuDung_QuyDoi_IdQuyDoi",
                        column: x => x.IdQuyDoi,
                        principalTable: "QuyDoi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            _ = migrationBuilder.InsertData(
                table: "ChieuCaoDeGiay",
                columns: new[] { "Id", "KichCo", "MaKichCo", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("1fd05d20-4e5a-460d-b691-349c329652d3"), 1, "KC1", 0 },
                    { new Guid("6237d811-d11b-4165-b6aa-50b70ebfd4c6"), 2, "KC2", 0 },
                    { new Guid("874a7601-4307-43fc-ae03-5f48cf01bbe7"), 5, "KC5", 0 },
                    { new Guid("90a04236-21ef-46e2-8935-1145c1c1f278"), 3, "KC3", 0 },
                    { new Guid("dc22b62f-7f72-44ee-bbd6-26e47a36d937"), 4, "KC4", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "Id", "MaChucVu", "TenChucVu", "TrangThai" },
                values: new object[] { new Guid("a461059e-3569-475c-84d0-95f9394691c2"), "CV1", "Nhân viên", 0 });

            _ = migrationBuilder.InsertData(
                table: "CuaHang",
                columns: new[] { "Id", "DiaChi", "MaCuaHang", "TenCuaHang", "TrangThai" },
                values: new object[] { new Guid("fc833c25-ebb6-44c2-850c-71b309e2314e"), "Hà Nội", "CH1", "Cửa hàng 1", 0 });

            _ = migrationBuilder.InsertData(
                table: "Giay",
                columns: new[] { "Id", "MaGiay", "TenGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("06478ca2-009a-4d80-a144-34e41d8990dd"), "G1", "Giày 1", 0 },
                    { new Guid("20dc1cf7-b2da-45da-928b-f3ed6721e8bb"), "G5", "Giày 5", 0 },
                    { new Guid("24419e78-a601-4b78-9979-41bfd262df3a"), "G4", "Giày 4", 0 },
                    { new Guid("914bb385-fa1f-4fc3-ac3c-1193298fa55c"), "G3", "Giày 3", 0 },
                    { new Guid("e36b5c47-ff9c-4f62-96b8-e072ad92d17f"), "G2", "Giày 2", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "HangGiay",
                columns: new[] { "Id", "MaHangGiay", "TenHangGiay", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("08d3ccdd-b0dc-40c3-bba2-adc515e49c7b"), "HG1", "Hãng giày 1", 0 },
                    { new Guid("89b0ae32-f859-491f-bbc2-8bdd25239fe7"), "HG2", "Hãng giày 2", 0 },
                    { new Guid("ad9d752e-c060-46d0-aa45-799c246aa9c9"), "HG3", "Hãng giày 3", 0 },
                    { new Guid("ec4283d1-7c60-4677-8ff9-97cc41b17381"), "HG4", "Hãng giày 4", 0 },
                    { new Guid("f7c642c8-808d-4fd3-8acb-ab3ab6b20852"), "HG5", "Hãng giày 5", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "Id", "DiaChi", "Email", "MaKhachHang", "NgaySinh", "Sdt", "SoCCCD", "TenKhachHang", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("a3cf634b-258f-4175-be33-13fc8f83b8ed"), "Hà Nội", null, "KH1", new DateTime(2022, 11, 14, 3, 39, 29, 739, DateTimeKind.Local).AddTicks(1837), "0385922775", "12345", "Khách hàng 1", 0 },
                    { new Guid("d3834548-68d3-45f9-8605-9f211ad94806"), "Hà Nội", null, "KH2", new DateTime(2022, 11, 14, 3, 39, 29, 739, DateTimeKind.Local).AddTicks(1867), "0385922775", "01234", "Khách hàng 2", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "MauSac",
                columns: new[] { "Id", "MaMauSac", "TenMauSac", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("11598eaf-e780-468f-ba6c-d1b3e54e8347"), "MS4", "Màu sắc 4", 0 },
                    { new Guid("1e20b456-e3b2-431b-b61d-f616fa2540e6"), "MS1", "Màu sắc 1", 0 },
                    { new Guid("58d2072c-af26-47f2-9c3a-4f9ad17ea60a"), "MS2", "Màu sắc 2", 0 },
                    { new Guid("8b66b543-1bb2-4aea-b60c-d5d1e3e9fb55"), "MS5", "Màu sắc 5", 0 },
                    { new Guid("b8ba4364-56e2-4be1-bd0b-4866233aff8e"), "MS3", "Màu sắc 3", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "Nsx",
                columns: new[] { "Id", "DiaChi", "MaNsx", "TenNsx" },
                values: new object[,]
                {
                    { new Guid("0f30a506-f09d-477c-b959-38ae7ec1b431"), "Hà Nội", "NSX3", "Nhà sản xuất 3" },
                    { new Guid("1d8a40d1-64eb-4395-addd-5a3e82ae0350"), "Hà Nội", "NSX4", "Nhà sản xuất 4" },
                    { new Guid("468093b5-3ecf-4ca1-bff3-c7428f6b638f"), "Hà Nội", "NSX5", "Nhà sản xuất 5" },
                    { new Guid("cc8605bc-b431-4097-b969-73a5e74318c2"), "Hà Nội", "NSX1", "Nhà sản xuất 1" },
                    { new Guid("e2a8b87d-1856-4292-9daf-c89da39a51f2"), "Hà Nội", "NSX2", "Nhà sản xuất 2" }
                });

            _ = migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "MaSize", "SoSize", "TenSize", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("3101592b-bbbc-4257-8fa7-d4257dd0623e"), "SZ4", 33, "Size 4", 0 },
                    { new Guid("3cd7ce8b-e2ce-43fa-8c77-95fb0ae1c14d"), "SZ2", 31, "Size 2", 0 },
                    { new Guid("6698a12a-6a0b-4790-a8e5-592cdb216868"), "SZ5", 34, "Size 5", 0 },
                    { new Guid("9541cf43-cd9d-476d-b009-2e149419d01d"), "SZ1", 30, "Size 1", 0 },
                    { new Guid("b3800344-67f5-44bc-bc06-999926d0d914"), "SZ3", 32, "Size 3", 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "ChiTietGiay",
                columns: new[] { "Id", "GiaBan", "GiaNhap", "IdChieuCaoDeGiay", "IdGiay", "IdHangGiay", "IdMauSac", "IdNsx", "IdSize", "MoTa", "SoLuongTon", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("25935c54-b421-4d09-8fa7-43ffc6e728a9"), 10000f, 7000f, new Guid("6237d811-d11b-4165-b6aa-50b70ebfd4c6"), new Guid("e36b5c47-ff9c-4f62-96b8-e072ad92d17f"), new Guid("89b0ae32-f859-491f-bbc2-8bdd25239fe7"), new Guid("8b66b543-1bb2-4aea-b60c-d5d1e3e9fb55"), new Guid("e2a8b87d-1856-4292-9daf-c89da39a51f2"), new Guid("3101592b-bbbc-4257-8fa7-d4257dd0623e"), null, 100, 0 },
                    { new Guid("5ffddf52-1b8f-4778-aaa0-b235cf5398b7"), 10000f, 7000f, new Guid("874a7601-4307-43fc-ae03-5f48cf01bbe7"), new Guid("24419e78-a601-4b78-9979-41bfd262df3a"), new Guid("08d3ccdd-b0dc-40c3-bba2-adc515e49c7b"), new Guid("8b66b543-1bb2-4aea-b60c-d5d1e3e9fb55"), new Guid("0f30a506-f09d-477c-b959-38ae7ec1b431"), new Guid("9541cf43-cd9d-476d-b009-2e149419d01d"), null, 100, 0 },
                    { new Guid("73648271-dfb1-45fd-9beb-14120bc07592"), 10000f, 7000f, new Guid("90a04236-21ef-46e2-8935-1145c1c1f278"), new Guid("e36b5c47-ff9c-4f62-96b8-e072ad92d17f"), new Guid("f7c642c8-808d-4fd3-8acb-ab3ab6b20852"), new Guid("b8ba4364-56e2-4be1-bd0b-4866233aff8e"), new Guid("1d8a40d1-64eb-4395-addd-5a3e82ae0350"), new Guid("6698a12a-6a0b-4790-a8e5-592cdb216868"), null, 100, 0 },
                    { new Guid("74267484-e487-442f-81ba-35a0d0ca7143"), 10000f, 7000f, new Guid("90a04236-21ef-46e2-8935-1145c1c1f278"), new Guid("e36b5c47-ff9c-4f62-96b8-e072ad92d17f"), new Guid("ec4283d1-7c60-4677-8ff9-97cc41b17381"), new Guid("1e20b456-e3b2-431b-b61d-f616fa2540e6"), new Guid("468093b5-3ecf-4ca1-bff3-c7428f6b638f"), new Guid("b3800344-67f5-44bc-bc06-999926d0d914"), null, 100, 0 },
                    { new Guid("744fd792-0f87-4080-919a-aafe22479a7e"), 10000f, 7000f, new Guid("1fd05d20-4e5a-460d-b691-349c329652d3"), new Guid("06478ca2-009a-4d80-a144-34e41d8990dd"), new Guid("08d3ccdd-b0dc-40c3-bba2-adc515e49c7b"), new Guid("b8ba4364-56e2-4be1-bd0b-4866233aff8e"), new Guid("0f30a506-f09d-477c-b959-38ae7ec1b431"), new Guid("3cd7ce8b-e2ce-43fa-8c77-95fb0ae1c14d"), null, 100, 0 },
                    { new Guid("9cb0afad-97b9-4269-a1d7-149ef7d4dc37"), 10000f, 7000f, new Guid("1fd05d20-4e5a-460d-b691-349c329652d3"), new Guid("24419e78-a601-4b78-9979-41bfd262df3a"), new Guid("ad9d752e-c060-46d0-aa45-799c246aa9c9"), new Guid("b8ba4364-56e2-4be1-bd0b-4866233aff8e"), new Guid("0f30a506-f09d-477c-b959-38ae7ec1b431"), new Guid("3cd7ce8b-e2ce-43fa-8c77-95fb0ae1c14d"), null, 100, 0 },
                    { new Guid("b3729e75-2868-42e5-a231-8a936d1fc044"), 10000f, 7000f, new Guid("90a04236-21ef-46e2-8935-1145c1c1f278"), new Guid("914bb385-fa1f-4fc3-ac3c-1193298fa55c"), new Guid("89b0ae32-f859-491f-bbc2-8bdd25239fe7"), new Guid("1e20b456-e3b2-431b-b61d-f616fa2540e6"), new Guid("e2a8b87d-1856-4292-9daf-c89da39a51f2"), new Guid("9541cf43-cd9d-476d-b009-2e149419d01d"), null, 100, 0 },
                    { new Guid("cada3a66-1546-4237-b5c0-a067d2f3cb33"), 10000f, 7000f, new Guid("6237d811-d11b-4165-b6aa-50b70ebfd4c6"), new Guid("914bb385-fa1f-4fc3-ac3c-1193298fa55c"), new Guid("f7c642c8-808d-4fd3-8acb-ab3ab6b20852"), new Guid("58d2072c-af26-47f2-9c3a-4f9ad17ea60a"), new Guid("0f30a506-f09d-477c-b959-38ae7ec1b431"), new Guid("9541cf43-cd9d-476d-b009-2e149419d01d"), null, 100, 0 },
                    { new Guid("d6b72661-551e-4fb7-aa79-ff973f441c28"), 10000f, 7000f, new Guid("874a7601-4307-43fc-ae03-5f48cf01bbe7"), new Guid("24419e78-a601-4b78-9979-41bfd262df3a"), new Guid("f7c642c8-808d-4fd3-8acb-ab3ab6b20852"), new Guid("58d2072c-af26-47f2-9c3a-4f9ad17ea60a"), new Guid("e2a8b87d-1856-4292-9daf-c89da39a51f2"), new Guid("6698a12a-6a0b-4790-a8e5-592cdb216868"), null, 100, 0 },
                    { new Guid("ea52f8df-bb8b-4724-b312-4ea9ea50ca2e"), 10000f, 7000f, new Guid("1fd05d20-4e5a-460d-b691-349c329652d3"), new Guid("06478ca2-009a-4d80-a144-34e41d8990dd"), new Guid("08d3ccdd-b0dc-40c3-bba2-adc515e49c7b"), new Guid("8b66b543-1bb2-4aea-b60c-d5d1e3e9fb55"), new Guid("468093b5-3ecf-4ca1-bff3-c7428f6b638f"), new Guid("b3800344-67f5-44bc-bc06-999926d0d914"), null, 100, 0 }
                });

            _ = migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "DiaChi", "Email", "GioiTinh", "IdChucVu", "IdCuaHang", "MaNhanVien", "MatKhau", "NgaySinh", "Sdt", "TenNhanVien", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("34062bbc-3f4f-4b38-8628-46ebd9914a0b"), "Hà Nội", null, 0, new Guid("a461059e-3569-475c-84d0-95f9394691c2"), new Guid("fc833c25-ebb6-44c2-850c-71b309e2314e"), "NV1", "00000", new DateTime(2022, 11, 14, 3, 39, 29, 739, DateTimeKind.Local).AddTicks(1726), "0385922775", "Nhân viên 1", 0 },
                    { new Guid("9f421dd2-39fe-45fc-92d8-08e94b7043b5"), "Hà Nội", null, 1, new Guid("a461059e-3569-475c-84d0-95f9394691c2"), new Guid("fc833c25-ebb6-44c2-850c-71b309e2314e"), "NV2", "00000", new DateTime(2022, 11, 14, 3, 39, 29, 739, DateTimeKind.Local).AddTicks(1790), "0385922775", "Nhân viên 2", 0 }
                });

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChieuCaoDeGiay_MaKichCo",
                table: "ChieuCaoDeGiay",
                column: "MaKichCo",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdChieuCaoDeGiay",
                table: "ChiTietGiay",
                column: "IdChieuCaoDeGiay");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdGiay",
                table: "ChiTietGiay",
                column: "IdGiay");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdHangGiay",
                table: "ChiTietGiay",
                column: "IdHangGiay");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdMauSac_IdSize_IdNsx_IdHangGiay_IdChieuCaoDeGiay_IdGiay",
                table: "ChiTietGiay",
                columns: new[] { "IdMauSac", "IdSize", "IdNsx", "IdHangGiay", "IdChieuCaoDeGiay", "IdGiay" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdNsx",
                table: "ChiTietGiay",
                column: "IdNsx");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiay_IdSize",
                table: "ChiTietGiay",
                column: "IdSize");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietSale_IdChiTietGiay_IdSale",
                table: "ChiTietSale",
                columns: new[] { "IdChiTietGiay", "IdSale" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietSale_IdSale",
                table: "ChiTietSale",
                column: "IdSale");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietThanhToan_IdHoaDon",
                table: "ChiTietThanhToan",
                column: "IdHoaDon");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietThanhToan_IdPhuongThucThanhToan",
                table: "ChiTietThanhToan",
                column: "IdPhuongThucThanhToan");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietTheLoai_IdChiTietGiay_IdTheLoai",
                table: "ChiTietTheLoai",
                columns: new[] { "IdChiTietGiay", "IdTheLoai" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChiTietTheLoai_IdTheLoai",
                table: "ChiTietTheLoai",
                column: "IdTheLoai");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ChucVu_MaChucVu",
                table: "ChucVu",
                column: "MaChucVu",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_CuaHang_MaCuaHang",
                table: "CuaHang",
                column: "MaCuaHang",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DiemTieuDung_IdKhachHang",
                table: "DiemTieuDung",
                column: "IdKhachHang",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DiemTieuDung_MaDiemTieuDung",
                table: "DiemTieuDung",
                column: "MaDiemTieuDung",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_IdNhanVien",
                table: "GiaoCa",
                column: "IdNhanVien");

            _ = migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_IdNhanVienTiepQuan",
                table: "GiaoCa",
                column: "IdNhanVienTiepQuan");

            _ = migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_MaGiaoCa",
                table: "GiaoCa",
                column: "MaGiaoCa",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Giay_MaGiay",
                table: "Giay",
                column: "MaGiay",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_HangGiay_MaHangGiay",
                table: "HangGiay",
                column: "MaHangGiay",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien");

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaHoaDon",
                table: "HoaDon",
                column: "MaHoaDon",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdChiTietGiay_IdHoaDon",
                table: "HoaDonChiTiet",
                columns: new[] { "IdChiTietGiay", "IdHoaDon" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHoaDon",
                table: "HoaDonChiTiet",
                column: "IdHoaDon");

            _ = migrationBuilder.CreateIndex(
                name: "IX_KhachHang_MaKhachHang",
                table: "KhachHang",
                column: "MaKhachHang",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_KhachHang_SoCCCD",
                table: "KhachHang",
                column: "SoCCCD",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdDiemTieuDung",
                table: "LichSuDiemTieuDung",
                column: "IdDiemTieuDung");

            _ = migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdHoaDon_IdDiemTieuDung_IdQuyDoi",
                table: "LichSuDiemTieuDung",
                columns: new[] { "IdHoaDon", "IdDiemTieuDung", "IdQuyDoi" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_LichSuDiemTieuDung_IdQuyDoi",
                table: "LichSuDiemTieuDung",
                column: "IdQuyDoi");

            _ = migrationBuilder.CreateIndex(
                name: "IX_MauSac_MaMauSac",
                table: "MauSac",
                column: "MaMauSac",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdChucVu",
                table: "NhanVien",
                column: "IdChucVu");

            _ = migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCuaHang",
                table: "NhanVien",
                column: "IdCuaHang");

            _ = migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaNhanVien",
                table: "NhanVien",
                column: "MaNhanVien",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Nsx_MaNsx",
                table: "Nsx",
                column: "MaNsx",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_QuyDoi_MaQuyDoi",
                table: "QuyDoi",
                column: "MaQuyDoi",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Sale_MaGiamGia",
                table: "Sale",
                column: "MaGiamGia",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Size_MaSize",
                table: "Size",
                column: "MaSize",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_TheLoai_IdPhanCap",
                table: "TheLoai",
                column: "IdPhanCap");

            _ = migrationBuilder.CreateIndex(
                name: "IX_TheLoai_MaTheLoai",
                table: "TheLoai",
                column: "MaTheLoai",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropTable(
                name: "ChiTietSale");

            _ = migrationBuilder.DropTable(
                name: "ChiTietThanhToan");

            _ = migrationBuilder.DropTable(
                name: "ChiTietTheLoai");

            _ = migrationBuilder.DropTable(
                name: "GiaoCa");

            _ = migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            _ = migrationBuilder.DropTable(
                name: "LichSuDiemTieuDung");

            _ = migrationBuilder.DropTable(
                name: "Sale");

            _ = migrationBuilder.DropTable(
                name: "PhuongThucThanhToan");

            _ = migrationBuilder.DropTable(
                name: "TheLoai");

            _ = migrationBuilder.DropTable(
                name: "ChiTietGiay");

            _ = migrationBuilder.DropTable(
                name: "DiemTieuDung");

            _ = migrationBuilder.DropTable(
                name: "HoaDon");

            _ = migrationBuilder.DropTable(
                name: "QuyDoi");

            _ = migrationBuilder.DropTable(
                name: "ChieuCaoDeGiay");

            _ = migrationBuilder.DropTable(
                name: "Giay");

            _ = migrationBuilder.DropTable(
                name: "HangGiay");

            _ = migrationBuilder.DropTable(
                name: "MauSac");

            _ = migrationBuilder.DropTable(
                name: "Nsx");

            _ = migrationBuilder.DropTable(
                name: "Size");

            _ = migrationBuilder.DropTable(
                name: "KhachHang");

            _ = migrationBuilder.DropTable(
                name: "NhanVien");

            _ = migrationBuilder.DropTable(
                name: "ChucVu");

            _ = migrationBuilder.DropTable(
                name: "CuaHang");
        }
    }
}
