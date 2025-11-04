using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome) : base (nome)
        { }

        public override double CalcularSalario()
        {
            Console.WriteLine($"O salario do: {Nome} e de: {(SalarioBase * 1.5).ToString("C")}"); 
            return SalarioBase * 1.5;
        }
    }
}