/*Через маршрутый лист*/
CREATE TRIGGER Изделия_принятые_на_складINS
ON Изделия_принятые_на_склад FOR INSERT
AS
DECLARE @ID_Inserted int, @Count int, @Price int, @Sort int, @UnitDetedminatein nvarchar(5)
IF @@ROWCOUNT=1
BEGIN	

	/*IF EXISTS
	(
		SELECT a.ID_Модели_фурнитуры
		FROM inserted a, Склад_фурнитуры b
		WHERE  EXISTS
		(
			SELECT b.ID_Модели_фурнитуры
			FROM Склад_фурнитуры b
			WHERE b.ID_Модели_фурнитуры = a.ID_Модели_фурнитуры
		)
	)*/

	IF EXISTS
	(
		SELECT a.ID_Модели_изделия
		FROM Модели_изделия a, Маршрутные_листы b
		WHERE EXISTS
		(
			SELECT b.ID_Модели_изделия
			FROM Маршрутные_листы b, Склад_готовой_продукции c, inserted d
			WHERE b.ID_Маршрутного_листа = d.ID_Маршрутного_листа AND b.ID_Модели_изделия = c.ID_Модели_изделия
			/*WHERE b.ID_Модели_изделия = a.ID_Модели_изделия*/
			/*WHERE EXISTS
			(
				SELECT 
				FROM
				WHERE
			)*/
		)
	)
	/*IF EXISTS
	(
		SELECT a.ID_Маршрутного_листа
		FROM inserted a, Маршрутные_листы b
		WHERE  EXISTS
		(
			SELECT c.ID_Модели_изделия
			FROM Модели_изделия c
			WHERE c.ID_Модели_изделия = b.ID_Модели_изделия
		)
	)*/
	BEGIN
		SELECT @ID_Inserted = b.ID_Модели_изделия, @Count = a.Количество, @Sort = a.Сорт
		FROM inserted a, Маршрутные_листы b
		WHERE a.ID_Маршрутного_листа = b.ID_Маршрутного_листа
		UPDATE Склад_готовой_продукции
		SET Количество += @Count
		WHERE ID_Модели_изделия = @ID_Inserted
	END
	ELSE
	BEGIN
		SELECT @ID_Inserted = b.ID_Модели_изделия, @UnitDetedminatein = 'шт', @Count = a.Количество, @Sort = a.Сорт
		FROM inserted a, Маршрутные_листы b
		WHERE a.ID_Маршрутного_листа = b.ID_Маршрутного_листа
		INSERT INTO Склад_готовой_продукции
		VALUES (@ID_Inserted, @Sort, @UnitDetedminatein, @Count)
	END
END
