using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var tarefa = modelBuilder.Entity<Tarefa>();
            tarefa.ToTable("tb_tarefa");
            tarefa.HasKey(x => x.Id);
            tarefa.Property(x => x.Id).ValueGeneratedOnAdd();
            
        }
    }
}