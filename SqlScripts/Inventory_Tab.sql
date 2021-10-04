USE [LocalDev]
GO

/****** Object:  Table [dbo].[Inventory]    Script Date: 9/27/2021 4:35:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Inventory](
	[Publisher] [varchar](max) NOT NULL,
	[Title] [varchar](max) NOT NULL,
	[AuthorLastName] [varchar](max) NOT NULL,
	[AuthorFirstName] [varchar](max) NOT NULL,
	[Price] [numeric](10, 2) NOT NULL,
    [titlofcontainer] [varchar](max) NOT NULL,
    [publicationDate] DateTime NOT NULL,
    [location] [varchar](max) NOT NULL

) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
  
