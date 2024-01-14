create table stores(store_id int identity primary key,Name varchar(20)not null,Phone bigint,Email varchar(20),
Street varchar(50),City varchar(20),State varchar(20),Zipcode int)
insert into stores values('Sbike',9096569768,'chandrima@gmail.com','Ram nagar','Nagpur','Maharashtra',440033)
insert into stores values('Mbike',8007659320,'pooja@gmail.com','Medical square','Nagpur','Maharashtra',440001)
insert into stores values('Dbike',9096230961,'karu@gmail.com','Pachpauli','Nagpur','Maharashtra',440020)
insert into stores values('Tbike',7069532187,'akash@gmail.com','Wanadongri','Nagpur','Maharashtra',440103)
select * from stores

create table staffs(staff_id int identity primary key,First_Name varchar(20),Last_Name varchar(20),
Email varchar(20),Phone bigint,Active tinyint,store_id int,Manager_id int,foreign key (store_id)
references store(store_id) on delete cascade on update cascade)
insert into staffs values('Chandrima','Ghosh','chand@gmail.com',9656874230,1,1,1)
insert into staffs values('Chandrima','Ghosh','chand@gmail.com',9656874230,1,2,3)
insert into staffs values('Chandrima','Ghosh','chand@gmail.com',9656874230,1,3,2)
select * from staffs

create table categores(category_id int identity primary key,
category_Name varchar(50)not null)
insert into categores values('Electric bike')
insert into categores values('Children bike')
insert into categores values('Comfort bike')
select * from categores

create table brands(b_id int identity primary key,
b_Name varchar(20)not null)
insert into brands values('Hero')
insert into brands values('Heller')
insert into brands values('Electra')
select * from brands

create table product(product_id int identity primary key,product_name varchar(50),
brand_id int not null,category_id int not null,model_yr int not null,
list_price decimal(10,2)not null,foreign key (category_id)references categories(category_id)
on delete cascade on update cascade,
foreign key (brand_id) references brands (b_id) 
on delete cascade on update cascade)
insert into product values('Front wheel',1,1,2022,500)
insert into product values('Engine oil',2,2,2023,50)
insert into product values('Number Plate',3,3,2023,100)
select * from product

create table customers(cust_id int identity(1,1)primary key,
fname varchar(20)not null,lname varchar(20)not null,
phone varchar(20)not null,email varchar(20)not null,
street varchar(50)not null,city varchar(20)not null,
state varchar(20)not null,pincode varchar(20)not null)
insert into customers values(''sarangi','9045679870','sarang@gmail.com','kamal sq','nagpur',
'mah','123')
insert into stores values('lucky',apati','9045679870','sarang@gmail.com','kamal sq','nagpur',
'mah','123')


