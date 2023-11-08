using System.Windows.Controls;


namespace SewingCompany.Pages
{
    /// <summary>
    /// Interaction logic for PgCustomer.xaml
    /// </summary>
    public partial class PgCustomer : Page
    {
        public PgCustomer()
        {
            InitializeComponent();
            FrCustomerOrderMenu.Navigate(new PgOrders());
        }
    }
}
