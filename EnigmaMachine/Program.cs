using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaMachine
{

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        public static int[] buffer = new int[3] { 0,1,2 };

        public static char[][] Mass_of_buffers = new char[][]
        {
            new char[26] { 'P','E','Z','U','O','H','X','S','C','V','F','M','T','B','G','L','R','I','N','Q','J','W','A','Y','D','K' },
            new char[26] { 'Z','O','U','E','S','Y','D','K','F','W','P','C','I','Q','X','H','M','V','B','L','G','N','J','R','A','T' },
            new char[26] { 'E','H','R','V','X','G','A','O','B','Q','U','S','I','M','Z','F','L','Y','N','W','K','T','P','D','J','C' },
        };

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
