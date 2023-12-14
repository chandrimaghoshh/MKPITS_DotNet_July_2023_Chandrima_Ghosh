create table customer(CustId int, CustName varchar(20), City varchar(20), Grade int, SalesmanId int)

insert into customer values(3001, 'Nick Rimando', 'New York', 100, 5001)
insert into customer values(3002, 'Nick Rimando', 'California', 200, 5002)
insert into customer values(3003, 'Mc Lyon', 'New York', 100, 5003)
insert into customer values(3004, ' Pit Alex', 'New York', 200, 5004)
insert into customer values(3005, 'Paul Adam', 'california', 100, 5005)
insert into customer values(3006, 'Lauson Hen', 'New York', 200, 5006)

select * from customer

select CustId, CustName, City, SalesmanId,Grade from customer where Grade=200