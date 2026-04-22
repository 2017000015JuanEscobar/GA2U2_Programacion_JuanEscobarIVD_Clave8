internal class Program
{
    private static void Main(string[] args)
    {
        double cant, m = 0, fts = 0, cm = 0, pulg = 0;
        int op;

        Console.WriteLine("CONVERSOR DE MEDIDAS DE LONGITUD");
        Console.WriteLine("Ingrese la cantidad a convertir:");
        cant = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Seleccione la unidad de medida original:");
        Console.WriteLine("1 - Metros");
        Console.WriteLine("2 - Pies");
        Console.WriteLine("3 - Centímetros");
        Console.WriteLine("4 - Pulgadas");
        op = Convert.ToInt32(Console.ReadLine());
        switch (op)
        {
            case 1: // De Metros a otros
                m = cant;
                fts = cant * 3.28084;
                cm = cant * 100;
                pulg = cant * 39.3701;
                break;
            case 2: // De Pies a otros
                m = cant / 3.28084;
                fts = cant;
                cm = cant * 30.48;
                pulg = cant * 12;
                break;
            case 3: // De Centímetros a otros
                m = cant / 100;
                fts = cant / 30.48;
                cm = cant;
                pulg = cant / 2.54;
                break;
            case 4: // De Pulgadas a otros
                m = cant / 39.3701;
                fts = cant / 12;
                cm = cant * 2.54;
                pulg = cant;
                break;
            default:
                Console.WriteLine("Opción no válida");
                return;
        }
        Console.WriteLine("Resultados de la conversión:");
        Console.WriteLine("" + m + " Metros");
        Console.WriteLine("" + fts + " Pies");
        Console.WriteLine("" + cm + " Centímetros");
        Console.WriteLine("" + pulg + " Pulgadas");

    }
}