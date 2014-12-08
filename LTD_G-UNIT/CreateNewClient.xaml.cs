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
    /// Interaction logic for CreateNewClient.xaml
    /// </summary>
    public partial class CreateNewClient : Window
    {

        ControllerForWindows _controller;
        DatabaseController _databaseController;
        //METHOD FOR NEW CLIENT
        public CreateNewClient()
        {
             InitializeComponent();
            _controller = new ControllerForWindows();
            _databaseController = new DatabaseController();
        }
        //METHOD TO SAVE CLIENT INTO DATABASE
        private void SaveBut_Click(object sender, RoutedEventArgs e)
        {
            _controller.newClient();
            _databaseController.AddClient(NameBut.Text, CompanyBut.Text ,AddressBut.Text,int.Parse(PhoneBut.Text),int.Parse(MobileBut.Text));
            NameBut.Text = "";
            CompanyBut.Text = "";
            PhoneBut.Text = "";
            AddressBut.Text = "";
            MobileBut.Text = "";
            
            MessageBox.Show("Client created");

        }
        
     

        }
    }

