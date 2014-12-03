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
        //hello helgi
        Product _product ;
        Checkstock _checker;
        
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
                Console.WriteLine("SQL conection error " + e.Message);
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
                Console.WriteLine("SQL conection error " + e.Message);
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

        }

        public void CalculatePrice(string type)
            {
                SqlConnection Conn = new SqlConnection(
                                                      "Server=ealdb1.eal.local;" +
                                                      "Database=EJL20_DB;" +
                                                      "User ID=ejl20_usr;" +
                                                      "Password=Baz1nga20;");
                try
                {
                    Conn.Open();

                    SqlCommand cmd = new SqlCommand("getprice", Conn);
                    cmd.Parameters.Add(new SqlParameter("@Grade", type));

                    SqlDataReader getprice = cmd.ExecuteReader();

                    if (getprice.HasRows)
                    {
                        while (getprice.Read())
                        {
                            Console.WriteLine("{0}", getprice.GetInt32(0),
                                getprice.GetString(1));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Price found.");
                    }
                    getprice.Close();

                }
                catch (SqlException e)
                {
                    Console.WriteLine("SQL conection error " + e.Message);
                }
                finally
                {
                    Conn.Close();
                    Conn.Dispose();
                }


            }
        //CONNECT NEW CLIENT TO THE DATABASE
        public void AddClient(string Name,string CompanyName , string Address1,int Phone, int MobilePhone)
        {
            SqlConnection Conn = new SqlConnection(
                                                  "Server=ealdb1.eal.local;" +
                                                  "Database=EJL20_DB;" +
                                                  "User ID=ejl20_usr;" +
                                                  "Password=Baz1nga20;");
            try
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand("Insertclient", Conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Name", Name));
                cmd.Parameters.Add(new SqlParameter("@CompanyName", CompanyName));
                cmd.Parameters.Add(new SqlParameter("@Address1", Address1));
                cmd.Parameters.Add(new SqlParameter("@Phone", Phone));
                cmd.Parameters.Add(new SqlParameter("@MobilePhone", MobilePhone));


                cmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine("SQL conection error " + e.Message);
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }
        }

        public void seestock()
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

                    _checker = new Checkstock();

                   SqlDataReader rdr = cmd.ExecuteReader();
                   while (rdr.HasRows && rdr.Read())
                        {

                            

                            _checker.listboxstock.Items.Add("Product: " + rdr["Grade"] + " - In stock; " + rdr["Quantity"] + "  Price: " + rdr["prise"]);
                       
                        }

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
