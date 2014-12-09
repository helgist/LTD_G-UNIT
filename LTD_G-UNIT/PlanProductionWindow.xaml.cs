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


            foreach (order O in Orderlist)
            {
                Orderlistbox.Items.Add("Order ID: " + O.orderid + " Delivery date: " + O.deliverydate);

                foreach (Product P in O.Productlist)
                {
                    Orderlistbox.Items.Add(P.type + " Quantity " + P.quant);
                }
            }

            List<Employe> employlist = _Controler.getemploylist();
            List<Employe> SortedList = employlist.OrderBy(o => o.day).ToList();

            foreach (Employe E in SortedList)
            {
                Employelistbox.Items.Add(E.name + "\n" + "Availeble in " + E.day);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            int Orderid = int.Parse(OrderID.Text);
            string Employe = Employetoassign.Text;
            int days = int.Parse(Daysforproject.Text);

            _Controler.assignemployetoorder(Employe, Orderid);
            _Controler.Addworkingdaystoemploye(days, Employe);
            MessageBox.Show("You have assingned " + Employe + "\nTo Order " + Orderid + "\nfor " + days + " days");
        }

      
    }
}
