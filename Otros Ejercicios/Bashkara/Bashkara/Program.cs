/* Problema
  La fórmula de Bhaskara se utiliza para calcular las raíces de un polinomio de segundo grado.
  Las letras a,b y c representan los coeficientes de la ecuación y la parte azul (b2 - 4ac) se llama discriminante,
  porque sirve para decidir entre los tipos posibles de respuesta:
    ● si el resultado de la discriminante es positivo, hay DOS soluciones para la ecuación;
    ● si la discriminante da cero, la ecuación tendrá sólo UNA solución;
    ● y si la discriminante da negativo hay dos soluciones que incluyen números imaginarios .
  Realice un programa que pida los coeficientes y devuelva los valores de las raices.
  */

using System;

class Program
{
    static void Main()
    {
        // Declaración de variables
        double a, b, c, discriminante, raiz1, raiz2;

        // Entrada de datos
        Console.WriteLine("Cálculo de raíces usando la fórmula de Bhaskara");
        Console.Write("Ingrese el coeficiente a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el coeficiente b: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el coeficiente c: ");
        c = double.Parse(Console.ReadLine());

        // Verificar si a es diferente de 0
        if (a == 0)
        {
            Console.WriteLine("El coeficiente 'a' no puede ser 0, ya que no sería una ecuación cuadrática.");
            return;
        }

        // Calcular el discriminante
        discriminante = Math.Pow(b, 2) - 4 * a * c;

        // Evaluar el discriminante y calcular las raíces
        if (discriminante > 0)
        {
            raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            Console.WriteLine($"La ecuación tiene dos soluciones reales:");
            Console.WriteLine($"Raíz 1 = {raiz1:F2}");
            Console.WriteLine($"Raíz 2 = {raiz2:F2}");
        }
        else if (discriminante == 0)
        {
            raiz1 = -b / (2 * a);
            Console.WriteLine("La ecuación tiene una solución real:");
            Console.WriteLine($"Raíz = {raiz1:F2}");
        }
        else
        {
            double parteReal = -b / (2 * a);
            double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);
            Console.WriteLine("La ecuación tiene dos soluciones complejas:");
            Console.WriteLine($"Raíz 1 = {parteReal:F2} + {parteImaginaria:F2}i");
            Console.WriteLine($"Raíz 2 = {parteReal:F2} - {parteImaginaria:F2}i");
        }
    }
}
