/* Problema
 Realizar un programa en C# que pida al usuario un número entero positivo y luego muestre sus divisores.
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero positivo: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero) && numero > 0)
        {
            Console.WriteLine($"Los divisores de {numero} son:");
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0) // Verifica si i es un divisor de numero
                {
                    Console.Write(i + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número entero positivo válido.");
        }
    }
}
