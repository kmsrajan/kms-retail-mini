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
    public partial class FrmInvoice : Form
    {
        private static FrmInvoice _frmInstance;
        public static FrmInvoice FrmInstance
        {
            get
            {
                if (FrmInvoice._frmInstance == null)
                {
                    FrmInvoice._frmInstance = new FrmInvoice();
                }
                return FrmInvoice._frmInstance;
            }
        }
        public FrmInvoice()
        {
            InitializeComponent();
        }
    }
}
