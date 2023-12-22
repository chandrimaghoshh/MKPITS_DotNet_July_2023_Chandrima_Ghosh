select * from product

alter procedure prod2
as
begin
select product_name,list_price from product
order by list_price 
end
exec prod2

alter proc prod3
	as
	begin 
	insert into product values('sport1',1,1,'2023',1200)
	select * from product
	end

exec prod3