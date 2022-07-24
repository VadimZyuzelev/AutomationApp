----"���� ������ ��������� �������������"
CREATE DATABASE AutomationAppDB
GO

CREATE TABLE �������
(
	ID_������� int NOT NULL IDENTITY PRIMARY KEY,
	������������ nvarchar(80) NOT NULL
);

CREATE TABLE ������_�������
(
	ID_������_������� int NOT NULL IDENTITY PRIMARY KEY,
	ID_������� int NOT NULL,
	������_������� nvarchar(15) NOT NULL

	FOREIGN KEY (ID_�������) REFERENCES ������� (ID_�������)
);

CREATE TABLE ����������_�����
(
	ID_�����������_����� int NOT NULL IDENTITY PRIMARY KEY,
	ID_������_������� int NOT NULL,
	�����_������ int NOT NULL,
	���� int NOT NULL,
	������ int NOT NULL,
	������� int NOT NULL,
	���_����� int NOT NULL,
	
	FOREIGN KEY (ID_������_�������) REFERENCES ������_������� (ID_������_�������),
);

CREATE TABLE �������_��������_��_�����
(
	ID_���������_������� int NOT NULL IDENTITY PRIMARY KEY,
	ID_�����������_����� int NOT NULL,
	���������� int NOT NULL,
	���� int NOT NULL,

	FOREIGN KEY (ID_�����������_�����) REFERENCES ����������_����� (ID_�����������_�����)
);

CREATE TABLE ���������
(
	ID_��������� int NOT NULL IDENTITY PRIMARY KEY,
	������������ nvarchar(30) NOT NULL
);

CREATE TABLE ������_���������
(
	ID_������_��������� int NOT NULL IDENTITY PRIMARY KEY,
	ID_��������� int NOT NULL,
	������_��������� nvarchar(50) NOT NULL,

	FOREIGN KEY (ID_���������) REFERENCES ��������� (ID_���������)
);

CREATE TABLE �����_���������
(
	ID_���������_��_������ int NOT NULL IDENTITY PRIMARY KEY,
	ID_������_��������� int NOT NULL,
	�������_��������� nvarchar(5) NOT NULL,
	���������� int NOT NULL,
	���� money NOT NULL,

	FOREIGN KEY (ID_������_���������) REFERENCES ������_��������� (ID_������_���������)
);

CREATE TABLE ����������
(
	ID_���������� int NOT NULL IDENTITY PRIMARY KEY,
	������������ nvarchar(80) NOT NULL,
	����� nvarchar(150) NOT NULL
);

CREATE TABLE ���������_������_��_���������
(
	ID_����������_������ int NOT NULL IDENTITY PRIMARY KEY,
	ID_���������� int NOT NULL,
	����_����������� date NOT NULL,
	����� nvarchar(30) NOT NULL,
	�����������������_���� nvarchar(20) NOT NULL,
	����������������_�������� nvarchar(50) NOT NULL,
	����� money NOT NULL,

	FOREIGN KEY (ID_����������) REFERENCES ���������� (ID_����������)
);

CREATE TABLE ������������_��������_��_������_��_���������
(
	ID_������������_�������� int NOT NULL IDENTITY PRIMARY KEY,
	ID_������_��������� int NOT NULL,
	ID_����������_������ int NOT NULL,
	�������_��������� nvarchar(5) NOT NULL,
	���������� int NOT NULL,
	���� money NOT NULL,
	����� money NOT NULL,

	FOREIGN KEY (ID_������_���������) REFERENCES ������_��������� (ID_������_���������),
	FOREIGN KEY (ID_����������_������) REFERENCES ���������_������_��_��������� (ID_����������_������)
);

CREATE TABLE ����
(
	ID_���� int NOT NULL IDENTITY PRIMARY KEY,
	������������ nvarchar(30) NOT NULL
);

CREATE TABLE �������
(
	ID_������� int NOT NULL IDENTITY PRIMARY KEY,
	ID_���� int NOT NULL,
	������������ nvarchar(30) NOT NULL,
	
	FOREIGN KEY (ID_����) REFERENCES ���� (ID_����)
);

CREATE TABLE �������_��������_�����
(
	ID_�������_��������_����� int NOT NULL IDENTITY PRIMARY KEY,
	ID_������� int NOT NULL,
	ID_������_������� int NOT NULL,
	����_����������� date NOT NULL,
	����������_������� int NOT NULL,
	
	FOREIGN KEY (ID_�������) REFERENCES ������� (ID_�������),
	FOREIGN KEY (ID_������_�������) REFERENCES ������_������� (ID_������_�������)
);

CREATE TABLE ���������_��_�������_��������_�����
(
	ID_���������_��_�������_��������_����� int NOT NULL IDENTITY PRIMARY KEY,
	ID_�������_��������_����� int NOT NULL,
	ID_���������_��_������ int NOT NULL,
	�����_��_�������_������� int NOT NULL,
	�������_��������� nvarchar(5) NOT NULL,
	���������� int NOT NULL,
	���� money NOT NULL,
	����� money NOT NULL,

	FOREIGN KEY (ID_�������_��������_�����) REFERENCES �������_��������_����� (ID_�������_��������_�����),
	FOREIGN KEY (ID_���������_��_������) REFERENCES �����_��������� (ID_���������_��_������)
);

CREATE TABLE �����
(
	ID_����� int NOT NULL IDENTITY PRIMARY KEY,
	������������ nvarchar(90) NOT NULL
);

CREATE TABLE ������_�����
(
	ID_������_����� int NOT NULL IDENTITY PRIMARY KEY,
	ID_����� int NOT NULL,
	������_����� nvarchar(50) NOT NULL,

	FOREIGN KEY (ID_�����) REFERENCES ����� (ID_�����)
);

CREATE TABLE �����_�����
(
	ID_�����_��_������ int NOT NULL IDENTITY PRIMARY KEY,
	ID_������_����� int NOT NULL,
	�������_��������� nvarchar(5) NOT NULL,
	���������� int NOT NULL,
	���� money NOT NULL,

	FOREIGN KEY (ID_������_�����) REFERENCES ������_����� (ID_������_�����)
);

CREATE TABLE ���������_������_��_�����
(
	ID_����������_������ int NOT NULL IDENTITY PRIMARY KEY,
	ID_���������� int NOT NULL,
	����_����������� date NOT NULL,
	����� nvarchar(30) NOT NULL,
	�����������������_���� nvarchar(20) NOT NULL,
	����������������_�������� nvarchar(50) NOT NULL,
	����� money NOT NULL,
	
	FOREIGN KEY (ID_����������) REFERENCES ���������� (ID_����������)
);

CREATE TABLE ������������_��������_��_������_��_�����
(
	ID_������������_�������� int NOT NULL IDENTITY PRIMARY KEY,
	ID_����������_������ int NOT NULL,
	ID_������_����� int NOT NULL,
	�������_��������� nvarchar(5) NOT NULL,
	���������� int NOT NULL,
	���� money NOT NULL,
	�����_��� money,
	�����_���_��� money NOT NULL,
	�����_�_��� money NOT NULL,

	FOREIGN KEY (ID_����������_������) REFERENCES ���������_������_��_����� (ID_����������_������),
	FOREIGN KEY (ID_������_�����) REFERENCES ������_����� (ID_������_�����)
);

CREATE TABLE ���������_�����
(
	ID_���������_����� int NOT NULL IDENTITY PRIMARY KEY,
	ID_������� int NOT NULL,
	ID_������_������� int NOT NULL,
	�����_������ nvarchar(15) NOT NULL,
	����_�������_����� date NOT NULL,

	FOREIGN KEY (ID_�������) REFERENCES ������� (ID_�������),
	FOREIGN KEY (ID_������_�������) REFERENCES ������_������� (ID_������_�������)
);

CREATE TABLE �����_���_���������_�����
(
	ID_�����_���_����� int NOT NULL IDENTITY PRIMARY KEY,
	ID_���������_����� int NOT NULL,
	ID_�����_��_������ int NOT NULL,
	���������� int NOT NULL,
	�������_��������� nvarchar(5) NOT NULL,

	FOREIGN KEY (ID_���������_�����) REFERENCES ���������_����� (ID_���������_�����),
	FOREIGN KEY (ID_�����_��_������) REFERENCES �����_����� (ID_�����_��_������)
);

CREATE TABLE �����_�������_���������
(
	ID_�������_���������_��_������ int NOT NULL IDENTITY PRIMARY KEY,
	ID_������_������� int NOT NULL,
	���� int NOT NULL,
	�������_��������� nvarchar(5) NOT NULL,
	���������� int NOT NULL,

	FOREIGN KEY (ID_������_�������) REFERENCES ������_������� (ID_������_�������)
);

CREATE TABLE �����������
(
	ID_����������� int NOT NULL IDENTITY PRIMARY KEY,
	��� nvarchar(9) NOT NULL,
	������������ nvarchar(80) NOT NULL,
	����� nvarchar(150) NOT NULL
);

CREATE TABLE ��������_���������
(
	ID_��������_��������� int NOT NULL IDENTITY PRIMARY KEY,
	����_������� date NOT NULL
);

CREATE TABLE �����������_��������_���������
(
	ID_�����������_��������_��������� int NOT NULL IDENTITY PRIMARY KEY,
	ID_��������_��������� int NOT NULL,
	ID_����������� int NOT NULL,
	���_����������� nvarchar(20) NOT NULL,

	FOREIGN KEY (ID_��������_���������) REFERENCES ��������_��������� (ID_��������_���������),
	FOREIGN KEY (ID_�����������) REFERENCES ����������� (ID_�����������)
);

CREATE TABLE ��������_������_��������_���������
(
	ID_���������_������� int NOT NULL IDENTITY PRIMARY KEY,
	ID_��������_��������� int NOT NULL,
	ID_�������_���������_��_������ int NOT NULL,
	�������_��������� nvarchar(5) NOT NULL,
	���������� int NOT NULL,
	���� money NOT NULL,
	���������_��������� money NOT NULL,
	������_��� int,
	�����_��� int,
	�����_�_��� int NOT NULL,

	FOREIGN KEY (ID_��������_���������) REFERENCES ��������_��������� (ID_��������_���������),
	FOREIGN KEY (ID_�������_���������_��_������) REFERENCES �����_�������_��������� (ID_�������_���������_��_������)
);

CREATE TABLE ����������
(
	ID_���������� int NOT NULL IDENTITY PRIMARY KEY,
	����� nvarchar(20) NOT NULL,
	������ nvarchar(30) NOT NULL,
	���������������_����� nvarchar(10) NOT NULL,
	�������� nvarchar(80) NOT NULL
);

CREATE TABLE ��������
(
	ID_�������� int NOT NULL IDENTITY PRIMARY KEY,
	��� nvarchar(50) NOT NULL,
	�����_�������������_������������� nvarchar(10) NOT NULL,
	����_������_������������� date NOT NULL
);

CREATE TABLE �������_������������_���������
(
	ID_�������_������������_��������� int NOT NULL IDENTITY PRIMARY KEY,
	ID_���������� int NOT NULL,
	ID_�������� int NOT NULL,
	����_������� date NOT NULL,
	���������_������� nvarchar(40) NOT NULL,
	������������� nvarchar(150),
	������_�������� nvarchar(25) NOT NULL,
	������_��������� nvarchar(25) NOT NULL,

	FOREIGN KEY (ID_����������) REFERENCES ���������� (ID_����������),
	FOREIGN KEY (ID_��������) REFERENCES �������� (ID_��������)
);

CREATE TABLE �����������_�������_������������_���������
(
	ID_�����������_�������_������������_��������� int NOT NULL IDENTITY PRIMARY KEY,
	ID_�������_������������_��������� int NOT NULL,
	ID_����������� int NOT NULL,
	���_����������� nvarchar(20) NOT NULL,

	FOREIGN KEY (ID_�������_������������_���������) REFERENCES �������_������������_��������� (ID_�������_������������_���������),
	FOREIGN KEY (ID_�����������) REFERENCES ����������� (ID_�����������)
);

CREATE TABLE ��������_������_�������_������������_���������
(
	ID_���������_������� int NOT NULL IDENTITY PRIMARY KEY,
	ID_�������_������������_��������� int NOT NULL,
	ID_�������_���������_��_������ int NOT NULL,
	�������_��������� nvarchar(5) NOT NULL,
	���������� int NOT NULL,
	���� money NOT NULL,
	��������� money NOT NULL,
	������_��� int,
	�����_��� int,
	���������_�_��� int NOT NULL,
	����������_��������_���� int NOT NULL,
	�����_����� int

	FOREIGN KEY (ID_�������_������������_���������) REFERENCES �������_������������_��������� (ID_�������_������������_���������),
	FOREIGN KEY (ID_�������_���������_��_������) REFERENCES �����_�������_��������� (ID_�������_���������_��_������)	
);
