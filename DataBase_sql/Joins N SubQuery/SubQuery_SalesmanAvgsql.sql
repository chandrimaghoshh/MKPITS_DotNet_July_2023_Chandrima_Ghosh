select * from Salesman
select * from orders

SELECT *
FROM orders
WHERE PurchaseAmt >
    (SELECT  AVG(PurchaseAmt) 
     FROM orders 
     WHERE OrderDate='2012-08-17');