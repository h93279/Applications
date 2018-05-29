using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample003
{
    class Program
    {
        static void Main(string[] args)
        {
            //這個 Equals 是執行個體方法，表示自己與傳入的物件比較

            int i = 10, j = 10;
            Console.WriteLine("i.Equals(j) is " + i.Equals(j));   //true
            // int 的  Equals 有多載，此處呼叫的是  int.Equals(int) 而非 object.Equals(object)

            // ▲ 如果目前的執行個體是實值類型，此方法測試 值 是否相等。
            // 1 兩個物件都屬於相同的型別。 
            // 2 兩個物件的公用和私用欄位的值相等。

            MyRectangle r1 = new MyRectangle { Width = 5, Height = 5 };
            MyRectangle r2 = new MyRectangle { Width = 5, Height = 5 };
            MyRectangle r3 = r2;

            Console.WriteLine("r1.Equals(r2) is " + r1.Equals(r2));   //false
            Console.WriteLine("r2.Equals(r3) is " + r2.Equals(r3));   //true
            // ▲  如果目前的執行個體是參考類型，此方法測試 參考(位置) 是否相等，
            //    而呼叫此方法相當於呼叫ReferenceEquals方法。
            
            Console.ReadLine();
        }
    }
}
