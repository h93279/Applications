using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndOperatorSample
{
    class Program
    {
        static void Main(string[] args)    //參數(引數) void ←一個方法
        {
            int x1 = 20, x2 = 30;
            string y1 = "abc", y2 = "abc";

            if (x1 == x2 && y1 == y2)         // x1=x2 且 y1=y2 (都成立)
            {
                Console.WriteLine("都對");
            }
            else                              // x1=x2 且 y1=y2 (只要有一個不對)
            {
                Console.WriteLine("至少有一個不對");
            }

            if (x1 == x2 || y1 == y2)         // x1=x2 或 y1=y2 (只要一個對)
            {
                Console.WriteLine("至少有一個對");
            }
            else                              // x1!=x2 且 y1!=y2 (都不成立)
            {
                Console.WriteLine("兩個都不對");
            }
            Console.ReadLine();
        }
    }
}
