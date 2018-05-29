using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakSample
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("i = " + i);
                for (int j = 11; j < 20; j++)
                {
                    Console.WriteLine("j = " + j);         //結果會變得不一樣
                    if (j==15)
                    {
                        break;     //跳離最接近的外層(封閉式)迴圈
                    }
                    // Console.WriteLine("j = " + j);      //假如這句放在上面↑
                }
            }
            Console.ReadLine();
        }
    }
}
