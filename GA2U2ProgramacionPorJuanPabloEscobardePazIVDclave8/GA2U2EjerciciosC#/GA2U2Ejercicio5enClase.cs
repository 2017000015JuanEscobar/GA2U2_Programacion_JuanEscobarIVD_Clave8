internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("MESES DEL AÑO");
        Console.WriteLine("Ingrese un numero del 1 al 12: ");
        int mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        switch (mes)
        {
            case 1:
                Console.WriteLine("El mes es Enero");
                Console.WriteLine("Tiene 31 dias");
                break;
            case 2:
                Console.WriteLine("El mes es Febrero");
                Console.WriteLine("Tiene 28 dias");
                break;
            case 3:
                Console.WriteLine("El mes es Marzo");
                Console.WriteLine("Tiene 31 dias");
                break;
            case 4:
                Console.WriteLine("El mes es Abril");
                Console.WriteLine("Tiene 30 dias");
                break;
            case 5:
                Console.WriteLine("El mes es Mayo");
                Console.WriteLine("Tiene 31 dias");
                break;
            case 6:
                Console.WriteLine("El mes es Junio");
                Console.WriteLine("Tiene 30 dias");
                break;
            case 7:
                Console.WriteLine("El mes es Julio");
                Console.WriteLine("Tiene 31 dias");
                break;
            case 8:
                Console.WriteLine("El mes es Agosto");
                Console.WriteLine("Tiene 31 dias");
                break;
            case 9:
                Console.WriteLine("El mes es Septiembre");
                Console.WriteLine("Tiene 30 dias");
                break;
            case 10:
                Console.WriteLine("El mes es Octubre");
                Console.WriteLine("Tiene 31 dias");
                break;
            case 11:
                Console.WriteLine("El mes es Noviembre");
                Console.WriteLine("Tiene 30 dias");
                break;
            case 12:
                Console.WriteLine("El mes es Diciembre");
                Console.WriteLine("Tiene 31 dias");
                break;
            default:
                Console.WriteLine("Escriba un numero valido");
                break;
        }
    }
}