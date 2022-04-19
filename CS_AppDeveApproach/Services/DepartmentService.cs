using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_AppDeveApproach.Models;
namespace CS_AppDeveApproach.Services
{
    internal class DepartmentService : IDataOperations<Department, int>
    {
        StackDatabase<Department> deptDb;
        public DepartmentService()
        {
            deptDb = new StackDatabase<Department>();   
        }

        Department IDataOperations<Department, int>.Create(Department record)
        {
            deptDb.AddRecord(record);
            return record;
        }

        Department IDataOperations<Department, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Department> IDataOperations<Department, int>.GetAll()
        {
            return deptDb.GetRecords ();
        }

        Department IDataOperations<Department, int>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Department IDataOperations<Department, int>.Update(int id, Department record)
        {
            throw new NotImplementedException();
        }
    }
}
