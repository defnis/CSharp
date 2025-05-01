/* Problema
 Se desea realizar una aplicación que solicite al usuario un carácter y un número natural N, y que la aplicación muestre en pantalla dicho carácter repetido N veces consecutivas.
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un carácter: ");
        string inputChar = Console.ReadLine();

        Console.Write("Ingrese un número natural (N): ");
        string inputN = Console.ReadLine();

        if (inputChar.Length == 1 && int.TryParse(inputN, out int N) && N > 0)
        {
            char caracter = inputChar[0]; // Obtiene el carácter ingresado
            Console.WriteLine($"\nEl carácter '{caracter}' repetido {N} veces es:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(caracter);
            }
            Console.WriteLine(); // Salto de línea al final
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un carácter válido y un número natural mayor a 0.");
        }
    }
}

