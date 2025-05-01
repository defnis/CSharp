/* Problema
 Hacer un programa en C# que permita el ingreso de 10 numeros enteros en un arreglo, y luego verifique si hay duplicados, 
 si existen valores duplicados debe mostrar por pantalla el siguiente mensaje: “El arreglo tiene valores duplicados”.
 */

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        VerificarDuplicados();
    }

    static void VerificarDuplicados()
    {
        int[] numeros = new int[10];

        Console.WriteLine("Ingrese 10 números enteros:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero:");
            }
        }

        // Verificar si hay duplicados
        bool tieneDuplicados = numeros.GroupBy(x => x).Any(g => g.Count() > 1);

        if (tieneDuplicados)
        {
            Console.WriteLine("El arreglo tiene valores duplicados.");
        }
        else
        {
            Console.WriteLine("El arreglo no tiene valores duplicados.");
        }
    }
}
