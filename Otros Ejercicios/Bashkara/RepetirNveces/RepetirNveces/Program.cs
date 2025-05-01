/* Problema
 Se desea realizar un programa que solicite al usuario un carácter, un número y que muestre por pantalla dicho carácter, 
repetido N veces consecutivas. Utilice la planificación para la resolución vista en teoría. 
 */

/* Algoritmo 
Inicio:
Declarar una variable para el carácter a mostrar.
Declarar una variable para la cantidad de repeticiones (número).

Entrada de datos:
Solicitar al usuario un carácter.
Solicitar al usuario un número entero 𝑁
N (la cantidad de veces que se repetirá el carácter).

Validación de entrada:
Si N≤0, no realizar ninguna salida y finalizar el programa.

Salida del carácter repetido:
Utilizar un bucle o una operación para mostrar el carácter N veces en una sola línea.
Fin.
*/

using System;

class Program
{
    static void Main()
    {
        // Variables
        char caracter;
        int cantidad;

        // Solicitar el carácter al usuario
        Console.Write("Ingrese un carácter para repetir: ");
        caracter = Console.ReadKey().KeyChar; // Captura un solo carácter
        Console.WriteLine();

        // Solicitar la cantidad de repeticiones
        Console.Write("Ingrese la cantidad de repeticiones: ");
        if (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0)
        {
            Console.WriteLine("La cantidad debe ser un número entero no negativo.");
            return;
        }

        // Validar si N es 0
        if (cantidad == 0)
        {
            Console.WriteLine("No se producirá ninguna salida.");
            return;
        }

        // Mostrar el carácter repetido N veces
        Console.WriteLine(new string(caracter, cantidad));
    }
}
