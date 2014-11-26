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
    /// Interaction logic for updatestockWindow.xaml
    /// </summary>
    public partial class updatestockWindow : Window
    {
        Controller _Controller;
        DatabaseController _DBC = new DatabaseController();
       // updatestockWindow upwind = new updatestockWindow();

        public updatestockWindow()
        {
            InitializeComponent();
        }

        private void updatebutton_Click(object sender, RoutedEventArgs e)
        {
            _Controller  = new Controller();
             // conection for type to DB
            try
            {
                _Controller.addToDB("type1", int.Parse(type_A.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type2", int.Parse(type_B.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type3", int.Parse(type_C.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type4", int.Parse(type_D.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type5", int.Parse(type_E.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type6", int.Parse(type_F.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type7", int.Parse(type_G.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type8", int.Parse(type_H.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type9", int.Parse(Type_I.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type10", int.Parse(type_J.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type11", int.Parse(type_K.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type12", int.Parse(type_L.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type13", int.Parse(type_M.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type14", int.Parse(type_N.Text));
            }
            catch (Exception)
            {

            }
            try
            {
                _Controller.addToDB("type15", int.Parse(type_S.Text));
            }
            catch (Exception)
            {

            }
            //finaly close the window
            this.Close(); 
        }
    }
}
