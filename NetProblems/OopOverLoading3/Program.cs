using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopOverLoading3
{
    class Program
    {


    class Foo
    {
        public Foo()
        {
                Woox();
        }
        public virtual void Woox()
        {
                Console.WriteLine("Foo.Woox()");
        }
    }

        class Bar : Foo
        {
            protected String name;
            public Bar()
            {
                name = "Bar";
            }

            public override void Woox()
            {
                Console.WriteLine("Bar.Woox()" + name);
            }

            public void Woox(params object [] param)
            {
                Console.WriteLine("Bar.Woox(params)");
            }
        }

        class Baz : Bar
        {
            public Baz()
            {
                name = "Baz";
                Woox();
                ((Foo)this).Woox();
            }
        }

        static void Main(string[] args)
        {
            new Baz();
            Console.ReadKey();
        }
    }
}
