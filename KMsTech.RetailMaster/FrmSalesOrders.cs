using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMsTech.RetailMaster
{
    public partial class FrmSalesOrders : Form
    {
        private static FrmSalesOrders _frmInstance;
        public static FrmSalesOrders FrmInstance
        {
            get
            {
                if (FrmSalesOrders._frmInstance == null)
                {
                    FrmSalesOrders._frmInstance = new FrmSalesOrders();
                }
                return FrmSalesOrders._frmInstance;
            }
        }
        public FrmSalesOrders()
        {
            InitializeComponent();
        }
    }
}
