select * from Employee

create table Job_Grade(Job_Grade varchar(10),Lowest_Sal int,Highest_Sal int)

insert into Job_Grade values('A',40000,80000)
insert into Job_Grade values('B',20000,60000)
insert into Job_Grade values('C',30000,50000)
insert into Job_Grade values('D',10000,70000)
insert into Job_Grade values('E',10000,20000)
insert into Job_Grade values('F',40000,90000)xf5
select * from Job_Grade

select E.FName,E.LName,E.Salary,J.Job_Grade
From Employee E
inner join Job_Grade J
on E.Salary between J.Lowest_Sal and J.Highest_Sal