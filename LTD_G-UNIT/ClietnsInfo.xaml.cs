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
using System.Data;
using System.Data.SqlClient;

namespace LTD_G_UNIT
{
    /// <summary>
    /// Interaction logic for ClietnsInfo.xaml
    /// </summary>
    /// 
    public partial class ClietnsInfo : Window
    {
        Controller _contr = new Controller();
        // This method call all the clients info
        public ClietnsInfo()
        {
            InitializeComponent();
        }

        private void seebut_Click(object sender, RoutedEventArgs e)
        {

            List<Client> Clielist = _contr.getclientlist();
            foreach(Client C in Clielist )
            {
                ClientListBox.Items.Add("\nName: " + C.Name + " \nCompany Name: " + C.CompanyName + "\nAddress: " + C.Address + " \nPhone: " + C.Phone + " \nMobile No.: " + C.MobilePhone + "\nID" + C.CostumerID);
            }

       
        }
    }
}
