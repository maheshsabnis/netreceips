-- Group By
-- This is a mechanism using which a Table rows can be arranges into a logical groups
-- based on Column Name

-- Get countg of Employees for Each DeptNo
-- Emp_Count is a Runtime Column Creation which will be available
-- only for the Following Select Query
select Count(*) as Emp_Count, DeptNo from Employee group by (DeptNo); 
-- Sum of Salary for Each Department
select DeptNo, sum(Salary) as Salary from Employee group by(DeptNo);
-- Count of Employees for each Designation
select Designation, Count(*) Empl_Count from Employee group by (Designation)

-- Lets find out Second Max Salary from the Employee Table
-- A Bit Deeper into the Select Queries
-- Execution will be from Right to Left. The clause 'where' will be executed first
-- based on its result the Left-Hand-Side Query will be executed 
-- This is also knownas 'Sub-Query'

select max(salary) as Salary from Employee where Salary < (Select max(Salary) from Employee);

-- Print Max Salary per department

select DeptNo, Max(Salary) as Salary from Employee Group by DeptNo;

-- Using Joins

-- Joins provides a Logical Relationships across 2 or multiple table to read data from it 
-- based on Conditions

-- Prerequisites
-- Tables using in JOIN MUST have at-lease one column common in them with relationship

-- Print all Employees with DeptName, Location


select EmpNo, EmpName, Salary, Designation, DeptName, Location -- Values to Print
From Employee, Department -- Tables
Where Employee.DeptNo = Department.DeptNo; -- Relational Condition
-- Default to Inner Join return Only matching values based on the Condition
select Department.DeptNo, DeptName, EmpNo, EmpName, Salary, Designation, Employee.DeptNo
From Department Inner Join Employee 
on Department.DeptNo = Employee.DeptNo;




select DeptName, Sum(Salary) as Salary
from Employee, Department -- Join
Where Employee.DeptNo = Department.DeptNo
Group by (Department.DeptName) -- Group By
Order By DeptName Desc -- Order by
;

-- Type of Joins

-- Left-Join
-- Selects Data from the Left Table and matching rows from the Right Table
-- Left join returns all rows from the left table and its corresponding
-- matching records from the Right Table, but if there are not match found in
-- Right table then for the records from the left table the 'null' values will be
-- generated for the Right table

-- Left Table is Deprtment and Right Table is Employee

select Department.DeptNo, DeptName, EmpNo, EmpName, Salary, Designation, Employee.DeptNo
From Department Left Join Employee 
on Department.DeptNo = Employee.DeptNo;


-- Right Join 
-- All data from Right Table will be Read that matched with the Data with Left Table
-- All Records from the Right Table will be returned  alomg with matching values of the Rows from
-- Left table, if not match found, then values will be null


select Department.DeptNo, DeptName, EmpNo, EmpName, Salary, Designation, Employee.DeptNo
From Department Right Join Employee 
on Department.DeptNo = Employee.DeptNo;
-- Now used the Department on Right, so the result will be same as the 
-- Left Join
select Department.DeptNo, DeptName, EmpNo, EmpName, Salary, Designation, Employee.DeptNo
From Employee Right Join Department 
on Department.DeptNo = Employee.DeptNo;

-- Full Joins
-- Read all data from both table with match and unmatched values

select Department.DeptNo, DeptName, EmpNo, EmpName, Salary, Designation, Employee.DeptNo
From Department Full Join Employee 
on Department.DeptNo = Employee.DeptNo;
