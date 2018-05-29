using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 0, 11, 22, 33, 44, 55 };  //可以隨意增加
            for(int i = 0; i < array.Length; i++)  //array.Length  ← 有幾個就有多長
            {
                Console.WriteLine(array[i]);
            }
            //因為是全部都列出，所以可以以下foreach代替
            // int[] array = new int[] { 0, 1, 2, 3, 4, 5 };
            // foreach (int i in array)
            // {
            //     Console.WriteLine(i);
            // }
            Console.ReadLine();
        }
    }
}
