/* Problema
 Se desea realizar un programa que solicite al usuario un carácter y un número natural N, y que muestre por pantalla dicho carácter y los próximos N-1 caracteres consecutivos en la tabla ASCII.
 */

using System;

class Program
{
    static void Main()
    {
        // Variables
        char caracter;
        int cantidad;

        // Solicitar el carácter al usuario
        Console.Write("Ingrese un carácter inicial: ");
        caracter = Console.ReadKey().KeyChar; // Captura un solo carácter
        Console.WriteLine();

        // Solicitar el número natural N
        Console.Write("Ingrese un número natural (N): ");
        if (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
        {
            Console.WriteLine("El número debe ser un natural (entero positivo).");
            return;
        }

        // Mostrar el carácter y los N-1 consecutivos
        Console.WriteLine("\nResultado:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write((char)(caracter + i));
        }
        Console.WriteLine(); // Salto de línea final
    }
}

