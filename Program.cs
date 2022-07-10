using FileCleaner.Controllers;
using FileCleaner.Models;
using FileCleaner.Views;
using System;
using System.Windows.Forms;

namespace FileCleaner
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Cleaner cleaner = new Cleaner();
            MainFormView mainFormView = new MainFormView();
            MainFormController mainFormController = new MainFormController(mainFormView, cleaner);

            Application.Run(mainFormView);
        }
    }
}
