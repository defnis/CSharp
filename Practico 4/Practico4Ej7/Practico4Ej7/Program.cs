/* Problema
 Escriba un programa que permita al usuario ingresar las medidas de 2 lados de un rectángulo, y que luego imprima por pantalla un rectángulo vacío (sin relleno), es decir, solo debe dibujar los lados.
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
            ancho > 1 && largo > 1) // Ancho y largo deben ser mayores que 1 para dibujar un rectángulo vacío
        {
            Console.WriteLine("\nDibujando el rectángulo vacío:\n");

            for (int i = 0; i < largo; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    // Dibuja los bordes: parte superior, inferior, izquierda y derecha
                    if (i == 0 || i == largo - 1 || j == 0 || j == ancho - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" "); // Espacios para el interior del rectángulo
                    }
                }
                Console.WriteLine(); // Nueva línea al final de cada fila
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese valores enteros positivos mayores que 1 para el ancho y el largo.");
        }
    }
}
