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
        
        //Shows THE UPDATESTOCKWINDOW
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            updatestockWindow updt = new updatestockWindow();
            updt.Show();
        }

        //THIS ADD DATA TO THE LISTBOX
        public MainWindow()
        {
           
            InitializeComponent();
            ListBox.Items.Clear();
            AddText.Text = "";
          
            _controller = new Controller();
        }
       
        //method for Save button 

        Controller _controller;
        private void SaveButton1_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            _controller.SaveNotification(AddText.Text + " \n " + dt);
            ListBox.Items.Add(AddText.Text + " \n " + dt);
           
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
        // OPEN NEW SALE WINDOW
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            newsaleswindow s1 = new newsaleswindow();
            s1.Show();
        }
        //OPEN CHECKSTOCK WINDOW
        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
           
            Checkstock chk = new Checkstock();
            chk.Show();
            
        }
       
        //OPEN NEW WINDOW FOR CREATE  NEW CLIENT 
        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            CreateNewClient cre = new CreateNewClient();
            cre.Show();
        }
        //Change the cancel button to clear
        private void ClearButton_Click_1(object sender, RoutedEventArgs e)
        {
           // Notification.Clear();
           
        
            ListBox.Items.RemoveAt(ListBox.Items.Count-1);
            _controller.ClearData();
        
        }
        //THIS OPEN THE WINDOW FOR PLAN PRODUCTION
        private void PlanProduction_Click(object sender, RoutedEventArgs e)
        {
            PlanProduction plan = new PlanProduction();
            plan.Show();
        }
        // this open client info client window
        private void ClientListBox_Click(object sender, RoutedEventArgs e)
        {
            ClietnsInfo client = new ClietnsInfo();
            client.Show();
        }

        

       
    }
}
