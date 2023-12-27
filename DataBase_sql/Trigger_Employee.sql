select *  from employee

create table emplog(logId int identity not null,empId int not null,
operation nvarchar(10)not null,updatedDate datetime not null)

create trigger empt
on employee

for insert
as
insert into emplog(EmpID,Operation,UpdatedDate)
select empid,'insert',GETDATE() from inserted; 

insert into employee values(11,'amit')
select * from employee
select * from emplog


insert into employee values(12,'amita')
select * from employee
select * from emplog