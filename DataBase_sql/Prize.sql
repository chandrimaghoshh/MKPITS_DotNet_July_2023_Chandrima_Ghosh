create table prize(YEAR int, SUBJECT varchar(20),WINNER varchar(20), COUNTRY varchar(20),CATEGORY varchar(20))

insert into prize values(1970, 'Physics', 'Louis Neel', 'France', 'Scientist')
insert into prize values(1971, 'Chemistry', ' Ulf von Euler ', 'Germany', 'Scientist')
insert into prize values(1970, 'Physics', ' Luis Federico Leloir ', 'France', 'Scientist')
insert into prize values(1973, 'Physiology', 'Paul Samuelson ', 'Russia', 'Scientist')
insert into prize values(1970, 'Physics', 'Aleksandr Solzhenitsyn', 'USA', 'Scientist')

select * from prize
select YEAR, SUBJECT, WINNER from prize where YEAR=1970

insert into prize values(1970, 'Physics', 'Louis Neel', 'France', 'Scientist')
insert into prize values(1971, 'Chemistry', ' Ulf von Euler ', 'Germany', 'Scientist')
insert into prize values(1970, 'Physics', ' Luis Federico Leloir ', 'France', 'Scientist')
insert into prize values(1973, 'Physiology', 'Paul Samuelson ', 'Russia', 'Scientist')
insert into prize values(1970, 'Physics', 'Aleksandr Solzhenitsyn', 'USA', 'Scientist')

select WINNER from prize where SUBJECT='physics'or YEAR=1970
