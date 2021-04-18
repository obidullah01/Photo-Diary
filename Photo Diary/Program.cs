using System;
using System.Windows.Forms;

namespace mim_c_hash_new
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("ok");
            Application.Run(new Form1());

        }
    }
}
