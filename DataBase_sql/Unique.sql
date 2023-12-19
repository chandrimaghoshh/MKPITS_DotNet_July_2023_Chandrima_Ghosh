create table person(id int identity primary key,
first_name varchar(20) not null,
last_name varchar(20)not null,
email varchar(20)unique)
insert into person values('Chandrima','Ghosh','chandrima@gmail.com')
insert into person values('Pooja','Tambe','pooja@gmail.com')
insert into person values('Kareena','Likhar','karu@gmail.com')
insert into person values('Akash','Gautam','akashg@gmail.com')
select * from person

create table person1(id int identity primary key,
first_name varchar(20) not null,
last_name varchar(20)not null,
email varchar(20))
insert into person1 values('Chandrima','Ghosh','chandrima@gmail.com')
insert into person1 values('Pooja','Tambe','pooja@gmail.com')
insert into person1 values('Kareena','Likhar','akash@gmail.com')
insert into person1 values('Akash','Gautam','akashg@gmail.com')
select * from person1