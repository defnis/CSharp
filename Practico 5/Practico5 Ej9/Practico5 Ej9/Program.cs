/* Problema
 Hacer un programa en C# que permita leer 10 numeros enteros entre 1 y 5 (inclusive),
 y luego muestre por pantalla cuántas veces aparece cada número.
 */

using System;

class Program
{
    static void Main()
    {
        ContarFrecuenciaNumeros();
    }

    static void ContarFrecuenciaNumeros()
    {
        int[] numeros = new int[10];
        int[] conteo = new int[5]; // Arreglo para contar las apariciones de los números 1 a 5

        Console.WriteLine("Ingrese 10 números enteros entre 1 y 5 (inclusive):");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]) || numeros[i] < 1 || numeros[i] > 5)
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entre 1 y 5:");
                Console.Write($"Número {i + 1}: ");
            }
            conteo[numeros[i] - 1]++; // Incrementar el conteo del número correspondiente
        }

        Console.WriteLine("\nFrecuencia de los números:");
        for (int i = 0; i < conteo.Length; i++)
        {
            Console.WriteLine($"El número {i + 1} aparece {conteo[i]} vez/veces.");
        }
    }
}
