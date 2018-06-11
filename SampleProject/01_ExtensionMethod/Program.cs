using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    interface IFoo
    {
        string Name { get; }
        int Age { get; }
        void Print();
    }

    class Foo : IFoo
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Print()
        {
            Console.WriteLine("Name={0}, Age={1}", Name, Age);
        }
    }

    class Bar : IFoo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public void Print()
        {
            Console.WriteLine("Name={0}, Age={1}, Gener={2}", Name, Age, Gender);
        }
    }

    class Kab : Foo
    {
        public new void Print()
        {
            //if (Age > 20)
            Console.WriteLine("Name={0}, Age={1}, Gener={2}", Name, Age);
            //else
            //    Console.WriteLine("yong");
        }
    }

    class Eunl : IFoo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }

        public void Print()
        {
            //if (Age > 20)
            Console.WriteLine("Name={0}, Age={1}, Company={2}", Name, Age, Company);
            //else
            //    Console.WriteLine("yong");
        }
    }
}
namespace Test
{
    static class FooExtension
    {
        public static void PrintEx(this Test.IFoo self, int age = 20)
        {
            if (self.Age > age)
                self.Print();
            else
                Console.WriteLine("yong");
        }
    }
}

namespace _01_ExtensionMethod
{
    using Test;

    class Program
    {
        static void Main(string[] args)
        {
            var foo = new Test.Foo() { Name = "조명근", Age = 28 };
            foo.Print();
            foo.PrintEx();
            var bar = new Test.Bar() { Name = "순이", Age = 21, Gender = "female" };
            bar.Print();
            bar.PrintEx();

            var k = new Test.Eunl() { Name = "철이", Age = 100, Company = "NASA" };
            k.Print();
            k.PrintEx();

            Console.ReadKey();
        }
    }
}
