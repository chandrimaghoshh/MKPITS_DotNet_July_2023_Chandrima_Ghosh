create table product(ProductId int,ProductName varchar(20),ProductPrice varchar(20),ProductQuantity varchar(20))

insert into product values(101,'Face Wash',250,10)
insert into product values(102,'Serum',595,2)
insert into product values(103,'Moisturizer',500,5)
insert into product values(104,'Sunscreen',400,4)
insert into product values(105,'EyeLinear',249,10)
insert into product values(106,'Foundation',450,5)
insert into product values(107,'Primer',300,2)
insert into product values(101,'Lipstick',500,10)

select * from product
select Top 60 PERCENT ProductName, ProductPrice from product order by ProductPrice
select Top 40 PERCENT ProductQuantity, ProductId from product order by ProductQuantity desc