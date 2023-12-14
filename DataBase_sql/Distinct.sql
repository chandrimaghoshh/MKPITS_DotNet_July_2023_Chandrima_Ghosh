create table student(RollNo int, Name varchar(20),Course varchar(20), City varchar(20))

insert into student values(1,'Chandrima','DotNet','Nagpur')
insert into student values(2,'Pooja','DotNet','MP')
insert into student values(3,'Kareena','DotNet','Nagpur')
insert into student values(4,'Akash','Java','MP')
insert into student values(5,'Sarang','Java','MP')
insert into student values(6,'Lucky','DotNet','Nagpur')

select * from student
select distinct City from student