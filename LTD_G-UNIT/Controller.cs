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
        order Order;

        //list of our orders
        List<order> _orderlist;

        

        //This method adds to inventory in database
        public void addToDB(string type, int toadd)
        {
            _Databasecontroller = new DatabaseController();

            ProdX = new Product(type, toadd, 0);

            _Databasecontroller.AddItemsToInventory(type, toadd);
         

        }

        //this method subtracts from database
        public void MakeNewSale(string type, int subbtract)
        {
            _Databasecontroller = new DatabaseController();

            Product Productsold = new Product(type, subbtract, 0);

            _Databasecontroller.NewSaleMade(type, subbtract);

        }

        //this method creates new order
        public void createnewOrder(string name, int telphon, string adress,List<Product> Productlist)
        {
            costumer newcostumer = new costumer();
          
            newcostumer.Name = name;
            newcostumer.Telephon = telphon;
            newcostumer.Adress = adress;

            order Order1 = new order();
            Order1.costomer1 = newcostumer;
            Order1.dateoforder = DateTime.Now;
            Order1.Productlist = Productlist;


        }
    
        
    }
}
