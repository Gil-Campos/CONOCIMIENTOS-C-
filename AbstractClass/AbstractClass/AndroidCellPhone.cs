using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class AndroidCellPhone : Device
    {
        public override int batteryPercentage
        {
            get
            {
                //Specific code for getter
                throw new NotImplementedException();
            }

            set
            {
                //Specific code for setter
            }
        }

        public override void playVideo()
        {
            //Define functionality of video play
        }
    }
}
