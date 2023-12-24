create table customers(id int, name varchar(20),phone bigint)

insert into customers values(1,'Chandrima','9096569768')
insert into customers values(2,'Akash','9884539709')
insert into customers values(3,'Pooja','8004565201')
insert into customers values(4,'Kareena','9563428720')
select * from customers

create table orders(ord_id int,ord_date varchar(20),id int,prd_name varchar(20),qty int,rate int)
insert into orders values(1,'20-11-2023',1,'pen',10,20)
insert into orders values(2,'10-11-2023',3,'pencil',20,20)
insert into orders values(3,'25-11-2023',2,'eraser',5,10)
select * from customers
select * from orders

select customers.id,customers.name,customers.phone,orders.ord_id,orders.ord_date,orders.prd_name,
orders.qty,orders.rate
from customers
inner join orders
on customers.id=orders.id 
