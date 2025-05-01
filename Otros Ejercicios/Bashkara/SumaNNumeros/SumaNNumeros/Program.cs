// Realice un programa que permita sumar los primeros N números naturales para un número N ingresado por el usuario.
// Deberá validar que el valor ingresado sea positivo. 

using System;

class Program
{
    static void Main()
    {
        int n;

        // Validar entrada del usuario
        while (true)
        {
            Console.Write("Ingrese un número positivo (N): ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                break; // Entrada válida, salir del bucle
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
            }
        }

        // Calcular la suma de los primeros N números naturales
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        // Mostrar el resultado
        Console.WriteLine($"La suma de los primeros {n} números naturales es: {sum}");
    }
}
