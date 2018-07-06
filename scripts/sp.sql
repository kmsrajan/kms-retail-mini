CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Insert_NewItem`(
IN pName VARCHAR(100),
IN pICID BIGINT(20),
IN pDispName VARCHAR(100),
IN pShortName VARCHAR(100),
IN pPurPrice DECIMAL(10,2),
IN pQty DECIMAL(10,2),
IN pMRP DECIMAL(10,2),
IN pSellingPrice DECIMAL(10,2),
IN pWSPrice DECIMAL(10,2),
IN pSplPrice DECIMAL(10,2),
IN pSID BIGINT(20),
IN pGST DECIMAL(10,2),
IN pTax DECIMAL(10,2),
IN pItemPicture MEDIUMBLOB
)
BEGIN
INSERT INTO `kms-mini-db`.`tab_items`
(
ItemName,
ICID,
DisplayName,
ShortName,
PurchasePrice,
Qty,
MRP,
SellingPrice,
WSPrice,
GCPrice,
SID,
GST,
Tax,
ItemPicture)
VALUES
(
pName,
pICID,
pItemDispName,
pItemShortName,
pPurPrice,
pQty,
pMRP,
pSellingPrice,
pWSPrice,
pSplPrice,
pSID,
pGSTpTax,
pItemPicture);
END
