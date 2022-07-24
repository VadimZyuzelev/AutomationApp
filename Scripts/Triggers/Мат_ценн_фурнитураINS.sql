CREATE TRIGGER ���_���_���������INS
ON ������������_��������_��_������_��_��������� FOR INSERT
AS
DECLARE @ID_FurnitureWarehouse int, @ID_Inserted int, @Count int, @Price int, @UnitDetedminatein nvarchar(5)
IF @@ROWCOUNT=1
BEGIN	
	IF EXISTS
	(
		SELECT a.ID_������_���������
		FROM inserted a, �����_��������� b
		WHERE  EXISTS
		(
			SELECT b.ID_������_���������
			FROM �����_��������� b
			WHERE b.ID_������_��������� = a.ID_������_���������
		)
	)
	BEGIN
		SELECT @ID_Inserted = a.ID_������_���������, @Count = a.����������
		FROM inserted a, �����_��������� b
		WHERE b.ID_������_��������� = a.ID_������_���������
		UPDATE �����_���������
		SET ���������� += @Count
		WHERE ID_������_��������� = @ID_Inserted
	END
	ELSE
	BEGIN
		SELECT @ID_Inserted = ID_������_���������, @UnitDetedminatein = �������_���������, @Count = ����������, @Price = ����
		FROM inserted a
		INSERT INTO �����_���������
		VALUES (@ID_Inserted, @UnitDetedminatein, @Count, @Price)
	END
END
