﻿using System;
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

namespace pr2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //logica l = new logica();
        public MainWindow()
        {
            InitializeComponent();
            /*Date.Text = now.ToString();
            Date.Text = now.AddDays(1).ToString();*/
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textbox_name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textbox_name_opis_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Dellete_Buttom_Click(object sender, RoutedEventArgs e)
        {
            //l.log(Date, list);
        }

        private void Add_Buttom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Edit_Buttom_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void DatePicker_SelectedDateChsnged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
