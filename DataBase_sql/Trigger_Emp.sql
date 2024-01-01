select * from employee

create table EmpLog(EmpName nvarchar(50)not null,
operation nvarchar(50),UpdatedDate Datetime not null)

create trigger emp1
on employee
for insert
as
insert into EmpLog(EmpName,operation,UpdatedDate)
select Name,'insert',GETDATE() from inserted; 

insert into employee values('Pooja','Manager','2023-12-15',8,60000)
select * from employee
select * from EmpLog