-- SQL Script to setup HanapKapeDB with new Shops and CoffeeItems schema
-- 1. Create the Database
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'HanapKapeDB')
BEGIN
    CREATE DATABASE HanapKapeDB;
END
GO

USE HanapKapeDB;
GO

-- 2. Drop existing tables to reset schema
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CoffeeItems]') AND type in (N'U'))
BEGIN
    DROP TABLE CoffeeItems;
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Shops]') AND type in (N'U'))
BEGIN
    DROP TABLE Shops;
END
GO

-- 3. Create Shops Table
CREATE TABLE Shops (
    ShopID INT PRIMARY KEY IDENTITY(1,1),
    OwnerID INT NOT NULL, -- Reference to the owner's account
    ShopName NVARCHAR(150) NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    MapLink NVARCHAR(500) NOT NULL,
    OperatingHoursJSON NVARCHAR(MAX) NOT NULL, -- Stores Mon-Sun hours
    DateCreated DATETIME DEFAULT GETDATE()
);
GO

-- 4. Create CoffeeItems Table
CREATE TABLE CoffeeItems (
    CoffeeID INT PRIMARY KEY IDENTITY(1,1),
    ShopID INT NOT NULL,
    CoffeeName NVARCHAR(150) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Size NVARCHAR(50) NULL,
    Category NVARCHAR(50) NULL,
    DateAdded DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ShopID) REFERENCES Shops(ShopID) ON DELETE CASCADE
);
GO

-- 5. Sample Data
INSERT INTO Shops (OwnerID, ShopName, Address, MapLink, OperatingHoursJSON)
VALUES (1, 'Central Cafe', 'Manila, PH', 'https://maps.app.goo.gl/Fv8Yt1wFf4V8aCvz8', '{"Mon":"08:00-22:00", "Tue":"08:00-22:00", "Wed":"08:00-22:00", "Thu":"08:00-22:00", "Fri":"08:00-22:00", "Sat":"09:00-20:00", "Sun":"09:00-20:00"}');

DECLARE @SID INT = SCOPE_IDENTITY();

INSERT INTO CoffeeItems (ShopID, CoffeeName, Price, Size, Category)
VALUES (@SID, 'Espresso', 120.00, 'Single', 'Hot');
GO
