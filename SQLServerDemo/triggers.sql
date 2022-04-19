-- Using Triggers

Create table EmployeeAudit(
  AuditId int identity (1,1) Primary Key,
  AuditEmpNo int not null,
  AudiDate Date Not null
)
go

Create Trigger trg_InsertEmp 
On Employee
After Insert
As
Begin
  Declare @EmpNo Int;
  Select @EmpNo = EmpNo from Inserted
  Insert into EmployeeAudit 
  Values
  (
	@EmpNo,
    GETDATE() 
  )
   	
End;

Insert into Employee Values (202, 'Amit', 34000, 'Lead', 20, 'amit@msit.com');
 
Select * from EmployeeAudit;
go;

Create Trigger trg_DeleteEmp 
On Employee
After Delete
As
Begin
  Declare @EmpNo Int;
  Select @EmpNo = EmpNo from deleted
  Insert into EmployeeAudit 
  Values
  (
	@EmpNo,
    GETDATE() 
  )
   	
End;

go;

Delete From Employee Where EmpNo=202;

Select * from Employee;