internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Rango de estudiantes");
        Console.WriteLine("Ingrese una letra(A-F):");
        char letra = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (letra)
        {
            case 'A':
                Console.WriteLine("Exelente");
                break;
            case 'B':
                Console.WriteLine("Bueno");
                break;
            case 'C':
                Console.WriteLine("Medio");
                break;
            case 'D':
                Console.WriteLine("Malo");
                break;
            case 'F':
                Console.WriteLine("REPROVADO");
                break;
            default:
                Console.WriteLine("Letra no válida. Por favor, ingrese una letra entre A y F.");
                break;
        }
    }
}