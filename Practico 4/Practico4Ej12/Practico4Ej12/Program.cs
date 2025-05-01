/* Problema
 Escriba un programa que, dada una oración ingresada calcule y muestre por pantalla:
a. El número total de caracteres en la oración
b. La cantidad total de letras (sólo consonantes y vocales, sin espacios, puntos ni signos de puntuación)
c. La cantidad de palabras separadas por uno o más espacios
En este ejercicio, para simplificar, asumiremos que los posibles caracteres de entrada sólo son letras, espacios, dígitos, 
signos de puntuación, signos de interrogación y de exclamación.
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una oración: ");
        string oracion = Console.ReadLine();

        // a. Número total de caracteres en la oración
        int totalCaracteres = oracion.Length;

        // b. Número de letras (consonantes y vocales, sin contar espacios ni signos de puntuación)
        int totalLetras = 0;
        foreach (char c in oracion)
        {
            if (Char.IsLetter(c)) // Verifica si el carácter es una letra
            {
                totalLetras++;
            }
        }

        // c. Número de palabras separadas por uno o más espacios
        // Usamos el método Split para dividir la oración en palabras
        string[] palabras = oracion.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        int totalPalabras = palabras.Length;

        // Mostramos los resultados
        Console.WriteLine($"\nEl número total de caracteres en la oración es: {totalCaracteres}");
        Console.WriteLine($"La cantidad total de letras (vocales y consonantes) es: {totalLetras}");
        Console.WriteLine($"La cantidad de palabras separadas por uno o más espacios es: {totalPalabras}");
    }
}

