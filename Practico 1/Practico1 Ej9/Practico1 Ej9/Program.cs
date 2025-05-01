/*  Algoritmo para cruzar el rio.

Llevar la cabra a la orilla opuesta.
Cruzarrío(cabra)

Regresar con la barca vacía.
Cruzarrío(vacío)

Llevar el lobo a la orilla opuesta.
Cruzarrío(lobo)

Regresar con la cabra a la orilla inicial.
Cruzarrío(cabra)

Llevar el arbusto a la orilla opuesta.
Cruzarrío(arbusto)

Regresar con la barca vacía.
Cruzarrío(vacío)

Llevar la cabra a la orilla opuesta.
Cruzarrío(cabra)
 */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Inicio del cruce del río...");

        // Paso 1: Llevar la cabra a la orilla opuesta
        CruzarRio("Cabra");

        // Paso 2: Regresar solo
        CruzarRio("Vacío");

        // Paso 3: Llevar el lobo a la orilla opuesta
        CruzarRio("Lobo");

        // Paso 4: Regresar con la cabra
        CruzarRio("Cabra");

        // Paso 5: Llevar el arbusto a la orilla opuesta
        CruzarRio("Arbusto");

        // Paso 6: Regresar solo
        CruzarRio("Vacío");

        // Paso 7: Llevar la cabra a la orilla opuesta
        CruzarRio("Cabra");

        Console.WriteLine("Todos han cruzado el río de manera segura.");
    }

    static void CruzarRio(string objeto)
    {
        Console.WriteLine("Cruzando el río con: " + objeto);
    }
}

