// Escriba un programa  que permita leer una secuencia de números naturales y mostrar el promedio. La secuencia termina en 0. 

using System;

class Program
{
    static void Main()
    {
        int sum = 0;       // Para almacenar la suma de los números
        int count = 0;     // Para contar la cantidad de números ingresados

        Console.WriteLine("Ingrese una secuencia de números naturales. Ingrese 0 para finalizar:");

        while (true)
        {
            Console.Write("Ingrese un número: ");
            if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número natural.");
                continue;
            }

            if (number == 0)
            {
                break; // Finalizar la entrada si se ingresa 0
            }

            sum += number;
            count++;
        }

        if (count == 0)
        {
            Console.WriteLine("No se ingresaron números para calcular el promedio.");
        }
        else
        {
            double average = (double)sum / count;
            Console.WriteLine($"El promedio de los {count} números ingresados es: {average:F2}");
        }
    }
}
