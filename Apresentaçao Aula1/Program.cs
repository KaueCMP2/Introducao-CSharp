using System.Xml;

namespace Introducao_CSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo(a) ao sistema.");

        //* Entrada de dados
        Console.WriteLine("Digite Seu nome:");

        string nome = Console.ReadLine();
        Console.WriteLine($"{nome}, Digite sua idade");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"\n Ola {nome}, tudo bem? vi que sua idade é {idade} anos.");

        if(idade < 18)
        {
            Console.WriteLine($"Ops, {nome} voce ainda é menor de idade");

        }

        else {
            Console.WriteLine($"{nome}, voce ja e maior de idade");
        }

        //* Menu
        Console.WriteLine($"\n esoclha uma opção!");
        Console.WriteLine("1- ver a taboada de um numero");
        Console.WriteLine("2- Contar ate um numero");
        Console.WriteLine("3- sair");

        Console.WriteLine($"{nome}, Digite a sua opcao");

        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            Console.WriteLine($"OK, {nome} digite um numero");
        }

        else if (opcao == 2)
        {
            Console.WriteLine($"OK, {nome} escolha um numerp");
        }

        else if (opcao == 3)
        {
            
        }
    }
}
