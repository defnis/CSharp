/* Problema
 La obra social “Ogenki” tiene tres clases de socios. Los socios tipo ‘A’ abonan una cuota mayor pero
tienen un 50% de descuento en todos los tipos de tratamientos. Los socios tipo ‘B’ abonan una cuota moderada y
tienen un 35% de descuento para los mismos tratamientos que los socios del tipo A. Los socios que menos aportan,
los de tipo ‘C’, no reciben descuentos sobre dichos tratamientos. Solicite una letra (carácter), que representa la clase
de un socio, luego un valor real que represente el costo del tratamiento (previo al descuento) y determine el importe
en efectivo que debe pagar dicho socio.
 */

/* Algoritmo
Inicio.
Leer la clase de socio (tipo_socio).
Leer el costo del tratamiento (costo_tratamiento).
Según el valor de tipo_socio:
Si es 'A': aplicar un descuento del 50%.
Si es 'B': aplicar un descuento del 35%.
Si es 'C': no aplicar descuento.
Si no es ninguna de las anteriores, mostrar un mensaje de error.
Calcular el importe a pagar como costo_tratamiento - descuento.
Mostrar el importe a pagar.
Fin.
 */

using System;

class Program
{
    static void Main()
    {
        // Declaración de variables
        char tipoSocio;
        double costoTratamiento, descuento = 0.0, importeAPagar;

        // Entrada de datos
        Console.Write("Ingrese la clase de socio (A, B, C): ");
        tipoSocio = char.ToUpper(Console.ReadLine()[0]); // Convertir a mayúscula para estandarizar

        Console.Write("Ingrese el costo del tratamiento: ");
        costoTratamiento = double.Parse(Console.ReadLine());

        // Determinar descuento según el tipo de socio
        switch (tipoSocio)
        {
            case 'A':
                descuento = costoTratamiento * 0.50;
                break;
            case 'B':
                descuento = costoTratamiento * 0.35;
                break;
            case 'C':
                descuento = 0.0;
                break;
            default:
                Console.WriteLine("Clase de socio no válida.");
                return; // Termina el programa si el tipo de socio no es válido
        }

        // Calcular el importe a pagar
        importeAPagar = costoTratamiento - descuento;

        // Mostrar el resultado
        Console.WriteLine($"El importe a pagar es: ${importeAPagar:F2}");
    }
}
