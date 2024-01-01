select * from product

create function f_product()

returns table
as
return(select * from product)

select * from f_product()