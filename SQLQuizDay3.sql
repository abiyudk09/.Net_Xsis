create database Db__sales

use Db__sales

create table salesperson(
id int primary key identity(1,1),
Name varchar(122),
BOD date,
Salary Decimal(18,2)
)

insert into salesperson(
Name, BOD, Salary
)
values
('Abe','9/11/1988',140000),
('Bob','9/11/1978',44000),
('Chris','9/11/1983',40000),
('Dan','9/11/1980',52000),
('Ken','9/11/1977',115000),
('Joe','9/11/1990',38000)



create table Orders(
ID int primary key identity(1,1),
Order_Date date,
Cust_ID int,
SalesPerson_ID int,
Amount decimal(18,2)
)

insert into Orders(
Order_Date, Cust_ID,SalesPerson_ID,Amount)
values
('8/2/2020',4,2,540),
('1/22/2021',4,5,1800),
('7/14/2019',9,1,460),
('1/29/2018',7,2,2400),
('2/3/2021',6,4,600),
('3/2/2020',6,4,720),
('5/6/2021',9,4,150)

select * from salesperson
select * from Orders

--a
select s.Name, count(o.salesperson_id) as Total_Order
from salesperson s join Orders o on s.id = o.SalesPerson_ID
group by s.Name
Having count(o.salesperson_id) > 1

--b
select s.Name, sum(o.Amount) as Total_Amount
from salesperson s join Orders o on s.id = o.SalesPerson_ID
group by s.Name
Having sum(o.Amount) > 1000

--c
select s.Name,DATEDIFF(YEAR, s.BOD,GETDATE()) as Umur, Salary, sum(o.Amount) as Total_Amount
from salesperson s join Orders o on s.id = o.SalesPerson_ID
where year(Order_Date) >= 2020
group by s.Name, s.BOD, S.Salary
order by Umur 

--d
select s.Name, Avg(o.Amount) as Rata_Rata
from salesperson s join Orders o on s.id = o.SalesPerson_ID
group by s.Name
order by Rata_Rata desc

--e
select s.Salary, s.Name, sum(o.amount) 'Total Amount', count(o.salesperson_id) [Total Order],
case when sum(o.amount) > 1000 and count(o.salesperson_id) > 2
then s.Salary * 0.3 end as Bonus,
case when sum(o.amount) > 1000 and count(o.salesperson_id) > 2
then s.salary + (s.Salary * 0.3) 
else s.Salary end  as Total
from salesperson s left join Orders o on s.id = o.SalesPerson_ID
group by s.Name, s.Salary
order by [Total Order] desc
--having sum(o.amount) > 1000 and count(o.salesperson_id) > 2


--f
select s.Name
from salesperson s  left join Orders o on s.id = o.SalesPerson_ID
where o.Amount is null

--g
select s.Name, s.Salary, case
when count(o.salesperson_id) = 0
then s.Salary * 0.02 end as Potongan,
case when count(o.salesperson_id) = 0
then s.Salary -(s.Salary * 0.02) end as Gaji
from salesperson s left join Orders o on s.id = o.SalesPerson_ID
group by s.Name, s.Salary
having count(o.salesperson_id) = 0




