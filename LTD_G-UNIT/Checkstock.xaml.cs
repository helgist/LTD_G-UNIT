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

namespace LTD_G_UNIT
{
    /// <summary>
    /// Interaction logic for Checkstock.xaml
    /// </summary>
    public partial class Checkstock : Window
    {
        DatabaseController _Databasecontroller;
        public Checkstock()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {

            listboxstock.Items.Add("300" + " Johann " + 300);
            _Databasecontroller.seestock();
        }
    }
}
