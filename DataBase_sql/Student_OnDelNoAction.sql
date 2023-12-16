create table student(rno int primary key,name varchar (20)not null,address varchar(50) not null)

create table fees(feesid int primary key,amount int,dates date,rno int
constraint fk1 foreign key (rno) references student(rno)on delete no action)

select * from student
select * from fees

insert into student values(1,'Chandrima','Ram Nagar, Nagpur')
insert into student values(2,'Akash','Wanadongri, Nagpur')
insert into student values(3,'Pooja','Medical chouwk, Nagpur')
delete from student where rno=1

insert into fees values(101,75000,'2023-07-12',2)
insert into fees values(102,65000,'2023-07-13',3)
insert into fees values(103,65000,'2023-07-14',1)
delete from fees where rno=1
drop table student
drop table fees


