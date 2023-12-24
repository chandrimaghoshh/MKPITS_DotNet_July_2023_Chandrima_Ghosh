create table customer(cust_id int identity,
cust_name varchar(20),state varchar(20),city  varchar(20))

insert into customer values('chandu','mah','nagpur')
insert into customer values('pooja','mah','mp')
insert into customer values('karu','mah','amravati')
insert into customer values('akash','mah','mp')
insert into customer values('yash','mah','nagpur')
select * from customer

select s1.cust_name,s2.state,s2.city
from customer s1,customer s2
where s1.cust_id<>s2.cust_id and s1.city=s2.city
order by s2.city
