create table Mkcount(RollNo int, Name varchar(20),Course varchar(20),City varchar(20))

insert into Mkcount values(1,'Chandrima','DotNet','Nagpur')
insert into Mkcount values(2,'Pooja','DotNet','Nagpur')
insert into Mkcount values(3,'Akash','DotNet','Mp')
insert into Mkcount values(4,'Kareena','Java','Mp')
insert into Mkcount values(5,'Sarang','Java','Nagpur')
insert into Mkcount values(6,'Lucky','Php','Nagpur')

select * from Mkcount
select City, count(*) from MkCount where Course = 'Java' group by City
select Course, count(*) from MkCount where City = 'Mp' group by Course