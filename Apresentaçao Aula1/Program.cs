using System.IO.Pipelines;
using System.Net.Quic;
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

        if (idade < 18)
        {
            Console.WriteLine($"Ops, {nome} voce ainda é menor de idade");

        }

        else
        {
            Console.WriteLine($"{nome}, voce ja e maior de idade");
        }

        //* Menu
        Console.WriteLine($"\n esoclha uma opção!");
        Console.WriteLine("1- ver a taboada de um numero");
        Console.WriteLine("2- Contar ate um numero");
        Console.WriteLine("3- fibonacci");
        Console.WriteLine("4- sair");

        Console.WriteLine($"{nome}, Digite a sua opcao");

        int opcao = int.Parse(Console.ReadLine());
        int numeroDig = int.Parse(Console.ReadLine());
        
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Digite um numero");
                numeroDig = int.Parse(Console.ReadLine());
                if (numeroDig < 1)
                {
                    Console.WriteLine($"O numero digitado precisa sem maior que 0");
                }

                else
                {
                    int multiplicador;
                    int resultado;

                    for (int i = 1; i < 10; i++)
                    {
                        multiplicador = i;
                        resultado = numeroDig * multiplicador;

                        Console.WriteLine($"{numeroDig}X{multiplicador} = {resultado}");
                    }
                }
            break;

            case 2:
                Console.WriteLine("Digite um numero para contagem");
                numeroDig = int.Parse(Console.ReadLine());
                if (numeroDig < 1)
                {
                    Console.WriteLine($"O numero digitado precisa sem maior que 0");
                }

                else

                {
                    for (int i = 0; i >= numeroDig; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            break;

            case 3:
                numeroDig = int.Parse(Console.ReadLine());
                int valorInicial = 0;
                int valorAtual = 1;
                int ValorTotal = valorInicial + valorAtual;
                Console.WriteLine("Digite um numero para iniciar");

                if (numeroDig < 1)
                {
                    Console.WriteLine($"O numero digitado precisa sem maior que 0");
                }

                else
                {
                    for (int i = 0; i < numeroDig; i++)
                    {
                        ValorTotal = valorInicial + valorAtual;

                        Console.WriteLine(ValorTotal);
                        valorInicial = valorAtual;
                        valorAtual = ValorTotal;
                    }
                }
            break;

            case 4:
                Environment.Exit(0);
            break;
        }
    }
}
