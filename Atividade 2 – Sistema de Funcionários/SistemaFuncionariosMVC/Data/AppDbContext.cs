using Microsoft.EntityFrameworkCore;
using SistemaFuncionariosMVC.Models;

namespace SistemaFuncionariosMVC.Data
{
    public class AppDbContext : DbContext
    {
        //Todo Recebe as opcoes de configuracoes do banco...
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //todo Direciona a classe (Funcionario) para a tabela (TabelaFuncionario)
        public DbSet<Funcionario> TabelaFuncionario { get; set; }

        //todo Vai sobrescrever o mapeamento do modelo... (Vai ser somente uma tabela para Funcionarios).
        protected void OnMOdelCreateing(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>() //todo Aqui começamos a configurar a entidade base Funcionario.
            .HasDiscriminator<string>("Cargo") //todo Cria uma unica tabela diferenciando gerente e vendedor por cargo.
            .HasValue<Gerente>("Gerente") //todo Quando a instancia for gerente grava gerente em cargo
            .HasValue<Vendedor>("Vendedor"); //todo Quando a instancia for vendedor grava vendedor em corgo
        }
    }
}