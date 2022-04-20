# Date: 18-Jan-2022 (Show me on 19-Jan-2022)
1. Create a Console Project. IN thie project in the 'Program class', add following method
	- Add()
		- Accept 2 Integers from the Main() method and return integer as addition of 2 numbers
	- Sub()
		- For Subscration
	- Multiplication()
		- For Multiplication
	- Division()
		- For Division
	- Square()
		- For Square
2. While Performing all of the above operations make sure that each method will conditionbal statement for the following
	- If parameters to these statements are <= 0, then direcly return 0
3. Create a Method that will accept 3 Parameters as below
	- e.g.
		- static void Process(int a,int b,string c)
			- If c == "Add", then return addition of paarmeters
			- If c == "Sub", then return Substratcion  of paarmeters
			- If c == "Mult", then return Multiplication  of paarmeters
			- if c == "Div", then return division  of paarmeters
		- MAke sure that, a dn b are not negative or 0

4. Self-Study
	- Learn the Math class and try out the Trignometric methods

# Date: 31-Jan-2022
5. Using the Following String
	"James Bond is a fictional character created by novelist Ian Fleming in 1953. A British secret agent working for MI6 under the codename 007, he has been portrayed on film by actors Sean Connery, David Niven, George Lazenby, Roger Moore, Timothy Dalton, Pierce Brosnan and Daniel Craig in twenty-seven productions. All but two films were made by Eon Productions, which now holds the adaptation rights to all of Fleming's Bond novels.[1][2]

In 1961, producers Albert R. Broccoli and Harry Saltzman purchased the filming rights to Fleming's novels.[3] They founded Eon Productions and, with financial backing by United Artists, produced Dr. No, directed by Terence Young and featuring Connery as Bond.[4] Following its release in 1962, Broccoli and Saltzman created the holding company Danjaq to ensure future productions in the James Bond film series.[5] The series currently has twenty-five films, with the most recent, No Time to Die, released in September 2021. With a combined gross of nearly $7 billion to date, it is the fifth-highest-grossing film series.[6] Accounting for inflation, it has earned over $14 billion at current prices.[a] The films have won five Academy Awards: for Sound Effects (now Sound Editing) in Goldfinger (at the 37th Awards), to John Stears for Visual Effects in Thunderball (at the 38th Awards), to Per Hallberg and Karen Baker Landers for Sound Editing, to Adele and Paul Epworth for Original Song in Skyfall (at the 85th Awards) and to Sam Smith and Jimmy Napes for Original Song in Spectre (at the 88th Awards). Several of the songs produced for the films have been nominated for Academy Awards for Original Song, including Paul McCartney's "Live and Let Die", Carly Simon's "Nobody Does It Better" and Sheena Easton's "For Your Eyes Only". In 1982 Albert R. Broccoli received the Irving G. Thalberg Memorial Award.[8]"

- Perform Following Operations on the string. Use 'switch..case' constructs
	1. Find out number of 'Blank Spaces' in the string
	2. Find out nunmber of 'Words'
	3. Find out number of '.'
	4. Find out number of statements
	5. Find out number of digits
	6. Find out number of vowels (a,e,i,o,u)
	7. Find out number of 'the', 'is', 'to', 'and' and their positions (indexes)
	8. Find out number and positions of comma (,)
	9. Reverse each word in string
	10. Reverse entire string
	11. Print each statement in separate line on console from the above string
	12. Print all words decorated uasing "" e.g. "Live and Let Die"
	13. Convert first character of each word in upper case.
	15. List 'month names' from the above list e.g. January, February, etc.
- Evaluation will be done based on following criterias
	- Avoiding Code Repetation
	- Using most suoitable and applicable string standard method that will avoid unnecessary code


# Date: 01-Feb-2022 (a Mini Project Final Date of Submission is 04-Feb-2022 (Friday))

1. Modify the EmployeeOperations class with Following Method
	- UpdateEmployee(EmpNo, Employee)
		- Search Employee By EmpNo, if Employee not found then throw Employee Not Found Exception, else Update the existing Employee from the List based on the Employee object passed to the method	  
	- DeleteEmployee(EmpNo)
		- Search Employee By EmpNo, if Employee not found then throw Employee Not Found Exception, else Delete the existing Employee from the List
	- While Storing Employee Create a Seperate Dictionary to Store Employee by DeptName
	- Add a method to List Employees by DeptName
	- Add a method to List Employees by Designation
	- Write a method to Validate Employee before Add and Update based on following  Rules
		- EmpNo
			- Must be Positive Integer
			- Must not be repeated
		- EmpName
			- Must start from Uppercase Charachetr
			- Can have Blank Spaces but not Number and special Characters
			- Note: Use Regular Express (Search on Regx class (Self-Study))
		- DeptName can be any of the following
			- IT, HRD, Sales, Admin, Account
		- Designation Can be any of the following
			- Manager, Engineer, Clerk, Staff
		- Salary MUST be positive Integer	
2. Add a new class known as 'Client' that will be used by Main() method to perform Employee operations
	- The Main() method will not directly access Employee and EmployeeOperations classes 
	- The Client class Must contain method for
		- AddEmployee()
			- Access Method AddEmployee() from the EmployeeOperations
		- UpdateEmployee()
		- DeleteEmployee()
		- SearchEmployee()
3. All Operations on Employee will be done using Swich...case statements 
		
# Date: 02-Feb-2022
1. Can overloading is possible by having same method name with same number and order of parameters but different in return type?
2. Can we override the private virtual method of abstract class using public method from the deriuved class?
3. Can we have private and protected abstract and virtual methods in abstract base class?
4. Can we have method overloading across base and deried classe?
5. Can we type cast the derived class instance using the base class? 
6. Can we have public property in abstract base class?
7. Can we have same property in base and derived class?
8. Can we derive a public class from internal class?
9. Can we have internal virtual or abstract methods in abstract class?
10. Can we have private or protect class?
11. Can we have internal property?
12. Can we have virtual method in not-abstract class?
13. Can we have abstract method in not-abstract class?
14. What will happen if the derive class dows not override all abstract methods of the abstract class?
15. Can we have virtual and/or abstract methods in sealed class
16. Can we have sealed access modifier for method?

# Date: 04-Feb-2022

1. Add following methods in the Standard Math class as extension methods
	- GetPower(int x,int y); 
		- Must return x raised to y
	- Factorialofn(int n)
		- Must return factorial of n
	- CubeRootn(int n)
		- Must return Cube root of n
2. Chek if we can have 'static' constructor in class, if yes tehn how many times it is executed?

# Date: 08-Feb-2022
Complete Pending Assignments
1. Read about LINQ from docs.microsaoft.com
	- Take, Skip, OrderBy, OrderByDesc, etc
2. Read about Anonymous Type

# Date: 09-Feb-2022
1. Create an Employee Collection with at least 50 Records with properties as
	- EmpNo, EmpName, DeptName, Salary, Designation
2. Perform Following Report Generation on the Employees Collection
	- Print All Employees In Ascending Order of the EmpName
	- Print All Employees Group by the DeptName, and also display Employee Count for each DeptName
	- Find out Sum of Salary for Employess per DeptName
	- Print Employee with Max Salary Per DeptName
	- Print Employee with Min Salary Per DeptName
	- Print Average Salary Per DeptName
	- Print Employees by Designation Group
	- Display All EMployees those are Managers, Directors only
	- Print All EMployees Having Salary in Range 25000 to 75000
	- Print Employee with Second MAx Salary Per DeptName
	- Print Employee with Second Max Salary
	- Calculate Tax for Each Employee as followas
	- Salary from >=20K to <=40K is 0.05%
		- Salary from >40K to <=60K is 0.1%
		- Salary <20K is 0
		- Salary >60K is 0.15%
		- Print All these Salaries DeptName Wise
3. Create a Department Collection with 10 Records as
	- DeptNo, DeptName, Location, Capacity
4. Modify the Employee Collection and use DeptNo instead of DeptName 
	- List Employes as
		- EmpNo, EmpName, Designation, DeptName, Location, Salary

5. Self-Study
	- Read about Following Operator Method
		- Fisrt(), FirstOrDefault()
		- Last(), LastOrDefault()
		- Count()
	- (Optional)
		- GroupJoin()
		- ToLookUp()
		- OfType()


# Date: 10-Feb-2022 (Submission:18-Feb-2022)

1. Use the Employee Class of Assignment on Date:09-Feb-2022 for Calculting Salary of each employee based on the following Rules
	- For Managers Calculate 
		- HRA as 10% of Salary
		- TS as 15% of Salary
		- DA as 20% of Salary
	- For Directors Calculate
		- HRA as 20% of Salary
		- TS as 30% of Salary
		- DA as 40% of Salary
	- Calculate Gross as 
		- Salary + HRA + TA + DA
	- Calculate Tax
		- Gross 5 to >=10 Lacs per Annum is 20% of Gross
		- Gross >10 to >=20 Lacs per Annum is 25% of Gross
		- Gross>20 Lacs per Annum is 30% of Gross
	- Calculate Net Salary as
		- Gross - Tax
2. Convert the NetSalary from Numeric to String as follows
	- If NetSalary Per Month is 124450
		- The Show it as One Lacs Twenty Four Thousand Four Hundred Fifty Only
3. Create a Salary Slip for Each Employee into Separate File as 
		- FileName Must be 'Salary-for-{Month}-{Year}-{EmpNo}.txt'
		- e.g.
			- Salary-for-Feb-2022-1001.txt
	
	------------------Salary Slip for Month of {MONTH-NAME}------------
	| EmpNo: {EmpNo}		EmpName: {EmpName}	DeptName: {DeptName}  |
	| Designation: {Designation}
	|-----------------------------------------------------------------|
	|Income (Rs.)					| Deduction (Rs.)				  |	
	|-------------------------------|---------------------------------|
	|Basic Salary:	{Salary}		|								  |
	|HRA:			{HRA}			|								  |
	|TA:			{TA}			|								  |
	|DA:			{DA}				|								  |	
	|-------------------------------|---------------------------------|
	|Gross:			{Gross}			|								  |
	|-------------------------------|---------------------------------|
	|								|Tax:			{Tax}			  |
	|-------------------------------|---------------------------------|
	|NetSalary:		{NetSalary}		|								  |
	|-----------------------------------------------------------------|
	|NetSalary In Words:		{Net_Salary_In_Words}				  |
	|-----------------------------------------------------------------|

# Date 14-Feb-2022

1. Read All fils from the Directory and Store is in List class
2. Let the User Select or Choose the file from which the data is read and then open the file and read data from it
	- The User Can read all data from file
	- (Mandatory) The User can read a Single Line from the file 
			- (optional) by  enter the Line Number
3. Print all files having an extension as .txt
4. (Research by you but Mandatory submit by 28 Feb)
	- Print folowing details of the file (HINT: File/FileInfo or event Stream Class)
		- FileName
		- FilePath
		- File Extension
		- Fine Size
5. Modify the 3rd problem statement from Date:10-Feb-2022 using the Serialization

# Date:16-Feb-2022

1. Select Second Max Salary Per DeptNo
2. Select Max and Second Max Salary for Each Designation (Write Separate Queries)
3. Create  Strored Proc (SP) that will return Max Salary per DeptName
	- Use Group By
4. Create a SP that will insert row in Employee Table

# Date: 17-Feb-2022

1. Create a Stored Provcedure that will perform an Insert Operation on Employee Table. But before Performing the insert operation, this SP Must call the ValidateData() function which will accept the Employee Row parameters and vbalidate it based on following conditions
	- EmpNo Must be +ve integer
	- EmpName Must containing Characters
	- Salary Must be +Ve integer
	- DeptNo Muset be present into Department table (Optional)
 The alidateData() function will return 0 is any of the record-value is invalid else will return 1. The SP will perform insert operation accordingly  	

# Date:18-Feb-2022
1. Perform CRUD Operations on Employee Table by adding Employee class and EmployeeDataAccess Class
2. Create a Class as 'Report', this call will have following methods
	- GetAllEmployeesByDeptName(string dname)
	- GetAllEmployeesWithMaxSalByDeptName(string dname)
	- GetSumSalaryByDeptName(string dname)
	- GetAllEmployeesByLocation(string location)
	
# Date: 22-Feb-2022

1. Like mentioned in Exercise 1 of  Date:18-Feb-2022 Perform the CRUD operations on Department and Employee Table using the disconneceted architrecture by adding DepartmetDataAccess and EmployeeDataAccess classes

# Date: 24-Feb-2022

1. Create a Class names StoreData. THis will have two methods as follows
	- WriteDataToFile()
		- THis will Accept an Employee Information and write this on the File
	- WriteDataToDb()
		- The EMployee Information will be written into Employee TAble
2. Execute both these methods on separate threads with following checks
	- If the File is not found or cannot be opened, then Abort the thread
	- If the Db Exception Occured, then abort the thread
3. Once these threads are doe with its job, print the EMployee Information on the Main THread (You decide this implemetation e.g. Seperate threads for File and Db Read)	

# Date: 02-March-2022

1. MOdify the Database Operations for Performing Asynchronous CRUD approch(Connected)
	- CReate a Class NAmed DbOperations, this class will have each method as 'async' and this will perform 'wait'able oeprations for CRUD
2. Modify the EMployee-Salary SLip application by generating Salary Slip for each EMployee on a Task, once these files are generated copy all files from C:\Source to C:\Destination folder with Task Continue
	
3. Makse sure that  1 and 2 uses Exception Handling
	- Explore Task.FromException() method

# Date:07-MArch-2022

1. CReate a EF COre App using .NET 6 COnsole Applicaiton with Db First Approach
	- CReate IDataAccess<TEntity,TPk> Interface for Async CRUD Operations
	- Create seperate classes those who implements IDataAccess interface for seperate Entityes to perform CRUD OParations
	- MAke sure that a Proper COnsole Menu Driven app is implemented usignSwitch Case


# Date: 08-Marh-2022

1. Create a CS ConsoleProject for .NET 6 and perform followig
	- Add a folder of name Models in t with following classes
		- Course Class 
			- CourseId, CourseName, CorseDuration, Fees
		- Student CLass
			- StudentUniqueId, StudentId, StudentName, CourseId, CourseYear, FeesStatus
	- Generate Migrations and Generate database
	- Modify the COurse class by adding DegreeType Column to it
		
2. FOllow Below Links for Assignment Practice of EF COre
	- https://www.devcurry.com/2019/08/stored-procedures-udt-types-ef-core.html
	- https://www.dotnetcurry.com/entityframework/1398/efcore-2-new-features (Priority)

	
# Date 09-March-2022
1. (Mandatory) Create a Seperate Library Project for EF Core DB First and perform and experience CRUD Operations
2. (OPtional) Create a .NET Frwk CLass Library Prject that will write Data into a text file OR USes Any existing Project e.g. EMployee Operations and implement it by performoing Employee CRUD Operations using dll nd use it in COnsole Exe project
3. (Mandatory) Publish Single File for .NET Core Project that uses DLL

# Date: 16-March-2022

1. Complete Employee and User (If this table is not present then add it in Database and Generate Models using EF COre DB First) Service form EF COre
2. CReate EmployeeService and USerService for CRUD OPerations
3. Create EmloyeeCOntroller and USerCOntrller with Action Methods
4. Create Views for Employee and User CRUD OPerations
5. Add HyperLInks for Departent, EMployee, and USer so that End-User can Directy NAvigate Across Vies of COntrollers. 

# Date: 21-March-2022
1. Write a Validation for EMployee Crete and Edit as follows
	- While Creating an Employee we need to pass the DeptNo, so check if the Capacity of DeptNO is not full
	- Make Sure that the Primary Key value is not-repeated (Plan and Implement, its not easy)
2. Modify the Create view for Employees to show Dropdown list of DeptName instaed of DeptNo
	- When a DeptNAme is selected the DeptNo MUST be actually selected
		- HINT: Use ViewData or ViewBag
			- SelectList is a class used for List of Departments to select DeptName
			- USe asp-items tag helper to generate &lt;option&gt; for &lt;select&gt;

# Date: 22-March-2022
1. Modify the LogFilterAttribute to log each request into the Database as following
	- RequestId: Auto Generated
	- RequestDateTime: DateTime
	- ControllerNAme
	- ActionNAme
	- ExecutionCompletionTime (Elapsed)
2. Generate a View where DeptName will be dipslayed in the DropDown, so when the DeptNAme is seleted and the GetDetails Submit button is clicked, the Same View MUST show EMployees of the Selected DeptName
3. Modify the EmployeeController to make sure that the EMployee will be added in the department if the deparyment capacity is not full, if it is full then throw an exception and return the error page with the Error Message that ""the Deparment {DeptName} does not have more capacity to accept new employee"
4. Write a Custom Validatr to make sure that the EmpName MUST start from Upper Case character and does not have Digit and Special character

# Date: 23-March-2022
1. MOdify the Excepton Filter to Log Exceptions in Database with Following
	- - RequestId: Auto Generated
	- RequestDateTime: DateTime
	- ControllerNAme
	- ActionNAme
	- ExecutionCompletionTime (Elapsed)
	- ExceptionType
	- ExceptionMessage
2. Modify Exception filter to return to seperate exception pages by Defining Seperate Pages for Exceptions
	- DbError.cshtml
	- CustomerError.chtml

3. COmplete an applcation from following link
https://www.webnethelper.com/2019/12/using-session-state-in-aspnet-core.html

# Date: 24-March-2022
1. Validate the EmpNAme for Employee Model class to have FullName (FirstNAme MiddleNAme LAstNAme)
2. Upload a File to the Server and Perform Following
	- Store File in Different FOlderes BAsed on Extensions
	- Make Sure That the Size of the File DOes not Cross 10 mb, do not accept file more than 10 mb
		- 1024 * 10 * 10
	- Create File Upload View to Upload the File, if the file is Image File, then Show the image on the Same View along with the File Name (Mandatory to be ompleted by today)
	- (Optional) If file is other than image then show the Logo of the File on the Same View once the Upload is siccessful    
3. (01-April)
	- CReate an ASP.NET COre App for Storing Profiles of Job Seekers, Capture the following Information
		- PErsonal: FullNAme, Address, COntact Info, EMail
		- Education: SSC, HSC, Degree, MAsters
		- Professional Info: e.g. Work Experience, Companies, Projects, etc.
		- Image of the Job Seeker and also Upload the Resume (PDF, WOrd only)
	- The Job Seeker will enter all Infromation	
		- The List of Job Seeker must be displayed in table as follows 
			- Full Name COntact No Email Highest Quaification IMage
		- WHen a Specific Job Seeker is Selected from the List then the View will sho 'All Infromation'		

	- The PersonalInfo Table will have COlumn for 'ImageFilePath' and 'PrifleFilePath' where the Path of the FIle will be stored (Not Image) so that it can be extracted

# Date: 29-March-2022
1. Complete CategoryCOntoller and ProductController in API
2. Add a Controller e.g. CatProdController to perform Following Operations
	-  POst method that will create One-Category and Multiple Products for the category using a SIngle POST request
3. Add a COntroller e.g. SeatchController that will contain Get method for Search Products by CategoryName

# Date: 30-March-2022

1. Create a API thet will have a Search GET Method with Following parameters
	- Search(string CategoryNAme, string condition, string ProductName)
		- This will return Data based on 'AND' and 'OR' value for 'condition' parameter
2. Create a Middleware that will Log Each Request in Database as below
	- RequestID
	- ControllerName
	- RequestMethodType (Get/Post/Put/Delete)
	- Date
	- Time
3. Modefy the ExceptionMiddleware for Logging request into database with followng information
	- RequestID
	- ControllerName
	- RequestMethodType (Get/Post/Put/Delete)
	- Date
	- Time
	- ErrorMessage
	- StatckTrace
4. Modify the Product class by adding the Price int property in it, generate Migration, Update database
5. MAke sure that when a new product for a category is created or updated, the Price value for the Product MUST be greater than or equal to the BAsePrice mentioned by the category
6. Write a Custom Validator for Price and BAsePrice for non-negative
7. Complete the ProductController with CRUD Operations
8. Take an Experience of FromBody, FormForm, FormQuery and FromRoute
	- https://www.webnethelper.com/2019/12/using-model-binders-in-aspnet-core.html

# 31-March-2022
1. Complete CategoryClientontroller for CRUD and Repeat The Same for ProductClientCOntroller
2. MAke sure thet the CLient is Send with Error Messages (Generated using the Middleware)
3. CReate a CLient for Search Method to fetech data from API USe SUbmit Button

# 06-April-2022
1. Modify the Job Seekar Portal using following Rules for the Security
	- Create 2 Roles
		- Employeer    
			- HR, Recuiter, Project Manager, Resource Manager Roles
		- JobSeeker
	- Employeer Role can search Profiles based on Qualification, Technology, Experience (OR or AND Conditions)
	- Employeer can select Profiles and store them into separate table
		- One Profile can be choosen by multiple Employeers
	- Once the JobSeeker Change the Status from 'Looking for Job' to 'Joined', this profile will be added into seperate table known as ExperienceEmployee
	- A JobSeeeker can 'Edit/Delete' his profile only
	- Employeer cannot edit any Profile
	- Employeer can add/update/delete his Companies information
	- JobSeeker cannot modify/delete any EMployeer's info by can read it

# Date: 13-April-2022
1. Generate Table Dynamically w/o hard-coded names for Employee Obect in Header and Body
	- HINT: Reflection 
2. When a TAble row is clicked, the data of the table row MUST be shown in TExt elements and Select element whih can be Updated and saved back to List and hence shown in Table
	- @onlick on tr in the tbody

# Date:14-April-2022

1. Modify the Table Component whihc will accept data from parent as following Parameters
	- DataSource: IEnumerable<Object>
	- CanEdit: Boolean, if true, then Each Row of the Table will have 'Edit' button
		- Once this button is clicked the selected value will be emitted to parent
	- CanSort: Boolean, if it is true, then the Table will be sorted based on Property SortKey
	- SortKey: String, the roperty NAme accepted from Parent to show the data in table sorted based on Propety NAme

	- e.g.
		&lt;TableComponent DataSource="Employees" CanEdit="true" CanSort="true" SortKey="EmpName"&gt;
			- TableComponent will show EMployees in HTML Table, where Each row will show Edit Button because 'CanEdit' is true. Since CanSort is true the Data in Table will be sorted based on SortKey i.e. EmpName  

2. Above the Table add tow Radio Butons, Sort and Reverse
	- WHen SOrt is clicked based on the SOrtKey the tabl will show data in sorted manner
	- If Reverse is licked then based on SortKey the data in table will be shown in reverse manner	
3. (optional): ABove the table add a TextBox, when a text is entered into this, based on the text, filter data from the table
	- e.g. If Table is showing products information so if the TextBox has CategoryNAme value then the table will show all produts of the CategoryNAme 

# 18-APril-2022

1. Complete .NET Core FullStack App with CRUD Operations from Blazor to API To Database using EF COre.
	- MAke sure that once the record is created/updated/deleted it MUST be reflected into the Table w/o Ostback
	- TO Edit the REcord, Select row from the tabl,e it will be displayed into TExt boxes, edite these values ad click on save button to compete edit
	- Each table ro MUST have delete button to delete the selected row
	- Category and Product

# 20-APril-2022
1. Create a Blazor FullStack Application for managing the CRUD OPerations on Products Table that is Created in MS-SQL Database
	- Products: ProdictRowID (indentity), ProductID (P.K.), ProductName, CategoryName, Manufacturer, Price
		- The the above Columns are required 
	- Users
		- UserName (Primary Key), Password
			- Harc-Code USer NAmes and PAsswords
	- Create a WEB API that will use EF Core DB-First APprch to perform CRUD Operations
	- Crete a Blazor App that will have components for List, Create, Edit, Delete
	- Make sure that, the USer loggedin first before accessing the Blazor App
		- When Blazor App is loaded the Login Compoent MUST be shown
			- if the Login Fail then show Error Component
		