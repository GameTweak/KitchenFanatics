using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenFanatics.Services
{
    //Written by Thomas
    public class LogService
    {
        /// <summary>
        /// A simple logservice, that makes a messagebox with the error message, and sends the detailed errormessage to the log (console)
        /// </summary>
        /// <param name="ex"></param>
        public void LogError(Exception ex)
        {
            MessageBox.Show(ex.Message + ", check logging for more info");
            Console.WriteLine(ex.ToString());
        }

        /// <summary>
        /// An overload of the first LogError funktion, if you want to change se second half of the errormessage in the textbox
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="message"></param>
        public void LogError(Exception ex, string message)
        {
            MessageBox.Show(ex.Message + ", " + message);
            Console.WriteLine(ex.ToString());
        }
    }
}
