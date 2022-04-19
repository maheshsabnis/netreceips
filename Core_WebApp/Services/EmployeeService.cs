using Core_WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Core_WebApp.Services
{
    public class EmployeeService : IService<Employee, int>
    {
        private readonly EnterpriseContext ctx;
        public EmployeeService(EnterpriseContext context)
        {
            this.ctx = context;
        }

        async Task<Employee> IService<Employee, int>.CreateAsync(Employee entity)
        {
            var res = await ctx.Employees.AddAsync(entity);
            await ctx.SaveChangesAsync();
            return res.Entity;
        }

        async Task<Employee> IService<Employee, int>.DeleteAsync(int id)
        {
            var objToDelete = await ctx.Employees.FindAsync(id);
            if (objToDelete == null) return null;
            ctx.Employees.Remove(objToDelete);
            await ctx.SaveChangesAsync();
            return objToDelete;
        }

        async Task<IEnumerable<Employee>> IService<Employee, int>.GetAsync()
        {
            return await ctx.Employees.ToListAsync();
        }

        async Task<Employee> IService<Employee, int>.GetAsync(int id)
        {
            return await ctx.Employees.FindAsync(id);
        }

        async Task<Employee> IService<Employee, int>.UpdateAsync(int id, Employee entity)
        {
            var objToUpate = await ctx.Employees.FindAsync(id);
            if (objToUpate == null) return null;

            objToUpate.EmpName = entity.EmpName;
            objToUpate.Designation = entity.Designation;
            objToUpate.Salary = entity.Salary;
            objToUpate.DeptNo = entity.DeptNo;

            await ctx.SaveChangesAsync();
            return objToUpate;
        }
    }
}
