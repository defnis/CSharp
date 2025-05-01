/* Problema
  Considere que se está realizando un trabajo de pintura y ya se han comprado una cierta cantidad de
latas de 4 litros de pintura cada una. Se quiere deducir si la pintura restante alcanzará para completar el trabajo o se
necesitará ir a comprar más, y en el caso de que exista un faltante, cuántos litros deberán comprar. Los datos a
considerar son los siguientes:

● litros_usados que corresponde a los litros ya utilizados en el trabajo
● litros_que_faltan que corresponde al cálculo de los litros que faltan para terminar el trabajo, y
● total_latas_4L_compradas que corresponde al total de latas de 4 litros compradas.

Si la diferencia entre el total de litros de pintura comprada y lo que ya fue usado alcanza para terminar el trabajo,
deberá mostrar por pantalla el texto “la pintura alcanza”, de lo contrario, deberá mostrar “la pintura no alcanza” y
cuántos litros de pintura hace falta comprar.
 */

/* Algoritmo
Entrada de datos:
Leer litros_usados.
Leer litros_que_faltan.
Leer total_latas_4L_compradas.

Cálculo:
Calcular litros_totales como total_latas_4L_compradas * 4.
Calcular litros_restantes como litros_totales - litros_usados.

Decisión:
Si litros_restantes es mayor o igual a litros_que_faltan, imprimir "la pintura alcanza".
Si no, calcular la cantidad faltante como litros_que_faltan - litros_restantes y mostrar "la pintura no alcanza"
junto con la cantidad de litros necesarios.
*/

using System;

class Program
{
    static void Main()
    {
        // Entrada de datos
        Console.WriteLine("Ingrese la cantidad de litros ya utilizados:");
        double litros_usados = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de litros que faltan:");
        double litros_que_faltan = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el total de latas de 4 litros compradas:");
        int total_latas_4L_compradas = int.Parse(Console.ReadLine());

        // Cálculos
        double litros_totales = total_latas_4L_compradas * 4;
        double litros_restantes = litros_totales - litros_usados;

        // Decisión y salida
        if (litros_restantes >= litros_que_faltan)
        {
            Console.WriteLine("La pintura alcanza.");
        }
        else
        {
            double litros_necesarios = litros_que_faltan - litros_restantes;
            Console.WriteLine($"La pintura no alcanza. Necesitarás comprar {litros_necesarios} litros más.");
        }
    }
}

