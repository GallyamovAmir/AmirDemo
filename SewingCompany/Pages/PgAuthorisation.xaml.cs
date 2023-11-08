using SewingCompany.Utilities;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SewingCompany.Pages
{
    /// <summary>
    /// Interaction logic for PgAuthorisation.xaml
    /// </summary>
    public partial class PgAuthorisation : Page
    {
       

        public PgAuthorisation()
        {
            InitializeComponent();
            TbLoginLogin.Focus();

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = Db.Conn.User.Where(u => u.Login == TbLoginLogin.Text && u.Password == PbLoginPassword.Password).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
            else
            {
                Transfer.LoggedUser = user;
                switch (user.IdRole)
                {
                    case 1:
                        NavigationService.Navigate(new PgCustomer());
                        break;
                    case 2:
                        NavigationService.Navigate(new PgManager());
                        break;
                    case 3:
                        NavigationService.Navigate(new PgStockman());
                        break;
                    case 4:
                        NavigationService.Navigate(new PgDirector());
                        break;
                }
            }
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
           
            
            if((TbRegLogin.Text != string.Empty) && 
                (PbRegPassword.Password == PbRegPasswordRepeat.Password))
     
            {
                if (Db.Conn.User.Where(u => u.Login == TbRegLogin.Text).FirstOrDefault() == null)
                {
                    User user = new User();
                    user.Login = TbRegLogin.Text;
                    user.Password = PbRegPassword.Password;
                    user.IdRole = 1;
                    Db.Conn.User.Add(user);
                    Db.Conn.SaveChanges();

                    MessageBox.Show("Регистрация прошла успешно!");
                    TbRegLogin.Text = string.Empty;
                    PbRegPassword.Password = string.Empty;
                    PbRegPasswordRepeat.Password = string.Empty;
                }
                else
                    MessageBox.Show("Данный логин уже занят.");
            }
        }

    }
}
