# SQL_for_test


SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN connection_P_C PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
  
![image](https://user-images.githubusercontent.com/78875572/215729324-bd33a287-741f-4426-a72d-9a92dd50db3e.png)


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
