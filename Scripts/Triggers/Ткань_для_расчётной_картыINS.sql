CREATE TRIGGER “кань_дл€_расчЄтной_картыINS
ON “кань_дл€_расчЄтной_карты FOR INSERT
AS
DECLARE @ID_ClothWarehouse int, @ID_Inserted int, @Count int, @Price int, @UnitDetedminatein nvarchar(5)
IF @@ROWCOUNT=1
BEGIN	
	IF EXISTS
	(
		SELECT a.ID_“кани_на_складе
		FROM inserted a, —клад_ткани b
		WHERE  EXISTS
		(
			SELECT b.ID_“кани_на_складе
			FROM —клад_ткани b
			WHERE b.ID_“кани_на_складе = a.ID_“кани_на_складе
		)
	)
	BEGIN
		SELECT @ID_Inserted = a.ID_“кани_на_складе, @Count = a. оличество
		FROM inserted a, —клад_ткани b
		WHERE b.ID_“кани_на_складе = a.ID_“кани_на_складе
		UPDATE —клад_ткани
		SET  оличество -= @Count
		WHERE ID_“кани_на_складе = @ID_Inserted
	END
END