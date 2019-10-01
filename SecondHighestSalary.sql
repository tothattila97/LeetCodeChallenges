select Max(r.salary) as SecondHighestSalary from 
  (select salary, DENSE_RANK() OVER(order by salary desc) as salaryrank from employee) r
where r.salaryrank = 2

--select max(Salary) as SecondHighestSalary from Employee where Salary < (select max(Salary) from Employee);
