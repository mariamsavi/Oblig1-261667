using Microsoft.EntityFrameworkCore;
using Oblig1_261667.Models;

namespace Oblig1_261667.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bruker> Brukere { get; set; }
    }
}
