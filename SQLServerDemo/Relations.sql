-- Constraints: Rules or Guideline applied on Column to have specific Values,
-- if values are not inserted as per the rules then the Insert/Update query will crash

-- Primary Key: Used to Identify the Record Uniquely
-- This cannot accept Null Values , becuase the Primary Key applies the
-- Not Null Constraint on the Column 
insert into Department values (null, 'Test_Dept','Pune',1200);

-- The Unique Key Constraint
-- Can accept a single (unique) value for the column or  null
-- This column value cannot be repeated for other row in the table
-- Alter Table [TABLE-NAME] Add Constraint [Constraint-Name] UNIQUE [Column-NAME]
Alter Table Department Add Constraint DeptName_Unique UNIQUE(DeptName);
-- the Following insert statement will generate an error 
insert into Department values (50, 'IT','Pune',1200);
select * from Department;

-- Create a table with the Unique Column

create table Users (
  UserId int Primary Key,
  UserName varchar(50) Unique,
  Password varchar(20) Not null
 );

 Insert into Users values(1, 'mahesh', 'mahesh');
 Insert into Users values(2, null, 'mahesh');

 Select * from Users;
 -- Delet the table
 Drop Table Users;

 -- Using an Identity Key also known as AUTO_INCREMENT Key
 -- The column value will be automatically generated from 1 by default

 --Create table Comments(
 --  CommentId int Identity PRIMARY Key,
 --  Comment varchar(2000) Not Null
 --);


 -- Create a Table with Identity Values for Start value and increment Count
 -- defined explicitely

  Create table Comments(
   CommentId int Identity(1, 10) PRIMARY Key,
   Comment varchar(2000) Not Null
 );


 -- Insertion into the table with Identity Key
 -- By Default Explict insertion for the Identity Column is not allowed
 -- To Do this execcute the SET IDENTITY_INSERT ON for the table
 Insert into Comments values('This is a table with Identity Key key');

 select * from Comments;

 -- Clear a table by Removing all Rows from it
 -- (NOTE: Use it Carefully, because once the data is lost it will be difficult for you to get it back)
 Truncate table Comments;

 Drop Table Comments;

 -- Explore the Foreign Key

 -- 1. A Forieign key is a Primary Key of one table used in the other table to
 -- Establish relationship
	-- e.g. DeptNo is a Primary Key of Department table used as a Foreign Key in Employee Table 

 -- 2. The foreign-key provides the Parent-Child Relatioship OR aka Has-a Relationship
 -- across tables. 
	-- Each Employee has-a Department 'One-to-one' Relationship
	-- Each Department can have one-or-more employees aka 'One-to-Many' Relationship
		-- Department has Employees
 
 -- 3. The Foreign Key imposes(aka applies) the 'REFERENTIAL INTEGRITY' on a child tables
	-- Each Employee MUST have Department
 
 -- 4. The Child table can have value for the Foreign Key column that matched with the 
 -- value for the same column in the parent table
	-- If Employee Table (Child) row wants to have 10 as Value for DeptNo, then in Department Table (Parent)
		-- MUST have a row with DeptNo as 10
insert into Employee Values (201, 'Sameer', 11000, 'Manager', 60, 'tejas@msit.com');

-- 5. We cannot delete a Record from Parent Table if its Primary Key value is used by the Child Table
-- The Following Statement will be successfully executed
Delete from Department Where DeptNo=50;
-- The following statement will be terminated because there are Records in Employee table
-- those aere part of DeptNo 40
Delete from Department Where DeptNo=40;
