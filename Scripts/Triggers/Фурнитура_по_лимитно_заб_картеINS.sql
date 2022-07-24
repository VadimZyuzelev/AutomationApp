CREATE TRIGGER Фурнитура_по_лимитно_заб_картеINS
ON Фурнитура_по_лимитно_заборной_карте FOR INSERT
AS
DECLARE @ID_FurnitureWarehouse int, @ID_Inserted int, @Count int, @Price int, @UnitDetedminatein nvarchar(5)
IF @@ROWCOUNT=1
BEGIN	
	IF EXISTS
	(
		SELECT a.ID_Фурнитуры_на_складе
		FROM inserted a, Склад_фурнитуры b
		WHERE  EXISTS
		(
			SELECT b.ID_Фурнитуры_на_складе
			FROM Склад_фурнитуры b
			WHERE b.ID_Фурнитуры_на_складе = a.ID_Фурнитуры_на_складе
		)
	)
	BEGIN
		SELECT @ID_Inserted = a.ID_Фурнитуры_на_складе, @Count = a.Количество
		FROM inserted a, Склад_фурнитуры b
		WHERE b.ID_Фурнитуры_на_складе = a.ID_Фурнитуры_на_складе
		UPDATE Склад_фурнитуры
		SET Количество -= @Count
		WHERE ID_Фурнитуры_на_складе = @ID_Inserted
	END
END