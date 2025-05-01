/* Problema
 Utilizando la sentencia CASE, realice un programa que pida la velocidad del viento en Km/h como un número entero y 
 muestre cómo está categorizada esa velocidad con respecto a la escala de Beaufort para categorizar el viento
 */

using System;

class Program
{
    static void Main()
    {
        // Solicitar la velocidad del viento en Km/h
        Console.Write("Ingrese la velocidad del viento en Km/h: ");

        // Validar que la entrada sea un número entero
        if (!int.TryParse(Console.ReadLine(), out int windSpeed) || windSpeed < 0)
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero no negativo.");
            return;
        }

        // Categorizar la velocidad del viento utilizando un switch
        string category;

        switch (windSpeed)
        {
            case int n when (n >= 0 && n <= 5):
                category = "Calma (0-5 km/h)";
                break;
            case int n when (n >= 6 && n <= 11):
                category = "Brisa ligera (6-11 km/h)";
                break;
            case int n when (n >= 12 && n <= 19):
                category = "Brisa moderada (12-19 km/h)";
                break;
            case int n when (n >= 20 && n <= 28):
                category = "Brisa fuerte (20-28 km/h)";
                break;
            case int n when (n >= 29 && n <= 38):
                category = "Viento moderado (29-38 km/h)";
                break;
            case int n when (n >= 39 && n <= 49):
                category = "Viento fuerte (39-49 km/h)";
                break;
            case int n when (n >= 50 && n <= 61):
                category = "Viento muy fuerte (50-61 km/h)";
                break;
            case int n when (n >= 62 && n <= 74):
                category = "Tormenta (62-74 km/h)";
                break;
            case int n when (n >= 75 && n <= 88):
                category = "Tormenta severa (75-88 km/h)";
                break;
            case int n when (n >= 89):
                category = "Huracán (más de 88 km/h)";
                break;
            default:
                category = "Velocidad fuera del rango permitido.";
                break;
        }

        // Mostrar la categoría de la velocidad del viento
        Console.WriteLine($"La velocidad del viento es de {windSpeed} km/h, categorizado como: {category}");
    }
}
