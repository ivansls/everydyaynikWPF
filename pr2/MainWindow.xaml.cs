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

namespace pr2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime now = DateTime.Now;
        logica l = new logica();
        public MainWindow()
        {
            InitializeComponent();

            Date.Text = now.ToString();
            logica.log(Date, list);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string selected = list.Items[list.SelectedIndex].ToString();
                textbox_name.Text = selected;
                textbox_name_opis.Text = logica.op[Convert.ToInt32(list.SelectedIndex)];

            }
            catch(Exception ex) 
            { 
                textbox_name.Text = "";
                textbox_name_opis.Text = ""; 
            }
        }

        private void textbox_name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textbox_name_opis_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Dellete_Buttom_Click(object sender, RoutedEventArgs e)
        {
            logica.del(Date, list);

        }

        private void Add_Buttom_Click(object sender, RoutedEventArgs e)
        {
            logica.add(Date, list, textbox_name, textbox_name_opis);
        }

        private void Edit_Buttom_Click(object sender, RoutedEventArgs e)
        {
            logica.edit(Date, list, textbox_name, textbox_name_opis);

        }

        private void DatePicker_SelectedDateChsnged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Date_CalendarOpened(object sender, RoutedEventArgs e)
        {

        }

        private void Date_CalendarClosed(object sender, RoutedEventArgs e)
        {
            logica.log(Date, list);
        }

        
    }
}
