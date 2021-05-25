using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndPrivate
{

    public class Example
    {
        private static int Counter;

        //This private constructor prevents creatings instances when there are no instance fields or methods
        private Example()
        {
            Counter = 10;
        }

        //Static constructor
        static Example()
        {
            Counter = 20;
        }

        //Public constructor
        public Example(int counter)
        {
            Counter = Counter + counter;
        }

        public static int GetCounter()
        {
            return ++Counter;
        }

        public class NestedExample
        {
            public void test()
            {
                //Internal instance
                Example ex = new Example();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //External instance
            //Example ex1 = new Example();

            Example ex = new Example(10);

            Console.WriteLine($"Counter: {Example.GetCounter()}");

            Console.ReadKey();
        }
    }
}
