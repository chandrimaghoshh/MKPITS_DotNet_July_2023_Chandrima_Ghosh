create table manager(mid int primary key, mname varchar(20)not null)

create table employee(empid int primary key,empname varchar(20)not null,mid int,
constraint fk foreign key (empid) references manager(mid))

select * from manager
select * from employee

insert into manager values(1,'Chandrima')
insert into manager values(2,'Akash')
delete from manager where mid=1
drop table manager

insert into employee values(1,'Pooja',2)
insert into employee values(2,'Kareena',1)
delete from employee where mid=2
drop table employee