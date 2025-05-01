/*
Inicio
   Escribir("Ingrese la forma de pago (E: efectivo, T: tarjeta, O: otro): ")
   Leer(P)
   Escribir("Ingrese el monto de la compra: ")
   Leer(M)

   Si P = 'E' Entonces
       D ← M * 0.20
   Sino Si P = 'T' y M > 25000 Entonces
       D ← M * 0.10
   Sino
       D ← 0
   FinSi

   T ← M - D

   Escribir("Descuento: ", D)
   Escribir("Total a pagar: ", T)
Fin
*/

using System;

class Programa
{
    static void Main()
    {
        // Solicitar la forma de pago
        Console.Write("Ingrese la forma de pago (E: efectivo, T: tarjeta, O: otro): ");
        char formaPago = char.Parse(Console.ReadLine().ToUpper());

        // Solicitar el monto de la compra
        Console.Write("Ingrese el monto de la compra: ");
        double montoCompra = double.Parse(Console.ReadLine());

        // Calcular el descuento
        double descuento = 0;
        if (formaPago == 'E')
        {
            descuento = montoCompra * 0.20;
        }
        else if (formaPago == 'T' && montoCompra > 25000)
        {
            descuento = montoCompra * 0.10;
        }

        // Calcular el total a pagar
        double totalPagar = montoCompra - descuento;

        // Mostrar el descuento y el total a pagar
        Console.WriteLine("Descuento: " + descuento);
        Console.WriteLine("Total a pagar: " + totalPagar);
    }
}
