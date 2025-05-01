/* Problema
 Escriba un programa que permita al usuario ingresar las medidas de 2 lados de un rectángulo, y que luego mediante la impresión repetida de un caracter (ej: *) lo dibuje en la pantalla. Por ejemplo, si el usuario ingresa ancho = 5, largo = 9.
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el ancho del rectángulo: ");
        string inputAncho = Console.ReadLine();
        Console.Write("Ingrese el largo del rectángulo: ");
        string inputLargo = Console.ReadLine();

        if (int.TryParse(inputAncho, out int ancho) && int.TryParse(inputLargo, out int largo) &&
            ancho > 0 && largo > 0)
        {
            Console.WriteLine("\nDibujando el rectángulo:\n");
            for (int i = 0; i < largo; i++) // Recorre las filas
            {
                for (int j = 0; j < ancho; j++) // Recorre las columnas
                {
                    Console.Write("*"); // Imprime el carácter del rectángulo
                }
                Console.WriteLine(); // Nueva línea al final de cada fila
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese valores enteros positivos válidos para el ancho y el largo.");
        }
    }
}
