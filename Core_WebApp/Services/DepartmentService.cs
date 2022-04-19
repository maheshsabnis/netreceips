using Core_WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Core_WebApp.Services
{
    public class DepartmentService : IService<Department, int>
    {
        private readonly EnterpriseContext ctx;
        /// <summary>
        /// Inject the EnterpriseContext
        /// </summary>
        public DepartmentService(EnterpriseContext ctx)
        {
            this.ctx = ctx;
        }

        async Task<Department> IService<Department, int>.CreateAsync(Department entity)
        {
            var res = await ctx.Departments.AddAsync(entity);
            await ctx.SaveChangesAsync();
            return res.Entity;
        }

        async Task<Department> IService<Department, int>.DeleteAsync(int id)
        {
            var objToDelete = await ctx.Departments.FindAsync(id);
            if(objToDelete == null) return null;
            ctx.Departments.Remove(objToDelete);
            await ctx.SaveChangesAsync();
            return objToDelete;
        }

        async Task<IEnumerable<Department>> IService<Department, int>.GetAsync()
        {
            return await ctx.Departments.ToListAsync();
        }

        async Task<Department> IService<Department, int>.GetAsync(int id)
        {
            return await ctx.Departments.FindAsync(id);
        }

        async Task<Department> IService<Department, int>.UpdateAsync(int id, Department entity)
        {
            var objToUpate = await ctx.Departments.FindAsync(id);
            if(objToUpate == null) return null;

            objToUpate.DeptName = entity.DeptName;
            objToUpate.Location = entity.Location;
            objToUpate.Capacity = entity.Capacity;

            await ctx.SaveChangesAsync();
            return objToUpate;
        }
    }
}
