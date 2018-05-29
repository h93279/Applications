using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCandy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("雜貨店阿婆準備一個新春優惠：糖果每4個包裝紙可以兌換一顆糖果");
            Console.WriteLine("今天你去到雜貨店打算邊吃邊換吃到飽，請問你想吃幾顆？");
            int eat = int.Parse(Console.ReadLine());
            int buy = 0;
            int wrapper = 0;

            for (int goal = eat; goal >= 0; goal--) //目標越來越小
            {
                wrapper++;
                buy++;
                while (wrapper % 4 == 0)
                {
                    buy--;
                    wrapper = wrapper - 4;
                    break;
                }
            }
            Console.WriteLine("你必須要買" + buy + "顆糖果，才可以吃到" + eat + "顆糖果");
            Console.ReadLine();
        }
    } 
}

/*
 for (int goal = eat; goal >= 0; goal--)
 {
     while (goal == 0)
     {
         buy++;
         eat--;

         if (eat % 4 == 0)
         {
             buy--;
         }
     }
 }
 Console.WriteLine("你必須要買" + buy + "顆糖果，才可以吃到" + eat + "顆糖果");
 Console.ReadLine();
 */
