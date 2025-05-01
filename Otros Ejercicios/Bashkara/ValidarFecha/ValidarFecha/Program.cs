// Realice un programa que pida una fecha expresada como tres enteros (día, mes y año)
// y determine si es una fecha válida o no. Para el año puede considerar válido que sea mayor a cero,
// u otro número que considere adecuado.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el día: ");
        if (!int.TryParse(Console.ReadLine(), out int day) || day <= 0 || day > 31)
        {
            Console.WriteLine("El día ingresado no es válido. Debe estar entre 1 y 31.");
            return;
        }

        Console.Write("Ingrese el mes: ");
        if (!int.TryParse(Console.ReadLine(), out int month) || month < 1 || month > 12)
        {
            Console.WriteLine("El mes ingresado no es válido. Debe estar entre 1 y 12.");
            return;
        }

        Console.Write("Ingrese el año (4 dígitos): ");
        if (!int.TryParse(Console.ReadLine(), out int year) || year < 0 || year > 9999 || year.ToString().Length != 4)
        {
            Console.WriteLine("El año ingresado no es válido. Debe tener exactamente 4 dígitos (0000-9999).");
            return;
        }

        // Verificar la validez del día en función del mes y del año
        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        bool isValidDate = false;

        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                isValidDate = day <= 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                isValidDate = day <= 30;
                break;
            case 2:
                isValidDate = isLeapYear ? day <= 29 : day <= 28;
                break;
            default:
                isValidDate = false;
                break;
        }

        // Mostrar el resultado
        if (isValidDate)
        {
            Console.WriteLine($"La fecha ingresada ({day}/{month}/{year}) es válida.");
        }
        else
        {
            Console.WriteLine($"La fecha ingresada ({day}/{month}/{year}) no es válida.");
        }
    }
}
