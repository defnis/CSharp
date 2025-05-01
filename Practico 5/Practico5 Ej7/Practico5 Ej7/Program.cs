/* Problema
 Hacer un programa en C# que permita ingresar un número, y luego crear un arreglo para almacenar por separado los dígitos del número. 
 Luego recorrer el arreglo y mostrar el índice que contiene el dígito mayor y el índice que contiene el dígito menor.
 */

using System;

class Program
{
    static void Main()
    {
        ProcesarNumero();
    }

    static void ProcesarNumero()
    {
        Console.Write("Ingrese un número: ");
        string entrada = Console.ReadLine();

        // Validar que la entrada sea un número positivo
        while (!long.TryParse(entrada, out long numero) || numero < 0)
        {
            Console.Write("Entrada no válida. Ingrese un número positivo: ");
            entrada = Console.ReadLine();
        }

        // Crear un arreglo con los dígitos del número
        int[] digitos = new int[entrada.Length];
        for (int i = 0; i < entrada.Length; i++)
        {
            digitos[i] = int.Parse(entrada[i].ToString());
        }

        // Encontrar el índice del dígito mayor y menor
        int indiceMayor = 0, indiceMenor = 0;
        for (int i = 1; i < digitos.Length; i++)
        {
            if (digitos[i] > digitos[indiceMayor])
            {
                indiceMayor = i;
            }
            if (digitos[i] < digitos[indiceMenor])
            {
                indiceMenor = i;
            }
        }

        // Mostrar resultados
        Console.WriteLine($"El dígito mayor es {digitos[indiceMayor]}, en el índice {indiceMayor}.");
        Console.WriteLine($"El dígito menor es {digitos[indiceMenor]}, en el índice {indiceMenor}.");
    }
}
