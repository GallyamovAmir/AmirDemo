using System;
using System.Windows;

namespace SewingCompany
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrMainFrame.Source = new Uri("./Pages/PgAuthorisation.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
