-- SELECT CategoryName, Description FROM Categories

-- SELECT 
--     p.ProductID AS Id,
--     p.ProductName [Ürün Adı],
--     P.UnitsInStock [Stok Adedi] ,
--     p.UnitPrice AS 'Birim Fiyat'
    
-- FROM Products p

--En Yüksek Fiyatı Bulalım

-- SELECT 
--     MAX(P.UnitPrice) [En Yüksek Fiyat],
--     MIN(P.UnitPrice) [En Düşük Fiyat],
--     AVG(P.UnitPrice) [Fiyat Ortalaması],
--     COUNT(*) [Ürün Sayısı],
--     SUM(p.UnitPrice * p.UnitsInStock) [Toplam Değer]
-- FROM Products p

--Tüm Ürünler
-- SELECT
--     p.ProductName [Default],
--     UPPER(p.ProductName) [BÜYÜK HARF],
--     LOWER(p.ProductName) [Küçük Harf],
--     LOWER(REPLACE(REPLACE(p.ProductName,' ','_'),'?',''))   [URL]
-- FROM Products p

-- 40TL DEN BÜYÜK ÜRÜNLERİ LİST

-- SELECT
--     p.UnitPrice
-- FROM Products p 
-- WHERE p.UnitPrice>40;

--40TL İLE 100TL ARASI FİYAT
-- SELECT
-- *
-- FROM Products p
-- WHERE p.UnitPrice >= 40 AND P.UnitPrice <=100
-- --WHERE p.UnitPrice  BETWEEN 40 AND 100 --(OTOMATİK 40BÜYÜK EŞİT 100BKÜÇÜK EŞİT ALIR!!)
-- --ORDER BY p.ProductName ASC --Küçükten büyüğe --DESC Büyükten Küçüğe
-- ORDER BY p.CategoryID, p.UnitPrice DESC

--JOİN= SQL DE TABLOLARI İLİŞKİSEL ALANLAR ÜZERİNDEN BİRLEŞTİRME İŞLEMİNE JOİN DENİR.

-- (inner) Join : Birleştirilen iki tablodaki eşleşen kayıtları bir araya getirir.
-- left join: sol taraftaki tablonun tüm kayıtlarını sağ taraftaki tablonnun ise sadece eşleşen kayırlarını getirir.
-- right join: sağ taraftaki tablonun tüm kayıtlarını sol taraftaki tablonnun ise sadece eşleşen kayırlarını getirir.
-- outher (full) join: Birleştirilecek iki tablodaki eşleşen aa da eşleşmeyen tüm kayıtları bir araya getirir.

--ÖRNEK--
-- prodact ve categories tablosunun birleşmesini sağlayalım
-- SELECT 
--     p.ProductID [Id],
--     p.ProductName [Ürün],
--     p.UnitPrice [Fiyat],
--     c.CategoryName [Kategori]

-- FROM Products p 
-- JOIN Categories c 
-- ON p.CategoryID = c.CategoryID
--WHERE c.CategoryName = 'Beverages'

--Yeni Bir Kategori ekliyoruz
-- INSERT INTO Categories(CategoryName, Description)
-- VALUES ('Televizyon','Televizyon Ürünleri')

-- SELECT * 
-- FROM Categories c RIGHT JOIN  Products p ON p.CategoryID=c.CategoryID

-- ürünlerin  productıd , productname , uniteprice  Supplair CompanyNameleri ile birlikte listeleyelim

    -- SELECT 
    --     p.ProductID [ID],
    --     P.ProductName [Ürün],
    --     P.UnitPrice [Fiyat],
    --     s.CompanyName [Tedarikçi Şirket]

    -- FROM  Products p JOIN Supplairs s       
    --         ON  p.SupplierID = s.SupplierID 

    --                  JOIN Categories c
    --         ON p.CategoryID=c.CategoryID

    -- ORDER BY [Kategori],[Tedarikçi Şirket]
    

    ----aynısı
    -- SELECT 
    --         p.ProductID AS [Id],
    --         p.ProductName AS [Ürün],
    --         p.UnitPrice AS [Fiyat],
    --         s.CompanyName AS [Tedarikçi],
    --         c.CategoryName AS [Kategori]
            
    -- FROM Products p JOIN Suppliers s
    --     ON p.SupplierID=s.SupplierID 
    --                 JOIN Categories c 
    --     ON p.CategoryID = c.CategoryId
    -- ORDER BY [Kategori] [Tedarikçi]

--HANGİ SİPARİŞ HANGİ ÇALIŞAN TARAFINDAN HANGİ MÜŞTERİYE GERÇEKLEŞMİŞTİR
-- orderID,OrderDATE,Employee Name, Customer Name

-- SELECT 
--      ord.OrderID AS [Sipraiş No],
--      ord.OrderDate AS [Spariş Tarihi],
--      e.FirstName + ' ' + e.LastName AS [ÇALIŞAN],
--      c.CompanyName AS [Müşteri]
-- FROM Orders ord
-- JOIN Employees e ON ord.EmployeeID=e.EmployeeID
-- JOIN Customers  c ON ord.CustomerID = c.CustomerID

--KATEGORİYE GÖRE ÜRÜN STOCK ADETİNİ GÖSTERELİM

-- SELECT 
--     c.CategoryName AS [Kategori],
--     Sum(p.UnitsInStock) AS [STOCK ADETİ]
-- FROM Products p 
-- JOIN Categories c ON p.CategoryID = c.CategoryID
-- GROUP BY c.CategoryName 

--HANGİ ÜLKE KAÇ MÜŞTERİM VAR?

-- SELECT 
--     c.Country as [ÜLKE],
--     COUNT(*) AS [Müiteri Sayısı]
-- FROM Customers c
-- GROUP BY c.Country
-- ORDER BY [Müiteri Sayısı] DESC

--EN ÇOK HANGİ ÜLKEDE MÜŞTERİNİZ VARSA MÜŞERİ SAYISIYLA BİRLİKTE GÖSTERİN

-- SELECT
--     TOP (1)
--     c.Country as [ÜLKE],
--     COUNT(*) AS [Müiteri Sayısı]
-- FROM Customers c
-- GROUP BY c.Country
-- ORDER BY [Müiteri Sayısı] DESC

-- HANGİ KATEGORİDE KAÇ ADET ÜRÜNÜMÜZ VAR?

-- SELECT 
--     c.CategoryName as [Kategori],
--     COUNT(p.ProductID) AS [ADET]
-- FROM Products p
-- right JOIN  Categories c  ON c.CategoryID = p.CategoryID
-- GROUP BY c.CategoryName

--Hangi ülkeye ne kadarlık kargo harcaması yapmışız 
-- SELECT 
--     o.ShipCountry as [ülke],
--     SUM(o.Freight) as [Kargo Bedeli]
-- FROM Orders o
-- GROUP BY o.ShipCountry

--hangi ülkeye ne kadarlık satış yapmışız

-- SELECT 
--    o.ShipCountry as [ülke],
--    SUM(od.Quantity* od.UnitPrice*(1-od.Discount)) as [Toplam satış]

-- FROM Orders o JOIN OrderDetails od ON o.OrderID = od.OrderID
-- GROUP BY o.ShipCountry
-- ORDER BY [Toplam satış] DESC

--TUTAR KOLONUNDA GÖRÜNTÜLENEN SATYININ 18.15168,5 ŞEKLİNDE GÖRÜNMESİ İÇİN NE YAPMALIYIZ ?

--Germany'den tedarik ettiğimiz ürünleri toplam satış tutarını bulunuz

-- SELECT
--         SUM(od.UnitPrice*.od.Quantity*(1-od.Discount))

-- FROM OrderDetails od 
-- JOIN Products p ON od.ProductID =p.ProductID
-- JOIN Suppliers s ON  p.SupplierID = s.SupplierID

-- WHERE s.Country ='Germany'

--Germany'den tedarik ettiğimiz ürünleri toplam satış tutarını bulunuz kategorilere göre listeleyelim

-- SELECT
--         c.CategoryName as [Kategori],
--         SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) as [Tutar]

-- FROM OrderDetails od 
-- JOIN Products p ON od.ProductID =p.ProductID
-- JOIN Suppliers s ON  p.SupplierID = s.SupplierID
-- JOIN Categories c ON p.CategoryID = c.CategoryID
-- WHERE s.Country ='Germany'
-- GROUP BY c.CategoryName
-- HAVING  SUM(od.UnitPrice*od.Quantity*(1-od.Discount))>20000
-- ORDER BY [Tutar] DESC

-- BÖLGELERE GÖRE SATIŞ TUTARI

-- SELECT 
--      rg.RegionDescription AS [Bölge],
--     FORMAT(SUM(ods.UnitPrice*ods.Quantity*(1-Discount)),'N2','tr-TR') AS [Tutar]

-- FROM OrderDetails ods
-- JOIN Orders o ON ods.OrderID=o.OrderID
-- JOIN Employees em ON  em.EmployeeID = o.EmployeeID
-- JOIN EmployeeTerritories emtr ON emtr.EmployeeID =em.EmployeeID
-- JOIN Territories trs ON  emtr.TerritoryID=trs.TerritoryID
-- JOIN Region rg ON  rg.RegionID = trs.RegionID
-- GROUP BY rg.RegionDescription

--HANGİ ÇALIŞANIN HANGİ KATEGORİDEN , NE KADARLIK SİPARİŞ YAPMIŞ

-- SELECT 
--     c.CategoryName AS [KATEGORİ],
--     e.FirstName as [ÇALIŞAN],
--      FORMAT(SUM(od.UnitPrice*od.Quantity*(1-Discount)),'N2','tr-TR') AS [Tutar]
-- FROM  Employees e 
-- JOIN Orders o ON e.EmployeeID = o.EmployeeID
-- JOIN OrderDetails od ON o.OrderID = od.OrderID
-- JOIN Products p ON od.ProductID = p.ProductID
-- JOIN Categories c ON p.CategoryID = c.CategoryID
-- GROUP BY c.CategoryName, e.FirstName
-- ORDER BY e.FirstName,c.CategoryName

------MÜŞTERİLİSİNİ ALICAM BURAYA




------------------------

--1997 YILININ MERT AYINDA YAPILAN SAYIŞLARI LİSTELEYELİM

-- SELECT * 
-- FROM Orders o 
-- WHERE o.OrderDate BETWEEN '1997-3-1'AND '1997-3-31'


----çay ürününü 1997 mart ayının yapılan satışları listeleyin

-- SELECT * 
-- FROM Orders o 
-- JOIN OrderDetails od ON o.OrderID = od.OrderID
--         JOIN Products p ON p.ProductID = od.ProductID
-- WHERE o.OrderDate BETWEEN '1997-3-1'AND '1997-3-31' AND p.ProductName 'Chai'<

-- TARİH KULLANIMI
-- SELECT *
-- FROM Employees e 
--     WHERE YEAR(e.BirthDate)>=1960

-- SELECT *
-- FROM Employees e
--     WHERE MONTH(GETDATE()) = MONTH(e.BirthDate)

--     --HER AYIN 8İ VE SONRASINDA İŞE BAŞLAYANLARIN LİSTESİ

--     SELECT * 
--     FROM Employees e 
--     WHERE DAY(e.HireDate)>=8











