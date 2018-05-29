using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int i = 12;                    //若超過範圍↓
            do                
            {
                result = result + i;
                i = i + 1;
            }
            while (i < 11);               //只跑一次，直接下一步
            Console.Write("加總結果：");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
