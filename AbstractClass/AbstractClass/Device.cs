using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Device
    {
        public int IMIE_Number = 0;
        public abstract int batteryPercentage { get; set; }

        public void powerOn()
        {
            //Some common basic functionality
        }

        public void powerOff()
        {
            //Some common basic functionality
        }

        public abstract void playVideo(); //Must be implemented in child class

        public virtual void playAudio()
        {
            //Some functionality that can be overriden
        }
    }
}
