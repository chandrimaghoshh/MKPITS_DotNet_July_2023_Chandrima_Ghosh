create table Department(Dep_Id int primary key,Dep_Name varchar(20),Maneger_Id int,Location_Id int)

insert into Department values(10,'Machenical',101,1100)
insert into Department values(20,'Electronics',102,1200)
insert into Department values(30,'Civil',103,1500)
insert into Department values(40,'IT',104,1600)
insert into Department values(50,'Computer Science',105,1700)
insert into Department values(60,'Human resource',106,1180)
insert into Department values(70,'Finance',107,1650)
insert into Department values(80,'Manufacturing',108,1430)
insert into Department values(90,'Construction',109,1121)
insert into Department values(100,'Sales',110,1101)
select * from Department

create table Employee(Emp_Id int,FName varchar(20),LName varchar(20),Email varchar(20),
Phone_No bigint,Hire_Date date,Job_Id int,Salary int,Comission_Pct decimal,Manager_Id int,Dep_Id int)

 insert into Employee values(100,'Steven','King','SKING@gmail.com',9568723041,'2003-06-17',1,24000,
0.00,101,10)
insert into Employee values(110,'Elle','Thoms','Elle@gmail.com',9568720361,'2003-02-12',2,34000,
0.00,102,20)
insert into Employee values(120,'Lees','kevis','kevis@gmail.com',8068720444,'2003-05-10',3,35000,
0.00,103,30)
insert into Employee values(130,'Karla','Sins','karla@gmail.com',9568720361,'2003-02-12',4,40000,
0.00,104,40)
insert into Employee values(140,'Thomas','King','thomas@gmail.com',9568720361,'2003-02-12',5,42000,
0.00,105,50)
insert into Employee values(150,'Stroo','Sen','sen@gmail.com',9568720361,'2003-02-12',6,50000,
0.00,106,60)
select * from Department
select * from Employee

select Employee.FName,Employee.LName,Department.Dep_Id,Dep_Name
from Employee
inner join Department
on Employee.Dep_Id = Department.Dep_Id