/*
Inicio
   Escribir("Ingrese un valor para x: ")
   Leer(x)
   resultado ← x * 0.3
   Escribir("El 30% de x es: ", resultado)
Fin


Entrada 𝑥   Operación 𝑥 * 0.3      Salida
100	        100 × 0.3 = 30	      "El 30% de x es: 30"
50	         50 × 0.3 = 15	      "El 30% de x es: 15"
0          	  0 × 0.3 = 0	      "El 30% de x es: 0"
-200	   -200 × 0.3 = -60	      "El 30% de x es: -60"
*/

using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingrese un valor para x: ");
        double x = double.Parse(Console.ReadLine());

        double resultado = x * 0.3;

        Console.WriteLine("El 30% de x es: " + resultado);
    }
}
