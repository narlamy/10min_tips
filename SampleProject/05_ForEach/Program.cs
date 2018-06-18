using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ForEach
{
    class Program
    {
        static List<string> list = new List<string>();

        static private IEnumerable<string> MyEnumerable()
        {   
            yield return list[0];
            yield return list[1];
            yield return list[2];
            yield return "hahaha";
        }

        static private IEnumerator<string> MyEnumerator()
        {
            yield return list[0];
            yield return list[1];
            yield return list[2];
            yield return "hahaha";
        }

        static private IEnumerable<string> MyEnumerable2()
        {
            yield return "Custom";

            using (var e = list.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    yield return e.Current;
                }
            }
        }

        static void Main(string[] args)
        {
            list.Add("1");
            list.Add("2");
            list.Add("3");

            Console.WriteLine("================\n<ForEach>");
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("================\n<Enumerator>");

            using (var e = list.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    Console.WriteLine(e.Current);
                }
            }
            
            Console.WriteLine("================\n<for>");
            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("================\n<enum_func>");
            foreach(var s in MyEnumerable())
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("================\n<enum_func2>");
            foreach (var s in MyEnumerable2())
            {
                Console.WriteLine(s);
            }


            Console.ReadKey();
        }
    }
}
