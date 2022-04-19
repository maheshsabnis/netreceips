using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CS_NetFrwk_ConnectedApp.Models;
using CS_NetFrwk_ConnectedApp.DataAccess;
namespace CS_NetFrwk_ConnectedApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using the ADO.NET Connected Architecture");
            try
            {
                IDataAccess<Department,int> deptDA = new  DepartmentDataAccess();
                
                var departments = deptDA.GetData();
                Console.WriteLine("DeptNo   DeptName    Location    Capacity");
                foreach (Department dept in departments)
                {
                    Console.WriteLine($"{dept.DeptNo}   {dept.DeptName} {dept.Location} {dept.Capacity}");
                }

                Console.WriteLine();

                Console.WriteLine("Print Record based on the DeptNo as 90");

                var dept1  = deptDA.GetData(90);

                Console.WriteLine($"{dept1.DeptNo}   {dept1.DeptName} {dept1.Location} {dept1.Capacity}");
                //Console.WriteLine("Updating new Record");
                //var deptNew = new Department()
                //{
                //    DeptNo = 90,
                //    DeptName = "D-90",
                //    Location = "Pune-East",
                //    Capacity = 1300
                //};

                //var result = deptDA.Update(90,deptNew);

                //if (result == null)
                //{
                //    Console.WriteLine("Upate Faild");
                //}
                //else
                //{
                //    Console.WriteLine("Update Success");
                //}

                Console.WriteLine("Call for delete");

                var resDelete = deptDA.Delete(90);

                //Console.WriteLine("Data After Updaing record");
                //var dept2 = deptDA.GetData(90);

                //Console.WriteLine($"{dept2.DeptNo}   {dept2.DeptName} {dept2.Location} {dept2.Capacity}");

                // Call the Dispose method and Kill the Connection object at once
                deptDA.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Occured {ex.Message}");
            }
            Console.ReadLine(); 
        }
    }
}
