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

        public CreateNewClient()
        {
             InitializeComponent();
            _controller = new ControllerForWindows();
        }

        private void SaveBut_Click(object sender, RoutedEventArgs e)
        {
            _controller.newClient();
        }
        
            private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            _controller.newClient();
            NameBut.Text = "";
            CompanyBut.Text = "";
            PhoneBut.Text = "";
            AddressBut.Text = "";
            MobileBut.Text="";
        }
        }
    }

