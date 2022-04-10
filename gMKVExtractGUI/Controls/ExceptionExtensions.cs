using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gMKVToolNix.Controls
{
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Displays a messagebox containing the message of the exception and aldo writes the exception stacktrace to the Debug console
        /// </summary>
        /// <param name="ex"></param>
        public static void ShowException(this Exception ex)
        {
            Debug.WriteLine(ex);
            MessageBox.Show(String.Format("An exception has occured!{0}{0}{1}", Environment.NewLine, ex.Message), "An exception has occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
