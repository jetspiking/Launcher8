using Launcher8.Core;
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

namespace Launcher8.Views
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class AppListing : UserControl
    {
        public AppListing(Core.Application application)
        {
            InitializeComponent();

            Icon.Source = application.Icon;
            Title.Content = application.Name;
            Title.Foreground = new SolidColorBrush(Constants.Color.FontColor);

            this.MouseDown += (Object sender, MouseButtonEventArgs e) =>
            {
                Discoverer.LaunchApplication(application);
            };
        }
    }
}
