using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrianHomeAuto
{
    class OpenPrograms
    {
        //Word
        public static void word()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "WINWORD.EXE";
            Process.Start(startInfo);
        }
    }
}
