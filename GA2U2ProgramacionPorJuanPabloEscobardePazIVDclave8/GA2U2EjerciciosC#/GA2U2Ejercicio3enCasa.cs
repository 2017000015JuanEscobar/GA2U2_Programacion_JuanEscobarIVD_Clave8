internal class Program
{
    private static void Main(string[] args)
    {
        int total, total2;
        Console.WriteLine("COMPRA DE ENTRADAS-Estadio Doroteo Guamuch");

        Console.WriteLine("Ingrese el numero de entradas que desea adquirir:");
        int entrada = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("SECTORES DEL ESTADIO-PRECIOS");
        Console.WriteLine("1 - Palco: Q300.00");
        Console.WriteLine("2 - Tribuna: Q100.00 - Q125.00");
        Console.WriteLine("3 - Preferencia: Q50.00 - Q75.00");
        Console.WriteLine("4 - Generales: Q30.00 - Q50.00");
        Console.WriteLine("5 - SALIR");
        Console.WriteLine("Seleccione un sector del estadio:");
        int opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                total = entrada * 300;
                Console.WriteLine("Palco");
                Console.WriteLine("Precio Total de entradas: Q" + total);
                break;
            case 2:
                total = entrada * 100;
                total2 = entrada * 125;
                Console.WriteLine("Tributaria");
                Console.WriteLine("Precio Total de entradas: Q" + total + " - Q" + total2);
                break;
            case 3:
                total = entrada * 50;
                total2 = entrada * 75;
                Console.WriteLine("Preferencia");
                Console.WriteLine("Precio Total de entradas: Q" + total + " - Q" + total2);
                break;
            case 4:
                total = entrada * 30;
                total2 = entrada * 50;
                Console.WriteLine("Generales");
                Console.WriteLine("Precio Total de entradas: Q" + total + " - Q" + total2);
                break;
            case 5:
                Console.WriteLine("Saliendo...");
                break;
            default:
                Console.WriteLine("Valor invalido");
                break;
        }
    }
}