/* Problema
La empresa “Chiketto” quiere promocionar la venta de entradas por Internet a espectáculos. En la promoción, si se
compra una sola entrada el precio es de $75, si se compran dos entradas el precio es $100 y si se compran tres
entradas el precio es $175. Cuando se compran más de 3 entradas (N>=4), el precio será $(N div 2)*100. Por ejemplo,
si se compran 9 entradas se paga $400.
 */

using System;

class Program
{
    static void Main()
    {
        // Declaración de variables
        int numeroEntradas;
        int costo;

        // Entrada de datos
        Console.WriteLine("Promoción de entradas de la empresa 'Chiketto'");
        Console.Write("Ingrese el número de entradas que desea comprar: ");
        numeroEntradas = int.Parse(Console.ReadLine());

        // Cálculo del costo según la cantidad de entradas
        if (numeroEntradas == 1)
        {
            costo = 75;
        }
        else if (numeroEntradas == 2)
        {
            costo = 100;
        }
        else if (numeroEntradas == 3)
        {
            costo = 175;
        }
        else if (numeroEntradas >= 4)
        {
            costo = (numeroEntradas / 2) * 100; // N div 2 * 100
        }
        else
        {
            Console.WriteLine("Número de entradas inválido.");
            return;
        }

        // Salida del costo total
        Console.WriteLine($"El costo total por {numeroEntradas} entrada(s) es: ${costo}");
    }
}
