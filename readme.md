## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)

## General info
This project is an Assesment for Cascade Fintech.Thre are 5 endpoints
that can be acessed:

The following will retreive data from an internal
function that set's up test data 
api/WebApi/GetByPublisher
api/WebApi/GetByAuthor
api/WebApi/GetInventorytotal

The following will retreive data dfrom the databse, so sql must be set up 
api/WebApi/GetByPublisherFromDB
api/WebApi/GetByAuthorFromDB

	
## Technologies
Project is created with:
* Visula Studio 2019
* .net framework 4.7
* C# (using some of the C# 8 Notations)
* Sql Server 2019 (Dev Addition)

	
## Setup
this project is A MVC api endpoint, the easiest way to run it is to 
use iis express in VS 2019 and run in debug mode

```
To set up, you will need to install Sqlserver. Durring set up of SQl, make sure that 
you also choose named pipes and tcp as communication protocols

Once Sql is set up, you will need to create a database called LocalDev. Once the database is
created, you will need to run the following scripts in this order against the database:

Inventory_Tab.sql - Creates the Inventory Table for test data
SP_GetByAuth.sql - used to retreive data for the GetByAuthorFromDB endpoint
SP_Getbypublisher.sql - used to retreive data by the GetByPublisherFromDB endpoint
Test_Data_Insert.sql - This will insert the test data for use in the enpoints that contain DB

Once this is done, you will have to adjust the sql server name in the connection strings in the 
home controller. Change the server name

```