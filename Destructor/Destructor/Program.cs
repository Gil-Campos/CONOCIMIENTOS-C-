using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    public class Example
    {
        public Example()
        {
            Console.WriteLine("Constructor called");
        }

        //Destructor
        ~Example()
        {
            //TO DO: clean up unmanaged objects
            Console.WriteLine("Destructor called to clean up unmanaged objects");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example ex = new Example();

        }
    }
}
