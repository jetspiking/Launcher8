using Launcher8.Constants;
using Launcher8.Core;
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
using static Launcher8.Misc.Image;
using Application = Launcher8.Core.Application
;

namespace Launcher8.Views
{
    /// <summary>
    /// Interaction logic for Apps.xaml
    /// </summary>
    public partial class Apps : UserControl
    {
        private List<Application> applications;
        private List<Char> addedCharacters;

        public Apps()
        {
            InitializeComponent();

            LoadApps();
            InitializeSearch();

        }

        public void LoadApps()
        {
            applications = Discoverer.GetInstalledApplications().OrderBy(a => a.Name).ToList();
            addedCharacters = new List<char>();

            foreach (Application app in applications)
            {
                Char character = Char.ToUpperInvariant(app.Name[0]);

                if (!addedCharacters.Contains(character))
                {
                    AppsGrid.Children.Add(new AppOrder(character));
                    addedCharacters.Add(character);
                }
                AppListing appListing = new AppListing(app);
                AppsGrid.Children.Add(appListing);
            }
        }

        private void InitializeSearch()
        {
            SearchBox.Foreground = new SolidColorBrush(Colors.Gray);
            SearchBox.Background = new SolidColorBrush(Colors.Transparent);
            SearchBox.FontSize = Constants.Start.SearchFontSize;
            SearchBox.FontFamily = Constants.Start.StartFontFamily;
            SearchBox.BorderBrush = new SolidColorBrush(Constants.Color.FontColor);
            SearchBox.BorderThickness = new Thickness(1, 1, 1, 1);
            SearchBox.Text = Text.Search;

            SearchBox.GotFocus += (searchBoxObject, keyboardFocusChangedEvent) =>
            {
                ((TextBox)searchBoxObject).Text = String.Empty;
                ((TextBox)searchBoxObject).Foreground = new SolidColorBrush(Colors.White);
            };

            SearchBox.TextChanged += (searchBoxObject, keyboardFocusChangedEvent) =>
            {
                AppsGrid.Children.Clear();
                addedCharacters.Clear();

                foreach (Application app in applications)
                {
                    if (app.Name.Trim().ToLower().Contains(((TextBox)searchBoxObject).Text.Trim().ToLower())) {
                        Char character = Char.ToUpperInvariant(app.Name[0]);

                        if (!addedCharacters.Contains(character))
                        {
                            AppsGrid.Children.Add(new AppOrder(character));
                            addedCharacters.Add(character);
                        }
                        AppListing appListing = new AppListing(app);
                        AppsGrid.Children.Add(appListing);
                    }
                }
            };
        }

    }
}
