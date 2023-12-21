--Left outer join
select * from Student

select Student.admission_no,Student.first_name,Student.last_name,Fees.course,Fees.amount_paid
from Student
left outer join Fees
on Student.admission_no=Fees.admission_no

--Right outer join
select * from Student
select Student.admission_no,Student.first_name,Student.last_name,Fees.course,Fees.amount_paid
from Student
right outer join Fees
on Student.admission_no=Fees.admission_no

--Full outer join
select * from Student
select Student.admission_no,Student.first_name,Student.last_name,Fees.course,Fees.amount_paid
from Student
full outer join Fees
on Student.admission_no=Fees.admission_no
