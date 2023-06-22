using RosSeti.DataFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using RosSeti.ClassFolder;
using System.Windows.Shapes;

namespace RosSeti.PageFolder.DirectorFolder
{
    /// <summary>
    /// Логика взаимодействия для EditStaffPage.xaml
    /// </summary>
    public partial class EditStaffPage : Page
    {
        public EditStaffPage(Staff staff)
        {
            InitializeComponent();
            DataContext = staff;
            GenderCB.ItemsSource = DBEntities.GetContext()
                .Gender.ToList();
        }

        private void EditEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            Staff staff = DBEntities.GetContext().Staff.
            FirstOrDefault(s => s.IdStaff == VariableClass.StaffId);
            staff.LastNameStaff = LastNameTB.Text;
            staff.FirstNameStaff = FirstNameTB.Text;
            staff.MiddleNameStaff = MiddleNameTB.Text;
            staff.PhoneNumberStaff = PhoneNumberTB.Text;
            staff.EmailStaff = EmailTB.Text;
            staff.IdGender = Int32.Parse(GenderCB.SelectedValue.ToString());
            DBEntities.GetContext().SaveChanges();
            MBClass.InfoMB("Сотрудник успешно отредактирован");
            NavigationService.Navigate(new ListStaffPage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListStaffPage());
        }
    }
}
