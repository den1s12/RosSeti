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
using System.Windows.Shapes;

namespace RosSeti.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для ListInfaWindow.xaml
    /// </summary>
    public partial class ListInfaWindow : Window
    {
        public ListInfaWindow()
        {
            InitializeComponent();
            ListInfaDG.ItemsSource = DBEntities.GetContext().Infa
            .ToList().OrderBy(u => u.IdInfa);
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListInfaDG_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void EditM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteM_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
