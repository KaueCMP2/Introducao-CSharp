namespace Atividade_Poo
{
    public class Pessoa()
    {
        public string Nome;
        public int Idade;
        public bool ExameDeProstata;

        //Virtual - vamos utilizar o metodo em outra classe podendo reescrever.
        public virtual void Apresentar()
        {
            Console.WriteLine($"Ola, M meu nome é{Nome} e tenho {Idade} anos.");
        }

    }

}
