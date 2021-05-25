using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly1
{
    public class Assembly1BaseClass
    {
        private string privateVariable = "private";
        protected string protectedVariable = "protected";
        internal string internalString = "internal";
        protected internal string protectedInternal = "protected internal";
        public string publicVariable = "public";

        public void testAccess()
        {
            //Accessible
            Console.WriteLine(privateVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalString);
            Console.WriteLine(protectedInternal);
            Console.WriteLine(publicVariable);
        }
    }

    public class Assembly1DerivedClass : Assembly1BaseClass
    {
        public void testAccessInDerivedClass()
        {
            //Not accessible: 
            //Console.WriteLine(privateVariable);

            //Accessible:
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalString);
            Console.WriteLine(protectedInternal);
            Console.WriteLine(publicVariable);
        }
    }

    public class Assemble1OtherClass
    {
        public void testAccess()
        {
            Assembly1BaseClass objBaseClass = new Assembly1BaseClass();

            //Not accessible:
            //Console.WriteLine(objBaseClass.privateVariable);
            //Console.WriteLine(objBaseClass.protectedVariable);

            //Accessible:
            Console.WriteLine(objBaseClass.internalString);
            Console.WriteLine(objBaseClass.protectedInternal);
            Console.WriteLine(objBaseClass.publicVariable);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Assembly 01");

            //Objects 
            //Assembly1BaseClass objBaseClass = new Assembly1BaseClass();
            //objBaseClass.testAccess();

            //Assembly1DerivedClass objDerivedClass = new Assembly1DerivedClass();
            //objDerivedClass.testAccessInDerivedClass();

            Assemble1OtherClass objOtherClass = new Assemble1OtherClass();
            objOtherClass.testAccess();
           
            Console.ReadKey();
        }
    }
}
