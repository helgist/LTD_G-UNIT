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


        
        List<double> Pricelist = new List<double>();
        List<Product> productlist = new List<Product>();       

       
        ControllerForWindows _contr = new ControllerForWindows();
        DatabaseController _datacontro = new DatabaseController();

        public newsaleswindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 wn1 = new Window1();
            wn1.Show();
            //invoic inv = new invoic();
            //inv.Show();  
            Controller _Controller = new Controller();
            _Controller = new Controller();
            try
            {
                _Controller.MakeNewSale("type1", int.Parse(type_A.Text), 2300);
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type2", int.Parse(type_B.Text), 2200);
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type3", int.Parse(type_C.Text), 2400);
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type4", int.Parse(type_D.Text), 2500);
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type5", int.Parse(type_E.Text), 2600);
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type6", int.Parse(type_F.Text), 2700);
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type7", int.Parse(type_G.Text), 2800);
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type8", int.Parse(type_H.Text), 2900);
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type9", int.Parse(Type_I.Text), 3000);
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type10", int.Parse(type_J.Text), 3100);
            }
            catch (Exception)
            {

            }

            try
            {
                _Controller.MakeNewSale("type11", int.Parse(type_K.Text), 3200);
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type12", int.Parse(type_L.Text), 3300);
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type13", int.Parse(type_M.Text), 3400);
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type14", int.Parse(type_N.Text), 3500);
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type15", int.Parse(type_S.Text), 3600);
            }
            catch (Exception)
            {


            }


            if (int.Parse(type_A.Text) != 0)
            {

                Product product1 = new Product("type1", int.Parse(type_A.Text), 2300);
                productlist.Add(product1);
                Pricelist.Add(product1.price * product1.quant);
                

                

            }
            if (int.Parse(type_B.Text) != 0)
            {
                Product product2 = new Product("type2", int.Parse(type_B.Text), 2200);
                productlist.Add(product2);
                Pricelist.Add(product2.price * product2.quant);
                

            }
            if (int.Parse(type_C.Text) != 0)
            {
                Product product3 = new Product("type3", int.Parse(type_C.Text), 2400);
                productlist.Add(product3);
                Pricelist.Add(product3.price * product3.quant);
                
            }

            if (int.Parse(type_D.Text) != 0)
            {
                Product product4 = new Product("type4", int.Parse(type_D.Text), 2500);
                productlist.Add(product4);
                Pricelist.Add(product4.price * product4.quant);
                           }
            if (int.Parse(type_E.Text) != 0)
            {
                Product product5 = new Product("type5", int.Parse(type_E.Text), 2600);
                productlist.Add(product5);
                Pricelist.Add(product5.price * product5.quant);
                
            }
            if (int.Parse(type_G.Text) != 0)
            {
                Product product6 = new Product("type6", int.Parse(type_G.Text), 2700);
                productlist.Add(product6);
                Pricelist.Add(product6.price * product6.quant);
                
            }
            if (int.Parse(type_H.Text) != 0)
            {
                Product product7 = new Product("type7", int.Parse(type_H.Text), 2800);
                productlist.Add(product7);
                Pricelist.Add(product7.price * product7.quant);
                
            }
            if (int.Parse(Type_I.Text) != 0)
            {
                Product product8 = new Product("type9", int.Parse(Type_I.Text), 2900);
                productlist.Add(product8);
                Pricelist.Add(product8.price * product8.quant);
                
            }
            if (int.Parse(type_J.Text) != 0)
            {
                Product product9 = new Product("type10", int.Parse(type_J.Text), 3000);
                productlist.Add(product9);
                Pricelist.Add(product9.price * product9.quant);
                
            }
            if (int.Parse(type_K.Text) != 0)
            {
                Product product10 = new Product("type11", int.Parse(type_K.Text), 3100);
                productlist.Add(product10);
                Pricelist.Add(product10.price * product10.quant);
                            }
            if (int.Parse(type_L.Text) != 0)
            {
                Product product11 = new Product("type12", int.Parse(type_L.Text), 3200);
                productlist.Add(product11);
                Pricelist.Add(product11.price * product11.quant);
                
            }
            if (int.Parse(Type_I.Text) != 0)
            {
                Product product12 = new Product("type13", int.Parse(Type_I.Text), 3300);
                productlist.Add(product12);
                Pricelist.Add(product12.price * product12.quant);
               
            }
            if (int.Parse(type_M.Text) != 0)
            {
                Product product13 = new Product("type14", int.Parse(type_M.Text), 3400);
                productlist.Add(product13);
                Pricelist.Add(product13.price * product13.quant);
                           }
            if (int.Parse(type_N.Text) != 0)
            {
                Product product14 = new Product("type15", int.Parse(type_N.Text), 3500);
                productlist.Add(product14);
                Pricelist.Add(product14.price * product14.quant);
              
            }
            if (int.Parse(type_S.Text) != 0)
            {
                Product product15 = new Product("type16", int.Parse(type_S.Text), 3600);
                productlist.Add(product15);
                Pricelist.Add(product15.price * product15.quant);
              
            }


           _Controller.createnewOrder(namebox.Text, Phone.Text, Address.Text, Company.Text, productlist, Deliverydate.Text);
        }
            //this method return the total price of products

           public double totalprice ()
           {
               double totalpric = 0;

            foreach (double p in Pricelist)
            {
             totalpric+=p;   
                    
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

