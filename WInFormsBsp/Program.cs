namespace WinFormsBsp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //In grafischen Anwendungen ruf die Main()-Methode standartm�ig das erste Fenster auf
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}