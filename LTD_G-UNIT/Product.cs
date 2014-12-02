using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTD_G_UNIT
{
    class Product
    {
        public  List<Product> Productlist;
        public string type { get; set; }
        public int quant { get; set; }
        public int price { get; set; }

        public Product(string type, int quant, int price)
        {
            this.type = type;
            this.quant = quant;
            this.price = price;
            
        }

        
    }
}
