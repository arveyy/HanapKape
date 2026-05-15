USE HanapKapeDB;

DROP TABLE IF EXISTS Shops;

     CREATE TABLE Shops (
         ShopID INT PRIMARY KEY IDENTITY(1,1),
         OwnerID INT NOT NULL,
         ShopName NVARCHAR(150) NOT NULL,
         Address NVARCHAR(255) NOT NULL,
         MapLink NVARCHAR(500) NOT NULL,
         OperatingHoursJSON NVARCHAR(MAX) NOT NULL,
        DateCreated DATETIME DEFAULT GETDATE()
    );
   
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