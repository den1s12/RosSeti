using RosSeti.ClassFolder;
using RosSeti.PageFolder.DirectorFolder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для DirectorWindow.xaml
    /// </summary>
    public partial class DirectorWindow : Window
    {
        public DirectorWindow()
        {
            InitializeComponent();
            DirectorFrame.Navigate(new ListStaffPage());
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void AddList_Click(object sender, RoutedEventArgs e)
        {
            //Process.Start("https://metanit.com/sharp/wpf/5.1.php");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new AuthorizationWindow().ShowDialog();
        }

        private void AddStorage_Click(object sender, RoutedEventArgs e)
        {
            DirectorFrame.Navigate(new AddStaffPage());
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            new AuthorizationWindow().ShowDialog();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MBClass.ExitMB();
        }
    }
}
