CREATE TRIGGER Мат_цен_тканьINS
ON Материальные_ценности_по_ордеру_на_ткань FOR INSERT
AS
DECLARE @ID_ClothWarehouse int, @ID_Inserted int, @Count int, @Price int, @UnitDetedminatein nvarchar(5)
IF @@ROWCOUNT=1
BEGIN	
	IF EXISTS
	(
		SELECT a.ID_Модели_ткани
		FROM inserted a, Склад_ткани b
		WHERE  EXISTS
		(
			SELECT b.ID_Модели_ткани
			FROM Склад_ткани b
			WHERE b.ID_Модели_ткани = a.ID_Модели_ткани
		)
	)
	BEGIN
		SELECT @ID_Inserted = a.ID_Модели_ткани, @Count = a.Количество
		FROM inserted a, Склад_ткани b
		WHERE b.ID_Модели_ткани = a.ID_Модели_ткани
		UPDATE Склад_ткани
		SET Количество += @Count
		WHERE ID_Модели_ткани = @ID_Inserted
	END
	ELSE
	BEGIN
		SELECT @ID_Inserted = ID_Модели_ткани, @UnitDetedminatein = Единица_измерения, @Count = Количество, @Price = Цена
		FROM inserted a
		INSERT INTO Склад_ткани
		VALUES (@ID_Inserted, @UnitDetedminatein, @Count, @Price)
	END
END