using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;               //有一個整數叫result(結果)=0 (←不用做增減)
            for (int i = 1; i < 11; i++)  //for迴圈，整數i起始為1，i一直遞增，直到=1停止
            {
                result = result + i;     //先讀右邊，r+i=結果，經迴圈而將結果覆蓋，直至false
            }
            Console.Write("總共為：");    //顯示結果
            Console.WriteLine(result);   //顯示上方的result結果
            Console.ReadLine();
        }
    }
}
