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

        public void addToDB(string type, int toadd)
        {
            _Databasecontroller = new DatabaseController();

            ProdX = new Product(type, toadd);

            _Databasecontroller.AddItemsToInventory(type, toadd);


            //_Databasecontroller.add(type, toadd (or Prodx))

        }
    }
}
