select * from orders
select * from customer

select ord_id,ordate,cust_id
from orders
where cust_id in(select cust_id from customer
where city='nagpur')
select * from orders
