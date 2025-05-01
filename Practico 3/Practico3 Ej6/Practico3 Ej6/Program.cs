/*
Inicio
   Escribir("Ingrese el lado del cuadrado: ")
   Leer(L)

   Escribir("Elija una opción: ")
   Escribir("1: Perímetro")
   Escribir("2: Área")
   Leer(O)

   Si O = 1 Entonces
       P ← 4 * L
       Escribir("El perímetro del cuadrado es: ", P)
   Sino Si O = 2 Entonces
       A ← L * L
       Escribir("El área del cuadrado es: ", A)
   Sino
       Escribir("Opción inválida")
   FinSi
Fin
*/

using System;

class Programa
{
    static void Main()
    {
        // Solicitar el lado del cuadrado
        Console.Write("Ingrese el lado del cuadrado: ");
        double lado = double.Parse(Console.ReadLine());

        // Solicitar la opción al usuario
        Console.WriteLine("Elija una opción:");
        Console.WriteLine("1: Perímetro");
        Console.WriteLine("2: Área");
        int opcion = int.Parse(Console.ReadLine());

        // Evaluar la opción y realizar el cálculo correspondiente
        if (opcion == 1)
        {
            double perimetro = 4 * lado;
            Console.WriteLine("El perímetro del cuadrado es: " + perimetro);
        }
        else if (opcion == 2)
        {
            double area = lado * lado;
            Console.WriteLine("El área del cuadrado es: " + area);
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
    }
}
