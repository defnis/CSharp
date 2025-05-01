/* Problema
 Se desea realizar una aplicación que solicite al usuario un número natural y que como resultado muestre por pantalla todos los divisores naturales de dicho número. 
 */

using System;

class Program
{
    static void Main()
    {
        // Solicitar el número natural al usuario
        Console.Write("Ingrese un número natural: ");
        if (!int.TryParse(Console.ReadLine(), out int numero) || numero < 1)
        {
            Console.WriteLine("Debe ingresar un número natural (entero positivo).");
            return;
        }

        // Mostrar los divisores del número
        Console.WriteLine($"\nDivisores naturales de {numero}:");
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
N