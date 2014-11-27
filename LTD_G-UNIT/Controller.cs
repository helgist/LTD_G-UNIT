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


        //This method adds to inventory in database
        public void addToDB(string type, int toadd)
        {
            _Databasecontroller = new DatabaseController();

            ProdX = new Product(type, toadd);

            _Databasecontroller.AddItemsToInventory(type, toadd);


         

        }

        //this method subtracts from database
        public void MakeNewSale(string type, int subbtract)
        {
            _Databasecontroller = new DatabaseController();

            Product Productsold = new Product(type, subbtract);

            _Databasecontroller.NewSaleMade(type, subbtract);

        }
    }
}
