select * from product
create proc pro1(@minprice as decimal)
as
begin
select * from product
where list_price > @minprice
order by list_price
end

exec pro1 1100
-----------------------------
create proc proddet(@pid as int)
as
begin
select * from product
where product_id > @pid
end

exec proddet 1
-----------------------------
