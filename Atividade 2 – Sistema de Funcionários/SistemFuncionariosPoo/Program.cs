using Atividade2;

namespace Exercicio2;

class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionario = new List<Funcionario>
        {
            new Gerente("Kaue"),
            new Vendedor("jotac")
        };

        foreach(var funcionarios in funcionario)
        {
            funcionarios.ExibirResumo();
        }

    }
}
