
create table course(course_id int, course_name varchar(20),fees int,duration varchar(20))

insert into course values(1,'Dotnet',80000,'6 months')
insert into course values(2,'Java',75000,'6 months')
insert into course values(3,'Dotnet',80000,'6 months')
insert into course values(4,'Php',70000,'6 months')
insert into course values(5,'Java',70000,'6 months')
insert into course values(6,'Dotnet',75000,'6 months')
insert into course values(7,'Java',75000,'6 months')
insert into course values(8,'Dotnet',80000,'6 months')
select * from course

select course_id,course_name,fees,duration
from course
where course_id in(select course_id from course where course_name='Dotnet')

select course_id,course_name,fees,duration
from course
where course_id in (select course_id from course where course_name='Java')

select course_id,course_name,fees,duration
from course
where course_id in (select course_id from course where course_name='Php')