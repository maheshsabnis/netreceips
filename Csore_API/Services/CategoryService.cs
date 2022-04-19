namespace Csore_API.Services
{
    public class CategoryService : IService<Category, int>
    {
        private readonly ApiDbContext context;
        public CategoryService(ApiDbContext context)
        {
            this.context = context;
        }
        async Task<Category> IService<Category, int>.CreateAsync(Category entity)
        {
            var res = await context.Categories.AddAsync(entity);
            await context.SaveChangesAsync();
            return res.Entity;
        }

        async Task<Category> IService<Category, int>.DeleteAsync(int id)
        {
            var res = await context.Categories.FindAsync(id);
            if (res == null) return null;
            context.Categories.Remove(res);
            await context.SaveChangesAsync();
            return res;
        }

        async Task<IEnumerable<Category>> IService<Category, int>.GetAsync()
        {
            return await context.Categories.ToListAsync();
        }

        async Task<Category> IService<Category, int>.GetAsync(int id)
        {
            var res = await context.Categories.FindAsync(id);
            return res;
        }

        async Task<Category> IService<Category, int>.UpdateAsync(int id, Category entity)
        {
            var res = await context.Categories.FindAsync(id);
            if (res != null)
            {
                context.Entry(res).CurrentValues.SetValues(entity);
                await context.SaveChangesAsync();
                return res;
            }
            else
            {
                return null;
            }
        }
    }
}
