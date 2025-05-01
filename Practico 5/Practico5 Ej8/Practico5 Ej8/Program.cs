/* Problema
 Hacer un programa en C# que permita cargar 10 números enteros en un arreglo, y luego muestre la lista completa de valores y pida al usuario un valor a eliminar. 
 Si el valor a eliminar no existe en el arreglo debe mostrar un mensaje y volver a mostrar los valores y pedir el numero a eliminar.
 Luego debe eliminar el valor del arreglo y mostrar el arreglo final por pantalla.
 */

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        ManejarArreglo();
    }

    static void ManejarArreglo()
    {
        int[] numeros = new int[10];
        Console.WriteLine("Ingrese 10 números enteros:");

        // Cargar los números en el arreglo
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero:");
            }
        }

        while (true)
        {
            // Mostrar la lista completa de valores
            Console.WriteLine("\nValores actuales en el arreglo:");
            Console.WriteLine(string.Join(" ", numeros));

            // Pedir al usuario un valor a eliminar
            Console.Write("Ingrese un valor a eliminar: ");
            if (!int.TryParse(Console.ReadLine(), out int valorAEliminar))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                continue;
            }

            // Verificar si el valor existe en el arreglo
            if (!numeros.Contains(valorAEliminar))
            {
                Console.WriteLine("El valor no existe en el arreglo. Inténtelo de nuevo.");
                continue;
            }

            // Eliminar el valor del arreglo
            numeros = numeros.Where(x => x != valorAEliminar).ToArray();

            // Mostrar el arreglo final
            Console.WriteLine("\nArreglo final después de eliminar el valor:");
            Console.WriteLine(string.Join(" ", numeros));

            break;
        }
    }
}
