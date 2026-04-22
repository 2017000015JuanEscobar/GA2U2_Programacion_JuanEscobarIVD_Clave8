internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n****MENU PRINCIPAL****");
        Console.WriteLine("1 - HAMBURGUESAS");
        Console.WriteLine("2 - PIZZAS");
        Console.WriteLine("3 - POLLO FRITO");
        Console.WriteLine("4 - ENSALADA");
        Console.WriteLine("5 - SALIR");
        Console.WriteLine("Digite un menu:");
        int opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("Ha solicitado una Hamburguesa");
                break;
            case 2:
                Console.WriteLine("Ha solicitado una porcion de pizza");
                break;
            case 3:
                Console.WriteLine("Ha solicitado una porcion de Pollo Frito");
                break;
            case 4:
                Console.WriteLine("Ha solicitado una Ensalada");
                break;
            case 5:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Seleccionar bien el menu");
                break;
        }
    }
}