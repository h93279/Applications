using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample001
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 10;
            Console.WriteLine("object.Equals(i,j) is " + object.Equals(i, j));   // true
            
            MyRectangle r1 = new MyRectangle { Width = 5, Height = 5 };
            MyRectangle r2 = new MyRectangle { Width = 5, Height = 5 };
            MyRectangle r3 = r2;

            //Equals預設是比位置
            Console.WriteLine("object.Equals(r1,r2) is " + object.Equals(r1, r2));   //false   <<比Heap的位子
            Console.WriteLine("object.Equals(r2,r3) is " + object.Equals(r2, r3));   //true

            Console.ReadLine();
        }
    }
}
