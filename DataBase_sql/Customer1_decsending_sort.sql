create table customer1(CustomerId int, CustomerName varchar(20),CustomerAddress varchar(50))

insert into customer1 values(1,'Chandrima','Ram Nagar, Nagpur')
insert into customer1 values(2,'Pooja','Medical Chouwk, Nagpur')
insert into customer1 values(3,'Kareena','Pachpauli, Nagpur')
insert into customer1 values(4,'Akash','Wanadongri, Nagpur')
insert into customer1 values(5,'Lucky','Indora Chouwk, Nagpur')
insert into customer1 values(6,'Sarang','Kamal Chouwk, Nagpur')
insert into customer1 values(7,'Ashwin','Hudkeshwar, Nagpur')
insert into customer1 values(8,'David','Chapdu Nagar, Nagpur')
insert into customer1 values(9,'Ayushree','Ajani, Nagpur')
insert into customer1 values(10,'Ayushi','Dutta wadi, Nagpur')

select * from customer1

select * from customer1 order by CustomerName
select * from customer1 order by CustomerName desc
select * from customer1 where CustomerName = 'Chandrima'
select * from customer1 where CustomerId = 1
select * from customer1 where CustomerId > 3
select * from customer1 where CustomerId > 0 and CustomerId<66