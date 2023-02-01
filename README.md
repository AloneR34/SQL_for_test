# SQL_for_test

**Задание**

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Связь многие-ко-многим реализована с помощью таблицы connection_P_C. Запрос будет содежать все продукты даже если у некоторых продуктов не будет категории, поскольку связь таблиц Products и connection_P_C осуществляется через LEFT JOIN.

SELECT P."Name_product", C."Name_Category"
FROM Product P
LEFT JOIN connection_P_C PC
	ON P.Id = PC.ProductId
LEFT JOIN Category C
	ON PC.CategoryId = C.Id;
	
  ![Снимок экрана (8)](https://user-images.githubusercontent.com/78875572/216077743-ddcb282e-75bf-4b2f-bdaa-7e5510fb83e2.png)

  


**Описание создания таблиц**

CREATE TABLE Product (
	Id INT PRIMARY KEY,
	"Name_product" TEXT
);


INSERT INTO Product
VALUES
	(1, 'Aser 2000'),
	(2, 'electric kettle'),
	(3, 'Azelit'),
	(4, 'Other product');



CREATE TABLE Category (
	Id INT PRIMARY KEY,
	"Name_Category" TEXT
);


INSERT INTO Category
VALUES
	(1, 'Food'),
	(2, 'Electronic'),
	(3, 'Domestic tools');




CREATE TABLE conn_P_C (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);


INSERT INTO conn_P_C
VALUES
	(1, 2),
	(2, 1),
	(2, 3),
	(3, 3);
	
