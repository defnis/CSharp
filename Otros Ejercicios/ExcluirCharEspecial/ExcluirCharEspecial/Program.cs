// Escriba un programa en Pascal para leer una secuencia de caracteres terminada en un punto,
// y contar la cantidad de letras (SIN incluir letras como la Ñ, ñ y las vocales con acentos tanto mayúsculas como minúsculas). 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una secuencia de caracteres terminada en un punto ('.'):");

        // Leer la secuencia de caracteres
        string input = Console.ReadLine();

        // Validar que la secuencia termina con un punto
        if (string.IsNullOrEmpty(input) || input[^1] != '.')
        {
            Console.WriteLine("La secuencia debe terminar con un punto.");
            return;
        }

        // Definir caracteres que no cuentan como letras válidas
        string excludedCharacters = "áéíóúÁÉÍÓÚñÑ";

        int letterCount = 0;

        foreach (char c in input)
        {
            // Comprobar si es una letra, excluyendo las no válidas y el punto
            if (char.IsLetter(c) && !excludedCharacters.Contains(c) && c != '.')
            {
                letterCount++;
            }
        }

        // Mostrar el resultado
        Console.WriteLine($"La cantidad de letras válidas es: {letterCount}");
    }
}
