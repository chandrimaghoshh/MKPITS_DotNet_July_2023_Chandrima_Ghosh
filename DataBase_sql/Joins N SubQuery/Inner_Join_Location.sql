select * from Department
select * from Employee

create table Location(Location_Id int,Street_Address varchar(20),Postal_Code int,
City varchar(20),State varchar(20),Country_Id varchar(20))

insert  into Location values(1100,'Via Cola di Rie',989,'Roma','Tokyo','IT')
insert  into Location values(1200,'Colle della Tesa',980,'Tex','Texsa','IT')
insert  into Location values(1300,'Murtenstrasse',981,'wash','Washington','US')
insert  into Location values(1400,'Mariano Escobedo',982,'franch','Francesco','US')
insert  into Location values(1500,'Clementi North',909,'white','Whitehouse','US')
insert  into Location values(1600,' Rua Frei Caneca',919,'ox','oxford','IT')
select * from Location

select E.FName,E.LName,
D.Dep_Name,L.City,L.State
From Employee E
inner join Department D
on E.Dep_Id = D.Dep_Id
inner join Location L
on L.Location_Id = D.Location_Id