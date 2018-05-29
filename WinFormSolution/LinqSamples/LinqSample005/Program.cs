using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample005
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();

            var person1 = list.SingleOrDefault((x) => x.Name == "Nana");
            Console.WriteLine("唯一被找到的是" + person1.Name);

            var person2 = list.SingleOrDefault((x) => x.Name == "Bill");
            Console.WriteLine("唯一被找到的是" + person2.Name);                //一定會出錯可用try catch

        }

        static List<MyData> CreateList()
        {
            List<MyData> list = new List<MyData>();
            list.Add(new MyData() { Name = "Nana", Age = 21 });
            list.Add(new MyData() { Name = "Irene", Age = 22 });
            list.Add(new MyData() { Name = "Bill", Age = 36 });
            list.Add(new MyData() { Name = "Kai", Age = 22 });
            list.Add(new MyData() { Name = "Bill", Age = 49 });
            return list;
        }
    }
}
