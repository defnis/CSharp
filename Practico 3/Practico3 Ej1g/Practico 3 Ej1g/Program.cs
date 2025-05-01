/*
Inicio
   Escribir("Ingrese el valor de a: ")
   Leer(a)
   Escribir("Ingrese el valor de b: ")
   Leer(b)
   Escribir("Ingrese el valor de c: ")
   Leer(c)

   diferencia ← |a - b|

   Si diferencia > c Entonces
       resultado ← a * b
       Escribir("El producto de a y b es: ", resultado)
   Sino
       Si b ≠ 0 Entonces
           resultado ← a / b
           Escribir("El cociente de a y b es: ", resultado)
       Sino
           Escribir("No es posible realizar la división: b es 0.")
       FinSi
   FinSi
Fin
*/

using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingrese el valor de a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de c: ");
        int c = int.Parse(Console.ReadLine());

        int diferencia = Math.Abs(a - b);

        if (diferencia > c)
        {
            int producto = a * b;
            Console.WriteLine("El producto de a y b es: " + producto);
        }
        else
        {
            if (b != 0)
            {
                double cociente = (double)a / b;
                Console.WriteLine("El cociente de a y b es: " + cociente);
            }
            else
            {
                Console.WriteLine("No es posible realizar la división: b es 0.");
            }
        }
    }
}


