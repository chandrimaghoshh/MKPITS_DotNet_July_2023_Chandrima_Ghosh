create table Employee(EmpId int primary key identity(1,1),EmpName varchar(20))

insert into Employee (EmpName)values('Chandrima')
insert into Employee (EmpName)values('Pooja')
insert into Employee (EmpName)values('Akash')

select*from Employee

delete from Employee where EmpId=2

