internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese dos valores numericos:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n****MENU PRINCIPAL***");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Divicion");
        Console.WriteLine("5. Salir");
        Console.WriteLine("Ingrese el valor segun sea la operación: [ ]");
        int opc = Convert.ToInt32(Console.ReadLine());

        string msj = "";
        double result = 0;
        switch (opc)
        {
            case 1:
                msj = "\nSuma\nLa suma es:";
                result = num1 + num2;
                break;
            case 2:
                msj = "\nResta\nLa resta es:";
                result = num1 - num2;
                break;
            case 3:
                msj = "\nMultiplicacion\nLa multiplicacion es:";
                result = num1 * num2;
                break;
            case 4:
                msj = "\nDivicion\nLa divicion es:";
                result = num1 / num2;
                break;
            case 5:
                msj = "\nSaliendo del programa...";
                result = 0;
                break;
            default:
                msj = "\nOpcion no valida";
                result = 0;
                break;
        }
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(msj);
        Console.WriteLine(result);

    }
}
