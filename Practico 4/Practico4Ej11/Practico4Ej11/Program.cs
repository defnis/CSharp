/* Problema
 Escriba un programa que dado un texto ingresado por el usuario cuente la cantidad total de vocales que aparecen y la muestre por pantalla.
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        int contadorVocales = 0;

        // Recorre cada carácter del texto
        foreach (char c in texto)
        {
            // Verifica si el carácter es una vocal (mayúscula o minúscula)
            if ("aeiouAEIOU".Contains(c))
            {
                contadorVocales++;
            }
        }

        Console.WriteLine($"\nLa cantidad total de vocales en el texto es: {contadorVocales}");
    }
}
