using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenFanatics.Services
{
    public class LogService
    {
        public void LogError(Exception ex)
        {
            MessageBox.Show(ex.Message + ", check logging for more info");
            Console.WriteLine(ex.ToString());
        }

        public void LogError(Exception ex, string message)
        {
            MessageBox.Show(ex.Message + ", " + message);
            Console.WriteLine(ex.ToString());
        }
    }
}
