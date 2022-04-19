-- Create Database
Create Database Enterprise;

-- Use the database so that all operations will be in that database

Use Enterprise;

-- Create table Department 
-- Note the Capacity Spelling is wrong
Create Table Department (
  DeptNo int Primary Key,
  DeptName varchar(100) not null,
  Location varchar(100),
  Capctay int not null
);
-- Alter table and modify the Constraints for the Location column as 
-- Not Null
Alter Table Department alter Column Location varchar(100) Not Null;

-- Rename column (Not Working)
-- Alter Table Department Alter Column Capacity int;

-- Rename using Stored Proc Provided using SQL Server 

EXEC sp_rename 'Department.Capctay', 'Capacity', 'COLUMN';

-- Insert Rows in Department Table
-- Insert into [TABLE_NAME] Values(COLUMN VALUES....)
insert into Department Values
(
  10, 'IT', 'Pune', 1000 
);
insert into Department Values
(
  20, 'HR', 'Pune', 25 
);
insert into Department Values
(
  30, 'SL', 'Pune', 45 
);
insert into Department Values
(
  40, 'AC', 'Pune', 18 
);

-- Using the Select Statement
Select * from Department;

-- Select all departments at location Pune
select * from Department where  Location='Pune';
-- Update the Location of Account Dept to Mumbai
Update Department set Location='Mumbai' where DeptName='AC';

-- Create an Employee table, this will have the DeptNo as a Foreign Key
Create Table Employee (EmpNo int Primary Key, EmpName varchar(200) not null,
  Salary int not null, Designation varchar(100) not null, 
  DeptNo int not null  References Department (DeptNo)
);
-- Add a new column in the Employee Table
Alter Table Employee 
	Add Email varchar(100) not null;
-- Modify the size of the EmpName 
Alter Table Employee
	Alter Column EmpName varchar(300) not null; 

-- Insert Employees

insert into Employee Values (101, 'Mahesh', 11000, 'Manager', 10, 'mahesh@msit.com');

insert into Employee Values (102, 'Tejas', 11000, 'Manager', 20, 'tejas@msit.com');
insert into Employee Values (103, 'Nandu', 11000, 'Manager', 30, 'nandu@msit.com');
insert into Employee Values (104, 'Anil', 11000, 'Manager', 40, 'anil@msit.com');
insert into Employee Values (105, 'Jaywant', 11000, 'Lead', 10, 'jaywany@msit.com');
insert into Employee Values (106, 'Abhay', 11000, 'Lead', 20, 'abhay@msit.com');
insert into Employee Values (107, 'Shyam', 11000, 'Lead', 30, 'shyam@msit.com');
insert into Employee Values (108, 'Anil', 11000, 'Lead', 40, 'anil@msit.com');
insert into Employee Values (109, 'Vikram', 11000, 'Sr.Manager', 10, 'vikram@msit.com');
insert into Employee Values (110, 'Suprotim', 11000, 'Sr.Manager', 20, 'suprotim@msit.com');
insert into Employee Values (111, 'Manish', 11000, 'Sr.Manager', 30, 'manish@msit.com');
insert into Employee Values (112, 'Praveen', 11000, 'Sr.Manager', 40, 'praveen@msit.com');
insert into Employee Values (113, 'Prasad', 11000, 'Staff', 10, 'prasad@msit.com');
insert into Employee Values (114, 'Pranil', 11000, 'Staff', 20, 'pranil@msit.com');
insert into Employee Values (115, 'Mukesh', 11000, 'Staff', 30, 'mukesh@msit.com');
insert into Employee Values (116, 'Vivek', 11000, 'Staff', 40, 'vivek@msit.com');
insert into Employee Values (117, 'Veenit', 11000, 'Engineer', 10, 'veenit@msit.com');
insert into Employee Values (118, 'Ashwin', 11000, 'Clerk', 20, 'ashwin@msit.com');
insert into Employee Values (119, 'Abhijit', 11000, 'Operator', 30, 'abhijit@msit.com');
insert into Employee Values (120, 'Vaibhav', 11000, 'Staff', 40, 'vaibhav@msit.com');

Select * from Employee;
