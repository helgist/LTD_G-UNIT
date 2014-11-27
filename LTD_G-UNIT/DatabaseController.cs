using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LTD_G_UNIT
{
    class DatabaseController
    {
        public void AddItemsToInventory(string type, int addtostock)
        {

            SqlConnection Conn = new SqlConnection(
                                                   "Server=ealdb1.eal.local;" +
                                                   "Database=EJL20_DB;" +
                                                   "User ID=ejl20_usr;" +
                                                   "Password=Baz1nga20;");
            try
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand("addgradestoinventory", Conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Grade", type));
                cmd.Parameters.Add(new SqlParameter("@Quantity", addtostock));


                cmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine("conection error " + e.Message);
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }
        }

            public void NewSaleMade(string type, int addtostock)
        {
            
            SqlConnection Conn = new SqlConnection(
                                                   "Server=ealdb1.eal.local;" +
                                                   "Database=EJL20_DB;" +
                                                   "User ID=ejl20_usr;" +
                                                   "Password=Baz1nga20;");
            try
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand("MakeNewSale", Conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Grade", type));
                cmd.Parameters.Add(new SqlParameter("@Quantity", addtostock));


                cmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine("conection error " + e.Message);
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

        }
    }
}
