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

namespace RosSeti.PageFolder.DirectorFolder
{
    /// <summary>
    /// Логика взаимодействия для AddStaffPage.xaml
    /// </summary>
    public partial class AddStaffPage : Page
    {
        public AddStaffPage()
        {
            InitializeComponent();
            GenderCB.ItemsSource = DBEntities.GetContext()
              .Gender.ToList();
        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LastNameTB.Text))
            {
                MBClass.ErrorMB("Введите фамилию");
                LastNameTB.Focus();
            }
            else if (string.IsNullOrWhiteSpace(FirstNameTB.Text))
            {
                MBClass.ErrorMB("Введите имя");
                FirstNameTB.Focus();
            }
            else if (string.IsNullOrWhiteSpace(PhoneNumberTB.Text))
            {
                MBClass.ErrorMB("Введите телефон");
                PhoneNumberTB.Focus();
            }
            else if (string.IsNullOrWhiteSpace(EmailTB.Text))
            {
                MBClass.ErrorMB("Введите почту");
                EmailTB.Focus();
            }
            else
            {
                try
                {
                    DBEntities.GetContext().Staff.Add(new Staff()
                    {
                        LastNameStaff = LastNameTB.Text,
                        FirstNameStaff = FirstNameTB.Text,
                        MiddleNameStaff = MiddleNameTB.Text,
                        PhoneNumberStaff = PhoneNumberTB.Text,
                        EmailStaff = EmailTB.Text,
                        IdGender = Int32.Parse(GenderCB.Text)
                    });
                    DBEntities.GetContext().SaveChanges();
                    MBClass.InfoMB("Сотрудник успешно добавлен");
                }
                catch (Exception ex)
                {
                    MBClass.ErrorMB(ex);
                }
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListStaffPage());
        }
    }
}
