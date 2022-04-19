using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EFCore_CodeFIrst.Models
{
    public class BusinessDbContext : DbContext
    {

        /// <summary>
        /// Define DbSet<T> properties
        /// </summary>

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }


        public DbSet<ProductionUnit> ProductionUnit { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<WebSeries> WebSeries { get; set; }

        public BusinessDbContext()
        {
        }

        /// <summary>
        /// Configure the Connection String
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Business;Integrated Security=SSPI");
            base.OnConfiguring(optionsBuilder);
        }
        /// <summary>
        /// Using the FLuent APIs
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                        .HasOne(c => c.Category) // One-To-One
                        .WithMany(p => p.Products) // One-To-Many
                        .HasForeignKey(p => p.CategoryRowId); // FOreign Key

            // Add Many-to-Many
            modelBuilder.Entity<Doctor>()
                        .HasMany(d => d.Patients) // Navigating from Doctors to Patients
                        .WithMany(p => p.Doctors) // Navigating from Patients to Doctors
                        .UsingEntity(relation => relation.ToTable("DoctorsPatients")); // Generate new table with FLexible Mapping


            // The seed Data
            // Define a Sample Seed Data (Seed Data is Default Data)
            var movies = new Movies[]
            {
                new Movies(){Id=1,Name="Dr.No", ReleaseYear=1963, Category="Spy", Collection=300000, Duration=120 },
                new Movies(){Id=2,Name="Golmal", ReleaseYear=1976, Category="Comedy", Collection=60000, Duration=180 }
            };

            var webSeries = new WebSeries[] {
               new WebSeries() {Id=3, Name="Ramayan", ReleaseYear=1986, NoOfSeasons=2,EpisodsPerSeason=70 },
                new WebSeries() {Id=4, Name="CID", ReleaseYear=1998, NoOfSeasons=50,EpisodsPerSeason=70 }
            };

            // define a uniion
            // ProductionUnit has Movies and WebSeries, so the Movies can be casted to ProductionUnit and Union with the WebSeries
            // The Union will contains Null values for Movie row for properties from WebSeries and vice-versa
            // The Case<T> method is used to case the Object if they have 
            // Derivation Relation
            // The following list contains Movies and WebSeries into a single list of
            // ProductionUnit
            var productionUnit = movies.Cast<ProductionUnit>().Union(webSeries).ToList();

            // link the data with entities so that when the table is generated it will have the defauilrt data
            modelBuilder.Entity<Movies>().HasData(movies);
            modelBuilder.Entity<WebSeries>().HasData(webSeries);


            base.OnModelCreating(modelBuilder);
        }
    }
}
