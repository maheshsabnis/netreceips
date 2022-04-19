using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_NetFrwk_Imperative_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            Console.WriteLine("Imperative LINQ");

            Console.WriteLine("Using the Select Statement");
            var res = from e in employees
                      select e;


            Console.WriteLine("Using a Where Condition to Display Employee by Specific Department");

            res = from e in employees
                  where e.DeptName == "HR"
                  select e;

            Console.WriteLine("All Employees Order By Salary in Ascending Order");

            res = from e in employees
                  orderby e.Salary
                  select e;

            Console.WriteLine("All Employees Order By Salary in Descending Order");

            res = from e in employees
                  orderby e.Salary descending 
                  select e;

            Console.WriteLine("Print all Employees group by the DeptName");
            DeptWiseGroup(ref employees);
            Console.WriteLine("Print Sum of Salary By each group");
            DeptWiseSumSalary(ref employees);
            Console.WriteLine();
            Console.WriteLine("Using Join");
            Console.WriteLine();
            UseJoin();
            Console.WriteLine("Using Join using Imoerative LINQ");
            UseJoinImperative();


            // PrintResult(res);
            Console.ReadLine();   
        }




        static void PrintResult(IEnumerable<Employee> emps)
        {
            foreach (var item in emps)
            {
                Console.WriteLine($"{item.EmpNo} {item.EmpName} {item.DeptName} {item.Salary}");
            }
        }

        static void DeptWiseGroup(ref Employees emps)
        {
            var res1 = (from e in emps
                        group e by e.DeptName into deptgroup
                        select new  // The Group Data is Stored in the Anonymous Type 
                        {
                            DeptName = deptgroup.Key, // Key aka the Property on WHich the Group is created
                            Records = deptgroup.ToList() // List of Records per Group
                        });

            foreach (var record in res1)
            {
                Console.WriteLine($"Group Key = {record.DeptName}");
                PrintResult(record.Records);
            }
        }

        static void DeptWiseSumSalary(ref Employees emps)
        {
            var res1 = (from e in emps
                        group e by e.DeptName into deptgroup
                        select new  
                        {
                            DeptName = deptgroup.Key,  
                            SumSalary = deptgroup.Sum(x=>x.Salary)  
                        });

            foreach (var record in res1)
            {
                Console.WriteLine($"Group Key = {record.DeptName} and Sum of Salary {record.SumSalary}");
            }
        }

        /// <summary>
        /// The dJsoin() is by default an Inner Join that will read all matching record from 
        /// the Collection using ikn Join from Outer Collection (Students) to 
        /// Inner collection (Standards)
        /// </summary>
        static void UseJoin()
        {
            var Students = new List<Student>()
            { 
              new Student(){StandardID=1, StudentName="S1", StudentID=1 },
              new Student(){StandardID=2, StudentName="S2", StudentID=2 },
              new Student(){StandardID=1, StudentName="S3", StudentID=3 },
              new Student(){StandardID=2, StudentName="S4", StudentID=4 },
              new Student(){StandardID=1, StudentName="S5", StudentID=5 },
              new Student(){StandardID=2, StudentName="S6", StudentID=6 }
            };

            var Standards = new List<Standard>()
            { 
              new Standard(){ StandardID=1, StandardName="Std1"},
              new Standard(){ StandardID=2, StandardName="Std2"},
              new Standard(){ StandardID=3, StandardName="Std3"}
            };

            // Declarative Query using Join() method
                        // Outer Sequence Students from which a join will start executing
            var join = Students.Join(
                           Standards, // inner sequence on which the Join will be applied
                           student=> student.StandardID, // Outer Key to apply on inner matched key
                           standrard=>standrard.StandardID, // the Inner Key to check with outer key 
                           (student, standard) => new { 
                              StudentName = student.StudentName,
                              StandardName = standard.StandardName  
                           }
                        );
            foreach (var value in join)
            {
                Console.WriteLine($"{value.StudentName} and {value.StandardName}");
            }
        }


        static void UseJoinImperative()
        {
            var Students = new List<Student>()
            {
              new Student(){StandardID=1, StudentName="S1", StudentID=1 },
              new Student(){StandardID=2, StudentName="S2", StudentID=2 },
              new Student(){StandardID=1, StudentName="S3", StudentID=3 },
              new Student(){StandardID=2, StudentName="S4", StudentID=4 },
              new Student(){StandardID=1, StudentName="S5", StudentID=5 },
              new Student(){StandardID=2, StudentName="S6", StudentID=6 }
            };

            var Standards = new List<Standard>()
            {
              new Standard(){ StandardID=1, StandardName="Std1"},
              new Standard(){ StandardID=2, StandardName="Std2"},
              new Standard(){ StandardID=3, StandardName="Std3"}
            };

            var join = from s in Students  // Outer Sequence 
                       join st in Standards // Inner Sequence
                       on s.StandardID equals st.StandardID // Key match
                       select new
                       {
                            StudentName = s.StudentName,
                            StandardName = st.StandardName
                       };


            foreach (var value in join)
            {
                Console.WriteLine($"{value.StudentName} and {value.StandardName}");
            }
        }
    }


    internal class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public int Salary { get; set; }
    }


    internal class Employees : List<Employee>
    {
        public Employees()
        {
            Add(new Employee() { EmpNo = 101, EmpName = "Mahesh", DeptName = "IT", Salary = 11000 });
            Add(new Employee() { EmpNo = 102, EmpName = "Tejas", DeptName = "HR", Salary = 12000 });
            Add(new Employee() { EmpNo = 103, EmpName = "Nandu", DeptName = "SL", Salary = 13000 });
            Add(new Employee() { EmpNo = 104, EmpName = "Anil", DeptName = "IT", Salary = 14000 });
            Add(new Employee() { EmpNo = 105, EmpName = "Jaywant", DeptName = "HR", Salary = 10000 });
            Add(new Employee() { EmpNo = 106, EmpName = "Abhay", DeptName = "SL", Salary = 9000 });
            Add(new Employee() { EmpNo = 107, EmpName = "Anil", DeptName = "IT", Salary = 8000 });
            Add(new Employee() { EmpNo = 108, EmpName = "Shyam", DeptName = "HR", Salary = 7000 });
            Add(new Employee() { EmpNo = 109, EmpName = "Vikram", DeptName = "SL", Salary = 6000 });
            Add(new Employee() { EmpNo = 110, EmpName = "Suprotim", DeptName = "IT", Salary = 5000 });
        }
    }


    internal class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StandardID { get; set; }
    }

    internal class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
}
