using System.Net.Http.Json;

namespace Proyecto_gamma_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre del cliente: ");
                String cliente = Console.ReadLine();

            Console.Write("Ingrese el Subtotal: ");
                Double subtotal = double.Parse(Console.ReadLine());
            
            Console.Write("Es un cliente frecuente?: ");
                bool esFrecuente = bool.Parse(Console.ReadLine());

            double total = CalcularTotal(subtotal, esFrecuente);

            MostrarFactura(cliente, total);

        }


        static double CalcularTotal(double  subtotal, bool esFrecuente)
        {
            if (esFrecuente)
            {
                subtotal = subtotal - (subtotal * 0.10);
            }

            double ITBIS = subtotal * 0.18;

            double total = subtotal + ITBIS;

            return total;
        }


        static void MostrarFactura(string cliente, double total)
        {
            Console.WriteLine($"Cliente: {cliente}");

            Console.WriteLine($"Total a pagar: {total}");
        }



    }
}
