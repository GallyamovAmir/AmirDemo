using System.Linq;
using System.Windows.Controls;

namespace SewingCompany.Pages
{
    /// <summary>
    /// Interaction logic for PgProductList.xaml
    /// </summary>
    public partial class PgProductList : Page
    {
        public PgProductList()
        {
            InitializeComponent();
            DgProductList.ItemsSource = Db.Conn.Product.ToList();
        }
    }
}
