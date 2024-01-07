CREATE TABLE student
(rollNumber INT, 
name VARCHAR(30), 
class VARCHAR(30), 
section VARCHAR(1), 
mobile VARCHAR(10),
PRIMARY KEY (rollNumber, mobile));

insert into student values(1,'amit','dotnet','i','1234567890')
insert into student values(1,'amit','dotnet','i','1234567891')

select * from student