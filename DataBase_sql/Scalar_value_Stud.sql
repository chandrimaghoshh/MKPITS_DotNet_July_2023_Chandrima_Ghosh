create table student(RollNo int,M1 int, M2 int)

insert into student values(1,95,85)
insert into student values(1,90,85)
insert into student values(1,70,77)
insert into student values(1,90,65)

select * from student

create function fun_stud
(@StudRollNo int,@StudM1 int,@StudM2 int)
returns int
as begin
return(select @StudM1 + @StudM2 * 0.2)
end

select
dbo.fun_stud(RollNo,M1,M2)as 'Percentage' from student
