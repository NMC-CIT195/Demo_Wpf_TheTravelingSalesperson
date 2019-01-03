using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Demo_Wpf_TheTravelingSalesperson.BusinessLayer;

namespace Demo_Wpf_TheTravelingSalesperson
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_Startup(object sender, StartupEventArgs e)
        {
            SalesTrackerBL salesTrackerBL = new SalesTrackerBL();
        }
    }
}
