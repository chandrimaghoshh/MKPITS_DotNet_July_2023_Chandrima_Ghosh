create table student(RollNo int, FirstName varchar(20),LastName varchar(20),State varchar(20))

insert into student values(1,'Chandrima','Ghosh','Maharashtra')
insert into student values(2,'Pooja','Tambe','Maharashtra')
insert into student values(3,'Akash','Gautam','Madhya Pradesh')
insert into student values(4,'Kareena','Likhar','Maharashtra')
insert into student values(5,'Chandrima','Ghosh','Kolkata')
insert into student values(6,'Yash','Kumbhalkar','Maharashtra')
insert into student values(7,'Sarang','Prajapati','Madhya Pradesh')

select * from student where FirstName = 'Chandrima' and LastName = 'Ghosh'
select * from student order by LastName
select * from student order by FirstName
select * from student where state = 'Maharashtra'
select * from student where state='Madhya Pradesh' order by FirstName desc