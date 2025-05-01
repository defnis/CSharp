/*
Inicio
   Escribir("Ingrese su día de nacimiento: ")
   Leer(d_n)
   Escribir("Ingrese su mes de nacimiento: ")
   Leer(m_n)
   Escribir("Ingrese su año de nacimiento: ")
   Leer(a_n)

   Obtener la fecha actual: (d_a, m_a, a_a)

   Si (m_n > m_a) o (m_n = m_a y d_n > d_a) Entonces
       edad ← a_a - a_n - 1
   Sino
       edad ← a_a - a_n
   FinSi

   Si (d_n = d_a y m_n = m_a) Entonces
       Escribir("¡Feliz cumpleaños!")
   FinSi

   Escribir("Su edad es: ", edad)
Fin
*/

using System;

class Programa
{
    static void Main()
    {
        // Solicitar la fecha de nacimiento del usuario
        Console.Write("Ingrese su día de nacimiento (1-31): ");
        int diaNacimiento = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su mes de nacimiento (1-12): ");
        int mesNacimiento = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su año de nacimiento: ");
        int añoNacimiento = int.Parse(Console.ReadLine());

        // Obtener la fecha actual
        DateTime fechaActual = DateTime.Now;
        int diaActual = fechaActual.Day;
        int mesActual = fechaActual.Month;
        int añoActual = fechaActual.Year;

        // Calcular la edad
        int edad = añoActual - añoNacimiento;
        if (mesNacimiento > mesActual || (mesNacimiento == mesActual && diaNacimiento > diaActual))
        {
            edad -= 1;
        }

        // Mostrar felicitaciones si es el cumpleaños
        if (diaNacimiento == diaActual && mesNacimiento == mesActual)
        {
            Console.WriteLine("¡Feliz cumpleaños!");
        }

        // Mostrar la edad
        Console.WriteLine("Su edad actual es: " + edad);
    }
}
