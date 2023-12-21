create table Student(id int identity primary key,
admission_no varchar(50)not null,
first_name varchar(20)not null,
last_name varchar(20)not null,
age int,city varchar(20)not null)

create table Fees(admission_no varchar(50)not null,
course varchar(50)not null,amount_paid int)

insert into Student values('12345','Chandrima','Ghosh',21,'Nagpur')
insert into Student values('12243','Pooja','Tambe',30,'Nagpur')
insert into Student values('11023','Kareena','Likhar',21,'Nagpur')
insert into Student values('14830','Akash','Gautam',21,'Nagpur')
insert into Student values('12540','Yash','Kumbhalkar',20,'Nagpur')
select * from Student

insert into Fees values(12345,'Dotnet',80000)
insert into Fees values(12540,'Java',75000)
insert into Fees values(14830,'Dotnet',60000)
select * from Student
select * from Fees

select Student.admission_no,Student.first_name,Student.last_name,Fees.course,Fees.amount_paid
from Student
inner join Fees
on Student.admission_no=Fees.admission_no
