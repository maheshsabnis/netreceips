-- Using Some Select Statements
-- Suggestions, instead of using select *, use select 'column-name',.... from the table
-- this will execute with optimization

select EmpNo, EmpName, Salary from Employee;
-- select only employee of specific Designation
select EmpNo, EmpName, Salary, DeptNo, Designation from Employee where Designation ='staff';
-- select only those employees whose name starts from the character 'M'
-- using the Like operator
select * from Employee where EmpName Like 'M%';
-- select those employees whose name ends with 'm'
select * from Employee where EmpName Like '%m';
-- select all employees those contains 'esh' at any position in EmpName
select * from Employee where EmpName Like '%esh%';
-- Select all employees having name starts with 'M' and having atleast 6 characters in length (Including first character)
select * from Employee where EmpName Like 'M_____%';
-- Select all employees having EmpName starts with M and ends with h
select * from Employee where EmpName Like 'S%m';

-- Print all Employees with designation as Manager and Lead
-- Following Select Statement will not return any result because Designation has a Single value only 
select EmpNo, EmpName, Designation from Employee
where Designation = 'Manager' and Designation = 'Lead'; 
-- The OR Operator will resturen correct result
select EmpNo, EmpName, Designation from Employee
where Designation = 'Manager' OR Designation = 'Lead'; 

-- use the 'in' operator

select EmpNo, EmpName, Designation, Salary, Email from Employee
where Designation in ('Manager', 'Lead');

-- Using the Between Operator, used to select rows for a column value between a range

select * from Employee where Salary between 5000 AND 50000; 

-- USing Standard Functions provided by SQL Server

-- Print Min and max salary

select Min(Salary) from Employee;
select Max(Salary) from Employee;

-- Sum of Salary of all Employees

select sum(Salary) from Employee;

-- Count of Employees

select Count(*) from Employee;

-- Average Salary
select AVG(Salary) from Employee;

-- Specific Records from Top

select Top 4 *  from Employee;

-- Specifc Percentage of Records

select top 20 Percent * from Employee ;

select top 20 Percent * from Employee where DeptNo = 10;

-- Sum of Salary for a specific DeptNo

select Sum(Salary) from Employee Where DeptNo=10;

select Salary from Employee where DeptNo=10; 
-- Max Salary for Specific DeptNo
select Max(Salary) from Employee where DeptNo=10; 

-- Min Salary for Specific DeptNo
select Min(Salary) from Employee where DeptNo=10; 
-- Print all designations
select Designation from Employee;
-- Print Distinct Designations

select Distinct Designation from Employee;

-- Print all employees Order by Salary ascending (Default)
select * from Employee Order by Salary; 

-- Print all employees Order by Salary descending
select * from Employee Order by Salary desc;