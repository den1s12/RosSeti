using RosSeti.ClassFolder;
using RosSeti.DataFolder;
using RosSeti.PageFolder.AdminFolder;
using RosSeti.WindowFolder;
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
            if (ListZakazDG.SelectedItem == null)
            {
                MBClass.ErrorMB("Вы не выбрали строку");
            }
            else
            {
                try
                {
                    Zakaz zakaz = ListZakazDG.SelectedItem as Zakaz;
                    VariableClass.ZakazId = zakaz.IdZakaz;
                    NavigationService.Navigate(new EditZakazPage(zakaz));
                }
                catch (Exception ex)
                {
                    MBClass.ErrorMB(ex);
                }
            }
        }

        private void EditM_Click(object sender, RoutedEventArgs e)
        {
            if (ListZakazDG.SelectedItem == null)
            {
                MBClass.ErrorMB("Выберите " +
                    "пользователя для редактирования");
            }

            Zakaz zakaz = ListZakazDG.SelectedItem as Zakaz;
            VariableClass.ZakazId = zakaz.IdZakaz;
            NavigationService.Navigate(new EditZakazPage(zakaz));
        }

        private void DeleteM_Click(object sender, RoutedEventArgs e)
        {
            Zakaz zakaz = ListZakazDG.SelectedItem as Zakaz;

            if (ListZakazDG.SelectedItem == null)
            {
                MBClass.ErrorMB("Выберите пользователя" +
                    "для удаления");
            }
            else
            {
                if (MBClass.QuestionMB("Удалить заказ?"))
                {
                    DBEntities.GetContext().Zakaz.Remove(zakaz);
                    DBEntities.GetContext().SaveChanges();

                    MessageBox.Show("Заказ удален");
                    ListZakazDG.ItemsSource = DBEntities.GetContext()
                        .Zakaz.ToList().OrderBy(u => zakaz.IdZakaz);
                }
            }
        }

        private void InfaM_Click(object sender, RoutedEventArgs e)
        {
            new ListInfaWindow().ShowDialog();
        }
    }
}
