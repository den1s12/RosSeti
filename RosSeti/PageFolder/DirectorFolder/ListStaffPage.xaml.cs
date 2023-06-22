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
    /// Логика взаимодействия для ListStaffPage.xaml
    /// </summary>
    public partial class ListStaffPage : Page
    {
        public ListStaffPage()
        {
            InitializeComponent();
            ListEmployeeDG.ItemsSource = DBEntities.GetContext().Staff
              .ToList().OrderBy(u => u.IdStaff);
        }

        private void DeleteM_Click(object sender, RoutedEventArgs e)
        {
            Staff staff = ListEmployeeDG.SelectedItem as Staff;

            if (ListEmployeeDG.SelectedItem == null)
            {
                MBClass.ErrorMB("Выберите сотрудника" +
                    "для удаления");
            }
            else
            {
                if (MBClass.QuestionMB("Удалить" +
                    $"сотрудника с фамилией" +
                    $"{staff.LastNameStaff}?"))
                {
                    DBEntities.GetContext().Staff.Remove(staff);
                    DBEntities.GetContext().SaveChanges();

                    MessageBox.Show("Сотрудник удален");
                    ListEmployeeDG.ItemsSource = DBEntities.GetContext()
                        .Staff.ToList().OrderBy(u => u.LastNameStaff);
                }
            }
        }

        private void EditM_Click(object sender, RoutedEventArgs e)
        {
            if (ListEmployeeDG.SelectedItem == null)
            {
                MBClass.ErrorMB("Выберите " +
                    "сотрудника для редактирования");
            }

            Staff staff = ListEmployeeDG.SelectedItem as Staff;
            VariableClass.StaffId = staff.IdStaff;
            NavigationService.Navigate(new EditStaffPage(staff));
        }

        private void ListEmployeeDG_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ListEmployeeDG.SelectedItem == null)
            {
                MBClass.ErrorMB("Вы не выбрали строку");
            }
            else
            {
                try
                {
                    Staff staff = ListEmployeeDG.SelectedItem as Staff;
                    VariableClass.StaffId = staff.IdStaff;
                    NavigationService.Navigate(new EditStaffPage(staff));
                }
                catch (Exception ex)
                {
                    MBClass.ErrorMB(ex);
                }
            }
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
