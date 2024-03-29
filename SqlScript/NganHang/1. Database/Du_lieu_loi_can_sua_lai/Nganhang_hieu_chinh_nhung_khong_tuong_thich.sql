USE [NGANHANG]
GO

/* 
Make compatible with new database 
ALTER TABLE [dbo].[TaiKhoan]
ADD  	[NGAYMOTK] [datetime] NOT NULL;


*/


/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 09/13/2018 16:21:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TABLE [dbo].[ChiNhanh](
	[MACN] [nchar](10) NOT NULL,
	[TENCN] [nvarchar](100) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[SoDT] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[MACN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UK_ChiNhanh] UNIQUE NONCLUSTERED 
(
	[TENCN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiNhanh] ([MACN], [TENCN], [DIACHI], [SoDT]) VALUES (N'BENTHANH  ', N'Chi nhánh Bến Thành', N'211 Lê Lợi, Quận 1, TPHCM', N'..')
INSERT [dbo].[ChiNhanh] ([MACN], [TENCN], [DIACHI], [SoDT]) VALUES (N'TANDINH   ', N'Chi nhánh Tân Định', N'234 Hai Bà Trưng, phường Đakao, Quận 1, TPHCM', N'...')
/****** Object:  Table [dbo].[NhanVien]    Script Date: 09/13/2018 16:21:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MANV] [nchar](10) NOT NULL,
	[HO] [nvarchar](40) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[PHAI] [nvarchar](3) NULL,
	[SODT] [nvarchar](15) NOT NULL,
	[MACN] [nchar](10) NULL,
	[TrangThaiXoa] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 09/13/2018 16:21:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[CMND] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[PHAI] [nvarchar](3) NULL,
	[NGAYCAP] [date] NOT NULL,
	[SODT] [nvarchar](15) NOT NULL,
	[MACN] [nchar](10) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GD_CHUYENTIEN]    Script Date: 09/13/2018 16:21:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GD_CHUYENTIEN](
	[MAGD] [int] IDENTITY(1,1) NOT NULL,
	[SOTK_CHUYEN] [nchar](9) NOT NULL,
	[NGAYGD] [datetime] NOT NULL,
	[SOTIEN] [money] NOT NULL,
	[SOTK_NHAN] [nchar](9) NOT NULL,
	[MANV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_GD_CHUYENTIEN] PRIMARY KEY CLUSTERED 
(
	[MAGD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 09/13/2018 16:21:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TaiKhoan](
	[SOTK] [nchar](9) NOT NULL,
	[CMND] [nchar](10) NOT NULL,
	[SODU] [money] NULL,
	[MACN] [nchar](10) NULL,
	[NGAYMOTK] [datetime] NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[SOTK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GD_GOIRUT]    Script Date: 09/13/2018 16:21:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GD_GOIRUT](
	[MAGD] [int] IDENTITY(1,1) NOT NULL,
	[SOTK] [nchar](9) NOT NULL,
	[LOAIGD] [nchar](2) NOT NULL,
	[NGAYGD] [datetime] NOT NULL,
	[SOTIEN] [money] NOT NULL,
	[MANV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_GD_GOIRUT] PRIMARY KEY CLUSTERED 
(
	[MAGD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

---------------------------------< Contraint >------------------------------------

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'‘GT’ : gởi tiền vào TK , ‘RT’ : rút tiền khỏi TK' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'GD_GOIRUT', @level2type=N'COLUMN',@level2name=N'LOAIGD'
GO
/****** Object:  Default [DF_GD_CHUYENTIEN_NGAYGD]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[GD_CHUYENTIEN] ADD  CONSTRAINT [DF_GD_CHUYENTIEN_NGAYGD]  DEFAULT (getdate()) FOR [NGAYGD]
GO
/****** Object:  Default [DF__TaiKhoan__SODU__09DE7BCC]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ((0)) FOR [SODU]
GO
/****** Object:  Default [DF_GD_GOIRUT_NGAYGD]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[GD_GOIRUT] ADD  CONSTRAINT [DF_GD_GOIRUT_NGAYGD]  DEFAULT (getdate()) FOR [NGAYGD]
GO
/****** Object:  Default [DF_GD_GOIRUT_SOTIEN]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[GD_GOIRUT] ADD  CONSTRAINT [DF_GD_GOIRUT_SOTIEN]  DEFAULT ((100000)) FOR [SOTIEN]
GO
/****** Object:  Check [CK_GD_CHUYENTIEN]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [CK_GD_CHUYENTIEN] CHECK  (([SOTIEN]>(0)))
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [CK_GD_CHUYENTIEN]
GO
/****** Object:  Check [CK_LOAIGD]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [CK_LOAIGD] CHECK  (([LOAIGD]='RT' OR [LOAIGD]='GT'))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [CK_LOAIGD]
GO
/****** Object:  Check [CK_SOTIEN]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [CK_SOTIEN] CHECK  (([SOTIEN]>=(100000)))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [CK_SOTIEN]
GO
/****** Object:  ForeignKey [FK_NhanVien_ChiNhanh]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
/****** Object:  ForeignKey [FK_KhachHang_ChiNhanh]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_ChiNhanh]
GO
/****** Object:  ForeignKey [FK_GD_CHUYENTIEN_NhanVien]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [FK_GD_CHUYENTIEN_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [FK_GD_CHUYENTIEN_NhanVien]
GO
/****** Object:  ForeignKey [FK_TaiKhoan_ChiNhanh]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_ChiNhanh]
GO
/****** Object:  ForeignKey [FK_TaiKhoan_KhachHang]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_KhachHang] FOREIGN KEY([CMND])
REFERENCES [dbo].[KhachHang] ([CMND])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_KhachHang]
GO
/****** Object:  ForeignKey [FK_GD_GOIRUT_NhanVien]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [FK_GD_GOIRUT_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [FK_GD_GOIRUT_NhanVien]
GO
/****** Object:  ForeignKey [FK_GD_GOIRUT_TaiKhoan]    Script Date: 09/13/2018 16:21:02 ******/
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [FK_GD_GOIRUT_TaiKhoan] FOREIGN KEY([SOTK])
REFERENCES [dbo].[TaiKhoan] ([SOTK])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [FK_GD_GOIRUT_TaiKhoan]
GO
