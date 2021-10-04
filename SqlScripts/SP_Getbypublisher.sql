USE [LocalDev]
GO
/****** Object:  StoredProcedure [dbo].[GetByPublisher]    Script Date: 9/27/2021 4:39:36 PM ******/
SET ANSI_NULLS ON
GO

IF EXISTS ( SELECT * 
            FROM   sysobjects 
            WHERE  id = object_id(N'[dbo].[GetByPublisher]') 
                   and OBJECTPROPERTY(id, N'IsProcedure') = 1 )
BEGIN
    DROP PROCEDURE [dbo].[GetByPublisher]
END
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetByPublisher]
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
    Publisher,AuthorLastName,AuthorFirstName,Title

 
END




GO


