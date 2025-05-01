/* Problema
 Escribe un programa en C# que genere un arreglo de 10 lugares y lo llene con números aleatorios entre 1 y 100. Luego, muestra por pantalla cuántos elementos son mayores a 50.
 */

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] numeros = new int[10];
        int contadorMayores50 = 0;

        // Generar 10 números aleatorios entre 1 y 100 e imprimirlos
        Console.WriteLine("Números generados:");
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = random.Next(1, 101); // Genera un número entre 1 y 100
            Console.Write(numeros[i] + " ");

            // Contar números mayores a 50
            if (numeros[i] > 50)
            {
                contadorMayores50++;
            }
        }
        Console.WriteLine();

        // Mostrar la cantidad de números mayores a 50
        Console.WriteLine($"Cantidad de números mayores a 50: {contadorMayores50}");
    }
}
