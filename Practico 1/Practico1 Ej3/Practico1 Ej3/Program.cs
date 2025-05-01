/*   Algoritmo para trasvasar aceite al motor utilizando bidones

Inicialización:

Bidón principal: 5000 ml (5 litros, con aceite inicial)

Bidón intermedio: 0 ml (capacidad 1500 ml)

Botella auxiliar: 0 ml (capacidad 1000 ml)

Motor: 0 ml (cantidad inicial de aceite en el motor)

Mientras la cantidad de aceite en el motor sea menor que 4000 ml (4 litros):

Llenar el bidón intermedio (1500 ml) desde el bidón principal.

Llenar la botella auxiliar (1000 ml) desde el bidón intermedio.

Trasvasar los 500 ml restantes en el bidón intermedio al motor.

Vaciar la botella auxiliar de vuelta al bidón principal.

Repetir el proceso hasta alcanzar 4000 ml en el motor.

Fin del algoritmo.
 */

using System;

class ProgramaMecanico
{
    static void Main(string[] args)
    {
        // Variables para controlar el volumen
        double bidonPrincipal = 5000; // 5 litros en mililitros
        double bidonIntermedio = 0; // 1.5 litros en mililitros
        double botellaAuxiliar = 0; // 1 litro en mililitros
        double motor = 0; // Aceite añadido al motor en mililitros
        double etapa = 500; // Cantidad por etapa (500 ml)

        // Repetir mientras el motor no tenga los 4 litros
        while (motor < 4000)
        {
            // Llenar el bidón intermedio (1500 ml) desde el bidón principal
            Llenar(ref bidonIntermedio, ref bidonPrincipal, 1500);

            // Llenar la botella auxiliar (1000 ml) desde el bidón intermedio
            Llenar(ref botellaAuxiliar, ref bidonIntermedio, 1000);

            // Trasvasar los 500 ml restantes al motor
            Trasvasar(ref bidonIntermedio, ref motor, etapa);

            // Vaciar la botella auxiliar de vuelta al bidón principal
            Trasvasar(ref botellaAuxiliar, ref bidonPrincipal, 1000);

            // Esperar 10 segundos
            Esperar(10);
        }

        Console.WriteLine("El motor ha recibido 4 litros de aceite correctamente.");
    }

    // Método para trasvasar entre recipientes
    static void Trasvasar(ref double origen, ref double destino, double cantidad)
    {
        double trasvaso = Math.Min(cantidad, origen);
        destino += trasvaso;
        origen -= trasvaso;
    }

    // Método para llenar un recipiente desde una sustancia
    static void Llenar(ref double recipiente, ref double fuente, double capacidadRecipiente)
    {
        double llenarCantidad = Math.Min(capacidadRecipiente - recipiente, fuente);
        recipiente += llenarCantidad;
        fuente -= llenarCantidad;
    }

    // Método para vaciar un recipiente (opcional, no se utiliza aquí)
    static void Vaciar(ref double recipiente)
    {
        recipiente = 0;
    }

    // Método para simular espera en segundos
    static void Esperar(int segundos)
    {
        System.Threading.Thread.Sleep(segundos * 1000);
    }
}
