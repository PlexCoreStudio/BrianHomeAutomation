using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrianHomeAuto
{
    class ClosePrograms
    {

        //The function to close a specefic program
        public static void _CloseProgram(String s)
        {
            System.Diagnostics.Process[] _process = null;

            try
            {
                _process = Process.GetProcessesByName(s);
                Process _program = _process[0];

                if (!_program.HasExited)
                {
                    _program.Kill();
                }
            }
            finally
            {
                if (_process != null)
                {
                    foreach (Process p in _process)
                    {
                        p.Dispose();
                    }
                }
            }
        }
    }
}
