/*
Inicio
   Escribir("Ingrese un número: ")
   Leer(numero)
   Si numero % 2 == 0 Entonces
       Escribir("El número es par.")
   Sino
       Escribir("El número es impar.")
   FinSi
Fin

TRAZA
Entrada Operación	Resultado
4   	4 % 2 == 0	"El número es par."
7	    7 % 2 != 0	"El número es impar."
0	    0 % 2 == 0	"El número es par."
-3	   -3 % 2 != 0	"El número es impar."
*/

using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
    }
}
