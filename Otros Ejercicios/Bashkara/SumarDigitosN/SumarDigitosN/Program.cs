/* Problema
 Escriba un programa que solicite al usuario un número natural de al menos 5 cifras y muestre la suma de las últimas 5 cifras. 
 Realice una validación sobre la entrada.
 */

using System;

class Program
{
    static void Main()
    {
        // Solicitar un número natural con al menos 5 cifras
        Console.Write("Ingrese un número natural de al menos 5 cifras: ");

        if (!long.TryParse(Console.ReadLine(), out long number) || number < 10000)
        {
            Console.WriteLine("Entrada inválida. El número debe ser un número natural de al menos 5 cifras.");
            return;
        }

        // Obtener las últimas 5 cifras del número
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            int digit = (int)(number % 10); // Obtener el último dígito
            sum += digit; // Sumar el dígito
            number /= 10; // Eliminar el último dígito
        }

        // Mostrar el resultado
        Console.WriteLine($"La suma de las últimas 5 cifras es: {sum}");
    }
}
