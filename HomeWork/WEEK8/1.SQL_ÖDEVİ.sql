USE Northwind

--1.SORGU
--Tüm ürünlerin adlarını ve birim fiyatlarını listeleyin.
SELECT p.ProductName, p.UnitPrice
FROM Products p

--2.SORGU
--Müşterilerin şirket adlarını ve bulundukları şehirleri alfabetik sırayla listeleyin.

SELECT c.CompanyName, c.City
FROM Customers c
ORDER BY c.CompanyName ASC

--3.SORGU
--Çalışanların ad ve soyadlarını birleştirerek tam isimlerini listeleyin.

SELECT
    e.FirstName +' '+e.LastName AS [AdSoyad]
FROM Employees e

--4.SORGU
--Stok miktarı 10'dan az olan ürünleri listeleyin.

SELECT *
FROM Products p
WHERE p.UnitsInStock<10

--5.SORGU
--1998 yılında yapılan siparişleri listeleyin.

SELECT *
FROM Orders o
WHERE o.OrderDate = '1998'

--6.SORGU
--Her bir kategorideki ürün sayısını bulun.

SELECT
    c.CategoryName,
    COUNT(p.CategoryID) AS [Ürün Sayısı]
FROM Categories c
    JOIN Products p ON p.CategoryID=c.CategoryID
GROUP BY c.CategoryName

--7.SORGU
--En pahalı 5 ürünü fiyatlarıyla birlikte listeleyin.
SELECT TOP 5
    P.ProductName, P.UnitPrice
FROM Products p
ORDER BY P.UnitPrice DESC

--8.SORGU
--Her bir ülkedeki müşteri sayısını bulun ve müşteri sayısına göre azalan sırayla listeleyin.

SELECT c.Country,
    COUNT(C.CustomerID) AS [Müşteri Sayısı]
FROM Customers c
GROUP BY c.Country
ORDER BY [Müşteri Sayısı] DESC

--9.SORGU
--Nakliye ücreti 50'den fazla olan siparişleri listeleyin.
SELECT
    o.OrderID,
    o.Freight

FROM Orders o
WHERE o.Freight>50

--10.SORGU
--Her bir çalışanın toplam sipariş sayısını bulun.

SELECT
    e.EmployeeID,
    COUNT(o.OrderID) AS [SİPARİŞ SAYISI]
FROM Employees e
    JOIN Orders o ON o.EmployeeID=e.EmployeeID
    JOIN OrderDetails od ON o.OrderID=od.OrderID
GROUP BY e.EmployeeID
ORDER BY e.EmployeeID

    
      

















