using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample008
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();

            string name = "Nana";    //將字串Da 指派給name
            bool result = list.Any((x) => x.Name == name );  //將name放在list裡面找，尋找任一符合name值(Nana)的項目，將有(true)無(false)結果指派給result
            if (result)  //if (result==true)    <是這個意思
            {
                Console.WriteLine("找到了" + name);
            }
            else
            {
                Console.WriteLine("找不到"+ name);
            }
            Console.ReadLine();
        }

        static List<MyData> CreateList()
        {
            List<MyData> list = new List<MyData>();
            list.Add(new MyData() { Name = "Nana", Age = 21 });
            list.Add(new MyData() { Name = "Irene", Age = 30 });
            list.Add(new MyData() { Name = "John", Age = 29 });
            list.Add(new MyData() { Name = "David", Age = 18 });
            list.Add(new MyData() { Name = "Nana", Age = 47 });
            return list;
        }

    }
}
