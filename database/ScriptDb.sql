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
		 [Gender] [VARCHAR](6) NOT NULL, 
         [Price] DECIMAL(10,2) NOT NULL, 
         [IsActive] [BIT] NOT NULL,
         CONSTRAINT PK_Animal PRIMARY KEY([Id])
        );
    END;

GO

Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Cattle','Aberdeen Angus','2022-06-01','Male',1000,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Cattle','Danish Jersey','2022-07-01','Male',20000,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Cattle','Irish Moiled','2022-08-01','Female',35000,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Cattle','Welsh Black','2022-09-01','Male',46500,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Cattle','Zebu','2022-06-01','Female',65200,0)


Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Goose','Rung','2022-04-01','Male',69000,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Goose','Rhenish','2022-04-10','Male',16520,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Goose','Wugang','2022-05-16','Female',25000,0)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Goose','Poitou','2022-09-15','Male',36000,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Goose','Roman','2023-06-01','Female',52000,1)


Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Chicken','Naine belge','2022-06-01','Male',35200,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Chicken','Dokki 4','2022-07-01','Male',45000,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Chicken','Golden Montazah','2022-08-01','Female',60000,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Chicken','Pekin','2021-07-30','Male',2000,0)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Chicken','Campine','2022-08-29','Female',4500,1)


Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Dog','Cane Paratore','2022-06-01','Male',36200,0)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Dog','Bakharwal','2022-07-01','Male',50000,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Dog','Chow Chow','2022-08-01','Female',100000,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Dog','Bernese Mountain ','2022-09-01','Male',200000,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Dog','Pug','2022-06-01','Female',3500,1)


Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Cat','Balinese','2021-01-12','Male',60000,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Cat','Bengal','2021-07-25','Male',90000,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Cat','Cyprus','2023-01-08','Female',65200,1)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Cat','Persian','2022-07-19','Male',90000,0)
Insert into [dbo].[Animal] (Name,Breed,Birthday,Gender,Price,IsActive) values ('Cat','Savannah','2021-05-18','Female',89000,1)