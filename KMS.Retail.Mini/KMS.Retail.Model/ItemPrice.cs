using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.Retail.Model
{
    public class ItemPrice
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public ItemPrice(string name,string price)
        {
            Name = name;
            Price = price;
        }
    }
}
