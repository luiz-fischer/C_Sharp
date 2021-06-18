using System;
using System.Windows.Forms;

namespace LocaCar
{
    public class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Home());
        }
    }
}