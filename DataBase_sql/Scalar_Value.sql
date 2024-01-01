select * from employee

create function fun_emp(@EmpName nvarchar(50),@EmpOccupation nvarchar(50))

returns nvarchar(100)
as
begin return (select @EmpName + ' ' +@EmpOccupation + ' ')
end

select 
dbo.fun_emp(Name,Occupation) as 'Details' from employee