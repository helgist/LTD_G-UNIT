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
           

            }

        }
    }

