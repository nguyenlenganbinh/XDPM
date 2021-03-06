
USE [dbChoThueDia]
GO
ALTER TABLE [dbo].[tbTieuDe] DROP CONSTRAINT [FK_tbTieuDe_tbLoaiDia]
GO
ALTER TABLE [dbo].[tbThongTinDatTruoc] DROP CONSTRAINT [FK_tbThongTinDatTruoc_tbTieuDe]
GO
ALTER TABLE [dbo].[tbThongTinDatTruoc] DROP CONSTRAINT [FK_tbThongTinDatTruoc_tbKhachHang]
GO
ALTER TABLE [dbo].[tbLapPhieuThue] DROP CONSTRAINT [FK_tbLapPhieuThue_tbKhachHang]
GO
ALTER TABLE [dbo].[tbLapPhieuThue] DROP CONSTRAINT [FK_tbLapPhieuThue_tbDiaCD]
GO
ALTER TABLE [dbo].[tbDiaCD] DROP CONSTRAINT [FK_tbDiaCD_tbTieuDe]
GO
/****** Object:  Table [dbo].[tbTieuDe]    Script Date: 11/27/2020 4:03:14 PM ******/
DROP TABLE [dbo].[tbTieuDe]
GO
/****** Object:  Table [dbo].[tbThongTinDatTruoc]    Script Date: 11/27/2020 4:03:14 PM ******/
DROP TABLE [dbo].[tbThongTinDatTruoc]
GO
/****** Object:  Table [dbo].[tbLoaiDia]    Script Date: 11/27/2020 4:03:14 PM ******/
DROP TABLE [dbo].[tbLoaiDia]
GO
/****** Object:  Table [dbo].[tbLapPhieuThue]    Script Date: 11/27/2020 4:03:14 PM ******/
DROP TABLE [dbo].[tbLapPhieuThue]
GO
/****** Object:  Table [dbo].[tbKhachHang]    Script Date: 11/27/2020 4:03:14 PM ******/
DROP TABLE [dbo].[tbKhachHang]
GO
/****** Object:  Table [dbo].[tbDiaCD]    Script Date: 11/27/2020 4:03:14 PM ******/
DROP TABLE [dbo].[tbDiaCD]
GO
/****** Object:  Table [dbo].[tbDiaCD]    Script Date: 11/27/2020 4:03:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDiaCD](
	[MaDiaCD] [nvarchar](50) NOT NULL,
	[TinhTrangDia] [nvarchar](50) NULL,
	[MaTieuDe] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbDiaCD] PRIMARY KEY CLUSTERED 
(
	[MaDiaCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbKhachHang]    Script Date: 11/27/2020 4:03:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbKhachHang](
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
	[PhiPhat] [money] NULL,
 CONSTRAINT [PK_tbKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbLapPhieuThue]    Script Date: 11/27/2020 4:03:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbLapPhieuThue](
	[MaPhieuThue] [nvarchar](50) NOT NULL,
	[MaKhachHang] [nvarchar](50) NULL,
	[NgayThueDia] [datetime] NULL,
	[NgayPhaiTra] [datetime] NULL,
	[GiaDiaThue] [money] NULL,
	[NgayTraDia] [datetime] NULL,
	[PhiPhat] [money] NULL,
	[KiemTraPhiPhat] [bit] NULL,
	[MaDiaCD] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbLapPhieuThue] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbLoaiDia]    Script Date: 11/27/2020 4:03:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbLoaiDia](
	[MaLoai] [nvarchar](50) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[ThoiGianThue] [int] NULL,
	[Gia] [money] NULL,
	[PhiPhat] [money] NULL,
 CONSTRAINT [PK_tbLoaiDia] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbThongTinDatTruoc]    Script Date: 11/27/2020 4:03:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbThongTinDatTruoc](
	[MaDatDia] [nvarchar](50) NOT NULL,
	[MaKhachHang] [nvarchar](50) NULL,
	[NgayDatDia] [datetime] NULL,
	[MaTieuDe] [nvarchar](50) NULL,
	[MaDiaTam] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbThongTinDatTruoc] PRIMARY KEY CLUSTERED 
(
	[MaDatDia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbTieuDe]    Script Date: 11/27/2020 4:03:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTieuDe](
	[MaTieuDe] [nvarchar](50) NOT NULL,
	[TenTieuDe] [nvarchar](max) NULL,
	[MoTa] [nvarchar](50) NULL,
	[MaLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbTieuDe] PRIMARY KEY CLUSTERED 
(
	[MaTieuDe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0001', N'Trống', N'TD0001')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0002', N'Đang Thuê', N'TD0001')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0003', N'Đang Chờ', N'TD0001')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0004', N'Trống', N'TD0001')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0005', N'Trống', N'TD0001')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0006', N'Đang Thuê', N'TD0008')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0007', N'Đang Thuê', N'TD0008')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0008', N'Đang Thuê', N'TD0008')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0009', N'Trống', N'TD0009')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0010', N'Trống', N'TD0010')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0011', N'Trống', N'TD0011')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0012', N'Đang Chờ', N'TD0012')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0013', N'Trống', N'TD0012')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0014', N'Đang Chờ', N'TD0007')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0015', N'Trống', N'TD0007')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0016', N'Trống ', N'TD0010')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0017', N'Đang Thuê', N'TD0007')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0018', N'Đang Thuê', N'TD0002')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0019', N'Trống ', N'TD0002')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0020', N'Trống ', N'TD0003')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0021', N'Đang Chờ', N'TD0004')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0022', N'Đang Chờ', N'TD0003')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0023', N'Trống ', N'TD0010')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0024', N'Trống ', N'TD0009')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0025', N'Trống ', N'TD0003')
INSERT [dbo].[tbDiaCD] ([MaDiaCD], [TinhTrangDia], [MaTieuDe]) VALUES (N'CD0026', N'Trống ', N'TD0004')
INSERT [dbo].[tbKhachHang] ([MaKhachHang], [TenKH], [DiaChi], [SoDienThoai], [PhiPhat]) VALUES (N'KH0001', N'Nguyễn Xuân Nam', N'347 Lê Quang Định, Phường 1, Gò Vấp, Tp.HCM', N'0346781908', 25000.0000)
INSERT [dbo].[tbKhachHang] ([MaKhachHang], [TenKH], [DiaChi], [SoDienThoai], [PhiPhat]) VALUES (N'KH0002', N'Văn Tý', N'50 Lê Quang Định, Phường 1, Gò Vấp, Tp.HCM', N'0346781910', 15000.0000)
INSERT [dbo].[tbKhachHang] ([MaKhachHang], [TenKH], [DiaChi], [SoDienThoai], [PhiPhat]) VALUES (N'KH0003', N'Trần Minh Dương', N'10 Lê Quang Định, Phường 1, Gò Vấp, Tp.HCM', N'0398481910', 0.0000)
INSERT [dbo].[tbKhachHang] ([MaKhachHang], [TenKH], [DiaChi], [SoDienThoai], [PhiPhat]) VALUES (N'KH0004', N'Lê Thị Trang', N'8 Lê Quang Định, Phường 1, Gò Vấp, Tp.HCM', N'0398481918', 5000.0000)
INSERT [dbo].[tbKhachHang] ([MaKhachHang], [TenKH], [DiaChi], [SoDienThoai], [PhiPhat]) VALUES (N'KH0005', N'Mai Trang', N'58 Lê Quang Định, Phường 1, Gò Vấp, Tp.HCM', N'0398401910', 5000.0000)
INSERT [dbo].[tbKhachHang] ([MaKhachHang], [TenKH], [DiaChi], [SoDienThoai], [PhiPhat]) VALUES (N'KH0006', N'Nguyễn Văn Hậu', N'100 Lê Quang Định, Phường 1, Gò Vấp, Tp.HCM', N'0398401910', 0.0000)
INSERT [dbo].[tbKhachHang] ([MaKhachHang], [TenKH], [DiaChi], [SoDienThoai], [PhiPhat]) VALUES (N'KH0007', N'Trần Cung', N'588 Lê Quang Định, Phường 1, Gò Vấp, Tp.HCM', N'0398401910', 0.0000)
INSERT [dbo].[tbKhachHang] ([MaKhachHang], [TenKH], [DiaChi], [SoDienThoai], [PhiPhat]) VALUES (N'KH0008', N'Lệ Quyên', N'105 Lê Quang Định, Phường 1, Gò Vấp, Tp.HCM', N'0398401910', 0.0000)
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0001', N'KH0001', CAST(0x0000AC4700000000 AS DateTime), CAST(0x0000AC5100000000 AS DateTime), 20000.0000, CAST(0x0000AC5A00000000 AS DateTime), 5000.0000, 0, N'CD0001')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0002', N'KH0001', CAST(0x0000AC4700000000 AS DateTime), CAST(0x0000AC5100000000 AS DateTime), 20000.0000, CAST(0x0000AC7D01267C96 AS DateTime), 5000.0000, 0, N'CD0017')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0003', N'KH0002', CAST(0x0000AC4700000000 AS DateTime), CAST(0x0000AC5100000000 AS DateTime), 20000.0000, CAST(0x0000AC7D00F1E39C AS DateTime), 5000.0000, 0, N'CD0003')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0004', N'KH0002', CAST(0x0000AC4700000000 AS DateTime), CAST(0x0000AC5100000000 AS DateTime), 20000.0000, CAST(0x0000AC5A00000000 AS DateTime), 5000.0000, 0, N'CD0015')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0005', N'KH0003', CAST(0x0000AC4700000000 AS DateTime), CAST(0x0000AC5100000000 AS DateTime), 20000.0000, CAST(0x0000AC4E00000000 AS DateTime), 0.0000, 1, N'CD0005')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0006', N'KH0004', CAST(0x0000AC4700000000 AS DateTime), CAST(0x0000AC4E00000000 AS DateTime), 25000.0000, CAST(0x0000AC5A00000000 AS DateTime), 5000.0000, 0, N'CD0010')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0007', N'KH0005', CAST(0x0000AC4700000000 AS DateTime), CAST(0x0000AC4E00000000 AS DateTime), 25000.0000, CAST(0x0000AC5A00000000 AS DateTime), 5000.0000, 0, N'CD0011')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0008', N'KH0005', CAST(0x0000AC4700000000 AS DateTime), CAST(0x0000AC4E00000000 AS DateTime), 25000.0000, CAST(0x0000AC5A00000000 AS DateTime), 5000.0000, 0, N'CD0001')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0009', N'KH0005', CAST(0x0000AC4700000000 AS DateTime), CAST(0x0000AC4E00000000 AS DateTime), 25000.0000, CAST(0x0000AC5A00000000 AS DateTime), 5000.0000, 0, N'CD0009')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0011', N'KH0001', CAST(0x0000AC5600000000 AS DateTime), CAST(0x0000AC5D00000000 AS DateTime), 20000.0000, CAST(0x0000AC6600000000 AS DateTime), 5000.0000, 0, N'CD0012')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0012', N'KH0005', CAST(0x0000AC7500000000 AS DateTime), CAST(0x0000AC7C00000000 AS DateTime), 25000.0000, CAST(0x0000AC7900000000 AS DateTime), 0.0000, 1, N'CD0012')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0013', N'KH0005', CAST(0x0000AC7500000000 AS DateTime), CAST(0x0000AC7C00000000 AS DateTime), 25000.0000, CAST(0x0000AC7900000000 AS DateTime), 0.0000, 1, N'CD0017')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0014', N'KH0004', CAST(0x0000AC7500000000 AS DateTime), CAST(0x0000AC7C00000000 AS DateTime), 25000.0000, NULL, NULL, NULL, N'CD0008')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0015', N'KH0002', CAST(0x0000AC7500000000 AS DateTime), CAST(0x0000AC7C00000000 AS DateTime), 25000.0000, NULL, NULL, NULL, N'CD0007')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0016', N'KH0003', CAST(0x0000AC6A00000000 AS DateTime), CAST(0x0000AC7100000000 AS DateTime), 25000.0000, NULL, NULL, NULL, N'CD0006')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP0017', N'KH0001', CAST(0x0000AC7500000000 AS DateTime), CAST(0x0000AC7C00000000 AS DateTime), 25000.0000, CAST(0x0000AC7D00F34913 AS DateTime), 5000.0000, 0, N'CD0009')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP3419', N'KH0007', CAST(0x0000AC8000C7AB7E AS DateTime), CAST(0x0000AC8A00000000 AS DateTime), 20000.0000, NULL, NULL, NULL, N'CD0002')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP6555', N'kh0005', CAST(0x0000AC8000F154A0 AS DateTime), CAST(0x0000AC8A00000000 AS DateTime), 20000.0000, NULL, NULL, NULL, N'CD0018')
INSERT [dbo].[tbLapPhieuThue] ([MaPhieuThue], [MaKhachHang], [NgayThueDia], [NgayPhaiTra], [GiaDiaThue], [NgayTraDia], [PhiPhat], [KiemTraPhiPhat], [MaDiaCD]) VALUES (N'MP8750', N'KH0007', CAST(0x0000AC8000C7AB7E AS DateTime), CAST(0x0000AC8700000000 AS DateTime), 25000.0000, NULL, NULL, NULL, N'CD0017')
INSERT [dbo].[tbLoaiDia] ([MaLoai], [TenLoai], [ThoiGianThue], [Gia], [PhiPhat]) VALUES (N'L0001', N'Đĩa Phim', 7, 25000.0000, 5000.0000)
INSERT [dbo].[tbLoaiDia] ([MaLoai], [TenLoai], [ThoiGianThue], [Gia], [PhiPhat]) VALUES (N'L0002', N'Đĩa Game ', 10, 20000.0000, 5000.0000)
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0001', N'KH0007', CAST(0x0000AC5F00000000 AS DateTime), N'TD0012', N'CD0012')
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0002', N'KH0005', CAST(0x0000AC5F00000000 AS DateTime), N'TD0012', NULL)
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0003', N'KH0008', CAST(0x0000AC6200000000 AS DateTime), N'TD0012', NULL)
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0004', N'KH0006', CAST(0x0000AC6A00000000 AS DateTime), N'TD0007', N'CD0014')
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0005', N'KH0006', CAST(0x0000AC6A00000000 AS DateTime), N'TD0008', NULL)
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0006', N'KH0008', CAST(0x0000AC7D00ADE2D8 AS DateTime), N'TD0001', N'CD0003')
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0008', N'KH0004', CAST(0x0000AC7D00B1114C AS DateTime), N'TD0011', NULL)
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0009', N'KH0001', CAST(0x0000AC7D0132D7F4 AS DateTime), N'TD0006', NULL)
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0010', N'KH0007', CAST(0x0000AC7D01492428 AS DateTime), N'TD0008', NULL)
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0011', N'KH0002', CAST(0x0000AC8000CB2320 AS DateTime), N'TD0005', NULL)
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0012', N'KH0002', CAST(0x0000AC8000CB2320 AS DateTime), N'TD0006', NULL)
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0013', N'KH0002', CAST(0x0000AC8000CB2320 AS DateTime), N'TD0013', NULL)
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0014', N'KH0003', CAST(0x0000AC8000CB406C AS DateTime), N'TD0007', NULL)
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0015', N'KH0002', CAST(0x0000AC8000CB5200 AS DateTime), N'TD0012', NULL)
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0016', N'KH0001', CAST(0x0000AC8000CB5200 AS DateTime), N'TD0003', N'CD0022')
INSERT [dbo].[tbThongTinDatTruoc] ([MaDatDia], [MaKhachHang], [NgayDatDia], [MaTieuDe], [MaDiaTam]) VALUES (N'DD0017', N'KH0005', CAST(0x0000AC8000CB5200 AS DateTime), N'TD0004', N'CD0021')
INSERT [dbo].[tbTieuDe] ([MaTieuDe], [TenTieuDe], [MoTa], [MaLoai]) VALUES (N'TD0001', N'Đĩa Game PS4 Jump Force Hệ US', N'Game hành động', N'L0002')
INSERT [dbo].[tbTieuDe] ([MaTieuDe], [TenTieuDe], [MoTa], [MaLoai]) VALUES (N'TD0002', N'ĐĨA GAME SONY PS4 DIABLO III: REAPER OF SOULS - ULTIMATE EVIL EDITION', N'Game hành động', N'L0002')
INSERT [dbo].[tbTieuDe] ([MaTieuDe], [TenTieuDe], [MoTa], [MaLoai]) VALUES (N'TD0003', N'Marvel''s Spider-Man: Miles Morales - US', N'Game nhập vai', N'L0002')
INSERT [dbo].[tbTieuDe] ([MaTieuDe], [TenTieuDe], [MoTa], [MaLoai]) VALUES (N'TD0004', N'Need For Speed: Hot Pursuit Remastered - US', N'Game tốc độ', N'L0002')
INSERT [dbo].[tbTieuDe] ([MaTieuDe], [TenTieuDe], [MoTa], [MaLoai]) VALUES (N'TD0005', N'Remothered: Broken Porcelain - US', N'Game nhập vai', N'L0002')
INSERT [dbo].[tbTieuDe] ([MaTieuDe], [TenTieuDe], [MoTa], [MaLoai]) VALUES (N'TD0006', N'Cỗ Máy Thời Gian (DVD)', N'Phim viễn tưởng, phim lẻ', N'L0001')
INSERT [dbo].[tbTieuDe] ([MaTieuDe], [TenTieuDe], [MoTa], [MaLoai]) VALUES (N'TD0007', N'Your name', N'Phim hoạt hình, viễn tưởng, phim lẻ', N'L0001')
INSERT [dbo].[tbTieuDe] ([MaTieuDe], [TenTieuDe], [MoTa], [MaLoai]) VALUES (N'TD0008', N'Kẻ Thế Mạng - Surrogates (DVD)', N'Phim hành động, phim lẻ', N'L0001')
INSERT [dbo].[tbTieuDe] ([MaTieuDe], [TenTieuDe], [MoTa], [MaLoai]) VALUES (N'TD0009', N'PHIM VIỆT NAM: TIẾNG GỌI PHÍA TRƯỚC', N'Phim chiến tranh, phim lẻ', N'L0001')
INSERT [dbo].[tbTieuDe] ([MaTieuDe], [TenTieuDe], [MoTa], [MaLoai]) VALUES (N'TD0010', N'Những Ông Bố - Old Dogs (DVD)', N'Phim đời sống, phim lẻ', N'L0001')
INSERT [dbo].[tbTieuDe] ([MaTieuDe], [TenTieuDe], [MoTa], [MaLoai]) VALUES (N'TD0011', N'LỘC ĐỈNH KÝ Tập 1 (2020)', N'Phim hài hước, cổ trang, phim bộ', N'L0001')
INSERT [dbo].[tbTieuDe] ([MaTieuDe], [TenTieuDe], [MoTa], [MaLoai]) VALUES (N'TD0012', N'LỘC ĐỈNH KÝ Tập 2 (2020)', N'Phim hài hước, cổ trang, phim bộ', N'L0001')
INSERT [dbo].[tbTieuDe] ([MaTieuDe], [TenTieuDe], [MoTa], [MaLoai]) VALUES (N'TD0013', N'LỘC ĐỈNH KÝ Tập 3 (2020)', N'Phim hài hước, cổ trang, phim bộ', N'L0001')
ALTER TABLE [dbo].[tbDiaCD]  WITH CHECK ADD  CONSTRAINT [FK_tbDiaCD_tbTieuDe] FOREIGN KEY([MaTieuDe])
REFERENCES [dbo].[tbTieuDe] ([MaTieuDe])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbDiaCD] CHECK CONSTRAINT [FK_tbDiaCD_tbTieuDe]
GO
ALTER TABLE [dbo].[tbLapPhieuThue]  WITH CHECK ADD  CONSTRAINT [FK_tbLapPhieuThue_tbDiaCD] FOREIGN KEY([MaDiaCD])
REFERENCES [dbo].[tbDiaCD] ([MaDiaCD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbLapPhieuThue] CHECK CONSTRAINT [FK_tbLapPhieuThue_tbDiaCD]
GO
ALTER TABLE [dbo].[tbLapPhieuThue]  WITH CHECK ADD  CONSTRAINT [FK_tbLapPhieuThue_tbKhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[tbKhachHang] ([MaKhachHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbLapPhieuThue] CHECK CONSTRAINT [FK_tbLapPhieuThue_tbKhachHang]
GO
ALTER TABLE [dbo].[tbThongTinDatTruoc]  WITH CHECK ADD  CONSTRAINT [FK_tbThongTinDatTruoc_tbKhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[tbKhachHang] ([MaKhachHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbThongTinDatTruoc] CHECK CONSTRAINT [FK_tbThongTinDatTruoc_tbKhachHang]
GO
ALTER TABLE [dbo].[tbThongTinDatTruoc]  WITH CHECK ADD  CONSTRAINT [FK_tbThongTinDatTruoc_tbTieuDe] FOREIGN KEY([MaTieuDe])
REFERENCES [dbo].[tbTieuDe] ([MaTieuDe])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbThongTinDatTruoc] CHECK CONSTRAINT [FK_tbThongTinDatTruoc_tbTieuDe]
GO
ALTER TABLE [dbo].[tbTieuDe]  WITH CHECK ADD  CONSTRAINT [FK_tbTieuDe_tbLoaiDia] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[tbLoaiDia] ([MaLoai])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbTieuDe] CHECK CONSTRAINT [FK_tbTieuDe_tbLoaiDia]
GO
