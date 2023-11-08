using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SewingCompany.Controls
{
    /// <summary>
    /// Interaction logic for UcHeader.xaml
    /// </summary>
    public partial class UcHeader : UserControl
    {

        public string PageName
        {
            get { return LbPageName.Content.ToString(); }
            set { LbPageName.Content = value; }
        }


        public bool ExitVisible
        {
            get { return BtnExit.IsVisible; }
            set
            {
                if (!value)
                {
                    BtnExit.Visibility = Visibility.Hidden;
                }
            }
        }

        public UcHeader()
        {
            InitializeComponent();
        }


        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this.Parent).Navigate(new Uri("./../Pages/PgAuthorisation.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this.Parent).GoBack();
        }
    }
}
