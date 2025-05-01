/*
Inicio
   Escribir("Ingrese el costo del objeto (c): ")
   Leer(c)
   Escribir("Ingrese el pago realizado (p): ")
   Leer(p)   v ← p - c

   billetes50 ← v // 50
   v ← v % 50

   billetes25 ← v // 25
   v ← v % 25

   billetes10 ← v // 10
   v ← v % 10

   billetes5 ← v // 5
   v ← v % 5

   billetes1 ← v

   Escribir("Billetes de 50: ", billetes50)
   Escribir("Billetes de 25: ", billetes25)
   Escribir("Billetes de 10: ", billetes10)
   Escribir("Billetes de 5: ", billetes5)
   Escribir("Billetes de 1: ", billetes1)
Fin

TRAZA
Entrada (c) | Entrada (p) | Vuelto (v=p−c) | Billetes de 50 | Billetes de 25 | Billetes de 10 | Billetes de 5 | Billetes de 1
135         |    200      |      65        | 1              | 0              | 1              | 1             | 0
40          |    100      |      60        | 1              | 0              | 1              | 0             | 0
75          |    100      |      25        | 0              | 1              | 0              | 0             | 0

*/

using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingrese el costo del objeto (c): ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el pago realizado (p): ");
        int p = int.Parse(Console.ReadLine());

        int vuelto = p - c;

        int billetes50 = vuelto / 50;
        vuelto %= 50;

        int billetes25 = vuelto / 25;
        vuelto %= 25;

        int billetes10 = vuelto / 10;
        vuelto %= 10;

        int billetes5 = vuelto / 5;
        vuelto %= 5;

        int billetes1 = vuelto;

        Console.WriteLine("Billetes de 50: " + billetes50);
        Console.WriteLine("Billetes de 25: " + billetes25);
        Console.WriteLine("Billetes de 10: " + billetes10);
        Console.WriteLine("Billetes de 5: " + billetes5);
        Console.WriteLine("Billetes de 1: " + billetes1);
    }
}
