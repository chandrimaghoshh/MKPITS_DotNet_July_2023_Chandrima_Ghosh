select * from Student

select Student.admission_no,Student.first_name,Student.last_name,Fees.course,Fees.amount_paid
from Student
cross join Fees
