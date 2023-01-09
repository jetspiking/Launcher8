using Launcher8.Constants;
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
    public partial class AppOrder : UserControl
    {
        public AppOrder(Char character)
        {
            InitializeComponent();

            Character.Content = character;
            Character.Foreground = new SolidColorBrush(Constants.Color.FontColor);
            Character.FontSize = Constants.Start.LetterFontSize;
            Border.BorderBrush = new SolidColorBrush(Constants.Color.FontColor);
            Border.BorderThickness = new Thickness(1, 1, 1, 1);
        }

    }
}
