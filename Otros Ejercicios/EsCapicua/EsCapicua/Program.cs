// Escriba un programa que lea por teclado un número natural N y determine si es o no capicúa.
// Debe validar que la entrada sea un número natural. 

using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario un número natural
        Console.Write("Ingrese un número natural: ");

        // Validar que la entrada sea un número natural
        if (!long.TryParse(Console.ReadLine(), out long number) || number < 0)
        {
            Console.WriteLine("Entrada inválida. Debe ingresar un número natural (mayor o igual a 0).");
            return;
        }

        // Convertir el número a una cadena para facilitar el análisis
        string numberStr = number.ToString();
        string reversedNumberStr = "";

        // Crear una cadena con el número al revés
        for (int i = numberStr.Length - 1; i >= 0; i--)
        {
            reversedNumberStr += numberStr[i];
        }

        // Comparar el número original con el número invertido
        if (numberStr == reversedNumberStr)
        {
            Console.WriteLine("El número es capicúa.");
        }
        else
        {
            Console.WriteLine("El número no es capicúa.");
        }
    }
}
