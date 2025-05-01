/* Problema 
 Hacer un programa en C# que permita a un profesor cargar las notas de los exámenes de sus alumnos. 
 El programa primero debe preguntar cuántas notas desea cargar el profesor, luego procede a cargar las notas en un arreglo,
 y posteriormente debe buscar la nota más alta y la más baja, debe mostrarlas e indicar en qué índice del arreglo se encuentra cada una.
 */

using System;

class Program
{
    static void Main()
    {
        CargarYAnalizarNotas();
    }

    static void CargarYAnalizarNotas()
    {
        Console.Write("¿Cuántas notas desea cargar?: ");
        int cantidadNotas;

        // Validar entrada del usuario
        while (!int.TryParse(Console.ReadLine(), out cantidadNotas) || cantidadNotas <= 0)
        {
            Console.Write("Por favor, ingrese un número válido mayor a 0: ");
        }

        int[] notas = new int[cantidadNotas];

        // Cargar las notas en el arreglo
        Console.WriteLine("Ingrese las notas de los alumnos:");
        for (int i = 0; i < cantidadNotas; i++)
        {
            Console.Write($"Nota {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0 || notas[i] > 100)
            {
                Console.WriteLine("Ingrese una nota válida entre 0 y 100.");
                Console.Write($"Nota {i + 1}: ");
            }
        }

        // Encontrar la nota más alta y más baja
        int notaMaxima = notas[0], indiceMaxima = 0;
        int notaMinima = notas[0], indiceMinima = 0;

        for (int i = 1; i < cantidadNotas; i++)
        {
            if (notas[i] > notaMaxima)
            {
                notaMaxima = notas[i];
                indiceMaxima = i;
            }
            if (notas[i] < notaMinima)
            {
                notaMinima = notas[i];
                indiceMinima = i;
            }
        }

        // Mostrar resultados
        Console.WriteLine($"La nota más alta es {notaMaxima}, en el índice {indiceMaxima}.");
        Console.WriteLine($"La nota más baja es {notaMinima}, en el índice {indiceMinima}.");
    }
}
