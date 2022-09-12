using A_Manager.Models;
using Microsoft.EntityFrameworkCore;

namespace A_Manager.Data
{
    public class DatabaseConnectionClass : DbContext
    {
        public DatabaseConnectionClass(DbContextOptions<DatabaseConnectionClass> options): base(options)
        {

        }

        //DbSet<Model> Table Name

        public DbSet<Car> Cars { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Car_Users> Cars_Users { get; set; }

        public DbSet<Car_Service> Cars_Services { get; set; }

        public DbSet<Car_Insurance> Cars_Insurances { get; set; }
    }
}
