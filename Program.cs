using System;
using System.Windows.Forms;
using MVP_Project.Views;
using MVP_Project._Repositories;
using MVP_Project.Presenters;
using MVP_Project.Models;
using System.Configuration;

namespace MVP_Project

{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView view = new MainView();
            
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}