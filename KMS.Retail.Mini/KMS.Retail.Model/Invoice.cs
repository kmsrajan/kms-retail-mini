using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.Retail.Model
{
    public class Invoice
    {
        public string ID { get; set; }
        public string InvoiceNo { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string Mobile { get; set; }
        public string Photo { get; set; }
        public DataTable Items { get; set; }
        public string TotalAmount { get; set; }
        public string TaxType { get; set; }
        public string TotalTax { get; set; }
        public string Discount { get; set; }
        public string NetTotal { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentStatus { get; set; }
        public string InvoiceStatus { get; set; }
        public string AmountReceived { get; set; }
        public string BalanceAmount { get; set; }
        public string CreatedDate { get; set; }
        public string CustomerDetails { get; set; }
    }
}
