/* Problema
 Dado un arreglo ordenado con una longitud máxima determinada en MaxPos y la cantidad realmente ocupada en UltPos, 
 hacer algoritmos para agregar y para borrar un elemento en el arreglo. Ambos procesos deben mantener el arreglo ordenado. 
 Escriba el programa en C# que pregunte al usuario el tamaño del arreglo, y luego muestre un menú que permita seleccionar 
 qué hacer con el arreglo: agregar elementos, borrar elementos, mostrar los elementos del arreglo y salir. 
 El menú debe repetirse hasta que el usuario elija la opción para salir.
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño máximo del arreglo: ");
        int maxPos;
        while (!int.TryParse(Console.ReadLine(), out maxPos) || maxPos <= 0)
        {
            Console.Write("Por favor, ingrese un número entero positivo: ");
        }

        int[] arreglo = new int[maxPos];
        int ultPos = 0; // Indica la cantidad de elementos ocupados en el arreglo

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Agregar un elemento");
            Console.WriteLine("2. Borrar un elemento");
            Console.WriteLine("3. Mostrar elementos del arreglo");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarElemento(ref arreglo, ref ultPos, maxPos);
                    break;
                case "2":
                    BorrarElemento(ref arreglo, ref ultPos);
                    break;
                case "3":
                    MostrarArreglo(arreglo, ultPos);
                    break;
                case "4":
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        }
    }

    static void AgregarElemento(ref int[] arreglo, ref int ultPos, int maxPos)
    {
        if (ultPos >= maxPos)
        {
            Console.WriteLine("El arreglo está lleno. No se pueden agregar más elementos.");
            return;
        }

        Console.Write("Ingrese un elemento para agregar: ");
        int nuevoElemento;
        while (!int.TryParse(Console.ReadLine(), out nuevoElemento))
        {
            Console.Write("Entrada no válida. Ingrese un número entero: ");
        }

        int i;
        for (i = ultPos - 1; i >= 0 && arreglo[i] > nuevoElemento; i--)
        {
            arreglo[i + 1] = arreglo[i];
        }
        arreglo[i + 1] = nuevoElemento;
        ultPos++;

        Console.WriteLine($"Elemento {nuevoElemento} agregado correctamente.");
    }

    static void BorrarElemento(ref int[] arreglo, ref int ultPos)
    {
        if (ultPos == 0)
        {
            Console.WriteLine("El arreglo está vacío. No hay elementos para borrar.");
            return;
        }

        Console.Write("Ingrese el elemento a borrar: ");
        int elementoABorrar;
        while (!int.TryParse(Console.ReadLine(), out elementoABorrar))
        {
            Console.Write("Entrada no válida. Ingrese un número entero: ");
        }

        int indice = Array.IndexOf(arreglo, elementoABorrar, 0, ultPos);
        if (indice == -1)
        {
            Console.WriteLine("El elemento no se encuentra en el arreglo.");
            return;
        }

        for (int i = indice; i < ultPos - 1; i++)
        {
            arreglo[i] = arreglo[i + 1];
        }
        ultPos--;

        Console.WriteLine($"Elemento {elementoABorrar} borrado correctamente.");
    }

    static void MostrarArreglo(int[] arreglo, int ultPos)
    {
        if (ultPos == 0)
        {
            Console.WriteLine("El arreglo está vacío.");
        }
        else
        {
            Console.WriteLine("Elementos del arreglo:");
            for (int i = 0; i < ultPos; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
