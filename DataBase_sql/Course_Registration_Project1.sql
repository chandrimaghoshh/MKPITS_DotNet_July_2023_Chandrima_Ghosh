create table TableNation(NationId int primary key, NationName varchar(500))
insert into TableNation values(1,'India'),(2,'United-Nation'),(3,'Nepal'),(4,'SriLanka')

create table TableState(StateId int primary key,StateName varchar(500),
NationId int Foreign key(NationId)references TableNation(NationId))
insert into TableState values(101,'Andhra Pradesh',1),
							 (102,'Punjab',1),
							 (103,'California',2),
							 (104,'Florida',2),
							 (105,'Koshi',3),
							 (106,'Bagmati',3),
							 (107,'Colombo',4),
							 (108,'Ratnapura',4)

create table TableCity(CityId int primary key, CityName varchar(500),
StateId int foreign key(StateId)references TableState(StateId))
insert into TableCity values(1001,'Visakhapatnam',101),
							(1002,'Vijayawada',101),
							(1003,'Guntur',101),
							(1004,'Amritsar',102),
							(1005,'Jalandhar',102),
							(1006,'Chandigarh',102),
							(1007,'Los Angeles',103),
							(1008,'San Jose',103),
							(1009,'San Diego',103),
							(1010,'Jacksonville',104),
							(1011,'Miami',104),
							(1012,'Tampa',104),
							(1013,'Damak',105),
							(1014,'Dharan',105),
							(1015,'Biratnagar',105),
							(1016,'Banepa',106),
							(1017,'Bharatpur',106),
							(1018,'Hetauda',106),
							(1019,'Grandpass',107),
							(1020,'Borella',107),
							(1021,'Pettah',107),
							(1022,'Balangoda',108),
							(1023,'Kolonna',108),
							(1024,'Panamure',108)

create table TableCourseRegDetail(CourseRegId int primary key identity,CategoryId int,
FullName varchar(1500),GenderId int)

create table TableRegAddress(RegAddressId int primary key identity,CourseRegId int foreign key(CourseRegId)
references TableCourseRegDetail(CourseRegId),NationId int foreign key(NationId)
references TableNation(NationId),StateId int foreign key(StateId)references TableState(StateId),
CityId int foreign key(CityId)references TableCity(CityId))

create table TableFeeDetail(FeeId int primary key identity,CourseRegId int foreign key(CourseRegId)
references TableCourseRegDetail(CourseRegId),TotalAmount Decimal,MinPer decimal,PiadAmount decimal,
BalAmount decimal,PaidDate datetime)

select * from TableNation
select * from TableState
select * from TableCity
select * from TableCourseRegDetail
select * from TableRegAddress
select * from TableFeeDetail
