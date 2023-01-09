using Launcher8.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Launcher8
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        ///// <summary>
        ///// Load embedded assemblies.
        ///// </summary>
        [STAThread]
        public static void Main()
        {
            _ = new EmbeddedAssemblyLoader();
            StartProgram();
        }

        ///// <summary>
        ///// Called after loading the neccessary assemblies.
        ///// </summary>
        public static void StartProgram()
        {
            App application = new App();
            application.InitializeComponent();
            application.Run();
        }
    }
}
