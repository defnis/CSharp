/* Problema
 Escriba un programa que permita el ingreso de números enteros positivos para calcular su promedio, el ingreso finaliza cuando el usuario ingresa un número negativo. Luego mostrar el promedio y la cantidad de valores que se ingresaron. Ej: “El promedio es ….. con un total de …. ingresos.”
 */

using System;

class Program
{
    static void Main()
    {
        int suma = 0; // Acumulador para la suma de los números
        int contador = 0; // Contador de números ingresados

        Console.WriteLine("Ingrese números enteros positivos. Para terminar, ingrese un número negativo.");

        while (true)
        {
            Console.Write("Ingrese un número: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int numero))
            {
                if (numero < 0) // Condición para finalizar el ingreso
                {
                    break;
                }

                suma += numero; // Suma el número ingresado
                contador++; // Incrementa el contador
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número entero válido.");
            }
        }

        if (contador > 0)
        {
            double promedio = (double)suma / contador; // Calcula el promedio
            Console.WriteLine($"\nEl promedio es {promedio:F2} con un total de {contador} ingresos.");
        }
        else
        {
            Console.WriteLine("\nNo se ingresaron números válidos.");
        }
    }
}
