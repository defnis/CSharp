/* Problema
 Realizar un programa para calcular el costo de un pasaje en un crucero internacional. El costo dependerá
de varios factores: la edad, el tipo de servicio, las comidas incluidas, y la forma de pago. El programa deberá solicitar
toda la información necesaria y luego mostrar dicha información a modo de resumen. Se conoce la siguiente
información sobre el viaje:
- El precio normal del pasaje (dato constante) es $1000.
- El precio normal del pasaje para menores de 18 años (dato constante) es $800.
- La compra anticipada del menú diario cuesta $50 por día (dato constante).
- El costo de las comidas dependerá de la cantidad de días solicitados.
- Si se realiza el pago en efectivo tiene un 10% de descuento, si se realiza en un pago en forma electrónica no
tiene descuento, y si se financia en 6 cuotas con tarjeta de crédito el costo tendrá un adicional del 10%.
 */

using System;

class Program
{
    static void Main()
    {
        const double PRECIO_NORMAL = 1000.00;
        const double PRECIO_MENORES = 800.00;
        const double COSTO_MENU_DIARIO = 50.00;
        const double DESCUENTO_EFECTIVO = 0.10;
        const double RECARGO_TARJETA = 0.10;

        Console.WriteLine("Crucero Internacional Horizonte Azul");
        Console.WriteLine($"Pasaje normal ${PRECIO_NORMAL}, menores de 18 años ${PRECIO_MENORES}, menú anticipado ${COSTO_MENU_DIARIO} por día.");

        // Solicitar edad
        Console.Write("Ingrese su edad (1 a 110): ");
        int edad = int.Parse(Console.ReadLine());
        double costoBase = edad < 18 ? PRECIO_MENORES : PRECIO_NORMAL;

        // Solicitar días de menú anticipado
        Console.Write("¿Cuántos días quiere comprar de menú anticipado? (0 para ninguno): ");
        int diasMenu = int.Parse(Console.ReadLine());
        double costoMenu = diasMenu * COSTO_MENU_DIARIO;

        // Solicitar forma de pago
        Console.WriteLine("Pagando en efectivo 10% de descuento, financiado en 6 cuotas 10% de recargo.");
        Console.Write("Seleccione forma de pago (E=efectivo, 1=pago electrónico, 6=seis cuotas): ");
        char formaPago = char.ToUpper(Console.ReadLine()[0]);

        // Calcular total acumulado
        double totalAcumulado = costoBase + costoMenu;
        double descuento = 0.0, recargo = 0.0;

        switch (formaPago)
        {
            case 'E':
                descuento = totalAcumulado * DESCUENTO_EFECTIVO;
                break;
            case '6':
                recargo = totalAcumulado * RECARGO_TARJETA;
                break;
        }

        double costoFinal = totalAcumulado - descuento + recargo;

        // Mostrar resumen
        Console.WriteLine("\nResumen de los datos ingresados:");
        Console.WriteLine($"Edad = {edad}, costo base de pasaje = ${costoBase:F2}");
        Console.WriteLine($"Días de menú anticipado = {diasMenu}, adicional por menús anticipados = ${costoMenu:F2}");
        Console.WriteLine($"Total acumulado = ${totalAcumulado:F2}");

        if (formaPago == 'E')
        {
            Console.WriteLine($"Forma de pago = efectivo, descuento de ${descuento:F2}");
        }
        else if (formaPago == '6')
        {
            Console.WriteLine($"Forma de pago = seis cuotas, recargo de ${recargo:F2}");
        }
        else
        {
            Console.WriteLine("Forma de pago = pago electrónico, sin descuento ni recargo");
        }

        Console.WriteLine($"Costo final del pasaje en crucero Horizonte Azul = ${costoFinal:F2}");
    }
}
