using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CS_EFCore_DbFirst.Models;
namespace CS_EFCore_DbFirst.DataAccess
{
    internal class DepartmentDataAccess : IDataAccess<Department, int>
    {
        
        EnterpriseContext ctx;

        public DepartmentDataAccess()
        {
            ctx = new EnterpriseContext();
        }

        async Task<Department> IDataAccess<Department, int>.CreateAsync(Department entity)
        {
             var result = await ctx.Departments.AddAsync(entity);
             await ctx.SaveChangesAsync();
            return result.Entity; // Return newly CReated ENtity
        }

        async Task<Department> IDataAccess<Department, int>.DeleteAsync(int id)
        {
            var deptToFind = await ctx.Departments.FindAsync(id);
            if (deptToFind == null)
            {
                return null;
            }
            ctx.Departments.Remove(deptToFind);
            await ctx.SaveChangesAsync();
            return deptToFind;
        }

        async Task<IEnumerable<Department>> IDataAccess<Department, int>.GetAsync()
        {
            var result = await ctx.Departments.ToListAsync();
            return result;
        }

        async Task<Department> IDataAccess<Department, int>.UpdateAsync(int id, Department entity)
        {
            var deptToUpdate = await ctx.Departments.FindAsync(id);
            if (deptToUpdate == null)
            {
                return null;
            }
            deptToUpdate.DeptName = entity.DeptName;
            deptToUpdate.Capacity = entity.Capacity;
            deptToUpdate.Location = entity.Location;    
            await ctx.SaveChangesAsync();
            return deptToUpdate;
        }
    }
}
