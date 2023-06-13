using RentIt.View.Facility_Page;
using RentIt.View.Menu;
using RentIt.View.Pembatalan_1;
using RentIt.View.Pembayaran_2;
using RentIt.View.RentPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using RentIt.View.Admin_HomePage;
using RentIt.View.Admin_Proposal;
using RentIt.View.Admin_LaporanKerusakan;
using RentIt.View.Other;
using RentIt.View.LaporKerusakanModel;
using RentIt.View.Pembayaran_1;

namespace RentIt
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new LoginView());
        }
    }
}
