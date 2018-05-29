using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("班級裡面有5個人，其中");

            var list = CreateList();
            var person1 = list.FirstOrDefault((x) => x.Age < 50);
            Console.WriteLine("40歲以下最接近40歲的人是：" + person1.Name);

            var person2 = list.FirstOrDefault((x) => x.Age <20);
            if (person2 != null)
            {
                Console.WriteLine("20歲以下，最接近20歲的人是：" + person2.Name);
            }
            else
            {
                Console.WriteLine("並沒有人小於20歲。");
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
