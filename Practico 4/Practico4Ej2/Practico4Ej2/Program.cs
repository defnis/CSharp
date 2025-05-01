/* Problema
 Realizar un programa en C# que solicite al usuario un número entero positivo, y luego en pantalla muestre solamente los números pares desde el 1 hasta el número ingresado. Ej: usuario ingresa 10, en pantalla se mostrará 2 4 6 8 10
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
            Console.WriteLine("Los números pares en la secuencia son:");
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0) // Verifica si el número es par
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

