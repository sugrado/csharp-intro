--Select
--ANSII
Select ContactName Adi, CompanyName Sirket, City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
sElEcT * from Products where CategoryID=1 or CategoryID=3


select * from Products where CategoryID=1 and UnitPrice>=10

--sort
select * from Products order by CategoryID, ProductName

--ascending (default)
select * from Products order by UnitPrice asc

--descending
select * from Products order by UnitPrice desc

select * from Products where categoryid=1 order by UnitPrice desc


select count(*) from Products --sayac

select count(*) Piece from Products where CategoryID = 2

select CategoryID, count(*) from Products group by CategoryID having count(*)<10

select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select * 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO (Data Transformation Project)

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

select*from Customers c left join orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID