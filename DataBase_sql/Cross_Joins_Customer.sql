select * from customers

select customers.id,customers.name,customers.phone,orders.ord_id,orders.ord_date,orders.prd_name,
orders.qty,orders.rate
from customers
cross join orders
