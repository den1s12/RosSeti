﻿using RosSeti.ClassFolder;
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

namespace RosSeti.PageFolder.AdminFolder
{
    /// <summary>
    /// Логика взаимодействия для AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        public AddUserPage()
        {
            InitializeComponent();
            RoleCB.ItemsSource = DBEntities.GetContext()
             .Role.ToList();
        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTB.Text))
            {
                MBClass.ErrorMB("Введите логин");
                LoginTB.Focus();
            }
            else if (string.IsNullOrWhiteSpace(PasswordPsb.Text))
            {
                MBClass.ErrorMB("Введите пароль");
                PasswordPsb.Focus();
            }
            else if (RoleCB.SelectedIndex == -1)
            {
                MBClass.ErrorMB("Выберите роль для пользователя");
                RoleCB.Focus();
            }
            else
            {
                try
                {
                    DBEntities.GetContext().User.Add(new User()
                    {
                        Login = LoginTB.Text,
                        Password = PasswordPsb.Text,
                        IdRole = Int32.Parse(RoleCB.SelectedValue.ToString())
                    });
                    DBEntities.GetContext().SaveChanges();
                    MBClass.InfoMB("Пользователь успешно добавлен");
                    NavigationService.Navigate(new ListUserPage());
                }
                catch (Exception ex)
                {
                    MBClass.ErrorMB(ex);
                }
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListUserPage());
        }
    }
    
}
