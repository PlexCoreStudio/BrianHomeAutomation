using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianHomeAuto
{
    class AppComm
    {
        //Restarts the program
        public static void restart()
        {
            Application.Restart();
        }

        public static void exit()
        {
            Application.Exit();
        }
    }
}
