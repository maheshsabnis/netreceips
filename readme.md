Open Visual Studio 2019/2022 (Enterprise/Pro/Comminuty Edition)

- Two Important Concepts
	- Solution
		- A Workspace for all .NET Projects
		- Extension is '.sln'
	- Project
		- The Application developed by developer
		- Contains Source Code
			- Class Files
		- Project Types
			- Desktop Projects
				- Console Apps, WinForm, WPF, Windows Service
				- Compiled into EXE
			- Class Library Project
				- Code for distrubution in other projects
				- Compiled into DLL
			- Web Application Project
				- Compiled into DLL and Hosted into the EXE (Only for .NET Core, .NET 5/6)
					- ASP.NET Razor
					- MVC
					- WEB API
					- Blazor
			- Other Project Types
				- Mobile Apps
				- IoT Apps
				- Third-Party Apps
				- Node.js
				-... and many more

- Solution will be created directly when the Project is created
- We Can create a 'Blank Solution' and add Projects in it	

- File-->New-->Project
	--> This will open a Dialog Box, Select Blank Solution from it
		--> Next --> Name The Solution and Set the Location e.g. C:\Coditas
			--> Create 
- Right-Click on the Solution and Select 'Add New Project'
	--> From 'Add New Project' DialogBox, select the 'Console Application'	
		(Note: Select the COnsole Application with C# Linux macOS Windows Console on it)
	--> Click on 'Next' --> Provide the Project Name-->Keep the Location of the 'Solution' as it is
	--> CLick on 'Next' --> From the Dropdown select '.NET 5'
	--> Click on Create
- If a Solution Contains Multiple-Projects, then to run a spefic project from the solution 
	--> Right-Click on the Project and select the 'Set as startup project'

#===============================================================================================================
# Project Structure
	- Each Project has dependencies
		- They are the Sandard or 'Common Base Libraries' those are required to execute the Project
		- e.g.
			- Microsoft.NETCore.App
				- A .NET 5 Library that has all the .NET 5 Common Libraries inside it

# .NET EcoSystem OR Building Blocks for Application Development 
	- Common Language Specificcations (CLS)
		- Common Language Specifications, The Syntax Check in Source Code, Verify the Keywords (Semantics) e.g. Verify the Expression

		e.g. Left-Hand-Side = Right-Hand-Side; 
		e.g. If  x is declared as integer, then value in x MUST be in the Range of Integers

	- Common Type System (CTS)
		- This contains all DataTypes in it 
		- The CLS uses CTS to maske sure that the Source code have used the DataType Propertly with value Ranges
			- Numeric Types
			- Character
			- Strings
			- DateTime
			- Boolean
	- Common Language Runtime (CLR)
		- Execute the Applciation after IL is JIT Compiled
		- Memory Management	


# C# Programming Language
	- Major Language on .NET Platform
	- 100% Object Oriented Programming Language
	- The Main() method, the Entry Point of the Application
	- The 'Namespace'
		- A Logical Container for all classes
		- Each Project Name (aka Assembly-Name) is a Namespace
		- Ine One Application there can be Multiple Namespaces athe they will be
			- [PROJECT-NAME].[CUSTOM-NAMESPACE-NAME]
		- If the Source-code uses any class, then make sure that its namespace is imported in Source code file as (CLS Rule)
			- using [NAMESPACE-NAME]
	- The 'Console' class
		- A Class under the 'System' Namespace
		- The WriteLine() method that is used to print message to the console window
		- The ReadLine() meth, used to accept data from the COnsole which is always 'string'
			- To Convert the String into Integer, Short, Byte, double, decimal, float, etc.
				- use  'Convert' Class
	- To Run the Project, Press F5 button
		- To Build the Project 
			- Build Menu --> Build Project Name
		- Project Debugging
			- It is Process using which an execution of each statement is verified
			- Follwoign Steps MUST be followed for debugging
				- using 'F9' to apply the Breakpoint on the line from which code is debugged
				- Run the Project using 'F5' and that will enter into the Debug-Mode from the breakpoint line
				- Using 'F11' to debug each line in source-code, inclusing the method call by jumping into the method
				- OR If you want to skip the JUMP into the called method body, then use 'F10'
# Creating Methods
	- In a Program class, each method MUST be 'static'
	- This method can have input and output parameters
		- static [RETURN-TYPE] [METHOD-NAME](PAREMETERS)
		{
		    // METHOD-BODY
		}
		- PARAMETERS: They are called as 'Formal-Parameters'
	- If a method is returning a value, them make sure that, the method has 'return' statement
		- If there is if.. OR if...else... then these Block MUST have return statement
		- OR If the if..else... block is processng data based on condition (if/else) then out of the if..else.. block return the data with return statement. 
# C# Programming Strctures
	- Conditional Staructrure
		- if statement
		- if...else statement
		- nested if
			- if...else...if
		
		- Switch Block
			- switch(Parameter OR Value to be conditionally check)
				- case [CONDITION]:	
						{
							// EXECUTION-BLOCK		
						}
				- .... multiple cases
				- default:
					// do something if non of the condition is satisfied		
	- Condition Operators
		- > , < , >=, <=, == (Comparision), != (Not-Equal)
		- Logical Operators
			- || OR
			- && AND
			- ! NOT
	- Iterations	
		- Loops used for reading the Data
			- for..loop
			- foreach
			- while
			- do..while
		- These are index Based Loops
			- StartIndex, Condition to stop/terminate, EndIndex
	- Defining Methods parameters
		- using the 'ref'
			- it is a mechanim for passing parameter references of actual parameter to a method instead of actual parameter value
			- Syntax
				- int a=10,b=20
				- pass the parameter
					- Change(ref a, ref b);
				- void Change(ref int x, ref int y) {}
			- IMP: The declaration with 'ref' MUST be initialoized befor passing to method
		- using the 'out'
			- Like 'ref'
			- The 'out' varianble need not be initialized before passing to the method
			- Generally used when a method want to return more than a parameter (a single value) from a method
				- Change(out a, out b);
			- void Change(out int x, out int y) 
			{
				// set value for x and y and then process
				// the processed value will be set to the actual parameter over its reference
			}
		- using the 'params' a mechanism of passing flexible number of parameters to a method
			- Internally this will be treated as an 'Array' 
			- The method MUST have 'params' as a last parameter to a method
			- e.g.
				- VALID Syntax
					- Add(int a,int b, params int[]x){}
				- INVALID Syntax
					- Add(params int[]x,int z,int y){}
# C# String
	- Array of Characters
		- Using '+' sign to Concat the String
	- By default string is a class that has verious methods
	- Interpolation or String Termplates
		- Mechanism of String Concatination
			- OLD: str1 + str2
			- Interpolations: $"{str1} {str2}"
				- Internally will invoke 'String.Format()'
	- Techniacally
		- A String is an Array of Characters
# Using C# Data Structures
	- An arrangement for stroing data in well-organized manner for efficient Read/Write
		- Array
			- The Most popular
			- System.Array is a Class for defining an Array type
			- Syntax
				- DataType [] Identifier;
				- By Default an array identifier is an instance of array class 
				- THis will provides various methods to work with array 
		- Collections
			- A preferred way of storing data in memory
			- This need not to be set with UpperSize by default
			- We can keep on adding data in it
			- IMP: Each entry in collection is stored as 'an object'
			- System.Collections is a namespace having collection classes 
				- ArrayList, LinkedList, Stack, Queue, etc.
			
		- Generics
			- Data Structure Templates
				- A predefined arrangement for Storing data which is common for all data types
			- USed to store data of 'SAME-TYPE' in the Collections in the memory w/o boxing 
			- System.Collectrions.Generic
				- List<T>
				- ArrayList<T>
				- Stack<T>
				- Queue<T>
				- ..... and many more
			- The 'T' is a Template Parameter aka Type Parameter that will be stored in the Data Structure
				- If 'T' is 'int' then the data structure will have data only oif the type integer
				- E.g. List<int> will create a List of Integers, List<string> will have only strings 
				- T can be any CTS type
					- Primitive Types
					- Custom CLR types
						- Classes
						- Methods
						- Interfaces
						- Events
						- Delegates
			- Once the 'T' is set to the specific type e.g. int or string, a seperate copy of the same generic type will be created into the memory in Binary Format
			- Mukti-Type Generics
				- The Data Structure used for Multiple-Type Parameters
				- MyClass<U,V>
					- Typically used for storing Key/Value pair


# Object Oriented Programming (OOPs) with C#	
	- Class
		- Access Specifiers, used to define the scope for accessing, class and its members
			- public, private, protected
			- internal, protected internal
		- Access Modifiers, they are used to define access behavior of the class and its members 
			- static, abstract, virtual, sealed
		- Inheritance
		- Polymorphism
	- Interface

	- Class is an encapsulation for
		- Data Members 
			- They are the properties used to store data for the class
			- This is an Abstraction for the data 
		- Members Methods (functions)
			- They are the behaviors on the data members to process them
			- Methods will define logic for processing
			- Class with encapsulate Logic and its processed outoput will be returned to other method within class and/or outside of the class 
		- Instance
			- Real-Word representation of the class
			- The Memory for class will be allocated when an instance is created
			- The instance contains 'defaults' for data members
				- e.g. for 'int' data member the defaultr will be 0 or the value set bt during declaration
			- The class will be in action (in-use) is possible only after an instance is created, otherwise the application will crash
		- Access Specifiers in .NET for C#
			- public
				- Members is accessible within and outisde the class
			- private
				- Members are accessible only within the class
				- Default to all members of the class
			- protected
				- Members are accessible within class and in derived class
			- internal
				- Members are accessible with the containing namespace. The namespace in which class is declared
				- Default to class 
			- protected internal
				- Members are accessible within the class, in the derived class of same namespace and derived class of other namespace
		- The 'this' concept
			- All Class members are accessed within the class using the 'this' object
			- The 'this' is the class scope (instance) itself within the class
		- Class Members
			- Variable
			- Methods
			- Constructor
			- Properties
				- Get/Set properties
				- They are public method blocks to Read (Get) and Write (Set) values for private members of the class
			- Event
	- To make sure that the method for class work or executes successfully, handle exception
		- The 'exception' is a mechanism using which 'SOME MEANINGFUL' result is returned or provided to the called when an execution is failed because of 'SOME UNCERTAINANITY'
		- Syntax:
			- try {..... THE CODE TO BE EXECUTED.....} catch(Exception ex){...THE CODE TO BE  EXECUTED IF CODE IN TRY IS FAILED TO EXECUTE.........} finally {.....THE CODE THAT WILL ALWAYS BE EXECUTED IRRESPECTIVE OF try BLOCK OR catch BLOCK............}
			- try 
			{
			   .......
			}
			catch(Exception ex) 
			{
				..........
			}
			finally
			{
			  ........
			}
		- The 'Exception', the Top-most class for all Exceptions
			- The 'Message' proeprty will contain the Error Detail occured during an execution of 'try' block 
		- To Throw and handle exception conditinally, use the 'throw' keyword
			- if(CONDITION)
			{
			   throw new Exception("MESSAGE");
			}
			- The thrown excpetion is also habdled by 'catch' block 
- Class definition Strategies
	- Class used only for Storing Data for Read/Write Operations MUST have only 'public properties'
		- These classes as known as Data Clases aka Entities
		- Public properties are used for Performing Read/Write operations on Private Data Members
		- Auto-Implemented Properties introduced in C# 3.0
			- Access_Specifier ReturnType PROEPRTY-NAME {get;set;}
			- The private member aka 'BAcking-Field' will be defined by CLS
	- If the class used to define Business Logic aka Domain Logic then it will contian methods with required Access Specifiers 
	- Guidelines for Class Creation
		- Start Design using Abstract class
			- Design Standard that will be followed by add Class Derivations aka Inheritance	
			- Use Inheritance when a specific-type of logical funcationality is to be implemented for the application
				- e.g. Employee Management System
					- Employee Base Class can have following derivations
						- FullTime, Base Type
							- Manager
							- Engineer
							- Clerk
						- Consultant
						- DailyWages
			- The Inheritance provided Following Features in Application Development
				- Uses the Base Type Public/Protected Properties as-it-is
				- The Derived Type can additionaly add extra properties and behavior
					- AKA 'Decorattion'
		- (Observation)
			- Since the 'Object' is highest-level DataType in .NET, each type 'is of the type object' and then it has an access to public methods of the 'Object' class
			- No Multiple Inheritence allowed in .NET 
				- No Multiple Parents are allowed for the class
			- Using the 'base' keyword, the 'protected' member of the base class can be accessbile in derived class
			- Within the namespace the 'internal' member of the class is accessible

		- (Critical Observations)

			- Overloading: Having Multiple methods  with same name but differnt in any of the following in Same class or Base and derived classes
				- Number of Parameters
				- Type of parameters
				- Order of Parameters
			- What if the Base class and Derived class has 'Same method name with Same Signeture'? 

				- If a System has multiple classes with common functionalities in more than two classes then add the common functionality in base classs and extend the base classs by derived classes

					- If the Base class is a Template Functionality for all derived classes, then we need not to instantiate it, so make it as 'abstract' class using 'abstract' access modifier.

				- If any of the derive class wants to extend a behavior of the base class method, then make sure that the base class method must be set the access modifier as 'virtual'.

				- METHOD OVERRIDING (Polymorphism)
					- The class that wants to extend the method will override it using 'override' access modifier on the method of the derived class and write new implementation for it.
				- If the all derive classes wants to define complete 'new implementation' for the matching method of the abstract base class, then do not provide any implementation for the method of abstract base class, just make the method as 'abstract' method 
					- all derive classed MUST OVERRIDE all abstract method of the basse class else make the derive class as 'abstract'
			
				- METHOD SHADOWING (Polymorphism)
					- What if the derived class does not want to override the method of the base class but instead, wants to define a complete new implementation to method from the derive class?  
						- Use the Method Shadowing by using 'new' access modifier definition for the method of the derived class
		- The Sealed class
			- The class that cannot be inherited
			- Use the 'sealed' access modifier
- Interfaces	
	- it is a type in ,NET programming that is used for following
		- Establish Communication across the Objects Horizontaly
		- It contains method definition that can be inplemented by each class with their own requirements of the logic
			- Like Abstract Methods of Abstract class
	- Abstract Class Vs Intercace
		- Abstract class is mainly used to define Implementation standard within a namespace for all classed deribed from Abstract class
		- Verticle search or instance casting is fastest in a namespace while using Abstract classs
		- Interfaces are more useful to establish horizontaal communication between objects in Inter-system communication
		- Interfaces does not have any metho implementation (by default) (NOTE: Provided from C# 8.0)
		- Rule: When a class implement an interface, all methods of the interface MUST be implemented by the class
		- A Class can implement Multiple interfaces be can have only one parent/Base class
		- (IMP***)An interface can be Implicitely Implemenetd or Explicitely implemented by a class 
			- A Polymorphism using interface
	- Implicit Implementation Vs Explicit Implementation
		- Implicit Implementation: The class is Owner of methods from Interface. All methods are accessed using an instance of the class as well as using the Interface Reference 
		- Explicit Implementation
			- Although methods from interface are physically implemented by class still those methods are owned by the intarface
			- These methods are accessed using Interface Reference of which instance is created by the class
	- Facts or Observations
		- One class can implement Multiple Interfaces
		- If these interfaces are having same signeture with same name then the class MUST implement them Explicitely
		- Interfaces are not for "MULTIPLE INHERITANCE"
# Using the Delegates and Events
	- Delegate
		- A .NET Type that is used to invoke a method with its reference and execute it (Fresher's Definition')
			- Same as Pointer-to-function in C,C++
		- The 'System.Delegate' is type in CTS and the keyword is 'delegate'
		- To execute a method using delegate the signeture of the method MUST match with Signeture of the delegate
		- Define a Delegate at Namespace level sothat it can be used by all Classes under the namespace
	- Observations on Delegates
		- Since a Delegate contains the Method reference, we can directly pass the method implementation to the delegate without creating any 'Named-Method'
			- Anonymous Method in C# 2.0
				- The Implementations passed to delegate will be directly converted into Binary and executed (Better for performance)
				- E.g.
					- handler = delegate (int x, int y) { return x + y; };
					- Operand Tree
						- x,y
					- Operator Tree
						- +
					- Expression Tree for Evaluation in Binary Form
						- x + y
		- What if there exists a Method that accepts an input parameter as Delegate?
			- e.g.
				- void Process(ProcessHandler handler){......}
			- C# 2.0 To Such Method we can pass the delegate that has anonymous method implementation
				- e.g.
					- handler = delegate (int x, int y) { return x + y; };
					- Process(handler);
			- C# 2.0 To Such Method we can direcly pass the Anonymous Method  
				- e.g.	
					-   Process(delegate (int a,int b) { return a * b; });
			- C# 3.0 To Such method we can pass a very simple syntax as 'Lambda Expression'
				- e.g.
					- Process((int x,int y) => { return x * x * y * y; });
					- The Entire Lambda Expreassion will be directly Compiled and executed into Binary(Best for Perfromance) 
			- NOTE****
				- If a method accepts delegate as input parameter then to that method we can pass Lambda Expression

		- Used for establishing communication across Objects (Advanced-Definition)
		- Used for defining an Event to establish Communciation across objects (Advanced-Definition)
			- The Event is used for 'Actoin-Based-Programming'
			- Some Action Has to take place so that a Notification is generated (aka Event)
			- An Event is a Special Type of Delegate, that is Raised when an action is taken place that will trigger and event to notify 
			- The delegate that is used to define an event MUST have a return type as 'void'

		- Steps for Working with Events
			- Define a delegate that has return type as 'void'
			- Define event using the delegate inside the class (Logic / Domain class) that will be generating notifications
			- Define a NotificationListener class, this class will be responsible for listening to events raised by the domain class
			- Client class that will call the domain class for transactions as well as will subscribe to the Notification Listener class so that the Notifcations are received

		- Next Level
			- Used for Threading in .NET
			- Used for Asynchronous Programming in .NET
# C# 3.0
	- All Chganges are done by Microsoft for Supporting Language Integrated Query aka LINQ
		- The 'var' declaration
			- used for defining Local variables in a method
			- the 'var' must be initialized
			- the typof of var declaration will be set based on the Left-Hand-Side initial value
			- one the 'var' declaration is initialized, we cannot assign differnt type parameter to it
		- Auto-Implemented properties
		- Lambda Expression
		- Extension Methods
			- They are an extended funcationalities added into the 'Standard CLR classes' as well as 'Custom Defined Sealed classes' without inheritance or modifiying the code of existing class 
			- Advantages
				- We can easily add an enhanced fucntionality as per the requirements in an existing class
				- No derivation is needed
				- No code changes are required
				- Improve speed of application development by adding new functionality in an existing application without stopping the existing 'under-use' application
			- Rules
				- The class that contains extension methods MUST be 'static'
				- The method to be used as ecxtension method MUST ne  'static'
				- The first parameter of this method MUST be 'this' referred reference of the 'class' or 'interface' for which we are adding the current method as extension method
				- e.g.
					- the sealed class as
						- public sealed class MyClass{.......}
					- Writing an extension method
						public static class MyExtension 
						{
							public static void MyExtensionMethod(this MyClass obj, int x,int y,....  )
							{
							
							}
						}
					- We can access the MyExtensionMethod() using an instance of the MyClass class
						- MyClass obj = new MyClass();
						- obj.MyExtensionMethod(x,y,....);
		- Object and Collection Initializers
		- Expression Tree
# Application Development
	- While defining a  generic class with generaic type parameter, make sure that the generic type parameter has 'type constraints'
		- Means the Generic Type parameter will be alowys of that type
		- e.g.
			- class GenericStack<T> where T : class
			{}
			- using 'where', we are informing to the coompiler that T will always be a class-type
	- While creating a generic interface for CRUD Operations, make sure that, for reading all records, instead of using a specific collection(or generic) type use a interface implemented by all collection(or generic) type
	- Conditional Serach
		- Retrieving collections based on Complex Conditions
		- Reorganize the collection into the groups, sort, reverse, take average, read position based data e.g. Take first 5 recodrs, skip first 4 records, etc.
	- C#.30 from .NET Framework 3.5+, Language Integrated Query (LINQ)
		- From .NET Frwk 3.5+, the Object and Data are accepted as "SAME Concepts" so they were queried using "Language Integrated Query" aka LINQ
		- IMP*** Note
			- In .NET Core Versions (.NET Core 1.x, 2.x, 3.x) and .NET 5,.NET 6, all LINQ methods are directly added in Collection Classes ro reducer the Memory-Utilization  and Process Space
		- LINQ
			- Newly define "extension methods" for Collection for performing following operations
				- Search
				- Rearrange
				- Orders
				- Groups
				- Read Specific records
				- .... and many more
			- ExtensionMethod(Lambda-Expression-As-Input-Paramater)
				- Standard Delegates
					- Predicate<T>
						- An Delegate Expression that will be  evaluated against an object to perform operations like filter, search, etc.
							- e.g.
								- collection.Where(e=>e.id ==100);
									- e=>e.id ==100, Predicate, a Pattern expression that will be executed on the collection
					- Func<T,U>
						- A Delegate that executes a logic
						- A logic that will be executed to re-arange the collection or process the collection
						- collection.ExtensionMethod(e=> {state1;state2;state3;......})
					- Action / Action<T>
						- Hiding Method Implementation
			- The LINQ is targetted to all 'IEnumerable' types aka Collections (Including Generics)
				- Target Object
					- The IEnumerable Type that contains data as Records
				- LINQ
					- Query that contains Methods and Expressions those are executed on Target Object 
				- Expression Tree
					- It is a Parsing for Query that will take each method from LINQ along with the Lambda Expression passed to it
					- The Expression will be Evaluated
						- Operands
						- Operators
					- The Parsed Expression will be Processed on the Target Object
				- Execution
					- Each Record from the target object will be evaluated and put into the Resulat Memory
						- Deferred Execution
			- Declarative Query
				- The LINQ uses extension Methods in Code
			- Imperative Query
				- Query Like Database Syntax with 'OPERATORS' those are mapped with Extension methods
					- Select(), select operator
					- Where(), where
					- OrderBy(), orderby
					- OrderByDescending(), orderby CONDITION desc
					- GroupBy(), group NAME-OF-GROUP by COLIUMN into GROUPNAME
				- e.g.
					- var res = from e in employees
                      select e
					- employees is a targte object
					- e is a renge variable, this is implicitely casted to a record type from the target object
					- select this will be mapped with the exetsnion method
				- Care to take while defining a Group
					- Create a Temporary Type or Object in memory to store the group information
						- new {};
							- C# 3.0 Anonymous Type, a class without any name created at runtime by CLR
				- LINQ Operator Methods
					- Sum(), Max(), Min(), Avg(), Count(), etc.
				- Join
					- A Mechanism to establish an association across 2 collections 
						- Join() method
			- LINQ to XML aka XLinq
			- LINQ to Database (SQL) aka DLinq 
# File Streams aka File I/O
	- System.IO Namespace
		- Stream a Base class
			- A Stream is an approach where data is well organized from its first byte to the last byte
			- There is a Read/Write Operation Possibility on Stream
			- The best mechanism for data exchange across apps using
				- Inter Process Communication (IPC)
				- Binary Format across Machines using TCP/IP
				- In Text Format on Internet or Wide-Area-Network using Http/Https
		- Following are derivations from Stream class
			- FileStream
				- Used to Create, Write, Read Files
				- If the FileStream is used for Read/Write Operations in a single block (Pair of {}) e.g. Method, if..else statenment, then make sure that before starting second operation using the same FileStream instance, close the FileStream object aftre completing the first operation 
			- MemoryStream
				- Pure Binary Data stored in memory for Communication across Processes 
			- NetworkStream
				- Pure Binary Data that will be used for communication across Processes on one Machine or across mechines using Communication Protocol 
		- StreamReader and StreamWriter
			- Used to Read/Write Stream
				- TextReader and TextWriter
				- BinaryReader and BinaryWriter
		- File (All Methods are Static)
			- The class that directly interactes with OS for File I/O Operations
				- Create, Read, Write, Append
				- Copy, Move, Delete, Rename
			- We can use Universal Text Format aka UTF while Read/Write Operations (Text method for Read/Write are already available)
		- Directory (All Methods are Static)
			- The class that directly interactes with OS for File Volumns (C:\, D:\)
				- Used create and Manageg Directories
		- FileInfo
			- Instance class for File Operations
			- Provides File Information like Name, Size, Extension, Path, etc.
		- DirectoryInfo
			- Instance class for Directory Operations
			- Provides Directory Information like Name, Size, Path, etc.
# Managed Code and Unmanaged Code
	- All Code that is executed withing boundaries of CLR is called as Managed Code 
		- e.g. User defined Classes, All Standard Classes provided in Framework Class Library those not crossing boundaries of CLR are called as Managed Resources Code
			- e.g. if creating an Employee, Department class and its List collecctio, the CLR is capable enough to manage these classes , their instances and hence the scope 
	- The code useing the Standard .NET Classes by if they are dependant on resources out-of-the boundary of the CLR they are called as UnManaged Resources, they are not purely managed by CLR
		- e.g
			- File Operations or Streams
			- Database Connections
			- Network or Protocol Resources
			- Other Hardware Interactions e.g. Accessing Camera, Audio/Video Devices, GPRS, etc.
# Serialization in .NET 
	- The Process of maintaining the state of the object into a stream
		- state, it is a schema and Values (aks data) of the object
			- e.g. For Employee Object the State Will be
				- Properties
					- EmpNo, EmpName, DeptName, Salary, Designation
				- Values
					- 101, "Mahesh", "IT", 123345456, "Director"
	- Formatter
		- The Format in which data will be stored into the stream
			- BinaryFormatter (All Versions of .NET)
				- Serialize(Stream stream, Object obj)
					- Write the 'obj' into 'stream'
				- Object obj = Deserialize(Stream stream)
					- Read an object state from 'stream' and stored in back into the 'obj'

			- SoapFormatter (All Versions of .NET, not preferred)
			- JsonFormatter (.NET Core 3.0+, fast)
				- System.Text.Json
					- JsonSerializer
						- Write Data in JSON Format
						- JavaScript Object Notation (JSON)
		- The IFormatter Interface provided by .NET to Convert the Object into a specific Format and stored it into Stream
	- The 'SerializableAttribute' class from System namespace
		- This is applied on the class which is to be serialized as 'Attribute'
		- The Attribute is an additional behavioral information of the class (and hence object)
		- If the class is applied with [Serializable] attribute, then all its 'public properties' can be stored into the stream
			- Syntax
				- [Serializable]
				  public class MyClass {.....PUBLIC PROPERTIES.....}	
				- NOTE: The Word 'Attribute' will be filteredout by the Compiler
		- Note: The Class to be used as Attribute MUST eb derived from 'Attribute' class 	

-  Well Form Data Organization	
	- Organize the data in the Suitable Manner under following Parameters
		- Use the Correct File Format
			- .txt. .dat, .doc/docs, .xls/xlsx, .csv
		- Put data in directoriess so that buch of files can be managed at a time  	
			- Directory class
				- Static
			- DirectoryInfo
				- Instnace
		- These classes uses 'IEnumerable' hence supports LINQ
	- Special Data Structure declarations
		- Tuples (C# 7.0)
		- Records (C# 9.0)
- To view an Assembly with IL and MetaInfo use 'Ildasm.exe' tool
	- Intermidiate Language Dis-Asssembler
	- This tool will be installed as Microsfot SDK in Windows OS
		- C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools
- The foreach..loop can be used only for those types who implements IEnumerable Interface

# Observation of Storing Data in Files
	- Since Files are managed by OS, even the app crash, the data is maintained
	- Files can be easily Copied or Moved to different volume either using Application or Mannualy 
	- If the file is already in use then it cannot be modified/moved
	- Reading data from file is having cost increasing beased on File Size 
		- Huge File Size needs
			- More Disk Space
			- More memory to load
			- More time to read 
		- The file MUST be Compressed before Copy/Move
			- gZip by .NET
	- The Data stored in file does not easily support random read/write	
		- Doing this is Time Consuming Process
	- The File Security MUST allow the current application to provide Create/Red/Write access

# Working With SQL Server Database
1. RDBMS by Micrisoft
2. Allows ro Create Database, Tables, Views, Stored Procedures, Fucntions, Cursors, etc.
2. Table Columns with Following Datatypes

Data Type		Memory(bytes)						Lower Limit				Upper Limit
bigint			8									-2^63					+2^63-1
int				4									-2^31					+2^31-1
smallint		2									-2^15					+2^15-1
tinyint			1									0						255
bit				1									0						1	(Boolean values)
decimal			5 to 17								-10^38+1				+10^38-1
numeric			5 to 17								-10^38+1				+10^31-1
money			8									Same as Bigint
smallmoney		4									Same as int

Data Type		Precision

float(n)		7 digits							Memory is dependant on value of n (byte)
real			15 digits							4 bytes Memory used to store values related to complex math													  operations
Data type		Memory (bytes)
datetime		8
smalldatetime	4 (fixed)
date			3 (fixed)
time			5									Accurate upto 100 nanoseconds
datetimeoffset	10									Accurate upto 100 nanoseconds and user for Server-Side Times
datetime2		6									Accurate upto 100 nanoseconds

char			n bytes								n is number of characters min is 0 max is 8000 chars
varchar			n bytes + 2 bytes					0 to 8000 (variable)
varchar(max)	n bytes + 2 bytes					2^34 characters
text			n bytes + 4 bytes					

Special Unicode characters (Internationalization)

nchar			2 times for n
nvarchar		2 time of n + 2 bytes	
ntext			2 times of the total length

Binary Datatypes (Images, Vides, Documents)
binary, varcharbinary, image

SQL Server Specific DataTypes used by Stored Procedures (SPs), general return types from SPs
	- table, cursor, XML, rowversion, uniqueidentifier (16 bytes aka GUID), etc.

# SQL Server Programming
1. Create Statements (Definition Statements)
	- Database
		- Create Database
	- Table
		- Create Table
	- View
		- Create View
	- Stored Procedure
		- Create Proceddure
	- Function
		- Create Fucntion
2. Modifications
	- Alter Statement
		- Alter Database
		- Alter Table
		- Alter View
		- Alter Procedure
		- Alter Function
3. Select Statements (Highest Probability of Programming)
	- Select
		- Conditions
			- Where
		- Rearrangements
			- Order by
			- Order by ... descending
			- Group By
		- Joins
			- Inner Join
			- Left
			- Right
	- Standard Functions or Operatoers
		- Count(), Min(), Max(), Avg, Sum
		- And,OR ,Not
		- IN, Like, Between
4. Data Manipulation Statements (DML)
	- Insert
		- Create new Row
	- Update
		- Modifiy Existing Row
	- Delete
		- Remove Exiusring Rows
#=================================================================================================================

# Database Programming using ADO.NET
1. System.Data
	- System.Data.SqlClient
		- SQL Server Provider for Data Access for .NET Apps in ADO.NET
2. Base Object Model in ADO.NET
	- DbConnection
		- Class to Connect to Database
	- DbCommand
		- Used to make request to databse to execute queries and SP over the connection 
	- DbReader
		- A Cursor aka a pointer to the resultant of 'Select Query' on database	
			- resultant: the memory area where rows are stored aka ResultSet
				- ResultSet: This is an arrangement of Rows read from Table(s) after select query execution 
					- One ResultSet can contain on-or-more rowsets
					- rowset: It is a select query result on a single table
		- This is a Read-Only-Forward-Only Cursor
3. Connected Architectures uses following objects
	- DbConnection, DbCommand, DbReader
4. SQL Server
	- SqlConnection:DbConnection
		- Methods
			- Open()
				- Open the Connection Based on the Connection Information aka ConnectionString to SQL Database
			- Close()
				- Close the Connection
			- BegingTransaction()
				- Start Transaction
			- CommitTransaction()
				- Save to DB
		- Properties
			- ConnectionString
				- Accepts a Connection string fro SQL Server Database
				- e.g.
					- "Data Source=[SERVER-NAME|IP-ADDRESS|Localhost|.]; Initial Catalog=[Database-Name]; Integrated Security=SSPI"
						- Integrated Security=SSPI: Used with for Windows Authentication for SQL Server
					
					- "Data Source=[SERVER-NAME|IP-ADDRESS|Localhost|.]; Initial Catalog=[Database-Name]; Use Id=[USER-NAME];Password=[Password]"
						- Use this if using the SQL Server Authentication

					- "Server=[SERVER-NAME|IP-ADDRESS|Localhost|.]; Database=[Database-Name]; Use Id=[USER-NAME];Password=[Password]"
			- State
				- Connection State
					- Open
					- Close
			- Command
				- Accept the Command Object (SqlCommand) for Starting Transactions
			

	- SqlCommand:DbCommand
		- Methods (Synchronous-Methods)
			- ExecuteReader()
				- Execute a select query on DB. This return an instance of SqlDataReader
			- ExecuteNonQuery()
				- USed to Execute DML Statements (Insert, Update, Delete)
				- Return a 'non-zero number' that represents number of records affected
			- ExecuteScalar()
				- USed to execute Scalar Queries (Select Queries with Scalar functions)
				- Used to execute SP
				- Return a single value
			- ExecuteXmlReader()
				- Execute Select Statement and return XML data from it (SQL Server 2005+)
				- The Select query must have xml
				- select * from Department For xml path('Departments')
	- SqlDataReader:DbReader
		- It is a cursor
		- 'Only-One' DataReader object is allowed over a single active connection by default
			- THis is a  problem to read data from muliple tables
		- Methods
			- Read()
				- Continue reading data from the cursor till End-of-Rows not received
			- Next() ADO.NET 1.x, uased in case to read data from Multiple tables
				- If a Single Reqest on Command object has Multiple Select-Statements for differemt table then a resultset will contain multiple rowsets, so to read all row sets, the Reader has to jump from one rowset-to-other, this is done using Next() method 
				- Select * from Department;select * from Employee
				
				- The data from RowSet is read using the Reader as follows
					- reader["COLUMN-NAME-AS-STRING" | INDEX-AS-ZERO-BASED-NUMBER]
			- Close()
				- Close the Reader
				- Its is Mandatory so that another Select Statement can be executed
	- ADO.NET 2.0 New Concept to Read the Data
		- Multipl-Active-Result-Sets (MARS)
			- Allows to execute Multiple Readers at a time over a single active conection
		- To use MARS change the ConenctoinString
		- "Data Source=[SERVER-NAME|IP-ADDRESS|Localhost|.]; Initial Catalog=[Database-Name]; Integrated Security=SSPI;MultipleActiveResultSets=true"
			- Entrypoint to EntifyFramework
5. Steps for ADO.NET Programming
	- Make sure that the Database is accessible with ServerName, DbName, Credentials
	- Create a Connnction Object with Connection String
	- Open connection
	- Create Command Object with SQL Statement (SELECT|INSERT|UPDATE|DELETE)
	- Use the Execute method of the Command
	- Perform Read Operation if reading data from Database
6. Make sure that the Database Access using ADO.NET MUST use the Exception Handling using try...catch
	- The SqlException is class provided by .NET for Handling SQL Exceptions
	- This is derived from Exception class
7. When Performing DML Opertions (also when the Query needs some input value), then instaed of Concating the values in Queries using Parameterized Queries
	- E.g. Insert Statement
		- Insert into Department values(10,'IT', 'Muumbai', 10000);
		- This means in .NET code we have to pass variable values for  "10,'IT', 'Muumbai', 10000"
		- E.g. if we have variabes
			- DeptNo=10, DeptName="IT", Location="Mumbai", Capacity=10000
			- The Query will be
				- Cmd.CommandText = $"Insert into Department values({DeptNo}, {DeptName}, {Location}, {Capacity})"
			- Instead use the SqlParameters or Parameterized Queries
	- SqlParameter Class
		- Used to define the Parameter object for Parameterized Query and the Stored Procedure
		- Properties
			- ParameterName, the Name of the Parameter
			- Type, data type
			- Direction, the input parameter (default) or output parameter
			- Value, the value
		- To Add Parameters to Conmmand object that is using Parameterized Query or Stored Procedure use following
			- Cmd.Parameters.Add(SqlParameter object)
	``` csharp
				SqlParameter pDeptNo = new SqlParameter();
                pDeptNo.ParameterName = "@DeptNo";
                pDeptNo.SqlDbType = SqlDbType.Int;
                pDeptNo.Direction = ParameterDirection.Input;
                pDeptNo.Value = id;
	```

# ADO.NET Disconnected Architecture
- System.Data
	- DataSet
		- The Miniatuare of Database created in the Client's  Memory
		- It has Following Objects
			- DataTableCollection
				- Collection of the DataTable Object
				- This object represents Tables like Database tables
			- DataTable
				- Contains following objects
					- DataColumnCollection
						- Contains a Schema for storing data in Client's memory
						- Each object in this collection is DataColumn
						- DataColumn
							- Used to define a mechanism of storing data in Databale	
								- Primary Key
								- Not null
								- DataType
					- DataRowCollection
						- Collection of Rows where each object is DataRow
						- DataRow
							- Collection of data received from DB Table or created by the Client application 
			- DataViewCollection
				- Collection of DataView
					- DataView 
						- Liek a View object from the Database
			- DataRelationsCollection
				- Collection of DataRelation Object
					- DataRelation
						- A One-to-One and/or one-to-Many relatrion in DataSet across various of its Data Tables
- To Create the DataSet we need the 'DataAdapter'
	- An Object which is responsible to Connect to DB based on ConnectionString and this object also accepts the Select Statement, based on which the table schema and its data will be read from Database
	- This object will create DataSet in Client's  memory and 'fill' data in it by creating DataTable object in it
	- This obect will also contains following Command objects
		- SelectCommand (Default Bahvior)
			- A 'Plain Select' Statemnent (e.g.Select * from Table) No jon, no where and no other additional select operators 
		- InsertCommand
			- An Insert Statement created by Adapater to perform Insert Operation 
		- UpdateCommand
			- An Update Statement created by Adapater to perform Update Operation 
		- DeleteCommand
			- An Delete Statement created by Adapater to perform Delete Operation 
	- DataAdpater("CONNECTION-STRING-TO-DB", "PLAIN-SELECT-STATEMENT")
		- A 'Fill()' method to fill received data from DB to DataSet
			- Fill(DataSet, "NAME-OF-TABLE-CREATED-IN-DATASET")
				- IMP-NOTE: NAME-OF-TABLE-CREATED-IN-DATASET, MUST match with the Actual Table 
	- Data Adapters object for various databases
		- SqlDataAdpater, for SQL Servre
		- OracleDataAdapter, fopr Oracle
		- OleDbDataAdapter, OdbcDataDapter
- To send the Updated data back to Database use 'CommandBuilder' object
	- This accepts an Adapter object as inout parameter
	- Generate DML Statements based on the Command object generated by the adapter
		- e.g. For InsertCommand, the Insert Statement is generated
	- It will connect back to Database Server
		- Invoke the 'Update()' method on the Adapter object to update data from DataSet to Corresponding table in Database
			- Adapter.Update(DataSet, "NAME-OF-TABLE-CREATED-IN-DATASET");
	- SqlCommandCommandBuilder for SQL Server
	- OracleCommandBuilder, OdbcCommandBuilder, OleDbCommandBuilder
- Types of Dataset
	- Typed DataSet
		- This contains the Constraints by defult when a Table is created in DataSet while calling Fill() method
			- e.g. PrimaryKey, ForeignKey, Not Null,etc.
	- UnTyped DataSet (Default)
		- Does not contain any constraints while creating tabale in DataSet with Fill() method
	- We can convert UnTyped DataSet into Typed DataSet
		- DataSet.MissingSchemaAction property of the DataSet class
			- Ds.MissingSchemaAction = MissingSchmeAction.AddWithKey;
				- This will add all Key constraints for Table Columns
				- Use this Statement before calling Fill() method 
- Pseudo Code
	- Fill data in DataSet
		- Connect to DB usinf Connection object with Connection String
		- Create DataApetr Object and pass the Connection object and Plain Select Statemenent 
		- Create an Instance od DataSet Object
			- DataSet Ds = new DataSet();
		- Fill the Data
			- Adapter.Fill(Ds, "Table-Name");
	- Get All Tables from DataSet
		- DataTableCollection dtCollection = Ds.Table;
	- Get Specific Table
		- DataTable dt  = Ds.Tables["NAME-AS-STRING"|Index-As-Number]; // 0 based index
	- Get All Columns from Table
		- DataColumnCollection dCollection = dt.Columns;
	- Get Specific Column Object
		- DataColumn dc = dt.Columns["NAME-AS-STRING"|Index-As-Number]; // 0 based index
	- Get All Rows of a Specific Table
		- DataRowCollection drCollection = dt.Rows;
	- Get Specific Row from Table based on index
		- DataRow dr = dt.Rows[Index-as-Number]; // 0 based index
	- Find a Row based on Primary Key
		- If  The DataSet is  a Typed DataSet
			- DataRow dr = Ds.Tables["NAME-AS-STRING"|Index-As-Number].Rows.Find(Primary-Key-Value);	
		- If DataSet is UnTyped DataSet (Slow for Perfromance)
			- Set the Column as Unique
				- Ds.Tables["NAME-AS-STRING"|Index-As-Number].Columns.["NAME-AS-STRING"|Index-As-Number].Unique = true;
			- Set the Column as Not Null	
				- Ds.Tables["NAME-AS-STRING"|Index-As-Number].Columns.["NAME-AS-STRING"|Index-As-Number].AllowDbNull = false;
			- Get Column array from the Table which is Unique and Not Null
				- DataColulm [] dcArray = new DataColum[] {Ds.Tables["NAME-AS-STRING"|Index-As-Number].Columns.["NAME-AS-STRING"|Index-As-Number]};
			
			- Set this column as Primary Key by passing the array to Primary Key Value
				- Ds.Tables["NAME-AS-STRING"|Index-As-Number].Columns.["NAME-AS-STRING"|Index-As-Number].PrimaryKey = dcArray;
	- Create a new Row in a Table
		- Create a new Row Object
			- DataRow Dr = Dt.NewRow();
		- Add values for All Columns
			- Dr["Column-Name" | Index] = value;
		- Add this row into the Rows collection of the Table
			- Dt.Rows.Add(Dr);
	- Update Row from Table
		- Find Row based on Primary Key.
		- Update its Column Values
	- Delete the Record
		- Find Row based on Primary Key.
		- Call Delete method for row
			- Dt.Rows.Remove(Dr);	

	- Read data from DataSet as Xml
		- string data = Ds.GetXml();
	- Read All tables schema in Xml form from DataSet
		- string schems = Ds.GetXmlSchema();

	
	- Update Data to Database
		- Create Command Builder and Pass adapter to it
			- SqlCommanBuilder builder = new SqlCommandBuilder(Adapter);
		- Call the Update method
			- Adapter.Update(Ds, "Table-Name" | Index-as-Number);
- Using Stored Procs in Connected Architecture
	- Make sure that the CommandType property of the Commad Object is set to 'CommandType.StoredProcedure'
	- This will make sure that the Command object will connect and inform to DB that Stored Proc is executed

# The Concept of Memory Allocation to Resources in .NET 
- The 'Managed Heap' is used to allocate the memory
	- This is having a pre-calculated memory limit for memory allocation
	- This contains Logical sections to Store Varibales to set its scope
	- These sections are known as 'Generations'
		- Generation 0
			- Used to store all Globals
				- They will be unloaded only when the app is closed / terminated / crashed
		- Generation 1
			- It contains all varibales those are declared for currently executing code-segment or block
	- The Memory Allocation or Management Thread (MMT) is responsible to monitor the veriable allocation in each generation. The MMT is actually known as 'Garbage Collector' aka (GC)	
			- The MMT, will scan the Gen 1 for all 'variable- those-are-out-of-scope' (aka dereferenced) variable and clean then (aka throw out of the memory)
			- The MMT will use this freed memory for new received variable or objects
			- The MMT will scan the Managed Heap for all dereferenced objects so that they can be thrown out or cleared 
		- Generation 2
			- Used for the allocation of all local variables of a code segment
			- This is used if the Gen 2 is full
			- Gen 2 is the primary candidate for getting deallocation
			- This will immediately deallocated by MMT
					
	- If managed heap is 14 mb and its is only allocated for 10 mb then its internal fragmentation
		- Now, if the MMT has to allocate an new object of 7 MB in managed heap, then the external fragmentation is occurred beause there is no enought space avaialble in managed heap to allocate memory for new object of 7 mb 
		- The MMT will start scanning the Managed Heap for dereferenced object and if it it found them then it will be cleaned 
			- e.g.
				- if 5 object are allocated lik A,B,C,D,E in Managhed Heap (MH)
				- A:2mb, B:3mb, C:1mb, D:2mb, e:2mb	, total 10 mb
- Managed and UnManaged Resources
	- Managed Resource
		- They are the Object those are executed within boundaries of CLR
			- e.g. User Defined classes those who are not using Streams, Database Objects, Http Calls, Socket, etc. Ultimately nothing beyond boundaries of CLR.
		- Managed Resources are cleaned by the MMT once they are Dr-referenced

	- UnManaged Resources
		- All those objects goes beyond boundary of CLR or object used by .NET Application thoose are controlled by the following are known as UnManaged Objects
			- Network
			- FileSystem
			- Database
		- The execution of these objects is not possible only within CLR, the CLR has to use OS, Network, FileSystem to execute them
		- The OS needs to provide access of UnManaged objects to CLR for any execution
			- Most of the UnManaged Objects are using the 'Marshalling' i.e. a way of communication between CLR and OS services
			- Marshalling AKA Communication across Processes
		- All UnManaged Objects has the Destructor to Break a Link between CLR and OS Services
			- The CLR invokes a destructor to destroy the link when the UnManaged object is de-referenced
		- The MMT or GC Thread MUST be Invoked Twice to kill an Un-Managed object, this will cost the performance.
			- To improve the performance, .NET Provides 'IDisposable' interface with its Dispose() method
			- Each Un-Managed object implements IDisposable intrface and its Dispose() method to clear the MH instantly but this method must be called explicitely in the code 
	- IMP: If your custom class uses or declares an instance of any of the un-managed resource, then make sure that, that class MUST implement 'IDisposable' interface and its 'Dispose()' method
		- This dispose method will call the Dispose() method of the Un-Managed resource
		- If your class implements an interface explicitely, then all methods will be owned by interface, then in this case let the interface implemenetd by class should implement the IDisposable interface and then in the class implement the Dispose() method explicitely, in this Displose() method call Dispose() method of the Un-Managed object
		- When the Displosable mechnism is used De-Referenced the Un-Managed object will be immedialtly removed fom Managed Heap and hence no twice invoking for MMT or GC thred needs to be called 
- The 'using' block
	- THis is used to define a object under a scope in such a way that, when the using block is done its execution, the Dispose() method will be auto-invoked

# THreadig
	- System.THreading
		- Thread class
			- USes a Delegate that contains a code to be executed on the explicitely created thread (Worker THread)
			- ExecutionContext
				- THe complete execution information of the thread
					- INteract with Clr.exe and demand a thread, put code on the threag using delegate and execute it

# TPL


- Parallel Clas
	- Invoke()
		- Perform Operations on Parallel THreads
		- They will be auto-pivcked by the Parallel Class
		- public static void Invoke(params Action[] actions)
			- Multiple Actions as Input Parameters
			- Action is a standard.NET Delegate
				- Action and Action<T>
					- Action delegate accept method as input which is having no input and output parameter
					- Action<T> delegate accept method as input which is having T as input parameter and no output parameter
		- MAke sure that, methods in INvoke() have the exception handling
	- For()
		- Iterate over te Collection wher each collection will be processed on Separate THread
	- ForEach()
		- Same as For()
	- For() and ForEach() are recomended in the case where large set of collection ir processed
	- IMprove performance a lot
	- Effective use of CPU is possible
- The Task Class
	- A Managed Wrapper on a Thread
	- Technically it is a 'Unit of Async' Operation
	- IAsyncResult is an Interfcae that acts as a Mnitor for Async Executiion State from Main THread to all Worker THreads
	- Task Wraps in it
		- Start THe TAsk
		- Input and Output Paramters
		- Exception Management
		- Dependency across Tasks
	- .NET Framework 4.0+ and Continue in .NET Core 1.x+, the 'Async' methods
		- XXXAsync();
			- Connection.OpenAsync()
			- ALl Async Methods returns TAsk Object
	- Task
		- Start(), Start the Task explicitely, StartNew(), will Start a new Task on a WorkerTHread automtially by reading thread from THreadPool
		- Wait(), wait for all other Tasks to Complete
		- WaitAll(), Wait for all Tasks to COmplete and then only return to MAin Thread
		- Result Property that represents the Outut from Task			
	- TAsk Observations
		- How the TAsk can return data
		- How to implement chanin of Task
			- Dependency across Tasks objects
	- If a Method is returning the Task object then use the 'async' access modifier that represents that the method contains some Asynchornous operations in it and returns the Task from it	 
		- In this method the statememt which is executing Asynchronoulsy MUST be decorated with 'await' statement modifier
			- await will inform CLR that the statement  is Asynchronous

#.NET 3.x/5/6 Publih Features

- THis supports 'Single-File-Publish'
	- We need to Modify the .csproj file for publishing a Single Exe as follows
	- USe Runtime Identifiers from Following
		- https://docs.microsoft.com/en-us/dotnet/core/rid-catalog
``` html
 <PublishSingleFile>true</PublishSingleFile>
	  <RuntimeIdentifier>win-x64</RuntimeIdentifier>
```

- publish trimmed file
``` html
	  <PublishTrimmed>true</PublishTrimmed>
```

- Modern Apps Databases
	- PostgreSQL
	- MySQL
	- Oracle
	- MS-SQL
- NoSQL Databases
	- MongoDB
	- RavenDB
	- DynamoDB
	- CosmosDB
		- TableService by MIcrosoft
		- SQL API earlier it was DocumentDB
		- Graph
- EFfective Data Access
	- EntityFramework Core aka EFCore
		- Cross-PLatform, CLoud-Ready, Lightweight Data Access Technology
		- Database First and Code-First Approach
		- Model Classes are called as Entities
			- Entity ---- Maped-with---- DBTable
	- PAckages
		- Mictosoft.EntityFrameworkCore
		- Mictosoft.EntityFrameworkCore.SqlSever
		- Mictosoft.EntityFrameworkCore.Relatinal
		- Mictosoft.EntityFrameworkCore.Tools
			- Generate Entity Classes from DB Tables
		- Mictosoft.EntityFrameworkCore.Design
			- Manage COnstraints, Relationships across entities based on Table Relationships
		
- INstalling PAckage
	- Download .NET 5/6 SDK
		- https://dotnet.microsoft.com/en-us/download/dotnet/6.0
	- Install the SDK
		- the 'dotnet' Command-Line-Interface (CLI)
		- the 'dotnet ef' CLI for EFCore
			- dotnet tool install --global dotnet-ef
	- Install PAckage for the Application
		- GO to the Command Prompt
		- NAvigate to the Appliation Folder
			- e.g. if App name is MyApp on C:\ drive, the Application folder Path
				- c:\MyApp\MyApp
		- Run the Following COmmand to install the package
			- dotnet add [PACKAGE-NAME]
	- THe Package
		- Microsoft.NetCore.App
			- Is a Default .NER Core Package that contains all standard libraries

# EF COre
1. Avalable on .NET Core 1.x to 3.x, .NET 5/6
2. Corss PLatform
3. Lightweight
3. Asynchronous
4. CLoud-REady
5. Resielent
6. Fast for Data Access
7. Suitable for Web App, API and MIcroservices
8. Supports
	- Database First
	- COde-First
	- COde-Frst with Fluent API
9. Command Line Support
10. Object Model for Database Programming
11. Compiled Queries
12. Flexible Property Mapping
	- The Private property of ENtity Class can be used to mp with Database table using the Public Methods of the class whihc are used to REad/Write value for the Private property
13. Table Per Hierarchy
	- Generate a Table for the BAsed on Derived Entity classes
14. One-to-One, One-to-Many and Many-to-Many Relationships
15. Support fot Stored Procedures and FUnctions
16. COncurrecy Update Management using TimeStamp


# Command to Generate COnceptual Model aka ENtity Classes from Database (Db FIrst)
1. INstall Required PAckages for the Application
	- Mictosoft.EntityFrameworkCore
		- Mictosoft.EntityFrameworkCore.SqlSever
		- Mictosoft.EntityFrameworkCore.Relatinal
		- Mictosoft.EntityFrameworkCore.Tools
		- Mictosoft.EntityFrameworkCore.Design

	- Use The Visual STudio IDE for Adding PAckages in Project from https://www.nuget.org
		- Right-CLick on Project
			- Select 'Manage NuGet PAckages'
			- Search the Package and Install it
	- COmmand Prompt, the Projet Folder (Parent of .bin folder), and run the following command
			- dotnet add package [PACKAGE-NAME]
			- dotnet add package Microsoft.EntityFrameworkCore
			- dotnet add package Microsoft.EntityFrameworkCore.SqlServer
			- dotnet add package Microsoft.EntityFrameworkCore.Relational
			- dotnet add package Microsoft.EntityFrameworkCore.Tools
			- dotnet add package Microsoft.EntityFrameworkCore.Design

2. OPen the Command Prompt, navigate to the Project folder (Parent of .bin folder) and run the following command

dotnet ef dbcontext scaffold "[CONNECTION-STRING]" [PROVIDER-NAME-FOR-DATABASE] -o [FOLDER-NAME-WHERE-MODEL(ENTITY)-CLASSES-WILL-BE-CREATED]
- e.g.
	- dotnet ef dbcontext scaffold "Data Source=.;Initial Catalog=Enterprise;Integrated Security=SSPI" Microsoft.EntityFrameworkCore.SqlServer -o Models

3. The EF COre Object Model
	- DbContext
		- CLass that is used for FOllowing
			- Connect to Database using the COnnection String
			- Mapp with the DB Tables using 'DbSet<T>'
			- USed to Comming Transactions using 'SaveChanges()' and 'SaveChangesAsync()' methods 
			- MAnage the Cursors (Table Rows) usinf DbSet<T>, for peforming Insert, Update and Delete Operations aka CRUD
			- Track changes done for Insert, Update and Delete for COncurrency Management
	- DbSet<T>
		- This is a Cursor (Container for All ROws from Mapped table)
		- T is the entity class mapeed with Table of name T
4. Pseudo
	- Consider CompanyContetext class with instance as ctx
	- Consider CompanyContetext class has DbSet<Employee> Emps

	- Use Microsoft.EntityFrameworkCore namespace for Async OPerations
 	- To Read all EMployees
		- ctx.Emps.ToList() OR ctx.Emps.ToListAsync()
	- To Read Employee based on Primary Key
		- ctx.Emps.Find(PK); Or ctx.Emps.FindAsync(PK);
	- To Create a new Entry in Emps
		- Create an instance of Employee Entity Class
		- Set its properties values
			- e.g. emp.EmpNo=101;
		- Add the emp instance into the Emps CUrsor
			- ctx.EMps.Add(emp) or ctx.EMps.AddAsync(emp)
		- Commit Transaction
			- ctx.SaveChanges(); or ctx.SaveChangesAsync()
	- Add Multiple Records
		- Create a Array Instnace of Employee entity
		- ctx.Emps.AddReage(Array); OR ctx.Emps.AddReageAsync(Array); 
		- Commit Transaction
			- ctx.SaveChanges(); or ctx.SaveChangesAsync()
	- To Update Record
		- Search Record based on Primary Key
		- Modify it Properties Values
		- Commit Transaction
	- OR OTHER WAY TO UPDATE
		- ctx.Entry(SEARCHED-OBJECT).CurrentValues.SetValues(NEW-VALUES);	
		- Commit Transaction
	- To Delete Record
		- Search Record based on Primary Key
		- ctx.EMps.Remove(Searched Emp)
		- COmmit Transaction
	- OR Other way to delete
		-  ctx.Entry(SEARCHED-RECORD).State = EntityState.Deleted;
		- COmmit Transaction

# EF Core Code First
1. Define a public class with public proeprties
2. MAke sure that these proeprties are applied with Data-Annotations
	- Data-Annotations: is a guideline that defines a rule for writing a value in a pubic property
		- e.g. Key, Required, StringLength, Email, Compare, etc.
		- System.ComponentModel.DataAnnotations
3. Set relation rules carefully
	- One-to-One
	- One-to-Many
	- Many-to-Many
4. Handle the Inheritance carefully

5. Steps for Generating Scripts (aka C# Classes) for DB Migration
	- MAke sure that all EF COre Packages MUST be installed for the Project
	- CRete Model classes aka entity classes with pubic properties, constraints and relations (if any)
	- Create a Class deribed from DbContext class 
		- This class MUST have public DbSet<T> proeprties
			- T is Entity class
	- Run the FOllowing command to generate script for Create table based on class with properties mapped with Columns along with constraints
		- dotnet ef migrations add [MIGRATION-NAME] -c [PATH-FOR-DBCONTEXT-CLASS]
		- e.g.
			- dotnet ef migrations add firstMigration -c MyProject.Models.MyDbContext
				- MyDbContext: is a class whoch is derived from DbContext
	- Run the Following command to Generate Database
		- dotnet ef database update -c [PATH-FOR-DBCONTEXT-CLASS]
			- e.g.
				- dotnet ef database update -c MyProject.Models.MyDbContext	
	- Run the following command to remove the latest migration
		- dotnet ef migrations remove

				
# USing Reflection for LateBinding of .NET Framework Assemblies
	- Load Assembly at RUntime
- System.Reflection
	- Assembly class
		- LoadFrom("ASSEMBLY-FILE-PATH"), load the assembly in Current Appliation
	- Type class
		- Highest level class in .NET Frwk for reading types e.g. int, string, custom classes, etc.
		- USe this to read classes from the loaded assembly
		- Types can be
			- Class
			- MEthods of class
			- DataTYpes
	- MethodInfo class
		- Represents Method in assembly
		- InvokeMember() method
			- USed to invoke methd from the class at runtime
	- ParameterInfo class
		- Parameters to a method	
	- BidingFlag
		- Public
			- ALl public methods of the class
		- DeclaredOnly
			- Methods declaed by the develper in the class
		- Instance
			- Not Static methods
	- Activator
		- CLass to create an instace

# C# Language IMprovements
1. Dynamic, a Late binding used for storing data in a variable aand set its type at runtime 
2. Inline Ref and Out to a method
	- Directly DEclare ref/out variables while passing to a method
3. STring Interpolation aka Template
4. Return Ref Type
5. Pattern Matching
	- A mechanism of evaluating a 'type-of' a varble before processing it
	- Operators
		- 'is'
			- Evaluate a type-of a variable in a COndition
			- THis will not read value of the variable
		- 'when'
			- THis will evaluate a State (value) of a variable based on condition
			- e.g.
				- s when < 0
					- means s have -ve value
	- Pattern mathng is avaiabe for
		- COllection
		- null
7. Discards
	- Defining a no-name variable scopped to a method
	- THis will have low overhead for Memory Management
8. Tuple
	Available in C# 7.0 and later, the tuples feature provides concise syntax to group multiple data elements in a lightweight data structure.
9. Destructuring
10. Record
	Records is just another way of creating a user-defined type.

You can define a record just same as you define a class or struct. The only difference is – instead of using class or struct keyword, you use the ‘record‘ keyword. A record type can be either defined as value type or as a reference type.

if record class is used, then it is a reference type. The keyword class is optional.
if record struct is used, then it is a value type.
If neither class nor struct is specified, then it is a reference type as class keyword is optional.
A record can also be marked as abstract or sealed. Abstract record cannot be instantiated, same as with abstract classes. Sealed record prevents the further inheritance from that type.

# ASP.NET Core
1. ASP.NET Core Runtime Library
	- Microsoft.AspNetCore.App
		- Dependency Services
		- Middleware
		- Execution
		- Session Management
		- Security Management
		- Caching
		- MVC
		- API
		- Blazor (Additional Libraries)
		- gRPC (Additional Libraries)
2. ASP.NET Core 2.x/3.x/5 Project Structure
	- Program.cs
		- Startup Main Method
		- Host the APplication in Hosting ENvironment
			- IIS, Self-Host, DOcker, OPen SOurce Host, etc.
	- appsettings.json
		- Cofigiration file that contains
			- Hosting Log Info
			- COnnection Strings
			- Any other Global COnfiguration Settings e.g. Token Security Key, Cache Connections, etc.
	- Startup.cs 
		- COntains a Startup class
			- COnstructor with 'IConguration' as  a Parameter
			- COnfigureServices() method with IServiceCollection as INput Parameter
			- COnfigure() method with IAPplicationBuilder and IHostingEnvironment interfaces as Input Parameters
	- Models
		- COntains all Model classes
			- ENtity Classes
			- Data Access Classes
			- Business Logic Classes (Generally put in seperate Repository/Services folder)
	- Controllers
		- This folder contains MVC Controller classes (For MVC Application, this can also contains API COntroller classes
		- These classes accepts HTTP Request from CLient
		- Each COntroller class contains 'Action-Method'
			- The Method that will be accessed based on HTTP Request (GET/POST/PUT/DELETE)
		- Each MVC COntroller is derived from 'Controller' base class which is further derived from 'ControllerBase' class
			- The 'Controller' clas has following methods
				- View()
					- Represents the View to be returned
						- Action Mathod Name ---> Mapped with ---> View name under the Sub-Folder of Views folder having same name as Controller Name
``` csharp
ViewResult View(); // return a view matched with the action method name
ViewResult View(string viewname); // return specific view
ViewResult View(object model); // return a view having same name as action mathod name and pass the model object to it to show data in view. MAke sure tat the View accepts the type of data specified by 'model' otherwise the veiw will crash 
ViewResult View(string viewName, object model);
	// Return a Specific View and the Data to be shown in the view
```

	- Views
		- This folder contains all Views aka User Interface those will be reponsed to HTTP Request when an Action Method of MVC COntroller is executed	
			- FOr each COntroller class there is a Sub-Folder provoided under the Views folder
			- Each of this Sub-Folder contains a view file for each action method in the Controller class
	- wwwroot
		-  This contains Static Files those are responded to browser
			- JavaScript Files
			- CSS Files
			- Images     
- Action Method of Controller
	- Each Action Method Return 'IActionResult' interface Type	
		- A Contract That represents a Return type when an action method is executed 
		- IMP*** Each Action Method in COntroller is by default acceessed as HTTP Get, make request and receive data from Server with UI
		- To Post/Put/Delete the data from Client-to-Server, use HttpPost attribute on actio methods 
- Views in MVC
	- Two Types od Views
		- Strongly Typed
			- They accepts a Model class as Parameter to scaffold a view
			- This view has the 'Model' property
				- Type of Model is based on View Template and model class passed to it
					- e.g. is View Template is List and Model class is EmployeeEnt, then the typf of Model proeprty will be IEnumerbale<EmployeeEnt> 
		- EMpty Veiws
			- No Model class passed to it
	- Veiw has following feature for UI
		- Html Helpers (In MVC 1,2,3,4,5 on .NET Frwk)
			- They are Custom HTML elements for MVC view to Generate UI based on Property from Model class passed to it
				- e.g. @Html.DisplayFor(m=>m.EmpNo)
			- They are executed on Server
		- Tag Helpers for ASP.NET Core MVC 1,2,3,5,6 
			- THey are attributes to HTML Elements to change its behavior
			- Each Tag Helper is prefixed with 'asp-'
			- asp-action: The Call to Action Method in a COntroller, this is used for <a> tag
			- asp-controller: Make an HTTP Request to Controller
			- asp-for: Bind to input:text element for Binding public property from Model class with UI to Read/Write data
			- asp-items: USed to load the collection on UI to generate HTML Dynamically. USed to generate option for select element

# CReating ASP.NET Core 5 MVC App
1. CReate a Model using EF COre	
	- Code-First or database First
	- Generate Models based on Database usign EF COre Scaffolding COmmand
		- Install EF COre PAckages
2. COpy the COnnection String from the DbContext.cs to appsettings.json
3. Add a new Folder in the Project and name it as 'Services' Or 'Repositories'
	- IN this folder add a new INterface with name as 'IService.cs'
	- Add Class in the same folder and implement IService interface on it
	- Write logic for Data Access CRUD Operations in it
4. Since the Service classes needs the DbCOntext class injected in it using COnstructor injection, reister the DBCOntext class in COnfigureServices() method of Startup class using in the following code
``` csharp
  services.AddDbContext<EnterpriseContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("AppConnStr"));
            });
```

5. Register the Service class in the DI Container  in COnfigureServices() method of Startup class using in the following code 
``` csharp
 services.AddScoped<IService<Department,int>,DepartmentService>();
``` 

6. Add a MVC EMpty Controller and inject the Service in it




# ASP.NET COre Internationalization
- Views
- Error Messages
- Data (Not with DB)

- Creare Resource Files
	- resx files
	- Name/Value pair for Strings an thir Transalations
		- Strings: Values to be Shown on View as Static Text or Error Messages
		- Transalations: Culture Specific values for Strings
	- Create Separate FOlder for 'Resources' of name 'Resources'
		- COntrollers
			- USed to Pass the Culture Specific Data to Views
		- Views
			- USed to define Culture Specific Strings for Static Text and Error Messages (aka Data Annotations)
			- There will sub-folders mapped with each subfolder in 'Views' folder of the Application 
		- Models
			- USed to set Culture Specific Data Annotation on Model class Properties 
	- Resource File Naming Standard
		- Model Class File Naming
			- MoldeClas.[Culture].resx
				- e.g.
					- Product.de.resx, Product class with Genrman String/Names
		- Controller class File Naming
			- ControllerName.[Culture].resx
				- ProductController.de.resx
		- View File
			- ViewFile.[Culture].resx
				- Index.de.resx
	- Add THe Service for Localization in the Dependency COntainer
```` csharp
		- builder.Services.AddLocalization(options=>options.ResourcesPath= "Resources");
````
	- Let the ASP.NET Core Host uses te Location Services and Read all respurce files from Resurce path aka 'Resources' folder
	- Add View Localization and the Data Annotation Localization for the Hosting
```` csharp
	- builder.Services.AddControllersWithViews()
		.AddViewLocalization
		(LanguageViewLocationExpanderFormat.SubFolder)
		.AddDataAnnotationsLocalization();

````

	- define culture SUpport in Host Services
```` csharp
	- builder.Services.Configure<RequestLocalizationOptions>(options => {
    var supportedCultures = new[] { "en-US", "fr", "de" };
    options.SetDefaultCulture(supportedCultures[0]) // default Culture en-US
        .AddSupportedCultures(supportedCultures)
        .AddSupportedUICultures(supportedCultures);
});
````

	- Add the Localization Middleware
```` csharp
   - // 4. defining Cultures
	var supportedCultures = new[] { "en-US", "fr", "de" };
	// 5. The Middleware settings that will accept the 
	// Culture from the HttpRequest
	var localizationOptions = new RequestLocalizationOptions()
		.SetDefaultCulture(supportedCultures[0])
		.AddSupportedCultures(supportedCultures)
		.AddSupportedUICultures(supportedCultures);

	app.UseRequestLocalization(localizationOptions);
````
	- Namespaces
```` csharp
	@using Microsoft.AspNetCore.Localization
	@using Microsoft.AspNetCore.Mvc.Localization
````

	- Contracts
```` charp
 @inject IViewLocalizer Localizer
@inject IOptions<RequestLocalizationOptions> locOptions
````
	- IViewLocalizer: Used to set the Localization on Views based on Resources
	- RequestLocalizationOptions: Load and Set the CUlture for rendering the view based on selected Culture 
	- IRequestCultureFeature
		- Detect the Current Culture from the Browser Originated HTTP Request
- Setting Culture on View
	- @Localizer["Request the culture provider:"]
		- This is set using the 'IViewLocalizer'
			- This will read the matching resource file for the Current View under Resources/Views/Sub-Foder/VeiwFileName.[selected-culture].resx
	- IStringLocalizer<T>
		- The Contractthat will be ijected into the Construtor of the Controller class to provde Culture specific Localization for the View returned from Actin Method and also data to be shown on Views
		- THis will also help for DataAnnotations for VAlidations	