using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTD_G_UNIT
{
    class Product
    {
        
        public string type { get; set; }
        public int quant { get; set; }
        public int price { get; set; }
        public int orderID { get; set; }

        public Product(string type, int quant, int price)
        {
            this.type = type;
            this.quant = quant;
            this.price = price;
            
        }

        public Product(int quant, int orderID, string type)
        {
            this.type = type;
            this.quant = quant;
            this.orderID = orderID;

        }
        
    }
}
