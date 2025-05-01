// Utilizando la sentencia CASE, realice un programa para distinguir mayúsculas y minúsculas.

using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese una letra
        Console.Write("Ingrese una letra: ");
        char input = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Salto de línea después de la entrada

        // Verificar si la entrada es una letra
        if (!char.IsLetter(input))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese una letra.");
            return;
        }

        // Determinar si la letra es mayúscula o minúscula utilizando switch
        switch (input)
        {
            case char c when (char.IsUpper(c)):
                Console.WriteLine("La letra ingresada es mayúscula.");
                break;

            case char c when (char.IsLower(c)):
                Console.WriteLine("La letra ingresada es minúscula.");
                break;

            default:
                Console.WriteLine("Entrada no válida.");
                break;
        }
    }
}
