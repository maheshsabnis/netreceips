using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_NetFrwk_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Update"); 
            Console.WriteLine("All EMps");
            foreach (var e in new Employees())
            {
                Console.WriteLine($"{e.EmpNo} {e.EmpNAme} {e.Salary}");
            }
            Console.WriteLine();
            Console.WriteLine("Enter EMpNO to Update");
            int eno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Set the Dat to Update for Employee");
            Employee epToUpdate = new Employee() {
                EmpNo = eno,
                EmpNAme = "New NAme",
                Salary = 909090
            };

            // Call For Update
            EmpOp eop = new EmpOp();
            
            eop.Update(eno, epToUpdate);

            Console.ReadLine(); 
        }
    }


    internal class Employee
    {
        public int EmpNo { get; set; }
        public string EmpNAme { get; set; }
        public int Salary { get; set; }
    }

    internal class Employees : List<Employee>
    {
        public Employees()
        {
            Add(new Employee() { EmpNo = 1, EmpNAme = "A", Salary = 10000 });
            Add(new Employee() { EmpNo = 2, EmpNAme = "B", Salary = 20000 });
            Add(new Employee() { EmpNo = 3, EmpNAme = "C", Salary = 30000 });
        }
        
    }

    internal class EmpOp
    {
        Employees emps;

        public EmpOp()
        {
            emps = new Employees(); 
        }

        public bool Update(int id, Employee emp)
        {
            Employee empToSearchAndUpdate = null;
            if (id != emp.EmpNo) return false;

            // 2 search for employee in the collection
            foreach (var item in emps)
            {
                if (item.EmpNo == emp.EmpNo)
                {
                    empToSearchAndUpdate = item;
                    break;
                }
            }
            // 3. Update
            empToSearchAndUpdate.EmpNAme = emp.EmpNAme;
            empToSearchAndUpdate.Salary = emp.Salary;

            return true;

        }
    }
}
