using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTD_G_UNIT
{
    class Controller
    {


        Product ProdX;
        DatabaseController _Databasecontroller;

        //list of our orders
        List<order> _orderlist;

        //list of employes, when they are avalible and what project they are working on(Order ID number)
        List<Employe> _employelist;
        public Controller()
        {
            _orderlist = new List<order>();
            _employelist = new List<Employe>();
            Employedata();
            
        }
        

        //This method adds to inventory in database
        public void addToDB(string type, int toadd)
        {
            _Databasecontroller = new DatabaseController();

            ProdX = new Product(type, toadd, 0);

            _Databasecontroller.AddItemsToInventory(type, toadd);
         

        }

        //this method subtracts from database
        public void MakeNewSale(string type, int subbtract, int price)
        {
            _Databasecontroller = new DatabaseController();

            Product Productsold = new Product(type, subbtract, price);

            _Databasecontroller.NewSaleMade(type, subbtract);

        }

        //this method creates new order
        public void createnewOrder(string name, string telphon, string adress, List<Product> Productlist, string delivery)
        {
            costumer newcostumer = new costumer();
          
            newcostumer.Name = name;
            newcostumer.Telephon = telphon;
            newcostumer.Adress = adress;

            order Order1 = new order();
            Order1.costomer1 = newcostumer;
            Order1.dateoforder = DateTime.Now;
            Order1.Productlist = Productlist;
            Order1.deliverydate = delivery;

            _orderlist.Add(Order1);

            

             
            //price of the order
            //int ans;
            //foreach (var quant in Productlist)
            //{

            //    (quant * price) + ans;
            //}


        }
    
        public void Employedata()
        {

        }
    }
}
