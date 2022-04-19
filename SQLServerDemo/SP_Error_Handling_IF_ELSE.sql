Create Procedure sp_InsertEmployee
@EmpNo int, @EmpName varchar(200), @Salary int, @Designation varchar(100), @DeptNo int
As
Begin
	Begin Try
		insert into Employee (EmpNo, EmpName, Salary, Designation, DeptNo )
		Values
			(@EmpNo, @EmpName, @Salary, @Designation, @DeptNo );
	End Try
	Begin Catch
		Select ERROR_NUMBER() as Error_number,
		ERROR_SEVERITY() as Error_Severity,
		ERROR_MESSAGE() as Error_Meessage
	End Catch
End;

Exec sp_InsertEmployee @EmpNo=101, @EmpName='Neeta', @Salary=3454, @Designation='Manager', @DeptNo=10;
Go


--Drop Proc sp_InsertEmployee;


create proc sp_selectEmployeesByDeptNo
@DeptNo int
As
Begin
    
	IF(@DeptNo < 0)
		Select 'Dept No cannot be 0 or -VE'
	Else
		Select * from Employee
		Where DeptNo=@DeptNo;
End;

Exec sp_selectEmployeesByDeptNo @DeptNo=-10;
Go


Drop proc sp_selectEmployeesByDeptNo;