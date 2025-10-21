namespace Atividade_Poo;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa
        {
            Nome = "Kaue",
            Idade = 18,
        };

        Aluno a = new Aluno
        {
            Nome = "Paulo",
            Idade = 18,
            Curso = "Dev",
        };

        p1.Apresentar();
        a.Apresentar();
    }
}
