using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assembly1;

namespace Assembly2
{
    class Program
    {

        public class Assembly2DerivedClass : Assembly1BaseClass
        {
            public void testAccessInDerivedClass()
            {
                //Not accessible: 
                //Console.WriteLine(privateVariable);
                //Console.WriteLine(internalString);

                //Accessible:
                Console.WriteLine(protectedVariable);
                Console.WriteLine(protectedInternal);
                Console.WriteLine(publicVariable);
            }
        }

        public class Assembly2OtherClass
        {
            public void testAccess()
            {
                Assembly1BaseClass objBase = new Assembly1BaseClass();
                //Not accessible: 
                //Console.WriteLine(objBase.privateVariable);
                //Console.WriteLine(objBase.internalString);
                //Console.WriteLine(objBase.protectedVariable);
                //Console.WriteLine(objBase.protectedInternal);

                //Accessible:
                Console.WriteLine(objBase.publicVariable);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-Assembly 02");

            //Objects
            //Assembly2DerivedClass objDerived = new Assembly2DerivedClass();
            //objDerived.testAccessInDerivedClass();
            //objDerived.testAccess();

            Assembly2OtherClass objOtherClass = new Assembly2OtherClass();
            objOtherClass.testAccess();

            Console.ReadKey();
        }
    }
}
