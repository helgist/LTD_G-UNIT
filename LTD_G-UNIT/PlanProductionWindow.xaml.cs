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
    /// Interaction logic for PlanProduction.xaml
    /// </summary>
    public partial class PlanProduction : Window
    {
        Controller _Controler =  new Controller();
       

        public PlanProduction()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
      
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            List<order> Orderlist = _Controler.getOrderlist();
            List<Product> Productlist = _Controler.getproductlist();
        }

      
    }
}
