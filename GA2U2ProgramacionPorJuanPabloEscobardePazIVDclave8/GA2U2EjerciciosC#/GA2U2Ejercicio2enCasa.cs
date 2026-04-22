internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite una caracter:");
        char c = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (c)
        {
            case '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9':
                Console.WriteLine("Su caracter es un digito");
                break;
            case 'A' or 'a' or 'E' or 'e' or 'I' or 'i' or 'O' or 'o' or 'U' or 'u':
                Console.WriteLine("Su caracter es una vocal");
                break;
            default:
                Console.WriteLine("Su caracter no es ni digito ni vocal");
                break;
        }
    }
}