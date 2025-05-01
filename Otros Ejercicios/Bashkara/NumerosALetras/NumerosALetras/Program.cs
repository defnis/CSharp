/* Programa 
 Escriba un programa en Pascal para leer una secuencia de 20 números y convertirlos a sus correspondientes caracteres en la tabla ASCII 
 */

using System;

class Program
{
    static void Main()
    {
        const int cantidadNumeros = 5; // Cantidad de números a leer
        int[] numeros = new int[cantidadNumeros]; // Arreglo para almacenar los números
        char[] caracteres = new char[cantidadNumeros]; // Arreglo para almacenar los caracteres correspondientes

        Console.WriteLine($"Ingrese {cantidadNumeros} números enteros entre 0 y 255:");

        // Leer los números
        for (int i = 0; i < cantidadNumeros; i++)
        {
            Console.Write($"Número {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out int numero) || numero < 0 || numero > 255)
            {
                Console.WriteLine("Debe ingresar un número entre 0 y 255. Inténtelo de nuevo.");
                i--; // Reintentar la entrada
                continue;
            }

            numeros[i] = numero;
            caracteres[i] = (char)numero; // Convertir el número al carácter correspondiente
        }

        // Mostrar los resultados
        Console.WriteLine("\nConversión a caracteres ASCII:");
        for (int i = 0; i < cantidadNumeros; i++)
        {
            Console.WriteLine($"Número {numeros[i]} -> Carácter '{caracteres[i]}'");
        }
    }
}
