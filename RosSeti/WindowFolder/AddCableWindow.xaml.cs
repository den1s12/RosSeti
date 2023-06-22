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

namespace RosSeti.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для AddCableWindow.xaml
    /// </summary>
    public partial class AddCableWindow : Window
    {
        public AddCableWindow()
        {
            InitializeComponent();
        }

        private void AddCableBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameCableTB.Text))
            {
                MBClass.ErrorMB("Введите название кабеля");
                NameCableTB.Focus();
            }
            else if (string.IsNullOrWhiteSpace(TypeCableTB.Text))
            {
                MBClass.ErrorMB("Введите тип кабеля");
                TypeCableTB.Focus();
            }          
            else
            {
                try
                {
                    DBEntities.GetContext().Cabel.Add(new Cabel()
                    {
                        NameCable = NameCableTB.Text,
                        TypeCable = TypeCableTB.Text
                    });
                    DBEntities.GetContext().SaveChanges();
                    MBClass.InfoMB("Кабель успешно добавлен");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MBClass.ErrorMB(ex);
                }
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
