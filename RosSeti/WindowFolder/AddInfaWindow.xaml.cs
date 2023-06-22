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
using System.Windows.Shapes;

namespace RosSeti.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для AddInfaWindow.xaml
    /// </summary>
    public partial class AddInfaWindow : Window
    {
        public AddInfaWindow()
        {
            InitializeComponent();
        }

        private void AddInfaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomerDogovoraTB.Text))
            {
                MBClass.ErrorMB("Введите номер договора");
                NomerDogovoraTB.Focus();
            }
            else if (string.IsNullOrWhiteSpace(EmailPokupTB.Text))
            {
                MBClass.ErrorMB("Введите почту");
                EmailPokupTB.Focus();
            }
            else if (string.IsNullOrWhiteSpace(PhonePokupTB.Text))
            {
                MBClass.ErrorMB("Введите номер телефона");
                PhonePokupTB.Focus();
            }
            else if (string.IsNullOrWhiteSpace(ZhiteTB.Text))
            {
                MBClass.ErrorMB("Введите почту");
                ZhiteTB.Focus();
            }
            else if (string.IsNullOrWhiteSpace(PassportSeriesTB.Text))
            {
                MBClass.ErrorMB("Введите серию паспорта");
                PassportSeriesTB.Focus();
            }
            else if (string.IsNullOrWhiteSpace(PassportNumberTB.Text))
            {
                MBClass.ErrorMB("Введите номер паспорта");
                PassportNumberTB.Focus();
            }
            else
            {
                try
                {
                    DBEntities.GetContext().Infa.Add(new Infa()
                    {
                        NomerDogovora = NomerDogovoraTB.Text,
                        EmailPokup = EmailPokupTB.Text,
                        PhonePokup = PhonePokupTB.Text,
                        Zhite = ZhiteTB.Text,
                        PassportSeries = PassportSeriesTB.Text,
                        PassportNumber = PassportNumberTB.Text
                    });
                    DBEntities.GetContext().SaveChanges();
                    MBClass.InfoMB("Информация успешно добавлена");
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
