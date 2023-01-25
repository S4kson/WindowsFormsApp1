using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.IO;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string currentDirectoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            if (!File.Exists($"{currentDirectoryPath}\\dataBase.db"))
            {
                new Database("Data Source=dataBase.db;Version=3;").InitializeDatabase();
            }
            Application.Run(new formLoginSystem());
        }
    }
}
