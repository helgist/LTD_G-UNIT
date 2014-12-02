using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTD_G_UNIT
{
    class order

    {
         public costumer costomer1 { get; set; }        
         public List<Product> Productlist { get; set; }
         public double price { get; set; }
         public DateTime dateoforder { get; set; }
         public string deliverydate{ get; set; }
         public int orderid {get; set;}
         

         private static int newID ;

    public void createorderid()
    {
        newID = newID +1;
        orderid = newID;

       
    }
    
    }
}
