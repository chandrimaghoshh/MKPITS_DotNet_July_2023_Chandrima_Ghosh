create table store(store_id int identity primary key,Name varchar(20)not null,Phone bigint,Email varchar(20),
Street varchar(50),City varchar(20),State varchar(20),Zipcode int)

insert into store values('Sbike',9096569768,'chandrima@gmail.com','Ram nagar','Nagpur','Maharashtra',440033)
insert into store values('Mbike',8007659320,'pooja@gmail.com','Medical square','Nagpur','Maharashtra',440001)
insert into store values('Dbike',9096230961,'karu@gmail.com','Pachpauli','Nagpur','Maharashtra',440020)
insert into store values('Tbike',7069532187,'akash@gmail.com','Wanadongri','Nagpur','Maharashtra',440103)

select * from store



create table staff1(staff_id int identity primary key,First_Name varchar(20),Last_Name varchar(20),
Email varchar(20),Phone bigint,Active tinyint,store_id int,Manager_id int,foreign key (store_id)references store(store_id) on delete cascade on update cascade,
foreign key (Manager_id)references staff1(staff_id) on delete no action on update no action)

insert into staff1 values('Chandrima','Ghosh','chand@gmail.com',9656874230,1,10,2)
insert into staff1 values('Chandrima','Ghosh','chand@gmail.com',9656874230,1,102,3)
insert into staff1 values('Chandrima','Ghosh','chand@gmail.com',9656874230,1,106,1)
select * from staff1
sp_help staff1
drop table staff1


