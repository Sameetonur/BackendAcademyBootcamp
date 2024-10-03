USE Northwind

--1.SORGU
--Hiç sipariş vermemiş müşterileri listeleyin.
SELECT
    c.CustomerID
FROM Customers c
    JOIN Orders o ON o.CustomerID=c.CustomerID
WHERE o.OrderID =NULL

--2.SORGU
--Her bir ürün için, o ürünü sipariş eden benzersiz müşteri sayısını bulun.
SELECT
    p.ProductName AS [ÜRÜNLER],
    COUNT(DISTINCT o.CustomerID) AS [Benzersiz müşteri sayısı]
FROM Products p
    JOIN OrderDetails od ON p.ProductID = od.ProductID
    JOIN Orders o ON O.OrderID=od.OrderID
GROUP BY P.ProductName

--3.SORGU
--Çalışanların yöneticilerini (FirstName ve LastName) listeleyin. Yöneticisi olmayan çalışanlar da listelenmelidir. 

--4.SORGU
--Her bir tedarikçinin sağladığı ürünlerin ortalama fiyatını hesaplayın, ancak sadece 10'dan fazla ürün sağlayan tedarikçileri listeleyin.
SELECT
    sp.CompanyName,
    AVG(p.UnitPrice) AS [ortalama Fiyatı],
    COUNT(p.ProductID) AS [Tedarik Ürün Sayısı]

FROM Suppliers sp
    JOIN Products p ON p.SupplierID = sp.SupplierID
GROUP BY sp.CompanyName

--5.SORGU
--En az 3 farklı kategoriden ürün sipariş etmiş müşterileri bulun.
SELECT
    ct.CustomerID,
    COUNT(DISTINCT o.OrderID) AS [Ürün Sayısı]
FROM Categories c
    JOIN Products p ON P.CategoryID=C.CategoryID
    JOIN OrderDetails OD ON OD.ProductID=P.ProductID
    JOIN Orders O ON O.OrderID=OD.OrderID
    JOIN Customers ct on ct.CustomerID=o.CustomerID
GROUP BY CT.CustomerID
HAVING COUNT(DISTINCT o.OrderID) =3

--6.SORGU
--Her bir çalışanın sorumlu olduğu bölgedeki (Territory) toplam satış miktarını hesaplayın.

SELECT
    e.FirstName +' '+e.LastName AS [Çalışan AdSoyad] ,
    T.TerritoryID AS [Sorumlu Bölgesi],
    SUM(Quantity) AS [TOPLAM SATIŞ MİK]
FROM Employees e
    JOIN Orders o ON O.EmployeeID = e.EmployeeID
    JOIN OrderDetails od ON OD.OrderID=O.OrderID
    JOIN EmployeeTerritories et ON ET.EmployeeID=E.EmployeeID
    JOIN Territories t on t.TerritoryID=et.TerritoryID
GROUP BY E.EmployeeID,E.FirstName,E.LastName,T.TerritoryID
--7.SORGU
--1997 yılının en yüksek cirolu ayını bulun.
SELECT top 1
    YEAR(o.OrderDate) AS [YIL],
    MONTH(o.OrderDate) AS [AY],
    SUM(od.Quantity*od.UnitPrice) AS [ciro]
FROM orders o
    JOIN OrderDetails od ON od.OrderID=o.OrderID
WHERE YEAR(o.OrderDate)=1997
GROUP BY YEAR(o.OrderDate),MONTH(o.OrderDate)
ORDER BY SUM(od.Quantity*od.UnitPrice) DESC

--8.SORGU
--Siparişlerin ortalama teslimat süresini (ShippedDate - OrderDate) hesaplayın ve bu ortalamadan daha uzun sürede teslim edilen siparişleri listeleyin.

                




