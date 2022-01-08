using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверяем работу арифметической прогрессии");
            ArithProgression arith = new ArithProgression();
            arith.SetStart(10);
            arith.setStep(2);
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine("После сброса к начальному значению");
            arith.Reset();
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());

            Console.WriteLine("Проверяем работу геометрической прогрессии");
            GeomProgression geom = new GeomProgression();
            geom.SetStart(10);
            geom.setStep(2);
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine("После сброса к начальному значению");
            geom.Reset();
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());

            Console.ReadKey();


        }
    }


    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }

}
