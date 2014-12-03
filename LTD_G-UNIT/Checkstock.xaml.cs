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
    /// Interaction logic for Checkstock.xaml
    /// </summary>
    public partial class Checkstock : Window
    {
        DatabaseController _Databasecontroller = new DatabaseController();
        public Checkstock()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
             
             SqlConnection Conn = new SqlConnection(
                                                      "Server=ealdb1.eal.local;" +
                                                      "Database=EJL20_DB;" +
                                                      "User ID=ejl20_usr;" +
                                                      "Password=Baz1nga20;");
                try
                {
                    Conn.Open();

                    SqlCommand cmd = new SqlCommand("getstock", Conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                   SqlDataReader rdr = cmd.ExecuteReader();

                   while (rdr.HasRows && rdr.Read())
                        {
                          listboxstock.Items.Add("Product: " + rdr["Grade"] + " - In stock; " + rdr["Quantity"] + "  Price: " + rdr["prise"]);
                      
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
