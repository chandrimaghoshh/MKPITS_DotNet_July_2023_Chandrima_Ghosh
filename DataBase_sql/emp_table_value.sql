select * from employee

create function f1()

returns table
as
return(select * from employee)

select * from f1()