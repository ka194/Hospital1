using Hospital1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTest
{
    class Program
    {
        static void Main(string[] args)
              
        {
            Console.WriteLine("Introduce un nombre de  la persona: ");
            double persona1 = Convert.ToDouble(Console.ReadLine());
            double persona2 = Convert.ToDouble(Console.ReadLine());

            double nombre =Hospital.nombre(persona1,persona2);
            double enfermedad = Hospital.enfermedad(persona1, persona2);

           
          


        }
    }
}
