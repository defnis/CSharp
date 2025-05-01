/* Problema
Escriba una programa que permita calcular cuánto debe pagar una persona que dejó un auto en un
estacionamiento que tiene 3 pisos. En el primer piso cuesta $10 la hora, en el segundo piso $8 la hora y en el tercer
piso $6 la hora. Si el auto está más de 5 horas se cobra una suma fija: $50 para el primer piso, $40 para el segundo y
$30 para el tercero. La aplicación debe solicitar piso y cantidad de horas y mostrar el costo en pantalla. Plantee cuatro
casos de prueba significativos. 
 */

using System;

class Program
{
    static void Main()
    {
        // Declaración de variables
        int piso;
        int horas;
        int costo;

        // Entrada de datos
        Console.WriteLine("Calculadora de costo de estacionamiento");
        Console.Write("Ingrese el piso donde dejó el auto (1, 2, o 3): ");
        piso = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de horas que el auto estuvo estacionado: ");
        horas = int.Parse(Console.ReadLine());

        // Calcular el costo según el piso y las horas
        switch (piso)
        {
            case 1:
                if (horas > 5)
                    costo = 50; // Costo fijo para más de 5 horas
                else
                    costo = horas * 10; // $10 por hora
                break;

            case 2:
                if (horas > 5)
                    costo = 40; // Costo fijo para más de 5 horas
                else
                    costo = horas * 8; // $8 por hora
                break;

            case 3:
                if (horas > 5)
                    costo = 30; // Costo fijo para más de 5 horas
                else
                    costo = horas * 6; // $6 por hora
                break;

            default:
                Console.WriteLine("Piso no válido. Por favor, ingrese un piso entre 1 y 3.");
                return;
        }

        // Mostrar el costo
        Console.WriteLine($"El costo total por {horas} hora(s) en el piso {piso} es: ${costo}");
    }
}
