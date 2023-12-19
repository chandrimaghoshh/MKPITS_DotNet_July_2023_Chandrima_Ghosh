create table product(Product_Id int Identity primary key, Product_Name varchar(20) not null,
unit_price dec(10,2)check(unit_price>0))
insert into product values('Mouse',120)
select * from product
delete from product where product_Id=5
drop table product

create table result1(RollNo int primary key,Marks int check(Marks > 0))
insert into result1 values(1,80)
insert into result1 values(2,50)
select * from result1

create table product1(id int identity primary key,Name varchar(20) not null,
unit_price dec(10)constraint c1 check(unit_price>0))
insert into product1 values('Keyboard',100)
insert into product1 values('Mouse',150)
select *  from product1

create table product2(id int identity primary key,
name varchar(20) not null,
unit_price dec(10,2)check(unit_price>0),
discount_price dec(10,2)check(discount_price>0),
check (discount_price<unit_price))
insert into product2 values('Pen',40,20)
insert into product2 values('Pencil',20,15)
insert into product2 values('Eraser',10,5)
select * from product2
delete from product2 where id=6

create table prod(id int identity primary key,
name varchar(20),
unit_price dec(10,2)check (unit_price>0),
discount_price dec(10,2)check (discount_price>0),
constraint valid_price check(discount_price<unit_price))
insert into prod values('Chocolate',200,50)
insert into prod values('Chips',50,10)
insert into prod values('Biscute',100,20)
select * from prod

create table Produs(id int identity primary key,
name varchar(20),
unit_price dec(10,2)check (unit_price>0),
discount_price dec(10,2)check (discount_price>0),
constraint valid check(discount_price<unit_price))
insert into Produs values('Chocolate',200,50)
insert into Produs values('Chips',50,10)
insert into Produs values('Biscute',100,20)
select * from Produs
alter table product2
add discount_price dec(20,2)
sp_help Produs

