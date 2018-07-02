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
    public partial class FrmOrder : Form
    {
        private static FrmOrder _frmInstance;
        public static FrmOrder FrmInstance
        {
            get
            {
                if (FrmOrder._frmInstance == null)
                {
                    FrmOrder._frmInstance = new FrmOrder();
                }
                return FrmOrder._frmInstance;
            }
        }

        public FrmOrder()
        {
            InitializeComponent();
        }
    }
}
