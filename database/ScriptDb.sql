USE master;
GO
IF NOT EXISTS
(
    SELECT name
    FROM master.sys.databases
    WHERE name = N'Farm'
)
    BEGIN
        CREATE DATABASE Farm;
    END;
GO
USE Farm;
GO
IF NOT EXISTS
(
    SELECT 1
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_SCHEMA = 'dbo'
          AND TABLE_NAME = 'Animal'
)
    BEGIN	
        CREATE TABLE [dbo].[Animal]
        ([Id]     INT IDENTITY(1, 1), 
         [Name] [VARCHAR](64) NOT NULL, 
		 [Breed] [VARCHAR](64) NOT NULL, 
		 [Birthday] [DATE] NOT NULL,
		 [Sex] [VARCHAR](4) NOT NULL, 
         [IsActive] [BIT] NOT NULL,
         CONSTRAINT PK_Animal PRIMARY KEY([Id])
        );
    END;

Go

Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Cattle','Aberdeen Angus','2022-06-01','Male',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Cattle','Danish Jersey','2022-07-01','Male',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Cattle','Irish Moiled','2022-08-01','Female',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Cattle','Welsh Black','2022-09-01','Male',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Cattle','Zebu','2022-06-01','Female',0)


Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Goose','Rung','2022-04-01','Male',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Goose','Rhenish','2022-04-10','Male',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Goose','Wugang','2022-05-16','Female',0)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Goose','Poitou','2022-09-15','Male',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Goose','Roman','2023-06-01','Female',1)


Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Chicken','Naine belge','2022-06-01','Male',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Chicken','Dokki 4','2022-07-01','Male',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Chicken','Golden Montazah','2022-08-01','Female',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Chicken','Pekin','2021-07-30','Male',0)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Chicken','Campine','2022-08-29','Female',1)


Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Dog','Cane Paratore','2022-06-01','Male',0)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Dog','Bakharwal','2022-07-01','Male',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Dog','Chow Chow','2022-08-01','Female',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Dog','Bernese Mountain ','2022-09-01','Male',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Dog','Pug','2022-06-01','Female',1)


Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Cat','Balinese','2021-01-12','Male',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Cat','Bengal','2021-07-25','Male',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Cat','Cyprus','2023-01-08','Female',1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Cat','Persian','2022-07-19','Male',0)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Sex,IsActive) values ('Cat','Savannah','2021-05-18','Female',1)