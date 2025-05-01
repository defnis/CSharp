// Dar un problrema y resolverlo usando for, while, do while y repeat.

using System;

class Program
{
    static void Main()
    {
        int limit = 50; // Límite para la suma

        Console.WriteLine("Programa para alcanzar un límite de suma usando diferentes bucles.");
        Console.WriteLine($"El objetivo es alcanzar o superar la suma de {limit}.\n");

        // Resolver usando for
        int sumFor = 0;
        Console.WriteLine("Usando FOR:");
        for (int i = 1; sumFor < limit; i++)
        {
            Console.Write($"Ingrese un número ({limit - sumFor} restantes): ");
            sumFor += int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Suma alcanzada con FOR: {sumFor}\n");

        // Resolver usando while
        int sumWhile = 0;
        Console.WriteLine("Usando WHILE:");
        while (sumWhile < limit)
        {
            Console.Write($"Ingrese un número ({limit - sumWhile} restantes): ");
            sumWhile += int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Suma alcanzada con WHILE: {sumWhile}\n");

        // Resolver usando do-while
        int sumDoWhile = 0;
        Console.WriteLine("Usando DO-WHILE:");
        do
        {
            Console.Write($"Ingrese un número ({limit - sumDoWhile} restantes): ");
            sumDoWhile += int.Parse(Console.ReadLine());
        } while (sumDoWhile < limit);
        Console.WriteLine($"Suma alcanzada con DO-WHILE: {sumDoWhile}\n");

        // Resolver usando repeat (simulación con bucle infinito)
        int sumRepeat = 0;
        Console.WriteLine("Usando REPEAT (simulado):");
        while (true) // Simulación de repeat
        {
            Console.Write($"Ingrese un número ({limit - sumRepeat} restantes): ");
            sumRepeat += int.Parse(Console.ReadLine());
            if (sumRepeat >= limit) break; // Condición de salida
        }
        Console.WriteLine($"Suma alcanzada con REPEAT: {sumRepeat}\n");

        Console.WriteLine("Fin del programa.");
    }
}
