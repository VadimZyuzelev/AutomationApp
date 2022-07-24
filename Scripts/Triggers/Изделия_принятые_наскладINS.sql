/*����� ��������� ����*/
CREATE TRIGGER �������_��������_��_�����INS
ON �������_��������_��_����� FOR INSERT
AS
DECLARE @ID_Inserted int, @Count int, @Price int, @Sort int, @UnitDetedminatein nvarchar(5)
IF @@ROWCOUNT=1
BEGIN	

	/*IF EXISTS
	(
		SELECT a.ID_������_���������
		FROM inserted a, �����_��������� b
		WHERE  EXISTS
		(
			SELECT b.ID_������_���������
			FROM �����_��������� b
			WHERE b.ID_������_��������� = a.ID_������_���������
		)
	)*/

	IF EXISTS
	(
		SELECT a.ID_������_�������
		FROM ������_������� a, ����������_����� b
		WHERE EXISTS
		(
			SELECT b.ID_������_�������
			FROM ����������_����� b, �����_�������_��������� c, inserted d
			WHERE b.ID_�����������_����� = d.ID_�����������_����� AND b.ID_������_������� = c.ID_������_�������
			/*WHERE b.ID_������_������� = a.ID_������_�������*/
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
		SELECT a.ID_�����������_�����
		FROM inserted a, ����������_����� b
		WHERE  EXISTS
		(
			SELECT c.ID_������_�������
			FROM ������_������� c
			WHERE c.ID_������_������� = b.ID_������_�������
		)
	)*/
	BEGIN
		SELECT @ID_Inserted = b.ID_������_�������, @Count = a.����������, @Sort = a.����
		FROM inserted a, ����������_����� b
		WHERE a.ID_�����������_����� = b.ID_�����������_�����
		UPDATE �����_�������_���������
		SET ���������� += @Count
		WHERE ID_������_������� = @ID_Inserted
	END
	ELSE
	BEGIN
		SELECT @ID_Inserted = b.ID_������_�������, @UnitDetedminatein = '��', @Count = a.����������, @Sort = a.����
		FROM inserted a, ����������_����� b
		WHERE a.ID_�����������_����� = b.ID_�����������_�����
		INSERT INTO �����_�������_���������
		VALUES (@ID_Inserted, @Sort, @UnitDetedminatein, @Count)
	END
END
