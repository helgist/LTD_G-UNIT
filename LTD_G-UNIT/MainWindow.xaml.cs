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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LTD_G_UNIT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        updatestockWindow updt = new updatestockWindow();
        //Shows the second menu
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            updt.Show();
        }
        public MainWindow()
        {
            InitializeComponent();
            Notification.Text = "";
            AddText.Text = "";
            _controller = new ControllerForWindows();
        }
       
        //method for Save button 

        ControllerForWindows _controller;
        private void SaveButton1_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            _controller.SaveNotification(AddText.Text + " \n " + dt);
            Notification.Text = _controller.DataToDisplay();
            AddText.Text = " ";  
        }
    }
}
