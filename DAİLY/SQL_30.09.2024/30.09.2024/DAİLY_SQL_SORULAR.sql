USE Northwind

-- SELECT TOP 1 p.UnitPrice FROM Products p 
-- ORDER BY p.UnitPrice DESC

--MÜŞTERİLERİN ÜLKERİNE GÖRE SAYILARINI VEREN SORGU

-- SELECT c.Country,
-- COUNT(c.CustomerID) AS [KAÇ TANE] FROM Customers c 
-- GROUP BY c.Country 

--STOCK ADETE 20 İLA 50 ARASI ÜRÜNLERİ YAZDIR

-- SELECT * FROM Products p 
-- WHERE p.UnitsInStock BETWEEN 20 AND 50

-- HANGİ ÜRÜN HANGİ KATEGORİDEDİR

-- SELECT c.CategoryName, p.ProductID FROM Products p
-- JOIN  Categories c ON  p.CategoryID = c.CategoryID

