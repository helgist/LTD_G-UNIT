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
using System.Windows.Shapes;

namespace LTD_G_UNIT
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        newsaleswindow _nsw;
        public Window1(newsaleswindow nsw)
        {
            InitializeComponent();

            _nsw = nsw;

            tprice.Text = Convert.ToString(_nsw.totalprice());
        }
        //newsaleswindow nsw = new newsaleswindow();

        private void tprice_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            //tprice.Text = Convert.ToString(nsw.totalprice());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // listboxorder.Items.Ad)f
        }
    }
}
