using RosSeti.ClassFolder;
using RosSeti.DataFolder;
using RosSeti.PageFolder.AdminFolder;
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
    /// Логика взаимодействия для EditZakazPage.xaml
    /// </summary>
    public partial class EditZakazPage : Page
    {
        public EditZakazPage(Zakaz zakaz)
        {
            InitializeComponent();
            DataContext = zakaz;
            NameCableCB.ItemsSource = DBEntities.GetContext()
             .Cabel.ToList();
            DogovorCB.ItemsSource = DBEntities.GetContext()
            .Infa.ToList();
        }

        private void EditZakazBtn_Click(object sender, RoutedEventArgs e)
        {
            Zakaz zakaz = DBEntities.GetContext().Zakaz.
                         FirstOrDefault(s => s.IdZakaz == VariableClass.ZakazId);
            zakaz.Address = AdressTb.Text;
            zakaz.IdCable = Int32.Parse(NameCableCB.SelectedValue.ToString());
            zakaz.IdInfa = Int32.Parse(DogovorCB.SelectedValue.ToString());
            DBEntities.GetContext().SaveChanges();
            MBClass.InfoMB("Успешно отредактировано");
            NavigationService.Navigate(new ListZakazPage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListZakazPage());
        }
    }
}
