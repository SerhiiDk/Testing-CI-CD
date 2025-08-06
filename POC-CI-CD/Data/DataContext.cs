using Microsoft.EntityFrameworkCore;
using POC_CI_CD.Entities;

namespace POC_CI_CD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
