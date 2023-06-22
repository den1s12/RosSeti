using RosSeti.ClassFolder;
using RosSeti.DataFolder;
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

namespace RosSeti.PageFolder.AdminFolder
{
    /// <summary>
    /// Логика взаимодействия для EditUserPage.xaml
    /// </summary>
    public partial class EditUserPage : Page
    {
        public EditUserPage(User user)
        {
            InitializeComponent();
            DataContext = user;
            RoleCB.ItemsSource = DBEntities.GetContext()
                .Role.ToList();
        }

        private void EditUserBtn_Click(object sender, RoutedEventArgs e)
        {
            User user = DBEntities.GetContext().User.
                         FirstOrDefault(s => s.IdUser == VariableClass.UserId);
            user.Login = LoginTB.Text;
            user.Password = PasswordPsb.Text;
            user.IdRole = Int32.Parse(RoleCB.SelectedValue.ToString());
            DBEntities.GetContext().SaveChanges();
            MBClass.InfoMB("Пользователь успешно отредактирован");
            NavigationService.Navigate(new ListUserPage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListUserPage());
        }
    }
}
