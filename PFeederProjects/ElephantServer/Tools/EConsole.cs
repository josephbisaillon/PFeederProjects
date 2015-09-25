using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElephantServer.UI;

namespace ElephantServer.Tools
{
    public static class EConsole
    {
        /// <summary>
        /// Append text to the Elephant Console
        /// </summary>
        /// <param name="line">Output string you want on the console</param>
        public static void WriteLine(string line)
        {
            // Append the line to the Elephant Console box
            UIControls.uElephantConsole.Text += line;
        }
    }
}
