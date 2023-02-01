# SQL_for_test

**Задание**

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Связь многие-ко-многим реализована с помощью таблицы connection_P_C. Запрос будет содежать все продукты даже если у некоторых продуктов не будет категории, поскольку связь таблиц Products и connection_P_C осуществляется через LEFT JOIN.

SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN connection_P_C PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
  
  
![Снимок экрана (1)](https://user-images.githubusercontent.com/78875572/215729990-9624b15a-dfa9-4d55-99f0-7e4932a1543e.png)


**Описание создания таблиц**

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Categories
VALUES
	(1, 'Food'),
	(2, 'Electronic'),
	(3, 'Domestic tools');


CREATE TABLE connection_P_C (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO connection_P_C
VALUES
	(1, 2),
	(2, 1),
	(2, 3),
	(3, 3);
