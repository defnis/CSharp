/* Problema 
 Escriba un programa en Pascal para leer una secuencia de 5 números naturales, y mostrar el menor y el mayor de todos los números leídos. 
 */

using System;

class Program
{
    static void Main()
    {
        const int cantidadNumeros = 5; // Cantidad de números a leer
        int menor = int.MaxValue; // Inicializar con el máximo valor posible
        int mayor = int.MinValue; // Inicializar con el mínimo valor posible

        Console.WriteLine($"Ingrese {cantidadNumeros} números naturales:");

        for (int i = 1; i <= cantidadNumeros; i++)
        {
            Console.Write($"Número {i}: ");
            if (!int.TryParse(Console.ReadLine(), out int numero) || numero <= 0)
            {
                Console.WriteLine("Debe ingresar un número natural (entero positivo). Inténtelo de nuevo.");
                i--; // Reintentar la entrada
                continue;
            }

            // Actualizar el menor y el mayor
            if (numero < menor) menor = numero;
            if (numero > mayor) mayor = numero;
        }

        // Mostrar el resultado
        Console.WriteLine($"\nEl número menor es: {menor}");
        Console.WriteLine($"El número mayor es: {mayor}");
    }
}

