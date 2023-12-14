create table orders2(OrderID int, PurchaseAmt float, OrderDate date, CustomerId int, SalesmanId int)

insert into orders2 values(70001, 150.5, '2012-10-05', 3005, 5002)
insert into orders2 values(70009, 270.65, '2012-09-10', 3001, 5005)
insert into orders2 values(70002, 65.26, '2012-10-05', 3002, 5001)
insert into orders2 values(70004, 110.5, '2012-08-17', 3009, 5003)
insert into orders2 values(70007, 948.5, '2012-09-10', 3005, 5002)

select * from orders2

select OrderDate, salesmanId,OrderId,PurchaseAmt from orders 