using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopOverLoading4
{
    class Program
    {


        public class Foo
        {
            protected class Wood
            {
            
                public Wood()
                {
                    Console.WriteLine("Foo.Wood()");
                }
            }
        }


        public class Bar : Foo
        {
             protected new class Wood
            {

                public Wood()
                {
                    Console.WriteLine("Bar.Wood()");
                }
            }
        }

        class Baz : Bar
        {
            public Baz()
            {
                new Wood();
            }
        
        }


        static void Main(string[] args)
        {

            new Baz();
        }
    }
}
