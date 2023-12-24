--left outer join
select * from customers

select customers.id,customers.name,customers.phone,orders.ord_id,orders.ord_date,orders.prd_name,
orders.qty,orders.rate
from customers
left outer join orders
on customers.id=orders.id 

--right outer join
select * from customers
select customers.id,customers.name,customers.phone,orders.ord_id,orders.ord_date,orders.prd_name,
orders.qty,orders.rate
from customers
right outer join orders
on customers.id=orders.id 

--full outer join
select * from customers
select customers.id,customers.name,customers.phone,orders.ord_id,orders.ord_date,orders.prd_name,
orders.qty,orders.rate
from customers
full outer join orders
on customers.id=orders.id 