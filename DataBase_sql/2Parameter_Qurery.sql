select * from product

create proc pro2(@pname as varchar(20),@p as decimal)
as
begin
select * from product 
where product_name=@pname
and list_price>=@p
order by product_name
end

exec pro2 'Front wheel',100
exec pro2 'Engine oil',10