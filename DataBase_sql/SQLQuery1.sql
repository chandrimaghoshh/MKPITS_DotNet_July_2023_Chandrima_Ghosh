create table sample(id int)
create table student(rno int, name varchar(20))
insert into student values(1,'Chandrima')
select * from student
insert into student values(2, 'Pooja')
select * from student

create  table product(productid int, productName varchar(20),productPrice int,productQuantity int)

insert into product values(101,'Laptop',50000,1)
select * from product

insert into product values(102,'Keyboard',1000,2)
select * from product

insert into product values(103,'Mouse',500,2)
select * from product

create table customer(CustomerId int primary key, CustomerName varchar(20))
insert into customer values(10, 'Chandrima')
select * from customer

insert into  customer values(20,'Pooja')
select * from customer
