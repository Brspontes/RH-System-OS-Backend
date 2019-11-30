using Brspontes_RH_System_Domain.CandidateContext;
using Brspontes_RH_System_Infra.SqlDbContext.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Brspontes_RH_System_Infra.SqlDbContext
{
    public class SqlContext : DbContext
    {

        public SqlContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressMapping());
            modelBuilder.ApplyConfiguration(new CandidateMapping());
        }
    }
}
