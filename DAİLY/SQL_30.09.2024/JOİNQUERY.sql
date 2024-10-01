 






 --- her bir comnynin  toplamda kaç sparişi var

 SELECT
   sp.CompanyName, COUNT(*)

  FROM Suppliers sp 
    JOIN  Products p on sp.SupplierID=p.SupplierID
        JOIN OrderDetails od ON od.ProductID = p.ProductID
            JOIN Orders o ON od.OrderID = o.OrderID
            GROUP BY sp.CompanyName
