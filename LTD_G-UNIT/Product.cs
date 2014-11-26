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

        public Product(string type, int quant)
        {
            this.type = type;
            this.quant = quant;
        }
    }
}
