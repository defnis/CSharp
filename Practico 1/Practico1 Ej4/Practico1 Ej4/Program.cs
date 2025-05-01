/*  Algoritmo para cambiar la rueda desinflada de un auto.

Identificar la rueda desinflada:

Para cada posición posible de rueda (IzqAdelante, DerAdelante, IzqAtrás, DerAtrás):

Si EnLlanta(Lugar) es verdadero, entonces esa es la rueda a cambiar.

Preparar el auto para el cambio de rueda:

LevantarAuto.

Quitar la rueda desinflada:

QuitarRueda(Lugar), donde Lugar es la posición identificada en el paso 1.

Sacar la rueda de auxilio del baúl:

AbrirBaúl.

QuitarRueda(baúl). (La rueda de auxilio se coloca en el suelo).

CerrarBaúl.

Colocar la rueda de auxilio en el auto:

PonerRueda(Lugar), donde Lugar es la posición donde se quitó la rueda desinflada.

Finalizar el proceso:

BajarAuto.

QuitarRueda(suelo). (Recoger la rueda desinflada del suelo y colocarla en el baúl).

AbrirBaúl.

PonerRueda(baúl). (Guardar la rueda desinflada en el baúl).

CerrarBaúl.

El auto está listo para continuar el recorrido.
 */

using System;

class CambioRueda
{
    static void Main()
    {
        string[] posiciones = { "IzqAdelante", "DerAdelante", "IzqAtrás", "DerAtrás" };
        string ruedaDesinflada = "";

        // Identificar la rueda desinflada
        foreach (string posicion in posiciones)
        {
            if (EnLlanta(posicion))
            {
                ruedaDesinflada = posicion;
                break;
            }
        }

        if (ruedaDesinflada == "")
        {
            Console.WriteLine("No hay rueda desinflada.");
            return;
        }

        Console.WriteLine("Rueda desinflada en: " + ruedaDesinflada);

        // Levantar el auto
        LevantarAuto();

        // Quitar la rueda desinflada
        QuitarRueda(ruedaDesinflada);

        // Sacar la rueda de auxilio del baúl
        AbrirBaúl();
        QuitarRueda("baúl");
        CerrarBaúl();

        // Colocar la rueda de auxilio en el auto
        PonerRueda(ruedaDesinflada);

        // Bajar el auto
        BajarAuto();

        // Guardar la rueda desinflada en el baúl
        QuitarRueda("suelo");
        AbrirBaúl();
        PonerRueda("baúl");
        CerrarBaúl();

        Console.WriteLine("Cambio de rueda completado con éxito.");
    }

    static bool EnLlanta(string lugar)
    {
        // Simulación de la verificación de rueda desinflada
        return lugar == "IzqAtrás"; // Suponemos que la rueda trasera izquierda está en llanta
    }

    static void LevantarAuto()
    {
        Console.WriteLine("Auto levantado.");
    }

    static void BajarAuto()
    {
        Console.WriteLine("Auto bajado.");
    }

    static void QuitarRueda(string lugar)
    {
        Console.WriteLine($"Rueda quitada de {lugar}.");
    }

    static void PonerRueda(string lugar)
    {
        Console.WriteLine($"Rueda colocada en {lugar}.");
    }

    static void AbrirBaúl()
    {
        Console.WriteLine("Baúl abierto.");
    }

    static void CerrarBaúl()
    {
        Console.WriteLine("Baúl cerrado.");
    }
}

