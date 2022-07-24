using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    // DbContext class resides in Microsoft.EntityFrameworkCore library
    // DBContext will provide all the logic that EF Core going to be using to be using it's change tracking 
    // and database interaction tasks 
    // EF and EF Core are more similar
    public class SamuraiContext : DbContext
    {
        // DbContext need to expose DBSets, which become wrappers to the different types we are going to interact with,
        // while we are using the context. 

        // Data project needs reference from Domain project(SamuraiApp.Domain).
        // Then Data project can identify domain classes

        // Add DbSets to Quote and Clans (other domain classes as well).  

        // There is a extention called Visual Studio Power Tools to create ER relations between Entities

        // !important EF Core presumes that table names match these DbSet Names
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source = PRABATH\\NATIONALLIBRARY; Initial Catalog = SamuraiAppData; User ID = psgdevelop; Password = 12345";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);

        }
    }
}
