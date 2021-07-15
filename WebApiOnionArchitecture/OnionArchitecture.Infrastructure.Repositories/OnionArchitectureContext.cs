using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Core.Domain.Entities;

namespace OnionArchitecture.Infrastructure.Repositories
{
    public class OnionArchitectureContext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }
        public OnionArchitectureContext() : base() { }
        public OnionArchitectureContext(DbContextOptions<OnionArchitectureContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlServer(@"Server=.;Database=OnionArchitecture;Trusted_Connection=True;");
            //if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlServer(@"Server=desarrollo;Database=BootcampToDo;Trusted_Connection=True;");
        }
    }
}
