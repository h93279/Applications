using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyData> list = CreateList();
            Console.WriteLine("有Nana,Irene,Bill,Kai,Ir五位同學");
            string input;
            Console.Write("請輸入欲查詢的同學名字：");
            input = Console.ReadLine();


        IEnumerable<MyData> people =
            from data in list
            where data.Name == input 
            select data;

        foreach (MyData person in people)
            {
                Console.WriteLine(person.Name + " is "+ person.Age + " years old. ");
            }
            Console.ReadLine();
        }

        static List <MyData> CreateList()
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
