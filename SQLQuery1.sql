USE [asistan]
GO
/****** Object:  Table [dbo].[Tbl_Konusma]    Script Date: 29/05/2021 23:25:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Konusma](
	[Konusma_ID] [int] IDENTITY(1,1) NOT NULL,
	[Konusma_Kayit] [nvarchar](max) NULL,
	[Konusma_Tarih] [smalldatetime] NULL,
	[Konusma_Baslik] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tbl_Konusma] PRIMARY KEY CLUSTERED 
(
	[Konusma_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Not]    Script Date: 29/05/2021 23:25:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Not](
	[Not_ID] [int] IDENTITY(1,1) NOT NULL,
	[Not_Baslik] [nvarchar](50) NULL,
	[Not_Yazi] [nvarchar](max) NULL,
	[Not_Tarih] [smalldatetime] NULL,
 CONSTRAINT [PK_Not] PRIMARY KEY CLUSTERED 
(
	[Not_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Yazma]    Script Date: 29/05/2021 23:25:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Yazma](
	[Yazma_ID] [int] IDENTITY(1,1) NOT NULL,
	[Yazma_Kayit] [nvarchar](max) NULL,
	[Yazma_Tarih] [smalldatetime] NULL,
	[Yazma_Baslik] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tbl_Yazma] PRIMARY KEY CLUSTERED 
(
	[Yazma_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Not] ON 
GO
INSERT [dbo].[Tbl_Not] ([Not_ID], [Not_Baslik], [Not_Yazi], [Not_Tarih]) VALUES (1, N'Five', N'One arm', CAST(N'2021-05-12T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Tbl_Not] ([Not_ID], [Not_Baslik], [Not_Yazi], [Not_Tarih]) VALUES (2, N'While loading', N'The their own', CAST(N'2021-05-24T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Tbl_Not] ([Not_ID], [Not_Baslik], [Not_Yazi], [Not_Tarih]) VALUES (3, N'While loading', N'The their own', CAST(N'2021-05-24T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Tbl_Not] ([Not_ID], [Not_Baslik], [Not_Yazi], [Not_Tarih]) VALUES (4, N'baslik', N'sdaferfjfhıudfouhdıgoehfhıeofldsıfdlgkjaerhotheıafojkghdfugorsughwpeafjıpghıdfoghaerogthewıpfjksdhgoıadrgjweğP', CAST(N'2021-05-12T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Tbl_Not] ([Not_ID], [Not_Baslik], [Not_Yazi], [Not_Tarih]) VALUES (5, N'One', N'fgdfh', CAST(N'2021-05-12T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Tbl_Not] ([Not_ID], [Not_Baslik], [Not_Yazi], [Not_Tarih]) VALUES (6, N'Hello', N'kyı', CAST(N'2021-05-12T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Tbl_Not] ([Not_ID], [Not_Baslik], [Not_Yazi], [Not_Tarih]) VALUES (7, N'Mr.', N'how', CAST(N'2021-05-12T00:00:00' AS SmallDateTime))
GO
SET IDENTITY_INSERT [dbo].[Tbl_Not] OFF
GO
