select * from Salesman

create table orders(OrderID int, PurchaseAmt float, OrderDate date, CustomerId int, Id int)

insert into orders values(70001, 150.5, '2012-10-05', 3005, 5001)
insert into orders values(70009, 270.65, '2012-09-10', 3001, 5002)
insert into orders values(70002, 65.26, '2012-10-05', 3002, 5003)
insert into orders values(70004, 110.5, '2012-08-17', 3009, 5004)
insert into orders values(70007, 948.5, '2012-09-10', 3005, 5005)

select * from orders
SELECT *
FROM orders
WHERE Id in
    (SELECT Id
     FROM Salesman 
     WHERE name='Chandrima')