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
    public partial class FrmNewSalesOrder : Form
    {
        private static FrmNewSalesOrder _frmInstance;
        public static FrmNewSalesOrder FrmInstance
        {
            get
            {
                if (FrmNewSalesOrder._frmInstance == null)
                {
                    FrmNewSalesOrder._frmInstance = new FrmNewSalesOrder();
                }
                return FrmNewSalesOrder._frmInstance;
            }
        }
        public FrmNewSalesOrder()
        {
            InitializeComponent();
        }
    }
}
