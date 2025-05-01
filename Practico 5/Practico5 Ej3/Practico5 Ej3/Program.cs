/* Problema
 Escribe un programa en C# que genere un arreglo de 20 lugares y lo llene con números aleatorios entre 1 y 100. 
Luego el programa debe calcular el promedio de los valores contenidos en el arreglo,
y mostrar por pantalla cuántos elementos son mayores l promedio calculado.
 */

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] numeros = new int[20];
        int suma = 0;
        int contadorMayoresPromedio = 0;

        // Generar 20 números aleatorios entre 1 y 100 e imprimirlos
        Console.WriteLine("Números generados:");
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = random.Next(1, 101); // Genera un número entre 1 y 100
            Console.Write(numeros[i] + " ");
            suma += numeros[i];
        }
        Console.WriteLine();

        // Calcular el promedio
        double promedio = suma / (double)numeros.Length;
        Console.WriteLine($"Promedio de los valores: {promedio:F2}");

        // Contar cuántos números son mayores al promedio
        foreach (int numero in numeros)
        {
            if (numero > promedio)
            {
                contadorMayoresPromedio++;
            }
        }

        // Mostrar la cantidad de números mayores al promedio
        Console.WriteLine($"Cantidad de números mayores al promedio: {contadorMayoresPromedio}");
    }
}
