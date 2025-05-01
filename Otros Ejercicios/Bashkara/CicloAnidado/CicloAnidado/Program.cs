// Mostrar un ciclo anidado.

using System;

class Program
{
    static void Main()
    {
        int cicloInterno = 1; // Contador global para el ciclo interno

        for (int i = 1; i <= 5; i++) // Ciclo externo (controla el valor de i)
        {
            int cicloExterno = i; // Contador del ciclo externo

            for (int j = 1; j <= i; j++) // Ciclo interno (controla el valor de j)
            {
                // Mostrar la información de cada iteración
                Console.WriteLine($"El valor de i es {i,3}, j es {j,2}, cicloInterno es {cicloInterno,3}, cicloExterno es {cicloExterno,3}");
                cicloInterno++; // Incrementar el contador global
            }

            // Línea separadora después de cada iteración del ciclo externo
            Console.WriteLine(new string('*', 16));
        }
    }
}

