using Microsoft.EntityFrameworkCore;

namespace Nuvem.Models
{
    public class PharmacyDBContext : DbContext
    {
        public PharmacyDBContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Pharmacy> Pharmacys { get; set; }
    }
}


