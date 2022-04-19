namespace Csore_API.Models
{
    public class ApiDbContext : DbContext
    {
        // define properties for DbSet for MApping CLR objects (aka entities)
        // with Database Tables
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// Inject the DbCOntextOptions<ApiDbContext>, this will be resolved by
        /// using AddDbContext<ApiDbContext> Service in DI COntainer
        /// </summary>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApiDbContext(DbContextOptions<ApiDbContext> options):base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                          .HasOne(c => c.Category) // One-To-One
                          .WithMany(p => p.Products) // One-To-Many
                          .HasForeignKey(p => p.CategoryRowId); // FOreign Key
            base.OnModelCreating(modelBuilder);
        }
       
    }
}
