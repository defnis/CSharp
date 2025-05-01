/*
Inicio
   Escribir("Ingrese el ancho de la habitación (mts): ")
   Leer(W)
   Escribir("Ingrese el largo de la habitación (mts): ")
   Leer(L)
   Escribir("Ingrese el alto de la habitación (mts): ")
   Leer(H)
   Escribir("Ingrese la cantidad de puertas: ")
   Leer(D)
   Escribir("Ingrese la cantidad de ventanas: ")
   Leer(V)

   A_paredes ← 2 * H * (W + L)
   A_puertas ← D * (0.75 * 2.00)
   A_ventanas ← V * (1.20 * 1.50)
   A_pintar ← A_paredes - (A_puertas + A_ventanas)

   Latas_necesarias ← techo(A_pintar / 12)

   Escribir("La cantidad de latas de pintura necesarias es: ", Latas_necesarias)
Fin
*/

using System;

class Programa
{
    static void Main()
    {
        // Solicitar dimensiones de la habitación
        Console.Write("Ingrese el ancho de la habitación (mts): ");
        double ancho = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el largo de la habitación (mts): ");
        double largo = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el alto de la habitación (mts): ");
        double alto = double.Parse(Console.ReadLine());

        // Solicitar la cantidad de puertas y ventanas
        Console.Write("Ingrese la cantidad de puertas: ");
        int puertas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de ventanas: ");
        int ventanas = int.Parse(Console.ReadLine());

        // Calcular el área total de las paredes
        double areaParedes = 2 * alto * (ancho + largo);

        // Calcular el área total de puertas y ventanas
        double areaPuertas = puertas * (0.75 * 2.00); // Área de cada puerta
        double areaVentanas = ventanas * (1.20 * 1.50); // Área de cada ventana

        // Calcular el área a pintar
        double areaPintar = areaParedes - (areaPuertas + areaVentanas);

        // Calcular la cantidad de latas necesarias
        double rendimientoPorLata = 12.0; // Rendimiento en m² por litro
        int latasNecesarias = (int)Math.Ceiling(areaPintar / rendimientoPorLata);

        // Mostrar el resultado
        Console.WriteLine("La cantidad de latas de pintura necesarias es: " + latasNecesarias);
    }
}
