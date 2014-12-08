using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTD_G_UNIT
{
    class Controller
    {


        
        DatabaseController _Databasecontroller;

       

        //list of employes, when they are avalible and what project they are working on(Order ID number)
        public List<Employe> _employelist = new List<Employe>();

        public Controller()
        {

            Employedata();
            Orderdatatolist();
            
        }
        
        //This method adds to inventory in database
        public void addToDB(string type, int toadd)
        {
            _Databasecontroller = new DatabaseController();

            Product ProdX = new Product(type, toadd, 0);

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
        public void createnewOrder(string name, string telphon, string adress,string company, List<Product> Productlist, string delivery)
        {
            
            costumer newcostumer = new costumer();
            
            newcostumer.Company = company;
            newcostumer.Name = name;
            newcostumer.Telephon = telphon;
            newcostumer.Adress = adress;

            order Order5 = new order();
            Order5.costomer1 = newcostumer;
            Order5.dateoforder = DateTime.Now;
            Order5.Productlist = Productlist;
            Order5.deliverydate = delivery;
          //  Order5.price = totalprice;

            _orderlist.Add(Order5);

        }
    
        // Here I add employes to our employe list
        public void Employedata()
        {
            Employe employe = new Employe();

            employe.name = "John";
            employe.day = 0;
            employe.orderNR = 0;
            _employelist.Add(employe);

            Employe employe2 = new Employe();
            employe2.name = "Lars";
            employe2.day = 9;
            employe2.orderNR = 0;
            _employelist.Add(employe2);

            Employe employe3 = new Employe();
            employe3.name = "Jakob";
            employe3.day = 5;
            employe3.orderNR = 0;
            _employelist.Add(employe3);

            Employe employe4 = new Employe();
            employe4.name = "Helgi";
            employe4.day = 5;
            employe4.orderNR = 0;
            _employelist.Add(employe4);

            Employe employe5 = new Employe();
            employe5.name = "Kim";
            employe5.day = 3;
            employe5.orderNR = 0;
            _employelist.Add(employe5);

            Employe employe6 = new Employe();
            employe6.name = "Benny";
            employe6.day = 0;
            employe6.orderNR = 0;
            _employelist.Add(employe6);

            Employe employe7 = new Employe();
            employe7.name = "Jonas";
            employe7.day = 0;
            employe7.orderNR = 0;
            _employelist.Add(employe7);

            Employe employe8 = new Employe();
            employe8.name = "Lone";
            employe8.day = 0;
            employe8.orderNR = 0;
            _employelist.Add(employe8);

            Employe employe9 = new Employe();
            employe9.name = "Tina";
            employe9.day = 0;
            employe9.orderNR = 0;
            _employelist.Add(employe9);

            Employe employe10 = new Employe();
            employe10.name = "michael jackson";
            employe10.day = 0;
            employe10.orderNR = 0;
            _employelist.Add(employe10);

            Employe employe11 = new Employe();
            employe11.name = "Tina";
            employe11.day = 0;
            employe11.orderNR = 0;
            _employelist.Add(employe11);

            Employe employe12 = new Employe();
            employe12.name = "Holger";
            employe12.day = 0;
            employe12.orderNR = 0;
            _employelist.Add(employe12);

            Employe employe13 = new Employe();
            employe13.name = "Ole";
            employe13.day = 0;
            employe13.orderNR = 0;
            _employelist.Add(employe13);



                


        }

        // Here I add orders to our orderlist just so it dont start out empty
        public void Orderdatatolist()
        {

            costumer newcostumer = new costumer();
            List<Product> Productlist = new List<Product>();
            Product product1 = new Product("type 1", 8 , 2300);
            Product product2 = new Product("type 6", 32, 2300);
            Product product3 = new Product("type 12", 11, 2300);
            Productlist.Add(product1);
            Productlist.Add(product2);
            Productlist.Add(product3);

            newcostumer.Company = "Silvan";
            newcostumer.Name = "Alex Jensen";
            newcostumer.Telephon = "78956234";
            newcostumer.Adress = "Midelfart vej 32b";

            order Order2 = new order();
            Order2.costomer1 = newcostumer;
            Order2.dateoforder = DateTime.Now;
            Order2.Productlist = Productlist;
            Order2.deliverydate = "15-12-2014" ;
            

            _orderlist.Add(Order2);

            costumer newcostumer2 = new costumer();
            List<Product> Productlist2 = new List<Product>();
            Product product4 = new Product("type 3", 8, 2300);
            Product product5 = new Product("type 8", 32, 2300);
            Product product6 = new Product("type 14", 11, 2300);
            Productlist2.Add(product4);
            Productlist2.Add(product5);
            Productlist2.Add(product6);

            newcostumer2.Company = "Jysk contractor";
            newcostumer2.Name = "Kaj Gamle";
            newcostumer2.Telephon = "78984565";
            newcostumer2.Adress = "Slotsgade 98";

            order Order3 = new order();
            Order3.costomer1 = newcostumer;
            Order3.dateoforder = DateTime.Now;
            Order3.Productlist = Productlist;
            Order3.deliverydate = "12-01-2015";

            _orderlist.Add(Order3);
        }

        public List<Employe> getemploylist()
        {
            
            return _employelist;
 
        }

        public List<order> getOrderlist()
        {
           
            return _Databasecontroller.getlistoforders();

        }
        public List<Product> getproductlist()
        {
            return _Databasecontroller.getlistofproducts();
        }
    }
}
