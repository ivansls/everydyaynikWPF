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
        string f;
        public static List<string> op = new List<string>();
        public static string ti = "";
        public static List<my_type> type = desir.MyDesirialize<List<my_type>>();
        public static my_type my;
        public static void log(DatePicker Date, ListBox list)
        {
            list.ItemsSource = "";

            foreach (my_type i in type)
            {
                if (i.Time.ToString() == Date.Text.ToString())
                {
                    list.ItemsSource = i.Name;
                    op = i.Opis;
                }
                

            }
            

        }

        public static void del(DatePicker Date, ListBox list)
        {
            try
            {
                foreach (my_type k in type)
                {
                    string item = list.Items[list.SelectedIndex].ToString();
                    try
                    {

                        foreach (string v in k.Name)
                        {
                            if (v == item && Date.Text == k.Time)
                            {
                                int i = k.Name.IndexOf(v);
                                k.Name.RemoveAt(i);
                                k.Opis.RemoveAt(i);

                                if (k.Name.Count == 0)
                                {
                                    int c = type.IndexOf(k);
                                    type.RemoveAt(c);
                                }
                                desir.MySerialeze(type);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        type = desir.MyDesirialize<List<my_type>>();
                        log(Date, list);
                    }

                }
            }
            catch(Exception ex)
            {
                type = desir.MyDesirialize<List<my_type>>();
                log(Date, list);
            }


        }

        public static void add(DatePicker Date, ListBox list, TextBox textbox_name, TextBox textbox_name_opis)
        {
            if (list.ItemsSource == "")
            {
                my_type add_type = new my_type();
                add_type.Time = Date.Text;
                add_type.Name.Add(textbox_name.Text);
                add_type.Opis.Add(textbox_name_opis.Text);

                type.Add(add_type);
                desir.MySerialeze(type);
                type = desir.MyDesirialize<List<my_type>>();
                log(Date, list);
            }
            else
            {
                foreach(my_type t in type)
                {
                    //string item = list.Items[list.SelectedIndex].ToString();
                    if (t.Time.ToString() == Date.Text.ToString())
                    {
                        t.Name.Add(textbox_name.Text);
                        t.Opis.Add(textbox_name_opis.Text);
                        desir.MySerialeze(type);
                    }
                }
                type = desir.MyDesirialize<List<my_type>>();
                log(Date, list);
            }
        }

        public static void edit(DatePicker Date, ListBox list, TextBox textbox_name, TextBox textbox_name_opis)
        {
            foreach (my_type k in type)
            {
                try
                {
                    string item = list.Items[list.SelectedIndex].ToString();
                    try
                    {
                        foreach (string v in k.Name)
                        {
                            if (v == item && Date.Text == k.Time)
                            {
                                int i = k.Name.IndexOf(v);
                                k.Name.RemoveAt(i);
                                k.Opis.RemoveAt(i);
                                k.Name.Add(textbox_name.Text);
                                k.Opis.Add(textbox_name_opis.Text);
                                desir.MySerialeze(type);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        type = desir.MyDesirialize<List<my_type>>();
                        log(Date, list);
                    }
                }
                catch (Exception ex)
                {
                    continue;
                }

            }
        }
        
        



    }
}
