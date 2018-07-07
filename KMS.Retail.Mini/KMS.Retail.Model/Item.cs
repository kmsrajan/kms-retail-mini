using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.Retail.Model
{
    public class Item
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string DisplayName { get; set; }
        public string Category { get; set; }
        public byte[] Picture { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Qty { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal WSPrice { get; set; }
        public decimal SplPrice { get; set; }
        public decimal MRP { get; set; }
        public decimal GST { get; set; }
        public decimal Tax { get; set; }
        public string Status { get; set; }

        public string DateCreated { get; set; }
    }
}
