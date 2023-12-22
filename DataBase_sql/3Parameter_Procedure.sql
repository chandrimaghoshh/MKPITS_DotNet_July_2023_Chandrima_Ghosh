create proc prod8(@minp as decimal,@maxp as decimal,@pn as varchar(max))
as
begin
select * from product
where list_price > @minp and list_price < @maxp
and product_name=@pn
order by product_name
end;

exec prod8 @minp=20,@maxp=400,@pn='Engine oil'

-----------------------------------------------------------
create proc prod9(@minp as decimal,@maxp as decimal,@pn as varchar(max))
as
begin
select * from product
where list_price > @minp and list_price < @maxp
and product_name LIKE '%' + @pn + '%'

order by product_name
end;

exec prod9 @minp=120,@maxp=500,@pn='Plate'
exec prod9 @minp=400,@maxp=1200,@pn='Engine oil'
