using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleJect
{
    class Update
    {
        public static string appVers = "1.2";
        public static string checkedVers = "";
        public static bool IsCorrectVersion = false;

        public static void CheckForUpdate()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    checkedVers = ExtractBetween(web.DownloadString("https://vexxed.000webhostapp.com/SimpleJect%20Version.html"), "<p>", "</p>");
                }
            }
            catch { MessageBox.Show("Unable to contact update server!"); }
            if (appVers != checkedVers)
                IsCorrectVersion = false;
            else if (appVers == checkedVers)
                IsCorrectVersion = true;     
        }

        static string ExtractBetween(string text, string start, string end)
        {
            int iStart = text.IndexOf(start);
            iStart = (iStart == -1) ? 0 : iStart + start.Length;
            int iEnd = text.LastIndexOf(end);
            if (iEnd == -1)
            {
                iEnd = text.Length;
            }
            int len = iEnd - iStart;

            return text.Substring(iStart, len);
        }
    }
}
