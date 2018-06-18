using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_structure
{
    class Program
    {
        interface IData
        {
            int val { get; set; }
        }
        struct StructData : IData
        {
            public int a;
            public int b;
            public int c;
            public string str;
            public byte[] p;

            public int val { get; set; }
        }

        class ClassData : IData
        {
            public int val { get; set; }
        }

        static void Func(IData data)
        {
            data.val = 30;
        }

        static void FuncAAA(StructData aaa)
        {
            StructData b = aaa;
            Console.WriteLine(b.str);
        }

        static void FuncBBB(ClassData bbb)
        {

        }

        static StructData g = new StructData();

        static void Main(string[] args)
        {
            StructData a = new StructData();
           
            a.str = "aaa";
            a.p = new byte[1] { 0x0c };
            g.str = a.str;
            g.p = a.p;
            Console.WriteLine("g.str : " + g.str);
            Console.WriteLine("a.p : " + a.p[0]);
            Console.WriteLine("g.p : " + g.p[0]);
            FuncAAA(a);
            a.str = "bbb";
            a.p[0] = 0xaa;
            Console.WriteLine("Main call : " + a.str);
            Console.WriteLine("a.p : " + a.p[0]);
            Console.WriteLine("g.p : " + g.p[0]);
            Console.WriteLine("g.str : " + g.str);



            /////////
            Func(a);

            Console.ReadKey();
        }
    }
}
