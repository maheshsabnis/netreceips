-- Error Handling
	-- Exception Handling and the Standard Error Handling Functions
	-- Begin Try...End Try  Begin Catch...End Catch
	-- Standard Functions
		-- Error_Number(), Error_Message(), Error_Severity, etc.

create proc sp_InsertDepartmentCheck
@DeptNo int, @DeptName varchar(100), @Location varchar(100), @Capacity int
As
Begin
	Begin try
		Insert into Department (DeptNo, DeptName, Location, Capacity )
		Values
			(@DeptNo, @DeptName, @Location, @Capacity)
	End try

	Begin Catch
	  -- Catch the exception if the DeptNo is alredy present
	  select ERROR_NUMBER() as Error_Number,
			 ERROR_MESSAGE() as Error_Message,
			 ERROR_SEVERITY() as Error_Severity
	End Catch
End;
go

Exec sp_InsertDepartmentCheck @DeptNo=80, @DeptName='MNT', @Location='Pune', @Capacity=45;

Select * from Department;
go;
-- IF Conditoin (IF-Else)
create proc sp_selectEmployeeByDeptNoCondition
@DeptNo int
As
begin
  if(@DeptNo <= 0)
	select 'DeptNo Cannot be 0 or -ve';
  else
	Select * from Employee
	where DeptNo=@DeptNo;
End;

exec sp_selectEmployeeByDeptNoCondition @DeptNo=-10;
go
-- USing Function
-- Syntax
	-- Create function [Name](PARAMETERS,,,,) returns [TYPE] As Beging ..... return [Parameter|LOCAL VARIABLE] End; 
create function CheckKey (@Key int)
returns Varchar(100)
As
Begin
	-- declare a local variable
	declare @message varchar(100);
	If @Key <=0 
		set @message = 'Make Sure that the Key ,ust be a positive integer';
	Else
		set @message = 'Key is validated successfully';	
	return @message;
End;
go
-- Note: Using the 'dbo' object to execute the Custom Function
-- This object will make the Custom Function as a Global Function
select dbo.CheckKey(-90);
 
-- Using DB Triggers
-- This is a Programmabble Block, that will be executed on the Database and 
-- will take a responsibility of monitoring the transaction executed on tables.
-- This consist of the Table Name to be monitored, the Action (or transaction),
-- the audit entry and finally the action reference performned on the table    

-- Table Name to be monitored: The Target table when Insert/Update/Delete will takes place
-- The Action (or transaction): The type of operation takes place i.e. Insert/ Update/ Delete
-- The audit entry: The table in which audit information will be kept for the transaction
	-- Record Inserted/Updated/Deleted
-- The action reference performned on the table: The Action Object that will provide an access
		-- of the row that is affected after insert/update/delete 
			-- E.g. Standard Object are
				-- inserted, updated, deleted
						-- to access EmpNo newly inserted into the Employee table
							-- inserted.EmpNo

-- Lets create a table for Audit

create table DepartmentTxAudit (
  AuditId int identity(1,1) Primary key,
  AuditDeptNo int not null,
  AuditType varchar(100) not null,
  AuditDate Date Not null
);
Go
-- create a trigger
-- Syntax
-- Create Trigger [Name] On [Target-Table] BEFORE|AFTER [INSERT|UPDATE|DELETE]
-- As  Begin .......... End;

Create Trigger  trg_InsertDept
On Department
After Insert
As
Begin
   declare @DeptNo int;
   -- Lets retrive the DeptNo that is inserted into the Department table
   Select @DeptNo = DeptNo from inserted
   -- Insert this data into the DepartmentTxAudit Table
   Insert into DepartmentTxAudit (AuditDeptNo, AuditType, AuditDate)
   Values
	(@DeptNo, 'New Record Created', GetDate());

End;
go

Insert into Department Values(90, 'HW', 'Pune', 96);

Select * from DepartmentTxAudit;
go

Create Trigger  trg_DeleteDept
On Department
After Delete
As
Begin
   declare @DeptNo int;
   -- Lets retrive the DeptNo that is inserted into the Department table
   Select @DeptNo = DeptNo from deleted
   -- Insert this data into the DepartmentTxAudit Table
   Insert into DepartmentTxAudit (AuditDeptNo, AuditType, AuditDate)
   Values
	(@DeptNo, 'New Record Deleted', GetDate());

End;
go

Delete from Department where deptNo=90;
Go
--- Views
	-- They are used to protect all important columns from the direct access by the Querying
	-- application
	-- Create a Temporary Storage based on data read from multiple tables and provide access of this storage
		-- to querying application.
	-- This is more beneficial whne executing join queries frequently on various tables

Create View DeptEmp
As
	Select DeptName, Location, EmpNo, EmpName, Salary, Designation
	From Department, Employee
	Where Department.DeptNo =  Employee.DeptNo;

-- Query to View
Select * from DeptEmp;

Insert into Employee Values (201, 'Amit', 123000, 'Sr. Manager', 80, 'amit@msit.com');
Delete from Employee Where EmpNo=201;