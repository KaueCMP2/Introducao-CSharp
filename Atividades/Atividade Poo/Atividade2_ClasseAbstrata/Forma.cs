namespace Atividade2_ClasseAbstrata
{
    public abstract class Forma
    {
        //todo Abstract obriga o uso
        public abstract double CalcularArea();

        public void mostrarTipo()
        {
            Console.WriteLine("Sou uma forma geométrica");
        }

    }
}