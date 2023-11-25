CREATE DATABASE ProductsDB;
GO

USE ProductsDB;
GO

CREATE TABLE Products (
  ProductID INT PRIMARY KEY IDENTITY(1, 1),
  ProductName NVARCHAR(200) NOT NULL,
  Price DECIMAL(10, 2) NOT NULL
  );

CREATE TABLE Categories (
  CategoryID INT PRIMARY KEY IDENTITY(1, 1),
  CategoryName NVARCHAR(100) NOT NULL
  );

CREATE TABLE ProductCategory (
  ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
  CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID),
  PRIMARY KEY (ProductID, CategoryID)
  );

INSERT INTO Products (ProductName, Price)
VALUES
  ('��������', 500.00),
  ('�������', 1200.00),
  ('��������', 20.00),
  ('����� �� SQL', 30.00),
  ('������', 1.00);

INSERT INTO Categories (CategoryName)
VALUES
  ('�����������'),
  ('������'),
  ('�����');

INSERT INTO ProductCategory (ProductID, CategoryID)
VALUES
  (1, 1),
  (2, 1),
  (3, 2),
  (4, 3),
  (4, 1);

SELECT
  P.ProductName, CategoryName,
  COALESCE(C.CategoryName, '��� ���������') AS CategoryNameWithCaveat
FROM
  Products P
LEFT JOIN
  ProductCategory PC ON P.ProductID = PC.ProductID
LEFT JOIN
  Categories C ON PC.CategoryID = C.CategoryID;
