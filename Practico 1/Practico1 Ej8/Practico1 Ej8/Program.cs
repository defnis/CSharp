/*   Algoritmo Jaras de Vino.
 
Llena la jarra de 5 litros desde la jarra de 8 litros.
Jarra de 8: 3 litros restantes.
Jarra de 5: 5 litros llenos.

Llena la jarra de 3 litros desde la jarra de 5 litros.
Jarra de 8: 3 litros.
Jarra de 5: 2 litros restantes.
Jarra de 3: 3 litros llenos.
Vacía la jarra de 3 litros.
Jarra de 8: 3 litros.
Jarra
Jarra de 3: 0 litros.

Llena la jarra de 3 litros nuevamente desde la jarra de 5 litros.
Jarra de 8: 3 litros.
Jarra de 5: 0 litros.
Jarra de 3: 2 litros llenos.

Llena la jarra de 5 litros desde la jarra de 8 litros.
Jarra de 8: 0 litros.
Jarra de 5: 5 litros llenos.
Jarra de 3: 2 litros.

Llena la jarra de 3 litros desde la jarra de 5 litros.
Jarra de 8: 0 litros.
Jarra de 5: 4 litros.
Jarra de 3: 3 litros llenos.

Vacía la jarra de 3 litros.
Jarra de 8: 0 litros.
Jarra de 5: 4 litros.
Jarra de 3: 0 litros.

Llena la jarra de 3 litros desde la jarra de 8 litros.
Jarra de 8: 0 litros.
Jarra de 5: 4 litros.
Jarra de 3: 0 litros. 
*/

using System;

class WineDivision
{
    static void Main(string[] args)
    {
        int jarra8 = 8; // Inicialmente llena con 8 litros
        int jarra5 = 0; // Inicialmente vacía
        int jarra3 = 0; // Inicialmente vacía

        Console.WriteLine($"Inicio: Jarra8 = {jarra8}L, Jarra5 = {jarra5}L, Jarra3 = {jarra3}L");

        // Paso 1: Trasvasar de Jarra8 a Jarra5
        int transfer = Math.Min(jarra8, 5 - jarra5);
        jarra8 -= transfer;
        jarra5 += transfer;
        Console.WriteLine($"Paso 1: Jarra8 = {jarra8}L, Jarra5 = {jarra5}L, Jarra3 = {jarra3}L");

        // Paso 2: Trasvasar de Jarra5 a Jarra3
        transfer = Math.Min(jarra5, 3 - jarra3);
        jarra5 -= transfer;
        jarra3 += transfer;
        Console.WriteLine($"Paso 2: Jarra8 = {jarra8}L, Jarra5 = {jarra5}L, Jarra3 = {jarra3}L");

        // Paso 3: Vaciar Jarra3
        jarra3 = 0;
        Console.WriteLine($"Paso 3: Jarra8 = {jarra8}L, Jarra5 = {jarra5}L, Jarra3 = {jarra3}L");

        // Paso 4: Trasvasar de Jarra5 a Jarra3
        transfer = Math.Min(jarra5, 3 - jarra3);
        jarra5 -= transfer;
        jarra3 += transfer;
        Console.WriteLine($"Paso 4: Jarra8 = {jarra8}L, Jarra5 = {jarra5}L, Jarra3 = {jarra3}L");

        // Paso 5: Trasvasar de Jarra8 a Jarra5
        transfer = Math.Min(jarra8, 5 - jarra5);
        jarra8 -= transfer;
        jarra5 += transfer;
        Console.WriteLine($"Paso 5: Jarra8 = {jarra8}L, Jarra5 = {jarra5}L, Jarra3 = {jarra3}L");

        // Paso 6: Trasvasar de Jarra5 a Jarra3
        transfer = Math.Min(jarra5, 3 - jarra3);
        jarra5 -= transfer;
        jarra3 += transfer;
        Console.WriteLine($"Paso 6: Jarra8 = {jarra8}L, Jarra5 = {jarra5}L, Jarra3 = {jarra3}L");

        // Paso 7: Vaciar Jarra3
        jarra3 = 0;
        Console.WriteLine($"Paso 7: Jarra8 = {jarra8}L, Jarra5 = {jarra5}L, Jarra3 = {jarra3}L");

        Console.WriteLine("Resultado Final: Jarra8 = 0L, Jarra5 = 4L, Jarra3 = 0L");
        Console.WriteLine("Se han dividido los 8 litros en dos partes iguales de 4 litros cada una.");
    }
}
