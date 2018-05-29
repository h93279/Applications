using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample004
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();

            var person1 = list.LastOrDefault((x) => x.Age > 35);
            Console.WriteLine("大於35歲的人，最後一個被找到的是：" + person1.Name);

            var person2 = list.LastOrDefault((x) => x.Age > 50);
            if (person2 != null)
            {
                Console.WriteLine("大於50歲的人，最後一個被找到的是：" + person1.Name);
            }
            else
            {
                Console.WriteLine("沒有人大於50歲。");
            }

            Console.ReadLine();

        }


        static List<MyData> CreateList()
        {
            List<MyData> list = new List<MyData>();
            list.Add(new MyData() { Name = "Nana", Age = 21 });
            list.Add(new MyData() { Name = "Irene", Age = 22 });
            list.Add(new MyData() { Name = "Bill", Age = 47 });
            list.Add(new MyData() { Name = "Kai", Age = 22 });
            list.Add(new MyData() { Name = "Ir", Age = 49 });
            return list;
        }
    }
}
