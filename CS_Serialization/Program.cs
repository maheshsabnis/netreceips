using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CS_Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEMO Serialization");

            // 1. Create a FileStream
            FileStream fs = new FileStream(@"c:\Coditas\Files\MyEmp.txt", FileMode.CreateNew);
            // 2. Define a Formatter
            // This will provide a format conversion for the Object that is to be serialized
            BinaryFormatter formatter = new BinaryFormatter();
            // 3. Define an instance of Employee with data
            Employee emp =  new Employee()
            { 
               EmpNo = 101,
               EmpName = "Mahesh",
               DeptName =  "IT",
               Designation = "Director",
               Salary = 100000
            };

            // 4. Serialize
            formatter.Serialize(fs, emp);

            // 5. Close the Stream
            fs.Close();

            // 6. Deserialize
            // 6.a. Open the Stream for Read
            fs = new FileStream(@"c:\Coditas\Files\MyEmp.txt", FileMode.Open, FileAccess.Read);

            // 6.b. Deserialize the Stream into the Object
            // Note: Cast the Deserialize() method to Employee

            Employee emp1 = (Employee)formatter.Deserialize(fs);

            Console.WriteLine($"After Deserialize \n" +
                $"EmpNo: {emp1.EmpNo}, EmpName: {emp1.EmpName}, " +
                $"DeptName: {emp1.DeptName}," +
                $"Designation: {emp1.Designation}, Salary: {emp1.Salary}");
            // 6.c. Closing the Stream
            fs.Close();
            Console.ReadLine();
        }
    }
}
