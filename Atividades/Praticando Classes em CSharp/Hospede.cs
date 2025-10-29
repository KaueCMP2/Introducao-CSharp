namespace Praticando_Classes_em_CSharp
{
    public class Hospede
    {
        public string Nome;
        public string CPF;
        public string Telefone;

    public Hospede(string construtorNome, string construtorCPF, string construtorTelefone){
        Nome = construtorNome;
        CPF = construtorCPF;
        Telefone = construtorTelefone;
    }
        public void ExibirInformacoes()
        {
        Console.WriteLine($"\nO hospede {Nome}, possui as seguintes informações: \nCPF: {CPF}\nTelefone: {Telefone}");
        }
    }
}