using Microsoft.EntityFrameworkCore;
using myAPI.EntityLayer;

namespace myAPI.DataAccessLayer
{
    public class MySqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString: @"server=sql11.freesqldatabase.com;port=3306;database=sql11510544;uid=sql11510544;password=vATfk5aHer;",
            new MySqlServerVersion(new Version(5, 0, 12)));
        }

        public DbSet<Project>? Projects { get; set; }
    }
}
