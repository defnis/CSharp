// Escriba un programa para leer una secuencia de caracteres terminada en <<ENTER>> y contar cuántos de ellos son espacios en blanco (carácter ‘ ‘). 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una secuencia de caracteres (presione ENTER para finalizar):");

        // Leer la secuencia de caracteres ingresada por el usuario
        string input = Console.ReadLine();

        // Contar los espacios en blanco
        int spaceCount = 0;
        foreach (char c in input)
        {
            if (c == ' ')
            {
                spaceCount++;
            }
        }

        // Mostrar el resultado
        Console.WriteLine($"La cantidad de espacios en blanco es: {spaceCount}");
    }
}
