/* Problema 
Se desea realizar un programa que solicite al usuario dos números enteros que representan un valor inferior y un valor superior y muestre por pantalla todos los enteros impares entre dichos valores inclusive. 
 */

using System;

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
            // Intercambiar los valores
            int temp = valorInferior;
            valorInferior = valorSuperior;
            valorSuperior = temp;
        }

        // Mostrar los números impares entre los valores
        Console.WriteLine("\nNúmeros impares entre {0} y {1}:", valorInferior, valorSuperior);
        for (int i = valorInferior; i <= valorSuperior; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine(); // Salto de línea final
    }
}
