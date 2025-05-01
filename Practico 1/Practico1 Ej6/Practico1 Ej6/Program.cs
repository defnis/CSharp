/*   Plan para lograr el tiempo mínimo de preparación:
Objetivo: Preparar tres tostadas (dos lados tostados cada una) en el menor tiempo posible utilizando una parrilla tostadora que solo permite tostar dos rebanadas por vez.

Restricciones:

Tiempo de tostado por lado: 30 segundos.

Colocar y retirar rebanadas: 5 segundos (simultáneamente si son dos).

Girar una rebanada: 3 segundos (simultáneamente si son dos).

Plan óptimo:
Para minimizar el tiempo, se deben maximizar las operaciones simultáneas y evitar periodos de inactividad:

Iniciar tostando dos rebanadas por un lado (T1 y T2).

Al finalizar, dar vuelta una rebanada (T1) y reemplazar la otra con la tercera rebanada (T3).

Continuar el proceso hasta que todas las tostadas estén listas.
 */
/* Conjunto de primitivas:
Colocar(T): Coloca una rebanada de pan 𝑇 en la parrilla. Tarda 5 segundos.
Retirar(T): Retira una rebanada de pan 𝑇 de la parrilla. Tarda 5 segundos.
Tostar(T, Lado): Tosta el 𝐿𝑎𝑑𝑜 de la rebanada 𝑇 durante 30 segundos.
Girar(T): Da vuelta una rebanada 𝑇 para tostar el lado contrario. Tarda 3 segundos.
Esperar(Tiempo): Espera el tiempo indicado en segundos sin realizar otra acción.
*/
/* Algoritmo para el tiempo mínimo de preparación:

Inicio:
Colocar(T1) y Colocar(T2).
Tostar(T1, Lado1) y Tostar(T2, Lado1).
Esperar(30).

Primera operación simultánea:
Girar(T1).
Retirar(T2) y Colocar(T3).
Tostar(T1, Lado2) y Tostar(T3, Lado1).
Esperar(30).

Segunda operación simultánea:
Retirar(T1).
Girar(T3) y Colocar(T2).
Tostar(T3, Lado2) y Tostar(T2, Lado2).
Esperar(30).

Final:
Retirar(T2) y Retirar(T3).
Todas las tostadas están listas. 
*/

using System;
using System.Threading;

class Tostadas
{
    static void Main()
    {
        Console.WriteLine("Inicio de preparación de tostadas...");

        // Ciclo 1: Tostar lado 1 de T1 y T2
        Colocar("T1", "T2");
        Tostar("T1", "T2");

        // Ciclo 2: Girar T1, retirar T2, colocar T3
        Girar("T1");
        Retirar("T2");
        Colocar("T3");
        Tostar("T1", "T3");

        // Ciclo 3: Retirar T1, girar T3, colocar T2
        Retirar("T1");
        Girar("T3");
        Colocar("T2");
        Tostar("T3", "T2");

        // Final: Retirar T2 y T3
        Retirar("T2", "T3");

        Console.WriteLine("Todas las tostadas están listas. Tiempo total: 110 segundos.");
    }

    static void Colocar(params string[] tostadas)
    {
        Console.WriteLine($"Colocando {string.Join(" y ", tostadas)} en la parrilla (5 segundos)...");
        Thread.Sleep(5000); // Simula 5 segundos
    }

    static void Retirar(params string[] tostadas)
    {
        Console.WriteLine($"Retirando {string.Join(" y ", tostadas)} de la parrilla (5 segundos)...");
        Thread.Sleep(5000); // Simula 5 segundos
    }

    static void Girar(string tostada)
    {
        Console.WriteLine($"Girando {tostada} en la parrilla (3 segundos)...");
        Thread.Sleep(3000); // Simula 3 segundos
    }

    static void Tostar(params string[] tostadas)
    {
        Console.WriteLine($"Tostando {string.Join(" y ", tostadas)} durante 30 segundos...");
        Thread.Sleep(30000); // Simula 30 segundos
    }
}

