/* Algoritmo llenarBotella
 
B5: Bidón de 5 litros.

B1.5_1, B1.5_2, B1.5_3, B1.5_4: Botellas de 1.5 litros.

B0.5: Botella de 500 ml.

 Inicio
    Vaciar(B5)      // Asegurar que el bidón de 5 litros está vacío.
    Vaciar(B1.5)  // Asegurar que una botella de 1.5 litros está vacía.
    Vaciar(B0.5)    // Asegurar que el bidón de 5 litros está vacío.

    Llenar(B1.5_1, Agua)  // Llenar una botella de 1.5 litros completamente.
    Trasvasar(B1.5_1, B5)  // Pasar el contenido de la botella al bidón.

    Llenar(B0.5, Agua)  // Llenar la botella de 0.5 litros.
    Trasvasar(B1.5_1, B5)  // Pasar el contenido de la botella al bidón.

    // Ahora B5 tiene exactamente 2 litros (1.5 + 0.5).
Fin
 */

using System;

class Limpieza
{
    static void Main()
    {
        int bidon = 0; // Bidón de 5 litros inicialmente vacío
        int botella1_5 = 0; // Botella de 1.5 litros inicialmente vacía
        int botella0_5 = 0; // Botella de 500 ml inicialmente vacía

        // Llenar y trasvasar
        botella1_5 = 1500; // Llenar la botella de 1.5 litros
        bidon += botella1_5; // Trasvasar al bidón
        botella0_5 = 500; // Llenar la botella de 0.5 litros
        bidon += botella0_5; // Trasvasar al bidón

        // Imprimir resultado
        Console.WriteLine("El bidón contiene exactamente " + bidon / 1000.0 + " litros de agua.");
    }
}

