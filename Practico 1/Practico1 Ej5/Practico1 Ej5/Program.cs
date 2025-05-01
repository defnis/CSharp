/*   Algoritmo para encontrar la moneda falsa:

Dividir las monedas en tres grupos:

Grupo A: Monedas 1, 2, 3, 4.

Grupo B: Monedas 5, 6, 7, 8.

Grupo C: Monedas 9, 10, 11, 12.

Primer pesaje:

Comparar el peso del Grupo A con el peso del Grupo B:

Si los pesos son iguales, la moneda falsa está en el Grupo C.

Si Grupo A es más pesado, la moneda falsa está en el Grupo A.

Si Grupo B es más pesado, la moneda falsa está en el Grupo B.

Seleccionar el grupo sospechoso:

Considera el grupo más pesado identificado en el primer pesaje.

Segundo pesaje:

Dividir el grupo sospechoso en dos pares de dos monedas cada uno.

Comparar el peso de las dos primeras monedas con las dos segundas:

Si los pesos son iguales, la moneda falsa está entre las dos monedas no pesadas.

Si un par es más pesado, la moneda falsa está en ese par.

Tercer pesaje:

Comparar las dos monedas sospechosas:

Si los pesos son iguales, la moneda falsa es la moneda no pesada.

Si uno de los pesos es mayor, esa es la moneda falsa.

Resultado:

Identificar y declarar cuál es la moneda falsa.
 */

using System;

class MonedaFalsa
{
    static void Main()
    {
        int[] monedas = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2 }; // Una moneda falsa más pesada
        EncontrarMonedaFalsa(monedas);
    }

    static void EncontrarMonedaFalsa(int[] monedas)
    {
        Console.WriteLine("Pesaje 1: Comparando grupo A (1-4) con grupo B (5-8)");
        int pesoA = monedas[0] + monedas[1] + monedas[2] + monedas[3];
        int pesoB = monedas[4] + monedas[5] + monedas[6] + monedas[7];

        if (pesoA == pesoB)
        {
            Console.WriteLine("La moneda falsa está en el grupo C (9-12)");
            EncontrarEnGrupo(monedas, 8, 9, 10, 11);
        }
        else if (pesoA > pesoB)
        {
            Console.WriteLine("La moneda falsa está en el grupo A (1-4)");
            EncontrarEnGrupo(monedas, 0, 1, 2, 3);
        }
        else
        {
            Console.WriteLine("La moneda falsa está en el grupo B (5-8)");
            EncontrarEnGrupo(monedas, 4, 5, 6, 7);
        }
    }

    static void EncontrarEnGrupo(int[] monedas, int i1, int i2, int i3, int i4)
    {
        Console.WriteLine("Pesaje 2: Comparando monedas {0} y {1} con {2} y {3}", i1 + 1, i2 + 1, i3 + 1, i4 + 1);
        int peso1 = monedas[i1] + monedas[i2];
        int peso2 = monedas[i3] + monedas[i4];

        if (peso1 == peso2)
        {
            Console.WriteLine("La moneda falsa es la que no fue pesada: {0}", i4 + 1);
        }
        else if (peso1 > peso2)
        {
            Console.WriteLine("La moneda falsa está entre {0} y {1}", i1 + 1, i2 + 1);
            EncontrarEntreDos(monedas, i1, i2);
        }
        else
        {
            Console.WriteLine("La moneda falsa está entre {0} y {1}", i3 + 1, i4 + 1);
            EncontrarEntreDos(monedas, i3, i4);
        }
    }

    static void EncontrarEntreDos(int[] monedas, int i1, int i2)
    {
        Console.WriteLine("Pesaje 3: Comparando monedas {0} y {1}", i1 + 1, i2 + 1);
        if (monedas[i1] > monedas[i2])
        {
            Console.WriteLine("La moneda falsa es la número {0}", i1 + 1);
        }
        else
        {
            Console.WriteLine("La moneda falsa es la número {0}", i2 + 1);
        }
    }
}

