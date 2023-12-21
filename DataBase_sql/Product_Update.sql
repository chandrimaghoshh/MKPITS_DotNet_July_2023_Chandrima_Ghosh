select * from product

update product set list_price=1000
where product_name='Engine oil'

update product set list_price=500
where product_name='Number Plate' and list_price='250'

delete from product where product_name='Front wheel'