using Microsoft.EntityFrameworkCore;

namespace RestWithAsp_net5.model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {} 

        public DbSet<Person> Persons { get; set; }
    }
}
