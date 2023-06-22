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
    /// Логика взаимодействия для AddZakazPage.xaml
    /// </summary>
    public partial class AddZakazPage : Page
    {
        public AddZakazPage()
        {
            InitializeComponent();
            NameCableCB.ItemsSource = DBEntities.GetContext()
            .Cabel.ToList();
            DogovorCB.ItemsSource = DBEntities.GetContext()
            .Infa.ToList();
        }

        private void AddZakazBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBEntities.GetContext().Zakaz.Add(new Zakaz()
                {
                    IdCable = Int32.Parse(NameCableCB.SelectedValue.ToString()),
                    IdInfa = Int32.Parse(DogovorCB.SelectedValue.ToString()),
                    Address = AdressTb.Text                    
                });
                DBEntities.GetContext().SaveChanges();
                MBClass.InfoMB("Пользователь успешно добавлен");
                NavigationService.Navigate(new ListZakazPage());
            }
            catch (Exception ex)
            {
                MBClass.ErrorMB(ex);
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListZakazPage());
        }

        private void Cable_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            new AddCableWindow().ShowDialog();
        }

        private void Dogovor_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            new AddInfaWindow().ShowDialog();
        }
    }
}
