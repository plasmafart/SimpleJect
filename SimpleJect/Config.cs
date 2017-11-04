using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleJect
{
    class Config
    {
        public static string cfgPath = $@"{Application.StartupPath}\SimpleJect.cfg";
        public static void SaveConfig(string line1, string line2)
        {
            /*don't ask*/
            string contents = @"";
            contents += $@"{line1}" + Environment.NewLine;
            contents += $@"{line2}" + Environment.NewLine;
            File.WriteAllText($@"{cfgPath}", $@"{contents}");
        }

        public static string ReadConfig(int line)
        {
            return File.ReadAllLines(cfgPath)[line - 1]/*arrays start at 0*/;
        }
    }
}
