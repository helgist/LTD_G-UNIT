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
            Notification.IsReadOnly = true;
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
        //HOME BUTTON
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            
        }
        //EXIT BUTTON
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Change the cancel button to clear
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Notification.Clear();
            _controller.ClearData();
          
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            newsaleswindow s1 = new newsaleswindow();
            s1.Show();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            Checkstock chk = new Checkstock();
            chk.Show();
        }

       
    }
}
