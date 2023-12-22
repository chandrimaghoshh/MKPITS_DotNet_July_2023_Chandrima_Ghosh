select * from product

create procedure prod1
as
begin
select * from product
end

exec prod1

create procedure prod2
as
begin
select * from product where model_yr='2023'
end

exec prod2
select * from order_items
create procedure prod3
as
begin
select product_id,list_price
from order_items
order by
product_id
end
exec prod3
