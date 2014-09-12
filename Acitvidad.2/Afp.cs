using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acitvidad._2
{
    class Afp
    {
        static int horasfinde, horas2;
        static void afpp()
        {
            try
            {
                Console.WriteLine("Ingrese Cantidad de Horas Trabajadas en los fines de semana ");
                horasfinde = Convert.ToInt16(Console.ReadLine());
                horas2 = horasfinde;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese solo numeros");

            }
        }
    }
}
