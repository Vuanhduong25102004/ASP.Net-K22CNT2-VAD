USE [VadK22CNT2Lesson09Db]
GO
/****** Object:  Table [dbo].[vadKhoa]    Script Date: 6/17/2024 3:53:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vadKhoa](
	[VadMaKH] [nchar](10) NOT NULL,
	[VadTenKH] [nchar](50) NULL,
	[VadTrangThai] [bit] NULL,
 CONSTRAINT [PK_vadKhoa] PRIMARY KEY CLUSTERED 
(
	[VadMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vadSinhVien]    Script Date: 6/17/2024 3:53:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vadSinhVien](
	[VadMaSV] [nchar](50) NOT NULL,
	[VadHoSV] [nchar](50) NULL,
	[VadTenSV] [nchar](50) NULL,
	[VadNgaySinh] [date] NULL,
	[VadPhai] [bit] NULL,
	[VadPhone] [nchar](10) NULL,
	[VadEmail] [nvarchar](50) NULL,
	[VadMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_vadSinhVien] PRIMARY KEY CLUSTERED 
(
	[VadMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[vadKhoa] ([VadMaKH], [VadTenKH], [VadTrangThai]) VALUES (N'K22CNT2   ', N'K22CNT2                                           ', 1)
GO
INSERT [dbo].[vadSinhVien] ([VadMaSV], [VadHoSV], [VadTenSV], [VadNgaySinh], [VadPhai], [VadPhone], [VadEmail], [VadMaKH]) VALUES (N'2210900017                                        ', N'Vũ Anh                                            ', N'Dương                                             ', CAST(N'2004-10-25' AS Date), 1, N'0972471680', N'vuanhduong251020042@gmail.com', N'K22CNT2   ')
GO
