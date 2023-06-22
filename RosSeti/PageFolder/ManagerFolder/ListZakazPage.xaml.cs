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

namespace RosSeti.PageFolder.ManagerFolder
{
    /// <summary>
    /// Логика взаимодействия для ListZakazPage.xaml
    /// </summary>
    public partial class ListZakazPage : Page
    {
        public ListZakazPage()
        {
            InitializeComponent();
            ListZakazDG.ItemsSource = DBEntities.GetContext().Zakaz
               .ToList().OrderBy(u => u.IdZakaz);
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListZakazDG_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if (ListEmployeeDG.SelectedItem == null)
            //{
            //    MBClass.ErrorMB("Вы не выбрали строку");
            //}
            //else
            //{
            //    try
            //    {
            //        Zakaz zakaz = ListZakazDG.SelectedItem as Zakaz;
            //        VariableClass.ZakazId = zakaz.IdZakaz;
            //        NavigationService.Navigate(new EditEmployeePage(employee));
            //    }
            //    catch (Exception ex)
            //    {
            //        MBClass.ErrorMB(ex);
            //    }
            //}
        }

        private void EditM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteM_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
