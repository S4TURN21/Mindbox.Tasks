-- ���� ������
CREATE DATABASE MindboxDb;
GO
USE MindboxDb;
GO

-- ������� ���������
CREATE TABLE Products (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(100)
);

-- ������� ���������
CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(50)
);

-- ������������� �������
CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id) NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL
	PRIMARY KEY (ProductId, CategoryId)
);
GO

-- ������� ���������
INSERT INTO Products(Name) VALUES 
	('��������'),
	('�������'),
	('��������'),
	('����'),
	('������� �������'),
	('�����-����');

-- ������� ���������
INSERT INTO Categories(Name) VALUES 
	('�����������'),
    ('������'),
    ('����������'),
	('��������� � �������');

-- ������� ������ ��������� � ���������
INSERT INTO ProductCategories(ProductId, CategoryId) VALUES 
	(1, 1),
	(2, 1),
	(3, 2),
	(4, 3),
	(1, 4),
	(5, 4),
	(5, 1);