/* Problema 
 Se desea realizar un programa que solicite al usuario dos números enteros que representan un valor inferior y un valor superior y muestre por pantalla todos los enteros impares entre dichos valores inclusive. Los números deben ser mostrados por líneas, donde cada línea debe tener un número más que la anterior, con excepción de la última línea que puede tener cualquier cantidad de números. La primera línea debe tener un único número.
 */

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Variables para los límites
        int valorInferior, valorSuperior;

        // Solicitar los valores al usuario
        Console.Write("Ingrese el valor inferior: ");
        valorInferior = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor superior: ");
        valorSuperior = int.Parse(Console.ReadLine());

        // Validar que el valor inferior sea menor o igual al superior
        if (valorInferior > valorSuperior)
        {
            int temp = valorInferior;
            valorInferior = valorSuperior;
            valorSuperior = temp;
        }

        // Crear una lista de números impares entre los valores
        List<int> impares = new List<int>();
        for (int i = valorInferior; i <= valorSuperior; i++)
        {
            if (i % 2 != 0)
            {
                impares.Add(i);
            }
        }

        // Mostrar los números impares por líneas crecientes
        Console.WriteLine("\nNúmeros impares entre {0} y {1}:", valorInferior, valorSuperior);
        int index = 0; // Índice en la lista de impares
        int count = 1; // Cantidad de números por línea

        while (index < impares.Count)
        {
            // Mostrar "count" números o los restantes
            for (int j = 0; j < count && index < impares.Count; j++)
            {
                Console.Write(impares[index] + " ");
                index++;
            }
            Console.WriteLine(); // Nueva línea
            count++; // Incrementar cantidad de números por línea
        }
    }
}
