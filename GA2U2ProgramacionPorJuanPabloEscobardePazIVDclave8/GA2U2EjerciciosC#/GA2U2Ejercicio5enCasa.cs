internal class Program
{
    private static void Main(string[] args)
    {
        double cant, opc, total, IVA, descuento, totalconIVA;
        string forma;
        Console.WriteLine("COMPRA DE IMPRESORAS - T&S, S.A de C.A");
        Console.WriteLine("Impresoras de tinta continua c/u Q650 (Sin IVA)");
        Console.Write("Ingrese la cantidad de impresoras que desea adquirir: ");
        cant = double.Parse(Console.ReadLine());
        Console.WriteLine("Seleccione una forma de pago (1-3): ");
        Console.WriteLine("(Se aplicara un descuento dependiendo de la forma de pago)");
        Console.WriteLine("(Se le aplicara IVA)");
        Console.WriteLine("1 - Efectivo - 10%");
        Console.WriteLine("2 - Tarjeta de credito - 5%");
        Console.WriteLine("3 - Vale de pago - 15%");
        opc = double.Parse(Console.ReadLine());
        switch (opc)
        {
            case 1:
                forma = "Efectivo";
                total = 650 * cant;
                IVA = total * 1.12;
                descuento = (IVA) * (10.0 / 100.0);
                totalconIVA = IVA - descuento;
                break;
            case 2:
                forma = "Tarjeta de credito";
                total = 650 * cant;
                IVA = total * 1.12;
                descuento = (IVA) * (5.0 / 100.0);
                totalconIVA = IVA - descuento;
                break;
            case 3:
                forma = "Vale de pago";
                total = 650 * cant;
                IVA = total * 1.12;
                descuento = (IVA) * (15.0 / 100.0);
                totalconIVA = IVA - descuento;
                break;
            default:
                Console.WriteLine("Opción no válida");
                return;
        }
        Console.WriteLine("DETALLES DEL PAGO");
        Console.WriteLine("Cantidad de impresoras a comprar: " + cant);
        Console.WriteLine("Total sin descuento (con IVA): Q" + IVA.ToString("F2"));
        Console.WriteLine("Forma de pago: " + forma);
        Console.WriteLine("Descuento realizado: Q" + descuento.ToString("F2"));
        Console.WriteLine("Total a pagar: Q" + totalconIVA.ToString("F2"));
    }
}