using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("以下顯示1~100，且3=A，5=B，9=C，0=D");
            for (int i = 1; i <= 100; i++)
            {
                ReplaceString(i.ToString());
            }
            Console.ReadLine();

            /*int[] s;
            for (s = 1; s <= 100; s++)
            {
                s = s.Replace(3,"A".Replace(5,"B").Replace(9,"C").Replace(0,"D");
                Console.WriteLine(s);
            }*/
        }



        private static void ReplaceString(string i)
        {
            var data = GetDictionary();
            for (int j = 0; j < 10; j++)
            {
                i = i.ToString().Replace(j.ToString(), data[j]);
            }
            Display(i);
        }
        
        private static void Display (string value)
        {
            Console.WriteLine(value);
        }
        
        private static Dictionary<int,string> GetDictionary()
        {
            return new Dictionary<int, string>
            {
                {3,"A"},{5,"B"},{9,"C"},{0,"D"},
                {1,"1"},{2,"2"},{4,"4"},{6,"6"},{7,"7"},{8,"8"}
            };
        }
    }
}
