using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApplication.Data
{
    public class PremiumContext : DbContext
    {
        public PremiumContext(DbContextOptions<PremiumContext> options)
            : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        //public DbSet<Students> PremiumRating { get; set; }
        

       protected override void OnConfiguring(DbContextOptionsBuilder dbcontext)
        {
            dbcontext.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=StudentDev; Integrated Security=true;");
        }
    }
}
