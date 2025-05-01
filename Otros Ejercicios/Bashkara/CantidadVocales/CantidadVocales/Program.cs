/* Problema 
 Escriba un programa para leer una secuencia de caracteres determinada por una cantidad especificada por el usuario y mostrar la cantidad de vocales 
 */

using System;

class Program
{
    static void Main()
    {
        // Solicitar la cantidad de caracteres
        Console.Write("Ingrese la cantidad de caracteres a analizar: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidad) || cantidad <= 0)
        {
            Console.WriteLine("Debe ingresar un número entero positivo.");
            return;
        }

        int contadorVocales = 0;

        // Leer la secuencia de caracteres
        Console.WriteLine($"\nIngrese {cantidad} caracteres uno por uno:");

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Carácter {i}: ");
            char caracter = Console.ReadKey().KeyChar; // Leer un carácter
            Console.WriteLine();

            // Comprobar si el carácter es una vocal
            if ("aeiouAEIOU".Contains(caracter))
            {
                contadorVocales++;
            }
        }

        // Mostrar el resultado
        Console.WriteLine($"\nLa cantidad de vocales ingresadas es: {contadorVocales}");
    }
}
