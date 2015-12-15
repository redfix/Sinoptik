using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopOverLoading2
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Bar();
            foo.Quux(23);
            new Bar().Quux(23);

            Console.ReadKey();
        }
    }


    class Foo
    {
        public virtual void Quux(int a)
        {
            Console.WriteLine("Foo.Quux");
        }
    }

    class Bar : Foo
    {
        public override void Quux(int a)
        {
            Console.WriteLine("Bar.Quux(int)");
        }

        public void Quux(object a)
        {
            Console.WriteLine("Bar.Quux(Obj)");
        }
    }
}
