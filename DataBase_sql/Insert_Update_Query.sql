select * from product
--insert Query
create proc pro5(@pid as int,@pn as varchar(20),
@bid as int,@cid as int,@my as int,@p as int)
as 
begin
insert into product values(@pid,@pn,@bid,@cid,@my,@p);
end

exec pro5 2,'Number Plate',3,3,2023,600
-------------------------------------------------
--Update Query
create proc sp_inprod2(@pid as int,@pn as varchar(20),
@pr as decimal)
as 
begin
update product set product_name=@pn,list_price=@pr
where product_id=@pid
end

exec sp_inprod2 23,'Engine oil',1000,4
select * from product