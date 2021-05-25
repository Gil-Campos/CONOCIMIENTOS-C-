using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Orange : IFruit
    {
        public string description { 
            get => throw new NotImplementedException(); 
            
            set => throw new NotImplementedException(); 
        }

        public string color()
        {
            throw new NotImplementedException();
        }

        public string name()
        {
            throw new NotImplementedException();
        }

        public string season()
        {
            throw new NotImplementedException();
        }
    }
}
