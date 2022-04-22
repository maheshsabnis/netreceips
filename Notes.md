# Backgroud Service in .NET 6

- Use Cases

	- Sender and Receiver Apps uses the BAckgound Services for COmminucation in DIsconnected Mode	
		- Sender app sends data to Messaging App (Q) and the Receiver App Received the data using BAckgroud service
	- Sender Data Cache data in RedisCache, the BAkground Service from Reeiver app read the Cache data and provide it to the Receiver App
	- Sender App Upload the File, the Backgound Service will reduce size of the file and then PUSH it to the File Server
- BackgroudService the BAse class
- Add the Service in Dependency COntainer of ASP.NET Core as Hosted Service using
	- AddHostedService() method


Implementation
```` c#
Create Database Sender;

Create Database Receiver;
use Sender;

use Receiver;

Create Table Employee(EmpNo int Primary Key, EmpName varchar(100) Not Null)
````