using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerUI
{
    class ComportFunctionality
    {
        public string[] SearchComport()
        {
            // Get a list of serial port names.
            string[] comportList = SerialPort.GetPortNames();

            return comportList;
        }
        


    }
}
