/* Algoritmo dividirPlatillos
 
 Inicio
    Leer p1, p2, p3, p4, p5, p6

    { Primera medición: dividir en dos grupos de 3 platillos }
    Si (p1 + p2 + p3) > (p4 + p5 + p6) Entonces
        { El platillo más pesado está en (p1, p2, p3) }
        Si p1 > p2 Entonces
            Si p1 > p3 Entonces
                Imprimir "El platillo más pesado es p1"
            Sino
                Imprimir "El platillo más pesado es p3"
            FinSi
        Sino
            Si p2 > p3 Entonces
                Imprimir "El platillo más pesado es p2"
            Sino
                Imprimir "El platillo más pesado es p3"
            FinSi
        FinSi
    Sino
        { El platillo más pesado está en (p4, p5, p6) }
        Si p4 > p5 Entonces
            Si p4 > p6 Entonces
                Imprimir "El platillo más pesado es p4"
            Sino
                Imprimir "El platillo más pesado es p6"
            FinSi
        Sino
            Si p5 > p6 Entonces
                Imprimir "El platillo más pesado es p5"
            Sino
                Imprimir "El platillo más pesado es p6"
            FinSi
        FinSi
    FinSi
Fin

 */

using System;

class Program
{
    static void Main()
    {
        // Leer los pesos de los platillos
        Console.Write("Ingrese el peso de p1: ");
        int p1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el peso de p2: ");
        int p2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el peso de p3: ");
        int p3 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el peso de p4: ");
        int p4 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el peso de p5: ");
        int p5 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el peso de p6: ");
        int p6 = int.Parse(Console.ReadLine());

        // Primera medición: comparar los grupos de 3 platillos
        if ((p1 + p2 + p3) > (p4 + p5 + p6))
        {
            // Comparar los platillos dentro del grupo (p1, p2, p3)
            if (p1 > p2)
            {
                if (p1 > p3)
                    Console.WriteLine("El platillo más pesado es p1");
                else
                    Console.WriteLine("El platillo más pesado es p3");
            }
            else
            {
                if (p2 > p3)
                    Console.WriteLine("El platillo más pesado es p2");
                else
                    Console.WriteLine("El platillo más pesado es p3");
            }
        }
        else
        {
            // Comparar los platillos dentro del grupo (p4, p5, p6)
            if (p4 > p5)
            {
                if (p4 > p6)
                    Console.WriteLine("El platillo más pesado es p4");
                else
                    Console.WriteLine("El platillo más pesado es p6");
            }
            else
            {
                if (p5 > p6)
                    Console.WriteLine("El platillo más pesado es p5");
                else
                    Console.WriteLine("El platillo más pesado es p6");
            }
        }
    }
}

