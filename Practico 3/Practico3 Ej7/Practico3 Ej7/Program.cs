/*
Inicio
   Escribir("Ingrese el primer número: ")
   Leer(n1)
   Escribir("Ingrese el segundo número: ")
   Leer(n2)
   Escribir("Ingrese el tercer número: ")
   Leer(n3)

   Si n1 > n2 y n1 > n3 Entonces
       mayor ← n1
   Sino Si n2 > n1 y n2 > n3 Entonces
       mayor ← n2
   Sino
       mayor ← n3
   FinSi

   Si n1 < n2 y n1 < n3 Entonces
       menor ← n1
   Sino Si n2 < n1 y n2 < n3 Entonces
       menor ← n2
   Sino
       menor ← n3
   FinSi

   Escribir("El mayor número es: ", mayor)
   Escribir("El menor número es: ", menor)
Fin
*/

using System;

class Programa
{
    static void Main()
    {
        // Solicitar tres números al usuario
        Console.Write("Ingrese el primer número: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        double n3 = double.Parse(Console.ReadLine());

        // Determinar el mayor número
        double mayor;
        if (n1 > n2 && n1 > n3)
        {
            mayor = n1;
        }
        else if (n2 > n1 && n2 > n3)
        {
            mayor = n2;
        }
        else
        {
            mayor = n3;
        }

        // Determinar el menor número
        double menor;
        if (n1 < n2 && n1 < n3)
        {
            menor = n1;
        }
        else if (n2 < n1 && n2 < n3)
        {
            menor = n2;
        }
        else
        {
            menor = n3;
        }

        // Mostrar el resultado
        Console.WriteLine("El mayor número es: " + mayor);
        Console.WriteLine("El menor número es: " + menor);
    }
}
