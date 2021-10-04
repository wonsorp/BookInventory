USE [LocalDev]
GO

IF EXISTS ( SELECT * 
            FROM   sysobjects 
            WHERE  id = object_id(N'[dbo].[GetByAuthor]') 
                   and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
    DROP PROCEDURE [dbo].[GetByAuthor]
END
GO

/****** Object:  StoredProcedure [dbo].[GetByAuthor]    Script Date: 9/27/2021 4:36:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetByAuthor]
AS
BEGIN
SET NOCOUNT ON
 
SELECT Publisher
      ,Title
      ,AuthorLastName
      ,AuthorFirstName
      ,Price
      ,titlofcontainer
      ,publicationDate
      ,location
  FROM dbo.Inventory
  order by 
    AuthorLastName,AuthorFirstName,Title

 
END




GO


