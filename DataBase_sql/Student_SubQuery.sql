create table student(Rollno int primary key,Name varchar(20)not null,
Email varchar(20),City varchar(20)not null,Course_Id int)

insert into student values(1,'Chandrima','chandrima@gmail.com','Nagpur',101)
insert into student values(2,'Pooja','pooja@gmail.com','MP',102)
insert into student values(3,'Kareena','karu@gmail.com','Nagpur',103)
insert into student values(4,'Akash','akash@gmail.com','Bhopal',104)
insert into student values(5,'Sarang','ranga@gmail.com','Nagpur',105)
insert into student values(6,'Lucky','tambe@gmail.com','Bhopal',106)
insert into student values(7,'David','david@gmail.com','Nagpur',107)
insert into student values(8,'Ayushree','ayuu@gmail.com','MP',108)
insert into student values(9,'Ashwin','ashwin@gmail.com','Nagpur',109)
insert into student values(10,'Payal','payal@gmail.com','Bhoapl',110)
select * from student

create table Fees(Fees_id int,Rollno int,Fees_Date varchar(20),
Amount int,Course_Id int(20))
insert into Fees values(100,1,'2023-07-14',75000,101)
insert into Fees values(200,2,'2023-07-14',65000,102)
insert into Fees values(300,3,'2023-07-14',70000,103)
insert into Fees values(400,4,'2023-07-14',80000,104)
insert into Fees values(500,5,'2023-07-14',75000,105)
select * from Fees

select Fees_id,Rollno,Fees_Date,Amount,Course_Id
from Fees where Rollno in
(select Rollno from student where City='Nagpur')

select Fees_id,Rollno,Fees_Date,Amount,Course_Id
from Fees where Rollno in 
(select Rollno from student where City='Bhopal')
drop table Fees

