using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_AppDeveApproach.Models;
namespace CS_AppDeveApproach.Services
{
    internal class EmployeeService : IDataOperations<Employee, int>
    {
        StackDatabase<Employee> empDb;

        public EmployeeService()
        {
            empDb = new StackDatabase<Employee>();    
        }


        Employee IDataOperations<Employee, int>.Create(Employee record)
        {
            empDb.AddRecord(record);
            return record;
        }

        Employee IDataOperations<Employee, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Employee> IDataOperations<Employee, int>.GetAll()
        {
            return empDb.GetRecords();
        }

        Employee IDataOperations<Employee, int>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Employee IDataOperations<Employee, int>.Update(int id, Employee record)
        {
            throw new NotImplementedException();
        }
    }
}
