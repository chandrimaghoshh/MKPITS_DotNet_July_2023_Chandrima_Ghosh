create table sample123(id int identity primary key,
name varchar(20) not null)

insert into sample123 values('mouse')
insert into sample123 values('Keyboard')
select * from sample123
delete from sample123

select * from sample123
insert into sample123 values('mouse')
insert into sample123 values('Keyboard')

truncate table sample123
alter table sample123
add price int

sp_help sample123
alter table sample123
alter column price dec(10,2)

sp_rename 'sample123' , 'newsample'
EXEC sp_rename 'stud.stunam', 'stuname','COLUMN'