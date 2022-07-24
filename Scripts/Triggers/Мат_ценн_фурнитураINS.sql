CREATE TRIGGER Мат_цен_фурнитураINS
ON Материальные_ценности_по_ордеру_на_фурнитуру FOR INSERT
AS
DECLARE @ID_FurnitureWarehouse int, @ID_Inserted int, @Count int, @Price int, @UnitDetedminatein nvarchar(5)
IF @@ROWCOUNT=1
BEGIN	
	IF EXISTS
	(
		SELECT a.ID_Модели_фурнитуры
		FROM inserted a, Склад_фурнитуры b
		WHERE  EXISTS
		(
			SELECT b.ID_Модели_фурнитуры
			FROM Склад_фурнитуры b
			WHERE b.ID_Модели_фурнитуры = a.ID_Модели_фурнитуры
		)
	)
	BEGIN
		SELECT @ID_Inserted = a.ID_Модели_фурнитуры, @Count = a.Количество
		FROM inserted a, Склад_фурнитуры b
		WHERE b.ID_Модели_фурнитуры = a.ID_Модели_фурнитуры
		UPDATE Склад_фурнитуры
		SET Количество += @Count
		WHERE ID_Модели_фурнитуры = @ID_Inserted
	END
	ELSE
	BEGIN
		SELECT @ID_Inserted = ID_Модели_фурнитуры, @UnitDetedminatein = Единица_измерения, @Count = Количество, @Price = Цена
		FROM inserted a
		INSERT INTO Склад_фурнитуры
		VALUES (@ID_Inserted, @UnitDetedminatein, @Count, @Price)
	END
END
