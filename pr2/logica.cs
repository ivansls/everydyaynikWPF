using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace pr2
{
    internal class logica
    {
        //DateTime now = DateTime.Now;
        string f;
        public void log(DatePicker Date, ListBox list)

        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("14.02.2023 0:00:00", "lalala");
            /*DateTime dt = Date.DisplayDate;

            string f = Date.SelectedDate.ToString();*/
            MessageBox.Show(f);
            /*foreach (string s in dic.Keys)
            {
                if (f == s)
                {
                    list.ItemsSource = dic[f];
                }
            }*/
            
            /*Date.Text = now.ToString();
            Date.Text = now.AddDays(1).ToString();*/
        }

    }
}
