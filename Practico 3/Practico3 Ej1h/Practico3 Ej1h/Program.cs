/*
Inicio
   Escribir("Ingrese el tipo de socio (A, B, C): ")
   Leer(T)
   Escribir("Ingrese el costo del tratamiento: ")
   Leer(C)

   Si T = 'A' Entonces
       P ← C * 0.5
   Sino Si T = 'B' Entonces
       P ← C * 0.65
   Sino Si T = 'C' Entonces
       P ← C
   Sino
       Escribir("Tipo de socio no válido.")
       Terminar
   FinSi

   Escribir("El importe a pagar es: ", P)
Fin

TRAZA

Entrada (T) | Entrada (C) | Descuento Aplicado | Importe a Pagar (P)
'A'         | 1000        | 50%                | 500
'B'         | 1000        | 35%                | 650
'C'         | 1000        |  0%                | 1000
'X'         | 1000        | N/A                | "Tipo de socio no válido"
*/

using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingrese el tipo de socio (A, B, C): ");
        char tipoSocio = char.ToUpper(Console.ReadLine()[0]); // Convertir a mayúscula para evitar errores

        Console.Write("Ingrese el costo del tratamiento: ");
        double costo = double.Parse(Console.ReadLine());

        double importeAPagar;

        if (tipoSocio == 'A')
        {
            importeAPagar = costo * 0.5; // 50% de descuento
        }
        else if (tipoSocio == 'B')
        {
            importeAPagar = costo * 0.65; // 35% de descuento
        }
        else if (tipoSocio == 'C')
        {
            importeAPagar = costo; // Sin descuento
        }
        else
        {
            Console.WriteLine("Tipo de socio no válido.");
            return; // Termina el programa
        }

        Console.WriteLine("El importe a pagar es: " + importeAPagar.ToString("F2"));
    }
}
