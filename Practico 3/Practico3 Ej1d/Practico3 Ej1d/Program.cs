/*
Inicio
   Escribir("Ingrese el primer número (num1): ")
   Leer(num1)
   Escribir("Ingrese el segundo número (num2): ")
   Leer(num2)
   Si num1 >= num2 Entonces
       Escribir("num1 es mayor o igual a num2")
   Sino
       Escribir("num1 es menor que num2")
   FinSi
Fin

TRAZA

num1  num2    Operación num1 ≥ num2      Salida
10	  5	      10 >= 5 → True	       "num1 es mayor o igual a num2"
3	  7	       3 >= 7 → False	       "num1 es menor que num2"
4	  4	       4 >= 4 → True	       "num1 es mayor o igual a num2"
*/

using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingrese el primer número (num1): ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número (num2): ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 >= num2)
        {
            Console.WriteLine("num1 es mayor o igual a num2");
        }
        else
        {
            Console.WriteLine("num1 es menor que num2");
        }
    }
}

