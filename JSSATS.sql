-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               Microsoft SQL Server 2022 (RTM-CU13) (KB5036432) - 16.0.4125.3
-- Server OS:                    Linux (Ubuntu 22.04.4 LTS) <X64>
-- HeidiSQL Version:             12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES  */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Dumping structure for table JSSATS.Bill
CREATE TABLE IF NOT EXISTS "Bill" (
	"BillId" INT NOT NULL,
	"CustomerId" INT NULL DEFAULT NULL,
	"UserId" INT NULL DEFAULT NULL,
	"TotalAmount" FLOAT NULL DEFAULT NULL,
	"SaleDate" DATETIME NULL DEFAULT NULL,
	FOREIGN KEY INDEX "FK__Bill__CustomerId__59063A47" ("CustomerId"),
	FOREIGN KEY INDEX "FK__Bill__CustomerId__73BA3083" ("CustomerId"),
	FOREIGN KEY INDEX "FK__Bill__UserId__59FA5E80" ("UserId"),
	FOREIGN KEY INDEX "FK__Bill__UserId__74AE54BC" ("UserId"),
	PRIMARY KEY ("BillId"),
	CONSTRAINT "FK__Bill__UserId__59FA5E80" FOREIGN KEY ("UserId") REFERENCES "User" ("UserId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Bill__UserId__74AE54BC" FOREIGN KEY ("UserId") REFERENCES "User" ("UserId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Bill__CustomerId__59063A47" FOREIGN KEY ("CustomerId") REFERENCES "Customer" ("CustomerId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Bill__CustomerId__73BA3083" FOREIGN KEY ("CustomerId") REFERENCES "Customer" ("CustomerId") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- Dumping data for table JSSATS.Bill: -1 rows
/*!40000 ALTER TABLE "Bill" DISABLE KEYS */;
INSERT INTO "Bill" ("BillId", "CustomerId", "UserId", "TotalAmount", "SaleDate") VALUES
	(1, 1, 2, 650, '2024-01-01 00:00:00.000'),
	(2, 2, 2, 1300, '2024-01-02 00:00:00.000'),
	(3, 3, 3, 1500, '2024-05-01 00:00:00.000'),
	(4, 4, 4, 1000, '2024-05-02 00:00:00.000'),
	(5, 5, 5, 2000, '2024-05-03 00:00:00.000'),
	(6, 6, 6, 2500, '2024-05-04 00:00:00.000'),
	(7, 3, 3, 600, '2024-05-10 00:00:00.000');
/*!40000 ALTER TABLE "Bill" ENABLE KEYS */;

-- Dumping structure for table JSSATS.BillJewelry
CREATE TABLE IF NOT EXISTS "BillJewelry" (
	"BillJewelryId" INT NOT NULL,
	"BillId" INT NULL DEFAULT NULL,
	"JewelryId" INT NULL DEFAULT NULL,
	FOREIGN KEY INDEX "FK__BillJewel__BillI__534D60F1" ("BillId"),
	FOREIGN KEY INDEX "FK__BillJewel__BillI__6E01572D" ("BillId"),
	FOREIGN KEY INDEX "FK__BillJewel__Jewel__52593CB8" ("JewelryId"),
	FOREIGN KEY INDEX "FK__BillJewel__Jewel__6D0D32F4" ("JewelryId"),
	PRIMARY KEY ("BillJewelryId"),
	CONSTRAINT "FK__BillJewel__BillI__534D60F1" FOREIGN KEY ("BillId") REFERENCES "Bill" ("BillId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__BillJewel__BillI__6E01572D" FOREIGN KEY ("BillId") REFERENCES "Bill" ("BillId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__BillJewel__Jewel__52593CB8" FOREIGN KEY ("JewelryId") REFERENCES "Jewelry" ("JewelryId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__BillJewel__Jewel__6D0D32F4" FOREIGN KEY ("JewelryId") REFERENCES "Jewelry" ("JewelryId") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

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

-- Dumping structure for table JSSATS.BillPromotion
CREATE TABLE IF NOT EXISTS "BillPromotion" (
	"BillPromotionId" INT NOT NULL,
	"BillId" INT NULL DEFAULT NULL,
	"PromotionId" INT NULL DEFAULT NULL,
	FOREIGN KEY INDEX "FK__BillPromo__BillI__5165187F" ("BillId"),
	FOREIGN KEY INDEX "FK__BillPromo__BillI__6C190EBB" ("BillId"),
	FOREIGN KEY INDEX "FK__BillPromo__Promo__5070F446" ("PromotionId"),
	FOREIGN KEY INDEX "FK__BillPromo__Promo__6B24EA82" ("PromotionId"),
	PRIMARY KEY ("BillPromotionId"),
	CONSTRAINT "FK__BillPromo__BillI__5165187F" FOREIGN KEY ("BillId") REFERENCES "Bill" ("BillId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__BillPromo__BillI__6C190EBB" FOREIGN KEY ("BillId") REFERENCES "Bill" ("BillId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__BillPromo__Promo__5070F446" FOREIGN KEY ("PromotionId") REFERENCES "Promotion" ("PromotionId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__BillPromo__Promo__6B24EA82" FOREIGN KEY ("PromotionId") REFERENCES "Promotion" ("PromotionId") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- Dumping data for table JSSATS.BillPromotion: -1 rows
/*!40000 ALTER TABLE "BillPromotion" DISABLE KEYS */;
INSERT INTO "BillPromotion" ("BillPromotionId", "BillId", "PromotionId") VALUES
	(1, 1, 1),
	(2, 2, 2),
	(3, 3, 3),
	(4, 4, 4),
	(5, 5, 3),
	(6, 6, 4);
/*!40000 ALTER TABLE "BillPromotion" ENABLE KEYS */;

-- Dumping structure for table JSSATS.Counter
CREATE TABLE IF NOT EXISTS "Counter" (
	"CounterId" INT NOT NULL,
	"Number" INT NULL DEFAULT NULL,
	PRIMARY KEY ("CounterId")
);

-- Dumping data for table JSSATS.Counter: -1 rows
/*!40000 ALTER TABLE "Counter" DISABLE KEYS */;
INSERT INTO "Counter" ("CounterId", "Number") VALUES
	(1, 101),
	(2, 102),
	(3, 3),
	(4, 4);
/*!40000 ALTER TABLE "Counter" ENABLE KEYS */;

-- Dumping structure for table JSSATS.Customer
CREATE TABLE IF NOT EXISTS "Customer" (
	"CustomerId" INT NOT NULL,
	"Name" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	"Phone" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	"Address" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	"Point" INT NULL DEFAULT NULL,
	PRIMARY KEY ("CustomerId")
);

-- Dumping data for table JSSATS.Customer: -1 rows
/*!40000 ALTER TABLE "Customer" DISABLE KEYS */;
INSERT INTO "Customer" ("CustomerId", "Name", "Phone", "Address", "Point") VALUES
	(1, 'Alice Smith', '123-456-7890', '123 Elm St', 100),
	(2, 'Bob Johnson', '987-654-3210', '456 Oak St', 200),
	(3, 'Alice Brown', '123-456-7890', '123 Main St', 150),
	(4, 'Bob Smith', '234-567-8901', '456 Oak St', 200),
	(5, 'Charlie Johnson', '345-678-9012', '789 Pine St', 300),
	(6, 'Diana Prince', '456-789-0123', '101 Maple St', 100);
/*!40000 ALTER TABLE "Customer" ENABLE KEYS */;

-- Dumping structure for table JSSATS.GoldPrice
CREATE TABLE IF NOT EXISTS "GoldPrice" (
	"GoldPriceId" INT NOT NULL,
	"Date" DATETIME NULL DEFAULT NULL,
	"PricePerGram" FLOAT NULL DEFAULT NULL,
	PRIMARY KEY ("GoldPriceId")
);

-- Dumping data for table JSSATS.GoldPrice: -1 rows
/*!40000 ALTER TABLE "GoldPrice" DISABLE KEYS */;
INSERT INTO "GoldPrice" ("GoldPriceId", "Date", "PricePerGram") VALUES
	(1, '2024-05-01 00:00:00.000', 50),
	(2, '2024-06-01 00:00:00.000', 52),
	(3, '2024-05-03 00:00:00.000', 62),
	(4, '2024-05-04 00:00:00.000', 63);
/*!40000 ALTER TABLE "GoldPrice" ENABLE KEYS */;

-- Dumping structure for table JSSATS.Jewelry
CREATE TABLE IF NOT EXISTS "Jewelry" (
	"JewelryId" INT NOT NULL,
	"JewelryTypeId" INT NULL DEFAULT NULL,
	"WarrantyId" INT NULL DEFAULT NULL,
	"Name" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	"Barcode" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	"BasePrice" FLOAT NULL DEFAULT NULL,
	"Weight" FLOAT NULL DEFAULT NULL,
	"LaborCost" FLOAT NULL DEFAULT NULL,
	"StoneCost" FLOAT NULL DEFAULT NULL,
	FOREIGN KEY INDEX "FK__Jewelry__Jewelry__4F7CD00D" ("JewelryTypeId"),
	FOREIGN KEY INDEX "FK__Jewelry__Jewelry__6A30C649" ("JewelryTypeId"),
	FOREIGN KEY INDEX "FK__Jewelry__Warrant__4E88ABD4" ("WarrantyId"),
	FOREIGN KEY INDEX "FK__Jewelry__Warrant__693CA210" ("WarrantyId"),
	PRIMARY KEY ("JewelryId"),
	CONSTRAINT "FK__Jewelry__Jewelry__4F7CD00D" FOREIGN KEY ("JewelryTypeId") REFERENCES "JewelryType" ("JewelryTypeId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Jewelry__Jewelry__6A30C649" FOREIGN KEY ("JewelryTypeId") REFERENCES "JewelryType" ("JewelryTypeId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Jewelry__Warrant__4E88ABD4" FOREIGN KEY ("WarrantyId") REFERENCES "Warranty" ("WarrantyId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Jewelry__Warrant__693CA210" FOREIGN KEY ("WarrantyId") REFERENCES "Warranty" ("WarrantyId") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

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

-- Dumping structure for table JSSATS.JewelryType
CREATE TABLE IF NOT EXISTS "JewelryType" (
	"JewelryTypeId" INT NOT NULL,
	"Name" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	PRIMARY KEY ("JewelryTypeId")
);

-- Dumping data for table JSSATS.JewelryType: -1 rows
/*!40000 ALTER TABLE "JewelryType" DISABLE KEYS */;
INSERT INTO "JewelryType" ("JewelryTypeId", "Name") VALUES
	(1, 'Ring'),
	(2, 'Necklace'),
	(3, 'Ring'),
	(4, 'Necklace'),
	(5, 'Bracelet'),
	(6, 'Earrings');
/*!40000 ALTER TABLE "JewelryType" ENABLE KEYS */;

-- Dumping structure for table JSSATS.Promotion
CREATE TABLE IF NOT EXISTS "Promotion" (
	"PromotionId" INT NOT NULL,
	"Type" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	"ApproveManager" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	"Description" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	"DiscountRate" FLOAT NULL DEFAULT NULL,
	"StartDate" DATETIME NULL DEFAULT NULL,
	"EndDate" DATETIME NULL DEFAULT NULL,
	PRIMARY KEY ("PromotionId")
);

-- Dumping data for table JSSATS.Promotion: -1 rows
/*!40000 ALTER TABLE "Promotion" DISABLE KEYS */;
INSERT INTO "Promotion" ("PromotionId", "Type", "ApproveManager", "Description", "DiscountRate", "StartDate", "EndDate") VALUES
	(1, 'Seasonal', 'Manager1', '20% off for summer sale', 0.2, '2024-06-01 00:00:00.000', '2024-08-31 00:00:00.000'),
	(2, 'Clearance', 'Manager2', '30% off on clearance items', 0.3, '2024-09-01 00:00:00.000', '2024-12-31 00:00:00.000'),
	(3, 'Holiday Sale', 'John Doe', '20% off on all items', 0.2, '2024-12-01 00:00:00.000', '2024-12-31 00:00:00.000'),
	(4, 'Clearance', 'Jane Smith', '30% off on selected items', 0.3, '2024-01-01 00:00:00.000', '2024-01-31 00:00:00.000');
/*!40000 ALTER TABLE "Promotion" ENABLE KEYS */;

-- Dumping structure for table JSSATS.Purchase
CREATE TABLE IF NOT EXISTS "Purchase" (
	"PurchaseId" INT NOT NULL,
	"CustomerId" INT NULL DEFAULT NULL,
	"UserId" INT NULL DEFAULT NULL,
	"JewelryId" INT NULL DEFAULT NULL,
	"PurchaseDate" DATE NULL DEFAULT NULL,
	"PurchasePrice" FLOAT NULL DEFAULT NULL,
	"IsBuyBack" INT NULL DEFAULT NULL,
	FOREIGN KEY INDEX "FK__Purchase__Custom__5629CD9C" ("CustomerId"),
	FOREIGN KEY INDEX "FK__Purchase__Custom__70DDC3D8" ("CustomerId"),
	FOREIGN KEY INDEX "FK__Purchase__Jewelr__5441852A" ("JewelryId"),
	FOREIGN KEY INDEX "FK__Purchase__Jewelr__6EF57B66" ("JewelryId"),
	FOREIGN KEY INDEX "FK__Purchase__UserId__5535A963" ("UserId"),
	FOREIGN KEY INDEX "FK__Purchase__UserId__6FE99F9F" ("UserId"),
	PRIMARY KEY ("PurchaseId"),
	CONSTRAINT "FK__Purchase__UserId__5535A963" FOREIGN KEY ("UserId") REFERENCES "User" ("UserId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Purchase__UserId__6FE99F9F" FOREIGN KEY ("UserId") REFERENCES "User" ("UserId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Purchase__Jewelr__5441852A" FOREIGN KEY ("JewelryId") REFERENCES "Jewelry" ("JewelryId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Purchase__Jewelr__6EF57B66" FOREIGN KEY ("JewelryId") REFERENCES "Jewelry" ("JewelryId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Purchase__Custom__5629CD9C" FOREIGN KEY ("CustomerId") REFERENCES "Customer" ("CustomerId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__Purchase__Custom__70DDC3D8" FOREIGN KEY ("CustomerId") REFERENCES "Customer" ("CustomerId") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

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

-- Dumping structure for table JSSATS.Role
CREATE TABLE IF NOT EXISTS "Role" (
	"RoleId" INT NOT NULL,
	"RoleName" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	PRIMARY KEY ("RoleId")
);

-- Dumping data for table JSSATS.Role: -1 rows
/*!40000 ALTER TABLE "Role" DISABLE KEYS */;
INSERT INTO "Role" ("RoleId", "RoleName") VALUES
	(1, 'Admin'),
	(2, 'Sales');
/*!40000 ALTER TABLE "Role" ENABLE KEYS */;

-- Dumping structure for table JSSATS.User
CREATE TABLE IF NOT EXISTS "User" (
	"UserId" INT NOT NULL,
	"RoleId" INT NULL DEFAULT NULL,
	"CounterId" INT NULL DEFAULT NULL,
	"Username" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	"Email" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	"Password" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	FOREIGN KEY INDEX "FK__User__CounterId__5812160E" ("CounterId"),
	FOREIGN KEY INDEX "FK__User__CounterId__72C60C4A" ("CounterId"),
	FOREIGN KEY INDEX "FK__User__RoleId__571DF1D5" ("RoleId"),
	FOREIGN KEY INDEX "FK__User__RoleId__71D1E811" ("RoleId"),
	PRIMARY KEY ("UserId"),
	CONSTRAINT "FK__User__RoleId__571DF1D5" FOREIGN KEY ("RoleId") REFERENCES "Role" ("RoleId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__User__RoleId__71D1E811" FOREIGN KEY ("RoleId") REFERENCES "Role" ("RoleId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__User__CounterId__5812160E" FOREIGN KEY ("CounterId") REFERENCES "Counter" ("CounterId") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__User__CounterId__72C60C4A" FOREIGN KEY ("CounterId") REFERENCES "Counter" ("CounterId") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- Dumping data for table JSSATS.User: -1 rows
/*!40000 ALTER TABLE "User" DISABLE KEYS */;
INSERT INTO "User" ("UserId", "RoleId", "CounterId", "Username", "Email", "Password") VALUES
	(1, 1, 1, 'admin', 'admin@example.com', 'password123'),
	(2, 2, 2, 'john_doe', 'john@example.com', 'password123'),
	(3, 2, 1, 'jdoe', 'jdoe@example.com', 'password123'),
	(4, 2, 2, 'asmith', 'asmith@example.com', 'password123'),
	(5, 2, 1, 'bwayne', 'bwayne@example.com', 'password123'),
	(6, 2, 2, 'ckent', 'ckent@example.com', 'password123');
/*!40000 ALTER TABLE "User" ENABLE KEYS */;

-- Dumping structure for table JSSATS.Warranty
CREATE TABLE IF NOT EXISTS "Warranty" (
	"WarrantyId" INT NOT NULL,
	"Description" NVARCHAR(255) NULL DEFAULT NULL COLLATE 'SQL_Latin1_General_CP1_CI_AS',
	"EndDate" DATE NULL DEFAULT NULL,
	PRIMARY KEY ("WarrantyId")
);

-- Dumping data for table JSSATS.Warranty: -1 rows
/*!40000 ALTER TABLE "Warranty" DISABLE KEYS */;
INSERT INTO "Warranty" ("WarrantyId", "Description", "EndDate") VALUES
	(1, '1 year warranty', '2025-12-31'),
	(2, '2 year warranty', '2026-12-31'),
	(3, '1 year warranty', '2025-12-31'),
	(4, '2 year warranty', '2026-12-31'),
	(5, '3 year warranty', '2027-12-31'),
	(6, 'Lifetime warranty', '2099-12-31');
/*!40000 ALTER TABLE "Warranty" ENABLE KEYS */;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
