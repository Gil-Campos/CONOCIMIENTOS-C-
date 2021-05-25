using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IFruit
    {

        /*
         * Can't have variables in interface
         * Can't have implementations in it, just declarations
         * All methods declared by default public
         * */

        string description { get; set; }
        string name();
        string season();
        string color();
    }
}
