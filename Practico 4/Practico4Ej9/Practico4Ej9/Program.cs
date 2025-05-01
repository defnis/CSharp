/* Problema
 Escriba un programa que permita el ingreso de números enteros positivos, finalizando el ingreso con 0, y luego indique si la secuencia estaba ordenada de menor a mayor.
 */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese números enteros positivos. Ingrese 0 para finalizar.");

        int anterior = int.MinValue; // Para comparar, inicializado al valor mínimo de un entero
        bool estaOrdenado = true; // Bandera para verificar si la secuencia está ordenada
        int numero; // Variable para almacenar el número ingresado

        while (true)
        {
            Console.Write("Ingrese un número: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numero) && numero >= 0)
            {
                if (numero == 0) // Condición para finalizar el ingreso
                {
                    break;
                }

                if (numero < anterior) // Verifica si el número actual rompe el orden
                {
                    estaOrdenado = false;
                }

                anterior = numero; // Actualiza el número anterior
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo válido o 0 para finalizar.");
            }
        }

        // Resultados
        if (estaOrdenado)
        {
            Console.WriteLine("\nLa secuencia está ordenada de menor a mayor.");
        }
        else
        {
            Console.WriteLine("\nLa secuencia no está ordenada de menor a mayor.");
        }
    }
}
