-- База данных
CREATE DATABASE MindboxDb;
GO
USE MindboxDb;
GO

-- Таблица продуктов
CREATE TABLE Products (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(100)
);

-- Таблица категорий
CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(50)
);

-- Промежуточная таблица
CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id) NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL
	PRIMARY KEY (ProductId, CategoryId)
);
GO

-- Вставка продуктов
INSERT INTO Products(Name) VALUES 
	('Смартфон'),
	('Ноутбук'),
	('Футболка'),
	('Часы'),
	('Сотовый телефон'),
	('Смарт-часы');

-- Вставка категорий
INSERT INTO Categories(Name) VALUES 
	('Электроника'),
    ('Одежда'),
    ('Аксессуары'),
	('Смартфоны и гаджеты');

-- Вставка связей продуктов и категорий
INSERT INTO ProductCategories(ProductId, CategoryId) VALUES 
	(1, 1),
	(2, 1),
	(3, 2),
	(4, 3),
	(1, 4),
	(5, 4),
	(5, 1);