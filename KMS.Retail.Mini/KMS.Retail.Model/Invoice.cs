using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.Retail.Model
{
    class Invoice
    {
        public string ID { get; set; }
        public string InvoiceNo { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string Mobile { get; set; }
        public string Photo { get; set; }
        public List<Item> Items { get; set; }
        public string TotalAmount { get; set; }
        public string TaxType { get; set; }
        public string TotalTax { get; set; }
        public string Discount { get; set; }
        public string NetTotal { get; set; }
        public string PaymentMode { get; set; }
        public string AmountReceived { get; set; }
        public string CreatedDate { get; set; }
    }
}
