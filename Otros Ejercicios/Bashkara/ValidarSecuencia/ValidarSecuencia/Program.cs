/* Problema
 Dada una secuencia de números reales y dos valores reales que representan un intervalo, donde el primer valor debe ser menor o igual al segundo. 
 Realice un programa que solicite al usuario dichos datos, realizando las validaciones correspondientes, 
 y calcule cuántos elementos de la secuencia se encuentran en dicho intervalo. 
 */

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Solicitar la secuencia de números reales
        Console.WriteLine("Ingrese una secuencia de números reales separados por espacios:");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        List<double> numbers = new List<double>();
        foreach (string part in parts)
        {
            if (double.TryParse(part, out double number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine($"El valor '{part}' no es un número válido y será ignorado.");
            }
        }

        // Validar que haya al menos un número en la secuencia
        if (numbers.Count == 0)
        {
            Console.WriteLine("No se ingresaron números válidos. Saliendo del programa...");
            return;
        }

        // Solicitar el intervalo
        double lowerBound, upperBound;
        while (true)
        {
            Console.Write("Ingrese el límite inferior del intervalo: ");
            if (double.TryParse(Console.ReadLine(), out lowerBound))
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número real.");
            }
        }

        while (true)
        {
            Console.Write("Ingrese el límite superior del intervalo: ");
            if (double.TryParse(Console.ReadLine(), out upperBound) && upperBound >= lowerBound)
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Asegúrese de que el límite superior sea mayor o igual al límite inferior.");
            }
        }

        // Contar cuántos números están dentro del intervalo
        int countInInterval = 0;
        foreach (double number in numbers)
        {
            if (number >= lowerBound && number <= upperBound)
            {
                countInInterval++;
            }
        }

        // Mostrar el resultado
        Console.WriteLine($"Cantidad de números en el intervalo [{lowerBound}, {upperBound}]: {countInInterval}");
    }
}
