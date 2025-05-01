/* Problema
 Realizar un programa en C# que solicite al usuario un número entero positivo, y luego en pantalla muestre la secuencia de números desde el 1 hasta el número ingresado. Ej: usuario ingresa 10, en pantalla se mostrará 1 2 3 4 5 6 7 8 9 10
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero positivo: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number > 0)
        {
            Console.WriteLine("La secuencia de números es:");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número entero positivo válido.");
        }
    }
}

