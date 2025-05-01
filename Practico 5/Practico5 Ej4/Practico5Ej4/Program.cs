/* Problema
 Escribe un procedimiento en C# que genere un arreglo de 8 lugares y lo llene con números aleatorios entre 1 y 100. 
 Luego, crea otro arreglo del mismo tamaño y llena este segundo arreglo con los valores del primero, pero en orden inverso.
 Finalmente, muestra ambos arreglos en pantalla.
 */

using System;

class Program
{
    static void Main()
    {
        GenerarYMostrarArreglos();
    }

    static void GenerarYMostrarArreglos()
    {
        Random random = new Random();
        int[] arregloOriginal = new int[8];
        int[] arregloInverso = new int[8];

        // Llenar el primer arreglo con números aleatorios entre 1 y 100
        Console.WriteLine("Arreglo original:");
        for (int i = 0; i < arregloOriginal.Length; i++)
        {
            arregloOriginal[i] = random.Next(1, 101); // Genera un número entre 1 y 100
            Console.Write(arregloOriginal[i] + " ");
        }
        Console.WriteLine();

        // Llenar el segundo arreglo con los valores del primero en orden inverso
        for (int i = 0; i < arregloInverso.Length; i++)
        {
            arregloInverso[i] = arregloOriginal[arregloOriginal.Length - 1 - i];
        }

        // Mostrar el segundo arreglo
        Console.WriteLine("Arreglo inverso:");
        for (int i = 0; i < arregloInverso.Length; i++)
        {
            Console.Write(arregloInverso[i] + " ");
        }
        Console.WriteLine();
    }
}
