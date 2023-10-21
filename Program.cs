using Supermarket_mvp._Repositorios;
using Supermarket_mvp.Modelos;
using Supermarket_mvp.Presentador;
using Supermarket_mvp.Properties;
using Supermarket_mvp.Vista;

namespace Supermarket_mvp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //ApplicationConfiguration.Initialize();
            //string sqlConnectionString = Settings.Default.SqlConnection;
            //IPayModeView view = new PayModeView();
            //IPayModeRepository reposity = new PayModeRepository(sqlConnectionString);
            //new PayModePresenter(view, reposity);
            //Application.Run((Form)view);


            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            IMainView view = new MainView();
            IPayModeRepository reposity = new PayModeRepository(sqlConnectionString);
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}