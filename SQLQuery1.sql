CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Products
VALUES
	(1, 'Aser 2000'),
	(2, 'electric kettle'),
	(3, 'Azelit');


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


SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN connection_P_C PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;