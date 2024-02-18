using ControleFacil.Api.Data.Mappings;
using ControleFacil.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleFacil.Api.Data
{
    public class ApplicationContext : DbContext
    {
        // Construtor somente pra passar informação pra base
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}