create table salesman1(Id int, Name varchar(20),City varchar(20),Comission float)

insert into salesman1 values(5001,'Chandrima','Nagpur',0.15)
insert into salesman1 values(5002,'Pooja','Nagpur',0.13)
insert into salesman1 values(5003,'Akash','MP',0.11)
insert into salesman1 values(5004,'Kareena','Indore',0.14)
insert into salesman1 values(5005,'Sarang','Nagpur',0.15)
insert into salesman1 values(5006,'Lucky','Bhopal',0.13)

select * from salesman1
select Name, City from salesman1 where City='Bhopal'