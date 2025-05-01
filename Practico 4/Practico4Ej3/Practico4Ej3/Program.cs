/* Problema
 Desarrollar un programa que permita al usuario indicar cuantos valores quiere ingresar, luego que permita la carga de los valores por teclado y nos muestre posteriormente la suma de los valores ingresados y su promedio.
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Cuántos valores desea ingresar?: ");
        string inputCantidad = Console.ReadLine();

        if (int.TryParse(inputCantidad, out int cantidad) && cantidad > 0)
        {
            double suma = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el valor {i}: ");
                string inputValor = Console.ReadLine();

                if (double.TryParse(inputValor, out double valor))
                {
                    suma += valor;
                }
                else
                {
                    Console.WriteLine("Valor no válido. Por favor, ingrese un número.");
                    i--; // Repite el intento para este índice
                }
            }

            double promedio = suma / cantidad;
            Console.WriteLine($"\nLa suma de los valores ingresados es: {suma}");
            Console.WriteLine($"El promedio de los valores ingresados es: {promedio}");
        }
        else
        {
            Console.WriteLine("Por favor, ingrese una cantidad válida de valores.");
        }
    }
}
