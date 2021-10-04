USE [LocalDev]
GO

INSERT INTO [dbo].[Inventory]
                     ([Publisher]
           ,[Title]
           ,[AuthorLastName]
           ,[AuthorFirstName]
           ,[Price]
           ,[titlofcontainer]
           ,[publicationDate]
           ,[location])
     VALUES
           ('Portfolio'
           ,'Start with Why: How Great Leaders Inspire Everyone to Take Action'
           ,'Simon'
           ,'Sinek'
           ,16.19
           ,'Stop, Look and Listen'
           ,01/01/1998
           ,'PP 120-122')
GO


INSERT INTO [dbo].[Inventory]
           ([Publisher]
           ,[Title]
           ,[AuthorLastName]
           ,[AuthorFirstName]
           ,[Price]
           ,[titlofcontainer]
           ,[publicationDate]
           ,[location])
     VALUES
           ('Microsoft Press'
           ,'Code Complete: A Practical Handbook of Software Construction'
           ,'Steve'
           ,'McConnell'
           ,28.43
           ,'Objects are Like Buckets'
           ,01/01/1995
           ,'PP 20-42')
GO

INSERT INTO [dbo].[Inventory]
           ([Publisher]
           ,[Title]
           ,[AuthorLastName]
           ,[AuthorFirstName]
           ,[Price]
           ,[titlofcontainer]
           ,[publicationDate]
           ,[location])
     VALUES
           ('Addison-Wesley Professional'
           ,'The Pragmatic Programmer'
           ,'Martin'
           ,'Fowler'
           ,32.00
           ,'What are variables?'
           ,01/01/1980
           ,'PP 5-21')
GO

INSERT INTO [dbo].[Inventory]
           ([Publisher]
           ,[Title]
           ,[AuthorLastName]
           ,[AuthorFirstName]
           ,[Price]
           ,[titlofcontainer]
           ,[publicationDate]
           ,[location])
     VALUES
           ('Packt Publishing'
           ,'Git for Programmers: Master Git for effective implementation of version control for your programming projects'
           ,'Jesse'
           ,'Liberty'
           ,49.99
           ,'Git out of here'
           ,01/01/2002
           ,'PP 155-157')
GO

INSERT INTO [dbo].[Inventory]
           ([Publisher]
           ,[Title]
           ,[AuthorLastName]
           ,[AuthorFirstName]
           ,[Price]
           ,[titlofcontainer]
           ,[publicationDate]
           ,[location])
     VALUES
           ('Morgan Kaufmann'
           ,'The Art of Multiprocessor Programming'
           ,'Maurice'
           ,'Herlihy'
           ,56.21
           ,'Threads o Plenty'
           ,01/01/2009
           ,'PP 85-92')
GO
