create table orders1(orderId int primary key, orderDate date,CustId int )

create table orderDetails(orderId int, productName varchar(20), Quantity int, constraint fk1 foreign key (orderId)
references orders1 (orderId))

insert into orders1 values(1,'2009/12/10',101)
insert into orders1 values(2,'2009/11/9',102)
select * from orders1

insert into orderDetails values(1,'Keyboard',5)
insert into orderDetails values(1,'Mouse',10)
insert into orderDetails values(1,'CPU',2)
select * from orderDetails

delete from orderDetails where orderId=2
delete from orders1 where orderId=2
delete from orderdetails where orderid=2
delete from orders1 where orderId=2
select * from orderDetails
select * from orders1