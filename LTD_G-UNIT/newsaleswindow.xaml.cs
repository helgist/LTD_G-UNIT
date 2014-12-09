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
    /// Interaction logic for newsaleswindow.xaml
    /// </summary>
    public partial class newsaleswindow : Window
    {



        List<int> Pricelist;  // = new List<int>();
        List<Product> productlist = new List<Product>();


        ControllerForWindows _contr = new ControllerForWindows();
        DatabaseController _datacontro = new DatabaseController();

        public newsaleswindow()
        {
            InitializeComponent();

            Pricelist = new List<int>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //invoic inv = new invoic();
            //inv.Show();  
            Controller _Controller = new Controller();
            _Controller = new Controller();






            if (int.Parse(type_A.Text) != 0)
            {

                Product product1 = new Product("type1", int.Parse(type_A.Text), 2300);
                productlist.Add(product1);
                Pricelist.Add(int.Parse(type_A.Text) * 2300);
                try
                {
                    _Controller.MakeNewSale("type1", int.Parse(type_A.Text), 2300);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }




            }
            if (int.Parse(type_B.Text) != 0)
            {
                Product product2 = new Product("type2", int.Parse(type_B.Text), 2200);
                productlist.Add(product2);
                Pricelist.Add(int.Parse(type_B.Text) * 2200);
                try
                {
                    _Controller.MakeNewSale("type2", int.Parse(type_B.Text), 2200);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }


            }
            if (int.Parse(type_C.Text) != 0)
            {
                Product product3 = new Product("type3", int.Parse(type_C.Text), 2400);
                productlist.Add(product3);
                Pricelist.Add(int.Parse(type_C.Text) * 2400);

                try
                {
                    _Controller.MakeNewSale("type3", int.Parse(type_C.Text), 2400);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }
            }

            if (int.Parse(type_D.Text) != 0)
            {
                Product product4 = new Product("type4", int.Parse(type_D.Text), 2500);
                productlist.Add(product4);
                Pricelist.Add(int.Parse(type_D.Text) * 2500);
                try
                {
                    _Controller.MakeNewSale("type4", int.Parse(type_D.Text), 2500);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }
            }
            if (int.Parse(type_E.Text) != 0)
            {
                Product product5 = new Product("type5", int.Parse(type_E.Text), 2600);
                productlist.Add(product5);
                Pricelist.Add(int.Parse(type_E.Text) * 2600);
                try
                {
                    _Controller.MakeNewSale("type5", int.Parse(type_E.Text), 2600);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }

            }
            if (int.Parse(type_G.Text) != 0)
            {
                Product product6 = new Product("type6", int.Parse(type_G.Text), 2700);
                productlist.Add(product6);
                Pricelist.Add(int.Parse(type_G.Text) * 2700);

                try
                {
                    _Controller.MakeNewSale("type6", int.Parse(type_F.Text), 2700);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }

            }
            if (int.Parse(type_H.Text) != 0)
            {
                Product product7 = new Product("type7", int.Parse(type_H.Text), 2800);
                productlist.Add(product7);
                Pricelist.Add(int.Parse(type_H.Text) * 2800);

                try
                {
                    _Controller.MakeNewSale("type7", int.Parse(type_G.Text), 2800);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }

            }
            if (int.Parse(Type_I.Text) != 0)
            {
                Product product8 = new Product("type8", int.Parse(Type_I.Text), 2900);
                productlist.Add(product8);
                Pricelist.Add(int.Parse(Type_I.Text) * 2900);
                try
                {
                    _Controller.MakeNewSale("type8", int.Parse(type_H.Text), 2900);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }

            }
            if (int.Parse(type_J.Text) != 0)
            {
                Product product9 = new Product("type9", int.Parse(type_J.Text), 3000);
                productlist.Add(product9);
                Pricelist.Add(int.Parse(type_J.Text) * 3000);
                try
                {
                    _Controller.MakeNewSale("type9", int.Parse(type_J.Text), 3000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }

            }
            if (int.Parse(type_K.Text) != 0)
            {
                Product product10 = new Product("type11", int.Parse(type_K.Text), 3100);
                productlist.Add(product10);
                Pricelist.Add(int.Parse(type_K.Text) * 3100);
                try
                {
                    _Controller.MakeNewSale("type11", int.Parse(type_K.Text), 3100);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }
            }
            if (int.Parse(type_L.Text) != 0)
            {
                Product product11 = new Product("type12", int.Parse(type_L.Text), 3200);
                productlist.Add(product11);
                Pricelist.Add(int.Parse(type_L.Text) * 3200);
                try
                {
                    _Controller.MakeNewSale("type12", int.Parse(type_L.Text), 3200);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }

            }
            if (int.Parse(Type_I.Text) != 0)
            {
                Product product12 = new Product("type13", int.Parse(Type_I.Text), 3300);
                productlist.Add(product12);
                Pricelist.Add(int.Parse(Type_I.Text) * 3300);
                try
                {
                    _Controller.MakeNewSale("type13", int.Parse(Type_I.Text), 3300);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }

            }
            if (int.Parse(type_M.Text) != 0)
            {
                Product product13 = new Product("type14", int.Parse(type_M.Text), 3400);
                productlist.Add(product13);
                Pricelist.Add(int.Parse(type_M.Text) * 3400);
                try
                {
                    _Controller.MakeNewSale("type14", int.Parse(type_M.Text), 3400);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }
            }
            if (int.Parse(type_N.Text) != 0)
            {
                Product product14 = new Product("type15", int.Parse(type_N.Text), 3500);
                productlist.Add(product14);
                Pricelist.Add(3500 * int.Parse(type_N.Text));
                try
                {
                    _Controller.MakeNewSale("type15", int.Parse(type_N.Text), 3500);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }

            }
            if (int.Parse(type_S.Text) != 0)
            {
                Product product15 = new Product("type16", int.Parse(type_S.Text), 3600);
                productlist.Add(product15);
                Pricelist.Add(3600 * int.Parse(type_S.Text));
                try
                {
                    _Controller.MakeNewSale("type16", int.Parse(type_S.Text), 3600);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQL conection error " + ex.Message);

                }

            }
            else 
            {
                MessageBox.Show("no product to order");
            }
            Window1 wn1 = new Window1(this);

            wn1.listboxorder.Items.Add("Name: " + namebox.Text + "\nAddress: " + Address.Text + "\nCompany: " + Company.Text + "\nDeliverydate: " + Deliverydate.Text);
            foreach (Product p in productlist)
            {
                wn1.listboxorder.Items.Add(p.type + " Qantity " + p.quant);
            }
            wn1.Show();


            _Controller.createnewOrder(namebox.Text, Phone.Text, Address.Text, Company.Text, productlist, Deliverydate.Text, int.Parse(IDtextbox.Text));
            this.Close();
        }
        //this method return the total price of products
        public int totalprice()
        {
            int totalpric = 0;

            foreach (int p in Pricelist)
            {
                totalpric += p;

            }
            return totalpric;

        }


        //Fill out automaticly the sale sheed after costumer ID
        private void FindIfId_Click(object sender, RoutedEventArgs e)
        {


            List<Client> Clielist = _contr.getclientlist();



            List<Client> IDsearch = Clielist.FindAll(delegate(Client m) { return m.CostumerID == int.Parse(IDtextbox.Text); });
            IDsearch.ForEach(delegate(Client m)
            {
                namebox.Text = m.Name;
                Address.Text = m.Address;
                Phone.Text = m.Phone.ToString();
                Company.Text = m.CompanyName;

            });
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

           
        }
        }
    


