namespace Atividade2_ClasseAbstrata;

class Program
{
    static void Main(string[] args)
    {
        Retangulo r = new Retangulo { Altura = 200, Largura = 400, };

        Circulo c = new Circulo { Raio = 3 };

        
        r.mostrarTipo();
        Console.WriteLine($"area do retangulo: {r.CalcularArea()}");

        c.mostrarTipo();
        Console.WriteLine($"Area curculo: {c.CalcularArea}()");
    }
}
