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
        
        Checkstock _checker;
        //this adds to inventory whebn worker has finished creating grades
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
        //subtracts from stock
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
        //this inserts into product table
        public void insertProductsToOrder(int orderID, string thetype, int quant)
        {
            SqlConnection Conn = new SqlConnection(
                                                  "Server=ealdb1.eal.local;" +
                                                  "Database=EJL20_DB;" +
                                                  "User ID=ejl20_usr;" +
                                                  "Password=Baz1nga20;");
            try
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand("insertProductsToOrder", Conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@orderID", orderID));
                cmd.Parameters.Add(new SqlParameter("@thetype", thetype));
                cmd.Parameters.Add(new SqlParameter("@quant", quant));
             


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
        //this inserts into order table
        public void CreateNewOrder(int orderID, string name, string Company, string telephone, string address, int costumerID , DateTime orderdate ,  string deliverydate)
            {
                SqlConnection Conn = new SqlConnection(
                                                   "Server=ealdb1.eal.local;" +
                                                   "Database=EJL20_DB;" +
                                                   "User ID=ejl20_usr;" +
                                                   "Password=Baz1nga20;");
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("CreateNewOrder", Conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@orderID", orderID));
                    cmd.Parameters.Add(new SqlParameter("@name",name));
                    cmd.Parameters.Add(new SqlParameter("@Company",Company));
                    cmd.Parameters.Add(new SqlParameter("@telephone",telephone));
                    cmd.Parameters.Add(new SqlParameter("@theaddress", address));
                    cmd.Parameters.Add(new SqlParameter("@costumerID", costumerID));
                    cmd.Parameters.Add(new SqlParameter("@dateoforder", orderdate));
                    cmd.Parameters.Add(new SqlParameter("@deliverydate", deliverydate));
                    cmd.Parameters.Add(new SqlParameter("@employe", ""));


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
        //here i retive the stock
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
        //this returns an list of costumers
        public List<Client> getlistofcostumers()
        {
            SqlConnection Conn = new SqlConnection(
                                                      "Server=ealdb1.eal.local;" +
                                                      "Database=EJL20_DB;" +
                                                      "User ID=ejl20_usr;" +
                                                      "Password=Baz1nga20;");
            List<Client> clientlist = new List<Client>();
                try
                {
                    Conn.Open();

                    SqlCommand cmd = new SqlCommand("select * from db_owner.Client", Conn);


                   
                    

                   SqlDataReader rdr = cmd.ExecuteReader();
                   while (rdr.HasRows && rdr.Read())
                        {
                           

                            string Name = rdr["Name"].ToString();
                            int Phone = Int32.Parse(rdr["Phone"].ToString());
                            int MobilePhone = Int32.Parse(rdr["MobilePhone"].ToString());
                            string Address = rdr["Address1"].ToString();
                            string CompanyName = rdr["CompanyName"].ToString();
                            int CostumerID = Int32.Parse(rdr["ID"].ToString());
                            Client clie = new Client();

                            clie.Name = Name;
                            clie.Phone = Phone;
                            clie.MobilePhone = MobilePhone;
                            clie.Address = Address;
                            clie.CompanyName = CompanyName;
                            clie.CostumerID = CostumerID;


                            clientlist.Add(clie);


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
                return clientlist;
        }
        //Here i get list of all orders from sql and ad list of products from getlistofproducts(int orderNR)
        public List<order> getlistoforders()
        {
            SqlConnection Conn = new SqlConnection(
                                                      "Server=ealdb1.eal.local;" +
                                                      "Database=EJL20_DB;" +
                                                      "User ID=ejl20_usr;" +
                                                      "Password=Baz1nga20;");
            List<order> Orderlist = new List<order>();
            try
            {
                Conn.Open();

                SqlCommand cmd = new SqlCommand("select * from db_owner.Orders", Conn);





                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.HasRows && rdr.Read())
                {

                    
                    costumer newcostumer = new costumer();

                    newcostumer.Company = rdr["company"].ToString();
                    newcostumer.Name = rdr["name"].ToString();
                    newcostumer.Telephon = rdr["telephone"].ToString();
                    newcostumer.Adress = rdr["theaddress"].ToString();

                    int orderNR = Int32.Parse(rdr["orderID"].ToString());
                    List<Product> productlist = getlistofproducts(orderNR);

                    order Order = new order();
                    Order.orderid = Int32.Parse(rdr["orderID"].ToString());
                    Order.costomer1 = newcostumer;
                    Order.Productlist = productlist;
                    Order.dateoforder = DateTime.Parse(rdr["dateoforder"].ToString());
                    Order.deliverydate = rdr["deliverydate"].ToString();

                    Orderlist.Add(Order);


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
            return Orderlist;
        }
        //Here i get the list of products according to order ID i get from getlistoforders()
        public List<Product> getlistofproducts(int orderNR)
        {
            SqlConnection Conn = new SqlConnection(
                                                     "Server=ealdb1.eal.local;" +
                                                     "Database=EJL20_DB;" +
                                                     "User ID=ejl20_usr;" +
                                                     "Password=Baz1nga20;");
            List<Product> Productlist = new List<Product>();
            try
            {
                Conn.Open();

                SqlCommand cmd = new SqlCommand("getproductlist", Conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@orderID", orderNR));


                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.HasRows && rdr.Read())
                {
                
                    int orderID = Int32.Parse(rdr["orderID"].ToString());
                    int quant = Int32.Parse(rdr["quant"].ToString());
                    string type = rdr["thetype"].ToString();
                    Product Product = new Product(quant, orderID, type);

                    Productlist.Add(Product);

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
            return Productlist;
        }
        //This returns an list of all employes and information about them
        public List<Employe> getlistofemployes()
        {
         SqlConnection Conn = new SqlConnection(
                                                     "Server=ealdb1.eal.local;" +
                                                     "Database=EJL20_DB;" +
                                                     "User ID=ejl20_usr;" +
                                                     "Password=Baz1nga20;");
            List<Employe> Employelist = new List<Employe>();
            try
            {
                Conn.Open();

                SqlCommand cmd = new SqlCommand("select * from db_owner.Employes ", Conn);
        

         


                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.HasRows && rdr.Read())
                {
                    Employe emp = new Employe();

                    emp.day = Int32.Parse(rdr["thedays"].ToString());
                    emp.orderNR = Int32.Parse(rdr["orderID"].ToString());
                    emp.name = rdr["name"].ToString();
                    

                    Employelist.Add(emp);

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
            return Employelist;
        }
        //Here i assign an worker to an order
        public void asignemployetoorder(string name, int orderID)
        {
            SqlConnection Conn = new SqlConnection(
                                               "Server=ealdb1.eal.local;" +
                                               "Database=EJL20_DB;" +
                                               "User ID=ejl20_usr;" +
                                               "Password=Baz1nga20;");
            try
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand("addemployetoorder", Conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@orderID", orderID));
               


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

        public void Addworkingdaystoemploye(int days, string name)
        {
           SqlConnection Conn = new SqlConnection(
                                               "Server=ealdb1.eal.local;" +
                                               "Database=EJL20_DB;" +
                                               "User ID=ejl20_usr;" +
                                               "Password=Baz1nga20;");
            try
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand("Addworkingdaystoemploye", Conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@days", days));
               


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
        }
    }

