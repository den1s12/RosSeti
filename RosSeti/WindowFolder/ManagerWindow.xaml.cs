﻿using RosSeti.PageFolder.DirectorFolder;
using RosSeti.PageFolder.ManagerFolder;
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
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
            ManagerFrame.Navigate(new ListZakazPage());
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ListBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddZakaz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
