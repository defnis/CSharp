/* Problema
 Hacer un programa en C# que permita ingresar una lista de nombres de invitados a un evento. 
 El programa debe permitir ingresar nombres hasta que se ingrese la palabra “salir”. 
 Luego mostrar por pantalla la cantidad de invitados y la lista completa. 
 El programa no debe preguntar cuántos nombres desea ingresar, sino que debe comenzar 
 con un arreglo de 10 lugares y manejar internamente la longitud del arreglo a medida que se cargan los nombres, 
 ampliándolo cuando sea necesario. Cada vez que sea necesario redimensionar el arreglo se agregarán 10 posiciones. 
 Al momento de finalizar debe “eliminar” las posiciones sobrantes del arreglo si es que hubieran quedado posiciones sin utilizar.
 */

using System;

class Program
{
    static void Main()
    {
        ManejarListaDeInvitados();
    }

    static void ManejarListaDeInvitados()
    {
        string[] invitados = new string[10];
        int contador = 0;

        Console.WriteLine("Ingrese los nombres de los invitados. Escriba 'salir' para finalizar.");

        while (true)
        {
            Console.Write($"Invitado {contador + 1}: ");
            string entrada = Console.ReadLine();

            if (entrada.Equals("salir", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (contador >= invitados.Length)
            {
                // Ampliar el arreglo en 10 posiciones
                Array.Resize(ref invitados, invitados.Length + 10);
            }

            invitados[contador] = entrada;
            contador++;
        }

        // Redimensionar el arreglo para eliminar posiciones sobrantes
        Array.Resize(ref invitados, contador);

        Console.WriteLine($"\nCantidad de invitados: {contador}");
        Console.WriteLine("Lista completa de invitados:");
        foreach (string invitado in invitados)
        {
            Console.WriteLine(invitado);
        }
    }
}
