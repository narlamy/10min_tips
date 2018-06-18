using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CSharp_7
{
    class Program
    {
        static string Name { get; } = "abc";
        int Id { get; set; } = 100;

        class Foo
        {
            public string Name { get; set; } = "";
        }

        static void Main(string[] args)
        {
            var r = Range(new int[] { 100, 30, 43, 21 });
            Console.WriteLine($"Min={r.Min}, Max={r.Max}");

            Func1(out int o);
            Func2(new Foo());

            var r1 = Func3(3, 3_300);
            var (_,n2) = Func3(5, 10);

            Console.WriteLine($"n2");

            //Action<int> a = Func4(30);

            Console.ReadKey();

            void Func1(out int data)
            {
                data = 100;
            }

            void Func2(Foo foo)
            {
                Console.WriteLine(foo?.Name ?? "x");
            }

            (int a, int b) Func3(int a1, int b1)
            {
                return (a1, b1);
            }
        }

        delegate void MyAction(int id);

        static MyAction Func4(int num)
        {
            MyAction action = (int id) => { Console.WriteLine(num); };
            return action;
        }


        private static (int Max, int Min) Range(IEnumerable<int> numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (var n in numbers)
            {
                min = (n < min) ? n : min;
                max = (n > max) ? n : max;
            }
            return (max, min);
        }
    }
}
