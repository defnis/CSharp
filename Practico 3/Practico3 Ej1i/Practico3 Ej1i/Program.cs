/*
Inicio
   Escribir("Ingrese un año: ")
   Leer(A)

   Si (A % 4 = 0 y A % 100 ≠ 0) o (A % 400 = 0) Entonces
       Escribir("El año ", A, " es bisiesto.")
   Sino
       Escribir("El año ", A, " no es bisiesto.")
   FinSi
Fin


TRAZA
Entrada (A) | Condición (A%4=0∧A%100≠0∨A%400=0A)  | Resultado
2000        | 2000%4=0,2000%100=0,2000%400=0       | "El año 2000 es bisiesto."
1900        | 1900%4=0,1900%100=0,1900%400≠0       | "El año 1900 no es bisiesto."
2024        | 2024%4=0                             | "El año 2024 es bisiesto."
2023        | 2023%4≠0                             | "El año 2023 no es bisiesto."
*/

using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingrese un año: ");
        int año = int.Parse(Console.ReadLine());

        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
        {
            Console.WriteLine("El año " + año + " es bisiesto.");
        }
        else
        {
            Console.WriteLine("El año " + año + " no es bisiesto.");
        }
    }
}
