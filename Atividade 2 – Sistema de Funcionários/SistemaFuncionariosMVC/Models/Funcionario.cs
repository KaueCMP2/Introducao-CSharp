using System.ComponentModel.DataAnnotations;

namespace SistemaFuncionariosMVC.Models
{
    public abstract class Funcionario
    {
        [Key] //Todo Chave pimaria... Primary key ou PK
        public int Id { get; set; }

        [Required] //todo obriga a passar um atibuto... NOT NULL
        public string Nome { get; set; }

        [Range(0, 10000)] //todo define que o salario vai de 0 ate 10000
        public double SalarioBase { get; set; }

        public Funcionario(){} //todo primeiro inicializar o metodo construtor vazio

        public Funcionario(string nomeC, double salarioBaseC)
        {
            Nome = nomeC;
            SalarioBase = salarioBaseC;
        }

        public abstract double CalcularSalario();
    }
}