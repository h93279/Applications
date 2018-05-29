using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;     //定義result = 0
            int i = 12;          //先給個判斷值
            while(i < 11)       //執行的條件
            {
                result = result + i;    //先跑右邊，跑到最後一個結果
                i = i + 1;              //i遞增，可以打i++
            }
            Console.Write("加總結果：");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
