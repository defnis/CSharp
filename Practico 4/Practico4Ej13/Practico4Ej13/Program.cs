/* Problema
 Escriba un programa que para un texto ingresado nos muestre cual es la palabra más larga dentro de ese texto y cuántas letras tiene.
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        // Separamos el texto en palabras utilizando espacio como delimitador
        string[] palabras = texto.Split(new char[] { ' ', '\t', '\n', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // Variables para almacenar la palabra más larga y su longitud
        string palabraMasLarga = "";
        int longitudMaxima = 0;

        // Recorremos las palabras y encontramos la más larga
        foreach (string palabra in palabras)
        {
            if (palabra.Length > longitudMaxima)
            {
                palabraMasLarga = palabra;
                longitudMaxima = palabra.Length;
            }
        }

        // Mostrar la palabra más larga y su longitud
        if (palabraMasLarga != "")
        {
            Console.WriteLine($"\nLa palabra más larga es: '{palabraMasLarga}' con {longitudMaxima} letras.");
        }
        else
        {
            Console.WriteLine("\nNo se ingresaron palabras válidas.");
        }
    }
}
