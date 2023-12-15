create table vendor_group(group_Id int identity primary key, group_Name varchar(20) not null)

create table vendors(vendors_Id int identity primary key not null,vendors_Name varchar(100) not null,
group_Id int not null)

select * from vendor_group

insert into vendors(vendors_Name, group_Id)values('Amit',123)

select * from vendors
