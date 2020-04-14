using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonacniAutomatBudicMarin
{
    class Program
    {
        static void Main(string[] args)
        {
          
        SlucajA:
            
            if (Console.ReadKey().KeyChar == '1') {  }
            else { goto SlucajA; }
            
            
            if (Console.ReadKey().KeyChar == '1') {  }
            else { goto SlucajA; }
            SlucajC:
            
            if (Console.ReadKey().KeyChar == '0') {  }
            else { goto SlucajC; }
            if (Console.ReadKey().KeyChar == '1')
            {
                Console.WriteLine("Dizi rampu!!!");
            }
            else { goto SlucajA; }
            Console.ReadKey();

        }
    }
}
