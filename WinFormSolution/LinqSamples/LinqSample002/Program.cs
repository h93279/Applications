using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyData> list = CreateList();


            var people = list.Where((x) => x.Name == "Nana");
            // from data in list
            // where data.Name == "Nana"
            // select data;

            foreach (var person in people)
            {
                Console.WriteLine(person.Name + "是" + person.Age + "歲");
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
