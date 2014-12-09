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
    public partial class ClietnsInfo : Window
    {
        // This method call all the clients info
        public ClietnsInfo()
        {
            InitializeComponent();
        }

        private void seebut_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection Conn = new SqlConnection(
                                                    "Server=ealdb1.eal.local;" +
                                                    "Database=EJL20_DB;" +
                                                    "User ID=ejl20_usr;" +
                                                    "Password=Baz1nga20;");
            try
            {
                Conn.Open();

                SqlCommand cmd = new SqlCommand("listallclient", Conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.HasRows && rdr.Read())
                {
                    ClientListBox.Items.Add("\nName: " + rdr["Name"] + " \nCompany Name: " + rdr["CompanyName"] + "\nAddress: " + rdr["Address1"] + " \nPhone: " + rdr["Phone"] + " \nMobile No.: " + rdr["MobilePhone"] + "\nID" + rdr["ID"]);

                }
            }
            catch (SqlException x)
            {
                Console.WriteLine("conection error " + x.Message);
            }

            finally
            {
                Conn.Close();
                Conn.Dispose();
            }  
        }
    }
}
