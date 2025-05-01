/* Problema
 Escribe un programa en C# que genere 10 números aleatorios entre 1 y 20 (incluidos) y los almacene en un arreglo. Luego, el programa debe pedirle al usuario que ingrese un número para buscar en el arreglo. Si el número se encuentra en el arreglo, el programa debe mostrar la posición en la que se encuentra. Si el número no está en el arreglo, el programa debe mostrar un mensaje indicando que no se encontró. El programa termina cuando el usuario ingresa un numero negativo para buscar en el arreglo.
 */

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] numeros = new int[10];

        // Generar 10 números aleatorios entre 1 y 20 e imprimirlos
        Console.WriteLine("Números generados:");
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = random.Next(1, 21); // Genera un número entre 1 y 20
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();

        while (true)
        {
            Console.Write("\nIngrese un número para buscar en el arreglo (o un número negativo para salir): ");
            int numeroBuscado;

            // Validar entrada del usuario
            if (!int.TryParse(Console.ReadLine(), out numeroBuscado))
            {
                Console.WriteLine("Entrada no válida. Inténtelo de nuevo.");
                continue;
            }

            // Salir si el usuario ingresa un número negativo
            if (numeroBuscado < 0)
            {
                Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                break;
            }

            // Buscar el número en el arreglo
            bool encontrado = false;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    Console.WriteLine($"Número encontrado en la posición {i}.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Número no encontrado en el arreglo.");
            }
        }
    }
}
