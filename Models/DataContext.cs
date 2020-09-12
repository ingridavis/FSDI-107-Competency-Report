
using Microsoft.EntityFrameworkCore;

namespace myCalendar.Models
{
    public class DataContext : DbContext /* Looks in "using" */
    {
        /**this Class sets up the connection to DB,you specify (dbSets) which of your models will be tables on the DB.
                
                Important:If you modify anything on your models, you need to run migrations: this is the instructions to cmd
                - dotnet ef migrations add <someName>
                - dotnet ef database update*/
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
            {
                

            }
            //Specify which of your models will become tables in the database
            public DbSet<task> TasksTable {get; set;}

            // public DbSet <User> UsersTables {get; set;}
            // public DbSet <Product> ProductsTable {get; set;}
    }
}