/* Problema
 Se desea determinar el estado de un alumno según la nota obtenida y mostrar si el alumno aprobó,
recupera o perdió la materia. La nota obtenida puede ser alguna de las siguientes letras: ‘A’, ‘B’, ‘C’ o ‘D’. Los estados
posibles son aprobado, recupera, o pierde la materia. Para las notas ‘A’ y ‘B’ se considera aprobado la materia, para la
nota ‘C’ se debe recuperar y para la nota es ‘D’ se pierde la materia.
 */

/* Algoritmo 
Entrada de datos:
Leer la letra de la nota obtenida (nota).

Decisión:
Si nota es 'A' o 'B', el estado del alumno es "aprobado".
Si nota es 'C', el estado del alumno es "recupera".
Si nota es 'D', el estado del alumno es "pierde la materia".
Si nota es diferente de estas opciones, mostrar un mensaje de error indicando que la nota ingresada no es válida.

Salida:
Mostrar el estado del alumno basado en la decisión tomada.
 */

using System;

class Program
{
    static void Main()
    {
        // Entrada de datos
        Console.WriteLine("Ingrese la nota del alumno (A, B, C, D):");
        char nota = char.ToUpper(Console.ReadLine()[0]); // Convertir a mayúscula para estandarizar

        // Decisión y salida
        switch (nota)
        {
            case 'A':
            case 'B':
                Console.WriteLine("El alumno está aprobado.");
                break;

            case 'C':
                Console.WriteLine("El alumno debe recuperar.");
                break;

            case 'D':
                Console.WriteLine("El alumno pierde la materia.");
                break;

            default:
                Console.WriteLine("Nota inválida. Ingrese una nota válida (A, B, C, D).");
                break;
        }
    }
}

