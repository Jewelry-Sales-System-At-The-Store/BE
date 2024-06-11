DROP DATABASE JSSATS
CREATE TABLE [User] (
  [UserId] int PRIMARY KEY,
  [RoleId] int,
  [CounterId] int,
  [Username] nvarchar(255),
  [Email] nvarchar(255),
  [Password] nvarchar(255)
)


CREATE TABLE [Role] (
  [RoleId] int PRIMARY KEY,
  [RoleName] nvarchar(255)
)


CREATE TABLE [Bill] (
  [BillId] int PRIMARY KEY,
  [CustomerId] int,
  [UserId] int,
  [TotalAmount] float,
  [SaleDate] datetime
)


CREATE TABLE [Jewelry] (
  [JewelryId] int PRIMARY KEY,
  [JewelryTypeId] int,
  [WarrantyId] int,
  [Name] nvarchar(255),
  [Barcode] nvarchar(255),
  [BasePrice] float,
  [Weight] FLOAT,
  [LaborCost] float,
  [StoneCost] float,
  [IsSold] bit
)


CREATE TABLE [Customer] (
  [CustomerId] int PRIMARY KEY,
  [Name] nvarchar(255),
  [Phone] nvarchar(255),
  [Address] nvarchar(255),
  [Point] int
)


CREATE TABLE [BillJewelry] (
  [BillJewelryId] int PRIMARY KEY,
  [BillId] int,
  [JewelryId] int
)


CREATE TABLE [Counter] (
  [CounterId] int PRIMARY KEY,
  [Number] int
)


CREATE TABLE [Promotion] (
  [PromotionId] int PRIMARY KEY,
  [Type] nvarchar(255),
  [ApproveManager] nvarchar(255),
  [Description] nvarchar(255),
  [DiscountRate] float,
  [StartDate] datetime,
  [EndDate] datetime
)


CREATE TABLE [GoldPrice] (
  [GoldPriceId] int PRIMARY KEY,
  [Date] datetime,
  [PricePerGram] float
)


CREATE TABLE [Purchase] (
  [PurchaseId] int PRIMARY KEY,
  [CustomerId] int,
  [UserId] int,
  [JewelryId] int,
  [PurchaseDate] date,
  [PurchasePrice] float,
  [IsBuyBack] int
)


CREATE TABLE [BillPromotion] (
  [BillPromotionId] int PRIMARY KEY,
  [BillId] int,
  [PromotionId] int
)


CREATE TABLE [JewelryType] (
  [JewelryTypeId] int PRIMARY KEY,
  [Name] nvarchar(255)
)


CREATE TABLE [Warranty] (
  [WarrantyId] int PRIMARY KEY,
  [Description] nvarchar(255),
  [EndDate] date
)


ALTER TABLE [Jewelry] ADD FOREIGN KEY ([WarrantyId]) REFERENCES [Warranty] ([WarrantyId])


ALTER TABLE [Jewelry] ADD FOREIGN KEY ([JewelryTypeId]) REFERENCES [JewelryType] ([JewelryTypeId])


ALTER TABLE [BillPromotion] ADD FOREIGN KEY ([PromotionId]) REFERENCES [Promotion] ([PromotionId])


ALTER TABLE [BillPromotion] ADD FOREIGN KEY ([BillId]) REFERENCES [Bill] ([BillId])


ALTER TABLE [BillJewelry] ADD FOREIGN KEY ([JewelryId]) REFERENCES [Jewelry] ([JewelryId])


ALTER TABLE [BillJewelry] ADD FOREIGN KEY ([BillId]) REFERENCES [Bill] ([BillId])


ALTER TABLE [Purchase] ADD FOREIGN KEY ([JewelryId]) REFERENCES [Jewelry] ([JewelryId])


ALTER TABLE [Purchase] ADD FOREIGN KEY ([UserId]) REFERENCES [User] ([UserId])


ALTER TABLE [Purchase] ADD FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([CustomerId])


ALTER TABLE [User] ADD FOREIGN KEY ([RoleId]) REFERENCES [Role] ([RoleId])


ALTER TABLE [User] ADD FOREIGN KEY ([CounterId]) REFERENCES [Counter] ([CounterId])


ALTER TABLE [Bill] ADD FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([CustomerId])


ALTER TABLE [Bill] ADD FOREIGN KEY ([UserId]) REFERENCES [User] ([UserId])

INSERT INTO "JewelryType" ("JewelryTypeId", "Name") VALUES
	(1, 'Ring'),
	(2, 'Necklace'),
	(3, 'Ring'),
	(4, 'Necklace'),
	(5, 'Bracelet'),
	(6, 'Earrings');
	
INSERT INTO "Warranty" ("WarrantyId", "Description", "EndDate") VALUES
	(1, '1 year warranty', '2025-12-31'),
	(2, '2 year warranty', '2026-12-31'),
	(3, '1 year warranty', '2025-12-31'),
	(4, '2 year warranty', '2026-12-31'),
	(5, '3 year warranty', '2027-12-31'),
	(6, 'Lifetime warranty', '2099-12-31');
	
INSERT INTO "Role" ("RoleId", "RoleName") VALUES
	(1, 'Admin'),
	(2, 'Sales');
	
INSERT INTO "Counter" ("CounterId", "Number") VALUES
	(1, 101),
	(2, 102),
	(3, 3),
	(4, 4);
	
-- Dumping data for table JSSATS.Promotion: -1 rows
/*!40000 ALTER TABLE "Promotion" DISABLE KEYS */;
INSERT INTO "Promotion" ("PromotionId", "Type", "ApproveManager", "Description", "DiscountRate", "StartDate", "EndDate") VALUES
	(1, 'Seasonal', 'Manager1', '20% off for summer sale', 0.2, '2024-06-01 00:00:00.000', '2024-08-31 00:00:00.000'),
	(2, 'Clearance', 'Manager2', '30% off on clearance items', 0.3, '2024-09-01 00:00:00.000', '2024-12-31 00:00:00.000'),
	(3, 'Holiday Sale', 'John Doe', '20% off on all items', 0.2, '2024-12-01 00:00:00.000', '2024-12-31 00:00:00.000'),
	(4, 'Clearance', 'Jane Smith', '30% off on selected items', 0.3, '2024-01-01 00:00:00.000', '2024-01-31 00:00:00.000');
/*!40000 ALTER TABLE "Promotion" ENABLE KEYS */;

INSERT INTO "User" ("UserId", "RoleId", "CounterId", "Username", "Email", "Password") VALUES
	(1, 1, 1, 'admin', 'admin@example.com', 'password123'),
	(2, 2, 2, 'john_doe', 'john@example.com', 'password123'),
	(3, 2, 1, 'jdoe', 'jdoe@example.com', 'password123'),
	(4, 2, 2, 'asmith', 'asmith@example.com', 'password123'),
	(5, 2, 1, 'bwayne', 'bwayne@example.com', 'password123'),
	(6, 2, 2, 'ckent', 'ckent@example.com', 'password123');
	
INSERT INTO "Customer" ("CustomerId", "Name", "Phone", "Address", "Point") VALUES
	(1, 'Alice Smith', '123-456-7890', '123 Elm St', 100),
	(2, 'Bob Johnson', '987-654-3210', '456 Oak St', 200),
	(3, 'Alice Brown', '123-456-7890', '123 Main St', 150),
	(4, 'Bob Smith', '234-567-8901', '456 Oak St', 200),
	(5, 'Charlie Johnson', '345-678-9012', '789 Pine St', 300),
	(6, 'Diana Prince', '456-789-0123', '101 Maple St', 100);
	
INSERT INTO "Bill" ("BillId", "CustomerId", "UserId", "TotalAmount", "SaleDate") VALUES
	(1, 1, 2, 650, '2024-01-01 00:00:00.000'),
	(2, 2, 2, 1300, '2024-01-02 00:00:00.000'),
	(3, 3, 3, 1500, '2024-05-01 00:00:00.000'),
	(4, 4, 4, 1000, '2024-05-02 00:00:00.000'),
	(5, 5, 5, 2000, '2024-05-03 00:00:00.000'),
	(6, 6, 6, 2500, '2024-05-04 00:00:00.000'),
	(7, 3, 3, 600, '2024-05-10 00:00:00.000');

-- Dumping data for table JSSATS.Jewelry: -1 rows
/*!40000 ALTER TABLE "Jewelry" DISABLE KEYS */;
INSERT INTO "Jewelry" ("JewelryId", "JewelryTypeId", "WarrantyId", "Name", "Barcode", "BasePrice", "Weight", "LaborCost", "StoneCost") VALUES
	(1, 1, 1, 'Diamond Ring', '1234567890', 500, 5, 50, 100),
	(2, 2, 2, 'Gold Necklace', '0987654321', 1000, 10, 100, 200),
	(3, 3, 3, 'Gold Ring', 'ABC123', 500, 10, 50, 100),
	(4, 4, 4, 'Silver Necklace', 'DEF456', 300, 20, 30, 50),
	(5, 5, 5, 'Diamond Bracelet', 'GHI789', 1500, 15, 150, 500),
	(6, 6, 6, 'Pearl Earrings', 'JKL012', 800, 5, 80, 200);
/*!40000 ALTER TABLE "Jewelry" ENABLE KEYS */;

-- Dumping data for table JSSATS.BillJewelry: -1 rows
/*!40000 ALTER TABLE "BillJewelry" DISABLE KEYS */;
INSERT INTO "BillJewelry" ("BillJewelryId", "BillId", "JewelryId") VALUES
	(1, 1, 1),
	(2, 2, 2),
	(3, 3, 3),
	(4, 4, 4),
	(5, 5, 5),
	(6, 6, 6),
	(7, 7, 4),
	(8, 7, 5);
/*!40000 ALTER TABLE "BillJewelry" ENABLE KEYS */;

INSERT INTO "BillPromotion" ("BillPromotionId", "BillId", "PromotionId") VALUES
	(1, 1, 1),
	(2, 2, 2),
	(3, 3, 3),
	(4, 4, 4),
	(5, 5, 3),
	(6, 6, 4);
	
-- Dumping data for table JSSATS.Purchase: -1 rows
/*!40000 ALTER TABLE "Purchase" DISABLE KEYS */;
INSERT INTO "Purchase" ("PurchaseId", "CustomerId", "UserId", "JewelryId", "PurchaseDate", "PurchasePrice", "IsBuyBack") VALUES
	(1, 1, 2, 1, '2024-05-01', 550, 0),
	(2, 2, 2, 2, '2024-06-01', 1300, 1),
	(3, 3, 3, 3, '2024-05-01', 1500, 0),
	(4, 4, 4, 4, '2024-05-02', 1000, 0),
	(5, 5, 5, 5, '2024-05-03', 2000, 1),
	(6, 6, 6, 6, '2024-05-04', 2500, 0),
	(7, 3, 3, 4, '2024-05-10', 300, 0),
	(8, 3, 3, 5, '2024-05-10', 300, 0),
	(9, 2, 3, 2, '2024-05-01', 1500, 0),
	(10, 5, 3, 5, '2024-04-01', 4000, 0);
/*!40000 ALTER TABLE "Purchase" ENABLE KEYS */;


-- Dumping data for table JSSATS.GoldPrice: -1 rows
/*!40000 ALTER TABLE "GoldPrice" DISABLE KEYS */;
INSERT INTO "GoldPrice" ("GoldPriceId", "Date", "PricePerGram") VALUES
	(1, '2024-05-01 00:00:00.000', 50),
	(2, '2024-06-01 00:00:00.000', 52),
	(3, '2024-05-03 00:00:00.000', 62),
	(4, '2024-05-04 00:00:00.000', 63);
/*!40000 ALTER TABLE "GoldPrice" ENABLE KEYS */;

