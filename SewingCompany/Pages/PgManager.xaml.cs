using System.Windows.Controls;

namespace SewingCompany.Pages
{
    /// <summary>
    /// Interaction logic for PgManager.xaml
    /// </summary>
    public partial class PgManager : Page
    {
        public PgManager()
        {
            InitializeComponent();
            FrProductList.Navigate(new PgProductList());
            FrOrders.Navigate(new PgOrders());
            
        }

    }
}
