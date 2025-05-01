/* Problema
 Realice un programa que muestre el siguiente menú de opciones y por cada opción realice la tarea seleccionada. 
 El menú deberá mostrarse nuevamente luego de realizar la tarea seleccionada hasta que el usuario seleccione la opción 0 (cero). 
 Se deberá validar la opción seleccionada, es decir, deberá indicar si la opción ingresada es errónea y volver a mostrar el menú. 
 De igual forma, deberá validar los datos que se solicitan al usuario para la opción 3 donde solicita un entero positivo (natural). 
 Respete la misma salida mostrada en el ejemplo:
   1) Mostrar hola mundo! 
   2) Mostrar el abecedario en mayúsculas. 
   3) Sumar todos los naturales hasta N. 
   0) Salir ¿Ingrese una opción? -5.
 Ha seleccionado una opción incorrecta. Vuelva a intentar.
 */

using System;

class Program
{
    static void Main()
    {
        int option;

        do
        {
            // Mostrar el menú
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1) Mostrar hola mundo!");
            Console.WriteLine("2) Mostrar el abecedario en mayúsculas.");
            Console.WriteLine("3) Sumar todos los naturales hasta N.");
            Console.WriteLine("0) Salir.");
            Console.Write("¿Ingrese una opción? ");

            // Leer la opción del usuario
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Ha seleccionado una opción incorrecta. Vuelva a intentar.");
                continue; // Volver al inicio del bucle
            }

            // Procesar la opción seleccionada
            switch (option)
            {
                case 1:
                    Console.WriteLine("Hola mundo!");
                    break;

                case 2:
                    Console.WriteLine("El abecedario en mayúsculas es:");
                    for (char letter = 'A'; letter <= 'Z'; letter++)
                    {
                        Console.Write(letter + " ");
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    Console.Write("Ingrese un número entero positivo (N): ");
                    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                    {
                        int sum = 0;
                        for (int i = 1; i <= n; i++)
                        {
                            sum += i;
                        }
                        Console.WriteLine($"La suma de los primeros {n} números naturales es: {sum}");
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Ha seleccionado una opción incorrecta. Vuelva a intentar.");
                    break;
            }
        } while (option != 0); // Continuar mostrando el menú hasta que se seleccione la opción 0
    }
}
