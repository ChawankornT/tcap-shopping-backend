USE [db_TCAP]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 8/16/2025 6:25:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [nvarchar](10) NULL,
	[ProductName] [nvarchar](50) NULL,
	[PricePerUnit] [decimal](10, 2) NOT NULL,
	[Quantity] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Stock] ON 
GO
INSERT [dbo].[Stock] ([Id], [ProductCode], [ProductName], [PricePerUnit], [Quantity]) VALUES (1, N'TCAP001   ', N'Product A', CAST(100.00 AS Decimal(10, 2)), 4)
GO
INSERT [dbo].[Stock] ([Id], [ProductCode], [ProductName], [PricePerUnit], [Quantity]) VALUES (2, N'TCAP002   ', N'Product B', CAST(500.00 AS Decimal(10, 2)), 9)
GO
INSERT [dbo].[Stock] ([Id], [ProductCode], [ProductName], [PricePerUnit], [Quantity]) VALUES (3, N'TCAP003   ', N'Product C', CAST(1000.00 AS Decimal(10, 2)), 0)
GO
SET IDENTITY_INSERT [dbo].[Stock] OFF
GO
