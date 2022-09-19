using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_mass_calculator
{
    static class Program
    {
        public static ApplicationContext Form0;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form0 = new ApplicationContext(new Form1());
            Application.Run(Form0);
        }

        public static void OpenForm(Form current, Form next)
        {
            Form0.MainForm = next;
            current.Close();
            Form0.MainForm.Show();
        }
    }
}
