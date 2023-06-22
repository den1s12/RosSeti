using RosSeti.ClassFolder;
using RosSeti.PageFolder.AdminFolder;
using RosSeti.PageFolder.DirectorFolder;
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
using System.Windows.Shapes;

namespace RosSeti.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            AdminFrame.Navigate(new ListUserPage());
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ListBtn_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new ListUserPage());
        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new AddUserPage());
        }

        private void ChangeProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new AuthorizationWindow().ShowDialog();
        }

        private void CloseImg_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MBClass.ExitMB();
        }
    }
}
