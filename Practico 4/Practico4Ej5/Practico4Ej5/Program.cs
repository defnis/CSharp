/* Problema
 Se desea realizar una aplicación que solicite al usuario tres números enteros positivos (A, B, y X), y que muestre por pantalla todos los múltiplos de X que estén entre A y B inclusive. Realice un algoritmo antes de escribir el programa, luego implemente en C# utilizando un ciclo FOR.
 */

/* Algoritmo
Inicio.
Solicitar al usuario los números enteros positivos A, B, y X.
Validar que A, B, y X sean números enteros positivos.

Determinar el rango correcto:
Si A>B, intercambiar los valores de A y B.

Recorrer el rango desde A hasta B utilizando un ciclo FOR:

Si un número en el rango es divisible entre X (es decir, numero % X == 0), imprimirlo.

Mostrar todos los múltiplos de X encontrados en el rango.
Fin.
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor de A (entero positivo): ");
        string inputA = Console.ReadLine();
        Console.Write("Ingrese el valor de B (entero positivo): ");
        string inputB = Console.ReadLine();
        Console.Write("Ingrese el valor de X (entero positivo): ");
        string inputX = Console.ReadLine();

        if (int.TryParse(inputA, out int A) && int.TryParse(inputB, out int B) && int.TryParse(inputX, out int X) &&
            A > 0 && B > 0 && X > 0)
        {
            // Asegurar que A sea menor o igual a B
            if (A > B)
            {
                int temp = A;
                A = B;
                B = temp;
            }

            Console.WriteLine($"Los múltiplos de {X} entre {A} y {B} son:");
            for (int i = A; i <= B; i++)
            {
                if (i % X == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese valores enteros positivos válidos para A, B y X.");
        }
    }
}
