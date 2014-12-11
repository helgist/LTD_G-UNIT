using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTD_G_UNIT
{
    class Controller
    {

        DatabaseController _Databasecontroller = new DatabaseController();
        public List<Client> _clientlist = new List<Client>();
        List<string> _allData;

       
        //list of employes, when they are avalible and what project they are working on(Order ID number)
        public List<Employe> _employelist = new List<Employe>();

              
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
        public void createnewOrder(string name, string telphon, string adress,string company, List<Product> Productlist, string delivery, int costumerID)
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

            Random rnd = new Random();
            int orderID = rnd.Next(0001, 9999);
            
            _Databasecontroller.CreateNewOrder(orderID, name, company, telphon, adress, costumerID, DateTime.Now, delivery);

            foreach(Product P in Productlist)
            {
                string type = P.type;
                int quant = P.quant;
                _Databasecontroller.insertProductsToOrder(orderID, type, quant);
            }
            

        }
    
        public List<Employe> getemploylist()
        {
            return _Databasecontroller.getlistofemployes();
        }

        public List<order> getOrderlist()
        {
                 return _Databasecontroller.getlistoforders();
        }

        public void assignemployetoorder(string name, int orderID)
        {
            _Databasecontroller.asignemployetoorder(name, orderID);
        }

        public void Addworkingdaystoemploye(int days, string name)
        {
            _Databasecontroller.Addworkingdaystoemploye(days, name);
        }
        //from other controller
        public void newClient(string Name, string CompanyName, string Address1, int Phone, int MobilePhone)
        {
            Client clie = new Client();
            clie.Name = Name;
            clie.CompanyName = CompanyName;
            clie.Address = Address1;
            clie.Phone = Phone;
            clie.MobilePhone = MobilePhone;

            _clientlist.Add(clie);

            _Databasecontroller.AddClient(Name, CompanyName, Address1, Phone, MobilePhone);

        }
        public List<Client> getclientlist()
        {

            _clientlist = _Databasecontroller.getlistofcostumers();
            return _clientlist;
        }
          public Controller()
        {
            _allData = new List<string>();
           

        }
          public void ClearData()
          {
              _allData.Clear();
          }
          internal void SaveNotification(String data)
          {
              _allData.Add(data);
          }

          public string DataToDisplay()
          {
              string returnData = "";
              foreach (string s in _allData)
              {
                  returnData += s + "\n";

              }
              return returnData;
          }
        
    }
}
