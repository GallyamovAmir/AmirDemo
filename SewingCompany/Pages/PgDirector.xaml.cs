using System.Windows.Controls;

namespace SewingCompany.Pages
{
    /// <summary>
    /// Interaction logic for PgDirector.xaml
    /// </summary>
    public partial class PgDirector : Page
    {
        public PgDirector()
        {
            InitializeComponent();
            FrProductList.Navigate(new PgProductList());
        }
    }
}
