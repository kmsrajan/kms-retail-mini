CREATE TABLE `kms-mini-db`.`tab_items` (
  `ID` INT NOT NULL,
  `Code` VARCHAR(10) NOT NULL,
  `Name` VARCHAR(50) NOT NULL,
  `ShortName` VARCHAR(15) NULL,
  `DisplayName` VARCHAR(50) NULL,
  `Picture` MEDIUMBLOB NULL,
  `PurchasePrice` DECIMAL(10,2) NOT NULL,
  `SellingPrice` DECIMAL(10,2) NOT NULL,
  `WSPrice` DECIMAL(10,2) NULL,
  `GCPrice` DECIMAL(10,2) NULL,
  `MRP` DECIMAL(10,2) NULL,
  `Tax` INT NULL,
  `GST` INT NULL,
  `CreatedDate` DATE NULL,
  `Status` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE INDEX `Code_UNIQUE` (`Code` ASC));

CREATE TABLE `kms-mini-db`.`tab_invoices` (
  `ID` INT NOT NULL,
  `InvoiceNo` VARCHAR(10) NOT NULL,
  `CustName` VARCHAR(50) NOT NULL,
  `CustAddress` VARCHAR(250) NULL,
  `Mobile` VARCHAR(15) NULL,
  `Photo` MEDIUMBLOB NULL,
  `Status` VARCHAR(50) NOT NULL,
  `Items` TEXT NOT NULL,
`TotalAmount` DECIMAL(10,2) NULL,  
  `TaxType` VARCHAR(50) NULL,
  `TotalTax` DECIMAL(10,2) NULL,
  `Discount` DECIMAL(10,2) NULL,
  `NetTotal` DECIMAL(10,2) NULL,   
  `PaymentMode`  VARCHAR(50) NULL,  
  `AmountReceived`   DECIMAL(10,2) NULL,
  `CreatedDate` DATE NULL,
  PRIMARY KEY (`ID`),
UNIQUE INDEX `InvoiceNo_UNIQUE` (`InvoiceNo` ASC));

CREATE TABLE `kms-mini-db`.`tab_category` (
  `ID` INT NOT NULL,
  `Category` VARCHAR(100) NULL,
  PRIMARY KEY (`ID`));

CREATE TABLE `kms-mini-db`.`tab_status` (
  `ID` INT NOT NULL,
  `StatusName` VARCHAR(50) NULL,
  PRIMARY KEY (`ID`));
