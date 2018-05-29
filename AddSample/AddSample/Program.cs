using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 2;
            int i2 = 3;
            double d = 9.98;
            string s1 = "one";
            string s2 = "two";             // 注意：以下是糖
            Console.WriteLine(i1 + i2);    // 23(X)     5(O)
            Console.WriteLine(i1 + d);     // 29.98(X)  11.98(O)
            Console.WriteLine(s1 + s2);    // onetwo
            Console.WriteLine(s1 + i1);    // one2
            Console.WriteLine(d + s2);     // 9.98two
            Console.ReadLine();            // 有沒有覺得糖裡有毒:)

        }
    }
}
