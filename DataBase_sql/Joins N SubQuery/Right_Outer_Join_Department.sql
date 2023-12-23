select * from Department
select * from Employee

SELECT E.FName, E.LName, D.Dep_Id, D.Dep_Name 
 FROM Employee E 
   RIGHT OUTER JOIN Department D
     ON E.Dep_Id = D.Dep_Id;