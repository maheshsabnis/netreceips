-- Using Stored Procs (SP)
-- A Simple SP to read all Employees
-- Syntax
-- Create Procedure | Proc [NAME] [INPUT, OUTPUT PARAMETERS] 
-- The Following SP is not having any input and output parameter

Create Procedure sp_getEmployees
As -- The Name SP and its Parameters (if any) will be uniquely used
Begin
   -- The Implementation
   Select * from Employee;
End;

-- Execute the Procedure
-- Exec [SP-NAME] 

exec sp_getEmployees;
GO -- Commit an execution of the Current Block

-- A SP with input parameter
-- NOTE: generally parameter name matches with actual column names
-- ParameterName is always Prefixed with '@' sign, 
-- Make Sure that the Implementation of SP (Code inside Begin...End) is implemented in
-- new line steps
Create Proc sp_getEmployeeByDesignation
@Designation varchar(100)
As
Begin
	select EmpNo, EmpName, Salary, Designation, DeptNo 
	From Employee
	Where Designation=@Designation
End;

-- Lets execute the Procedute with input parameter

Exec sp_getEmployeeByDesignation @Designation='Manager';
Go
-- Declaring a Variable
Declare @Desig varchar(100);
-- Setting Value for the variable
Set @Desig = 'Lead';
-- Passing a variable as input Parameter value 
Exec sp_getEmployeeByDesignation @Designation=@Desig;
GO -- Completing a Batch of the  sp_getEmployeeByDesignation SP execution

-- Using SP with Return value

-- Gets get the Sum of salary by DeptNo

Create Proc sp_GetSumSalaryByDeptNo
@DeptNo int
As
-- Lets Declare a Local Variable for Store Procedure
Declare @SumSalary int
Begin
	Select @SumSalary= Sum(Salary)
	From Employee
	Where DeptNo=@DeptNo;

	-- Return the result
	return @SumSalary;
End;
Go
-- Declare a Varible that will collect result from the Stored Proc
declare @SumSalary int;
-- Execute the Procedure
Exec @SumSalary = sp_GetSumSalaryByDeptNo @DeptNo=10;
-- Print the Result
Select @SumSalary;
Go;

Create proc sp_GetSumSalaryByDeptNoWithOutParam
@DeptNo int, -- Input Parameter
@Result int Output -- output parameter
As
Begin
-- Local variable
Declare @SumSalary int;

Select @SumSalary=Sum(Salary)
	From Employee
	Where DeptNo=@DeptNo;
	-- Set the Value of Local Variable to output parameter
	select @Result = @SumSalary;
End;
Go

-- Delete teh SP
-- Drop Proc sp_p_GetSumSalaryByDeptNoWithOutParam;

-- Execute the SP with Output parameter
-- Declare a variable to collect the output value from SP
Declare @Res int;
-- Execute SP by Passing input and output parameter 
Exec sp_GetSumSalaryByDeptNoWithOutParam @DeptNo=10, @Result=@Res OUTPUT;
-- Print the result
Select @Res;
Go

-- SP with Insert Operations

Create proc sp_InsertDepartment
@DeptNo int, @DeptName varchar (100), @Location varchar(100), @Capacity int
As
Begin 
  -- Always Specify columns of which values are inserted	 	
  Insert into Department (DeptNo,DeptName, Location, Capacity)
  Values
    -- Pass Parameters
	(@DeptNo,@DeptName, @Location, @Capacity);
End;
Go;

-- Execute SP
Exec sp_InsertDepartment @DeptNo=70, @DeptName='SYS', @Location='Mumbai', @Capacity=350;
Go


