CREATE LOGIN CutPicker 
	WITH PASSWORD ='qwerty123',
	DEFAULT_DATABASE = AutomationAppDB,
	DEFAULT_LANGUAGE = русский,
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = OFF
GO

CREATE LOGIN WarehouseCloth 
	WITH PASSWORD ='qwerty123',
	DEFAULT_DATABASE = AutomationAppDB,
	DEFAULT_LANGUAGE = русский,
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = OFF
GO

CREATE LOGIN WarehouseFurniture 
	WITH PASSWORD ='qwerty123',
	DEFAULT_DATABASE = AutomationAppDB,
	DEFAULT_LANGUAGE = [русский],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = OFF
GO

CREATE LOGIN WarehouseProducts 
	WITH PASSWORD='qwerty123',
	DEFAULT_DATABASE = AutomationAppDB,
	DEFAULT_LANGUAGE = русский,
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = OFF
GO


CREATE USER CutPicker FOR LOGIN CutPicker
WITH DEFAULT_SCHEMA=dbo 
ALTER ROLE db_datareader ADD MEMBER CutPicker
ALTER ROLE db_datawriter ADD MEMBER CutPicker

CREATE USER WarehouseCloth FOR LOGIN WarehouseCloth
WITH DEFAULT_SCHEMA=dbo 
ALTER ROLE db_datareader ADD MEMBER WarehouseCloth
ALTER ROLE db_datawriter ADD MEMBER WarehouseCloth

CREATE USER WarehouseFurniture FOR LOGIN WarehouseFurniture
WITH DEFAULT_SCHEMA=dbo 
ALTER ROLE db_datareader ADD MEMBER WarehouseFurniture
ALTER ROLE db_datawriter ADD MEMBER WarehouseFurniture

CREATE USER WarehouseProducts FOR LOGIN WarehouseProducts
WITH DEFAULT_SCHEMA=dbo 
ALTER ROLE db_datareader ADD MEMBER WarehouseProducts
ALTER ROLE db_datawriter ADD MEMBER WarehouseProducts
