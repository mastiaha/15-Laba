using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вебинар
{
    class Program
    {
        static void Main(string[] args)
        {
            AChiper aChiper = new AChiper();
            Console.WriteLine(aChiper.EnCode("ABC123 XYZ"));
            Console.ReadKey();
        }
    }
}
