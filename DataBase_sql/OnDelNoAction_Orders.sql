create table orders(id int primary key,name varchar (20)not null)

create table order_details(or_id int primary key,name varchar (20)not null,rate int,id int,
constraint fk foreign key (id) references orders(id) on delete cascade)

select * from orders
select * from order_details

insert into orders values(101,'Pen')
insert into orders values(102,'Pencil')
insert into orders values(103,'Eraser')
delete from orders where id=101
insert into order_details values(101,'refil',10,102)
insert into order_details values(102,'graphite',5,101)
insert into order_details values(103,'rase',4,103)
delete from order_details where id=101

drop table orders
drop table order_details


