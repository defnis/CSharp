/* Programa
 Desarrolla un programa en C# que genere dos arreglos de tamaño 5 y los llene con números aleatorios entre 3 y 57. 
 Luego, crea un tercer arreglo del mismo tamaño donde cada elemento sea la suma de los elementos correspondientes de los dos primeros arreglos.
 */

using System;

class Program
{
    static void Main()
    {
        GenerarYSumarArreglos();
    }

    static void GenerarYSumarArreglos()
    {
        Random random = new Random();
        int[] arreglo1 = new int[5];
        int[] arreglo2 = new int[5];
        int[] arregloSuma = new int[5];

        // Llenar los dos primeros arreglos con números aleatorios entre 3 y 57
        Console.WriteLine("Arreglo 1:");
        for (int i = 0; i < arreglo1.Length; i++)
        {
            arreglo1[i] = random.Next(3, 58); // Genera un número entre 3 y 57
            Console.Write(arreglo1[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Arreglo 2:");
        for (int i = 0; i < arreglo2.Length; i++)
        {
            arreglo2[i] = random.Next(3, 58); // Genera un número entre 3 y 57
            Console.Write(arreglo2[i] + " ");
        }
        Console.WriteLine();

        // Crear el tercer arreglo como suma de los dos primeros
        Console.WriteLine("Arreglo suma:");
        for (int i = 0; i < arregloSuma.Length; i++)
        {
            arregloSuma[i] = arreglo1[i] + arreglo2[i];
            Console.Write(arregloSuma[i] + " ");
        }
        Console.WriteLine();
    }
}
