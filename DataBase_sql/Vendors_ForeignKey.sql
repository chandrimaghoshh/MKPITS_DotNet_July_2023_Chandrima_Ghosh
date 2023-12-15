create table vendor_groups(group_Id int identity primary key,group_Name varchar(20) not null)

create table vendors(vendors_Id int identity primary key not null,vendors_Name varchar(100) not null,
group_Id int not null,constraint fk_group foreign key(group_id) references vendor_groups(group_Id))

select * from vendor_groups
insert into vendors(vendors_Name,group_Id)values('Amit',123)
insert into vendor_groups values('Mkpits')

select * from vendor_groups
insert into vendors values('amit',1)
select * from vendors
insert into vendors values('arjun',2)
insert into vendor_groups values('niit')
select * from vendor_groups
insert into vendors values('arjun',2)
select * from vendors
insert into vendors values('arpita',2)
select * from vendors