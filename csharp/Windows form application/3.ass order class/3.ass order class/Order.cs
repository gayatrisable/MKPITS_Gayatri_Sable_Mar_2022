using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ass_order_class
{
     class Order
    {
        public int orno;
        public string cosname;
        public string pro;
        
       public float calculatetotalamount(float price, int quantity)
        {
            //this.price = price;
            //this.quantity = quantity;
            //return price * quantity;
                  //or
            float total = price * quantity;
            return total;
        }
    }
}
