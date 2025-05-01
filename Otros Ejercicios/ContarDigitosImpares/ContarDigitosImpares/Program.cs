// Realice un programa para contar cuántos dígitos impares tiene un número entero N. 

using System;

class Program
{
    static void Main()
    {
        // Solicitar el número entero N
        Console.Write("Ingrese un número entero: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
            return;
        }

        // Convertir el número a su representación absoluta
        number = Math.Abs(number);

        // Contador de dígitos impares
        int oddCount = 0;

        // Iterar a través de los dígitos del número
        while (number > 0)
        {
            int digit = number % 10; // Obtener el último dígito
            if (digit % 2 != 0) // Verificar si es impar
            {
                oddCount++;
            }
            number /= 10; // Eliminar el último dígito
        }

        // Mostrar el resultado
        Console.WriteLine($"El número tiene {oddCount} dígitos impares.");
    }
}

