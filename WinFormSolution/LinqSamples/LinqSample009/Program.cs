using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample009
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();

            //是否List中的都叫做Nana
            bool isAllNana = list.All((x) => x.Name == "Nana");
            if( isAllNana)
            {
                Console.WriteLine("全部都叫Nana");
            }
            else
            {
                Console.WriteLine("有些人不叫Nana");
            }

            //是否List中的都超過40歲
            bool isAllOverForty = list.All((x) => x.Age >= 40);
            if (isAllOverForty)
            {
                Console.WriteLine("大家都超過40歲");
            }
            else
            {
                Console.WriteLine("有人不到40歲");
            }
            Console.ReadLine();

        }

        static List<MyData> CreateList()
        {
        List<MyData> list = new List<MyData>();
            list.Add(new MyData() { Name = "Nana", Age = 21 });
            list.Add(new MyData() { Name = "Nana", Age = 45 });
            list.Add(new MyData() { Name = "Nana", Age = 10 });
            list.Add(new MyData() { Name = "Nana", Age = 23 });
            list.Add(new MyData() { Name = "Nana", Age = 39 });
            return list;
        }

    }
}
