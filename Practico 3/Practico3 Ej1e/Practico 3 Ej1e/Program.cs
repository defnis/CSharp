/*
Inicio
   Escribir("Ingrese la distancia en metros (Dm): ")
   Leer(Dm)
   pulgadas ← Dm * 39.37
   pies ← pulgadas / 12
   Escribir("La distancia equivalente en pies es: ", pies)
Fin

Entrada (Dm​) | Operación (Dm × 39.37) | Operación (pulgadas ÷ 12pulgadas) | Salida
1            | 1×39.37=39.371         | 39.37÷12=3.280833...              | "La distancia equivalente en pies es: 3.28"
10           | 10×39.37=393.710       | 393.7÷12=32.80833...              | "La distancia equivalente en pies es: 32.81"
0            | 0×39.37=00             | 0÷12=0                            | "La distancia equivalente en pies es: 0"
*/

using System;

class Programa
{
    static void Main()
    {
        Console.Write("Ingrese la distancia en metros (Dm): ");
        double Dm = double.Parse(Console.ReadLine());

        double pulgadas = Dm * 39.37;
        double pies = pulgadas / 12;

        Console.WriteLine("La distancia equivalente en pies es: " + pies.ToString("F2"));
    }
}
