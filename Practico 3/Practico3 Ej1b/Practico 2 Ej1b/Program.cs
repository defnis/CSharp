/*
 Inicio
   Escribir("Ingrese el primer número (a): ")
   Leer(a)
   Escribir("Ingrese el segundo número (b): ")
   Leer(b)
   suma ← a + b
   Escribir("La suma de a y b es: ", suma)
Fin

TRAZA
Entrada a   Entrada b  Operación a+b     Salida
5       	3	        5 + 3 = 8	    "La suma de a y b es: 8"
-2          7	        -2 + 7 = 5   	"La suma de a y b es: 5"
0	        0       	0 + 0 = 0	    "La suma de a y b es: 0"
10	       -5       	10 + (-5) = 5	"La suma de a y b es: 5"

*/

using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingrese el primer número (a): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número (b): ");
        int b = int.Parse(Console.ReadLine());

        int suma = a + b;

        Console.WriteLine("La suma de a y b es: " + suma);
    }
}
