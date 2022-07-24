CREATE TRIGGER �����_���_���������_�����INS
ON �����_���_���������_����� FOR INSERT
AS
DECLARE @ID_ClothWarehouse int, @ID_Inserted int, @Count int, @Price int, @UnitDetedminatein nvarchar(5)
IF @@ROWCOUNT=1
BEGIN	
	IF EXISTS
	(
		SELECT a.ID_�����_��_������
		FROM inserted a, �����_����� b
		WHERE  EXISTS
		(
			SELECT b.ID_�����_��_������
			FROM �����_����� b
			WHERE b.ID_�����_��_������ = a.ID_�����_��_������
		)
	)
	BEGIN
		SELECT @ID_Inserted = a.ID_�����_��_������, @Count = a.����������
		FROM inserted a, �����_����� b
		WHERE b.ID_�����_��_������ = a.ID_�����_��_������
		UPDATE �����_�����
		SET ���������� -= @Count
		WHERE ID_�����_��_������ = @ID_Inserted
	END
END