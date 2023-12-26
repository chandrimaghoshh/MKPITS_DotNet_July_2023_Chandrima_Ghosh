select * from product
select product_name, min(list_price) As "Minimum price"
from product
group by product_name
having min(list_price)>50