/* Problema
 Escriba un algoritmo para calcular la suma de los divisores positivos de un número N. Por ejemplo, si N=12, sus divisores son 1, 2, 3, 4, 6 y 12, y la suma de los divisores es 28. El número N=17 es primo, por lo tanto, sus únicos divisores son 1 y 17, y la suma es 18.
 */

using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario el número N
        Console.Write("Ingrese un número positivo: ");
        if (!int.TryParse(Console.ReadLine(), out int numero) || numero <= 0)
        {
            Console.WriteLine("Debe ingresar un número positivo.");
            return;
        }

        // Inicializar la suma de divisores
        int sumaDivisores = 0;

        // Calcular la suma de los divisores
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                sumaDivisores += i;
            }
        }

        // Mostrar el resultado
        Console.WriteLine($"\nLa suma de los divisores positivos de {numero} es: {sumaDivisores}");
    }
}
