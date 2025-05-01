/*  Algoritmo Propuesto
 
Vaciar el envase de 5 litros y el envase de 4 litros (si contienen agua).
→ Vaciar(Envase5)
→ Vaciar(Envase4)

Llenar completamente el envase de 5 litros.
→ Llenar(Envase5, Agua)

Trasvasar el contenido del envase de 5 litros al envase de 4 litros.
→ Trasvasar(Envase5, Envase4)
(El envase de 5 litros queda con 1 litro y el de 4 litros está lleno).

Vaciar el envase de 5 litros.
→ Vaciar(Envase5)

Trasvasar el litro restante del envase de 4 litros al envase de 5 litros.
→ Trasvasar(Envase4, Envase5)

Llenar completamente el envase de 5 litros nuevamente.
→ Llenar(Envase5, Agua)

Trasvasar el contenido del envase de 5 litros al envase de 4 litros hasta que este último se llene.
→ Trasvasar(Envase5, Envase4)
(Ahora, el envase de 5 litros tiene exactamente 2 litros). 
*/

using System;

class Program
{
    static int envase5 = 0;
    static int envase4 = 0;

    static void Llenar(ref int recipiente, int capacidad)
    {
        recipiente = capacidad;
        Console.WriteLine($"Se llenó el envase de {capacidad} litros.");
    }

    static void Vaciar(ref int recipiente)
    {
        recipiente = 0;
        Console.WriteLine("Se vació el envase.");
    }

    static void Trasvasar(ref int origen, int capacidadOrigen, ref int destino, int capacidadDestino)
    {
        int cantidadATrasvasar = Math.Min(origen, capacidadDestino - destino);
        destino += cantidadATrasvasar;
        origen -= cantidadATrasvasar;
        Console.WriteLine($"Se trasvasaron {cantidadATrasvasar} litros.");
    }

    static void Main()
    {
        // Paso 1: Vaciar ambos envases
        Vaciar(ref envase5);
        Vaciar(ref envase4);

        // Paso 2: Llenar el envase de 5 litros
        Llenar(ref envase5, 5);

        // Paso 3: Trasvasar del envase de 5 litros al de 4 litros
        Trasvasar(ref envase5, 5, ref envase4, 4);

        // Paso 4: Vaciar el envase de 5 litros
        Vaciar(ref envase5);

        // Paso 5: Trasvasar el 1 litro restante del envase de 4 litros al de 5 litros
        Trasvasar(ref envase4, 4, ref envase5, 5);

        // Paso 6: Llenar el envase de 5 litros nuevamente
        Llenar(ref envase5, 5);

        // Paso 7: Trasvasar del envase de 5 litros al de 4 litros
        Trasvasar(ref envase5, 5, ref envase4, 4);

        Console.WriteLine($"Estado final: Envase de 5 litros = {envase5} litros, Envase de 4 litros = {envase4} litros.");
    }
}

