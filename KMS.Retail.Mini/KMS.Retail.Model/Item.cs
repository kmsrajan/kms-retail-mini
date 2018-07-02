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
        public string Picture { get; set; }
        public string PurchasePrice { get; set; }
        public string Qty { get; set; }
        public string SellingPrice { get; set; }
        public string WSPrice { get; set; }
        public string GCPrice { get; set; }
        public string MRP { get; set; }
        public string GST { get; set; }
        public string Tax { get; set; }
        public string Status { get; set; }
    }
}
