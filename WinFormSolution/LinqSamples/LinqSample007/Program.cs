using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample007
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            var list = CreateList();

            var person = list.ElementAtOrDefault(index);
            if (person == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine("找到索引為：" + index.ToString() + "的人是" + person.Name + "-" + person.Age);
            }
            Console.ReadLine();
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
