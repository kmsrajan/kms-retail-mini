using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS.Retail.Master
{
    public partial class FrmSalesInvoices : Form
    {
        private static FrmSalesInvoices _frmInstance;
        public static FrmSalesInvoices FrmInstance
        {
            get
            {
                if (FrmSalesInvoices._frmInstance == null)
                {
                    FrmSalesInvoices._frmInstance = new FrmSalesInvoices();
                }
                return FrmSalesInvoices._frmInstance;
            }
        }
        public FrmSalesInvoices()
        {
            InitializeComponent();
        }
    }
}
