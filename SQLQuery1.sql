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


SELECT P."Name_product", C."Name_Category"
FROM Product P
LEFT JOIN connection_P_C PC
	ON P.Id = PC.ProductId
LEFT JOIN Category C
	ON PC.CategoryId = C.Id;