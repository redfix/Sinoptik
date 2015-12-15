using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            //Oop1

            Foo();
            Foo(null);
            Foo(new XBar());
            Foo(new XBar(), new XBar());
            Foo(new XBar(), new object());
            Foo(new object(), new object());


            Console.ReadKey();
        }

        public static void Foo(object o)
        {
            Console.WriteLine("obj");
        }

        public static void Foo(object o, object oo)
        {
            Console.WriteLine("Obj, obj");
        }

        public static void Foo(params object[] args)
        {
            Console.WriteLine("params obj[]");
        }

        public static void Foo<T>(params T[] args)
        {
            Console.WriteLine("params T[]");
        }
    }
}
