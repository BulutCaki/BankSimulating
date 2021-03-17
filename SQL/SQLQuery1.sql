
select * from [Order Details]
select * from Orders

select * from [Order Details] inner join Orders on [Order Details].OrderID=Orders.OrderID

select  EmployeeID ,SUM((UnitPrice-(UnitPrice*Discount))*Quantity) as "Kazanılan Miktar"
from [Order Details] inner join Orders 
on [Order Details].OrderID=Orders.OrderID
GROUP BY EmployeeID

select  ShipCountry ,SUM((UnitPrice-(UnitPrice*Discount))*Quantity) as "Kazanılan Miktar"
from [Order Details] inner join Orders 
on [Order Details].OrderID=Orders.OrderID
GROUP BY ShipCountry
ORDER BY [Kazanılan Miktar] DESc