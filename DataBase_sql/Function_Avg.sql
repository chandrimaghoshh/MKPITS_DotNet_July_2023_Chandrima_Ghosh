create table employee(Name varchar(20),Occupation varchar(20),Working_Dates date,
Working_Hours int,salary int)

insert into employee values('Chandrima','Manager','2023-12-10',9,60000)
insert into employee values('Chandrima','Manager','2023-11-20',10,50000)
insert into employee values('Akash','Clerk','2023-12-18',8,30000)
insert into employee values('Kareena','Clerk','2023-10-11',9,40000)
select * from employee

select Working_Hours, avg(Working_Hours)as "Average"
from employee
group by Working_Hours

drop table employee