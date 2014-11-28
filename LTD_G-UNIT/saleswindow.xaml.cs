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
    /// Interaction logic for saleswindow.xaml
    /// </summary>
    public partial class saleswindow : Window
    {
        costumer costumer1;
        Controller _Controller;
        public saleswindow()
        {
            saleswindow sw1 =new saleswindow ();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void sale_Click(object sender, RoutedEventArgs e)
        {
            costumer newcostumer = new costumer();
            newcostumer.Name = name.Text;
            newcostumer.Telephon = int.Parse(telphon.Text);
            newcostumer.Adress = adress.Text;

            _Controller = new Controller();
            try
            {
                _Controller.MakeNewSale("type1", int.Parse(type_A.Text));
            }
            catch(Exception )
            {
                 
            }
            try
            {
                _Controller.MakeNewSale("type2", int.Parse(type_B.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type3", int.Parse(type_C.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type4", int.Parse(type_D.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type5", int.Parse(type_E.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type6", int.Parse(type_F.Text));
            }
            catch (Exception)
            {

            }
               try
            {
                _Controller.MakeNewSale("type7", int.Parse(type_G.Text));
            }
            catch(Exception )
            {
                 
            }
            try
            {
                _Controller.MakeNewSale("type8", int.Parse(type_H.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.MakeNewSale("type9", int.Parse(Type_I.Text));
            }
            catch (Exception)
            {

            }
               try
            {
                _Controller.MakeNewSale("type10", int.Parse(type_J.Text));
            }
            catch(Exception )
            {
                 
            }
        
            try     
            {
                    _Controller.MakeNewSale("type11", int.Parse(type_K.Text));
                }
                catch (Exception)
                {

                }
                try
                {
                    _Controller.MakeNewSale("type12", int.Parse(type_L.Text));
                }
                catch (Exception)
                {

                }
                try
                {
                    _Controller.MakeNewSale("type13", int.Parse(type_M.Text));
                }
                catch (Exception)
                {

                }
                try
                {
                    _Controller.MakeNewSale("type14", int.Parse(type_N.Text));
                }
                catch (Exception)
                {

                }
                try
                {
                    _Controller.MakeNewSale("type15", int.Parse(type_S.Text));
                }
                catch (Exception)
                {


                }
                List<Product> productlist = new List<Product>();
            if (int.Parse(type_A.Text)!=0)
            {
                Product product1 = new Product("type1",int.Parse(type_A.Text));
                productlist.Add(product1);
            }
              if (int.Parse(type_B.Text)!=0)
            {
                Product product2 = new Product("type2",int.Parse(type_B.Text));
                productlist.Add(product2);
            }
              if (int.Parse(type_C.Text)!=0)
            {
                Product product3 = new Product("type3",int.Parse(type_C.Text));
                productlist.Add(product3);
            }
              if (int.Parse(type_D.Text)!=0)
            {
                Product product4 = new Product("type4",int.Parse(type_D.Text));
                productlist.Add(product4);
            }
              if (int.Parse(type_E.Text)!=0)
            {
                Product product5 = new Product("type5",int.Parse(type_E.Text));
                productlist.Add(product5);
            }
              if (int.Parse(type_G.Text)!=0)
            {
                Product product6 = new Product("type6",int.Parse(type_G.Text));
                productlist.Add(product6);
            }
              if (int.Parse(type_H.Text)!=0)
            {
                Product product7 = new Product("type7",int.Parse(type_H.Text));
                productlist.Add(product7);
            }
              if (int.Parse(Type_I.Text)!=0)
            {
                Product product8 = new Product("type9",int.Parse(type_I.Text));
                productlist.Add(product8);
            }
              if (int.Parse(type_J.Text)!=0)
            {
                Product product9 = new Product("type10",int.Parse(type_J.Text));
                productlist.Add(product9);
            }
              if (int.Parse(type_K.Text)!=0)
            {
                Product product10 = new Product("type11",int.Parse(type_K.Text));
                productlist.Add(product10);
            }
              if (int.Parse(type_L.Text)!=0)
            {
                Product product11 = new Product("type12",int.Parse(type_L.Text));
                productlist.Add(product11);
            }
              if (int.Parse(Type_I.Text)!=0)
            {
                Product product12 = new Product("type13",int.Parse(Type_I.Text));
                productlist.Add(product12);
            }
              if (int.Parse(type_M.Text)!=0)
            {
                Product product13 = new Product("type14",int.Parse(type_M.Text));
                productlist.Add(product13);
            }
              if (int.Parse(type_N.Text)!=0)
            {
                Product product14 = new Product("type15",int.Parse(type_N.Text));
                productlist.Add(product14);
            }
              if (int.Parse(type_S.Text)!=0)
            {
                Product product15 = new Product("type16",int.Parse(type_S.Text));
                productlist.Add(product15);
            }



            
            }








           

            }

        }
    }

