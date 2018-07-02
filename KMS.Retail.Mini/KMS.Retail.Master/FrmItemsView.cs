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
    public partial class FrmItemsView : Form
    {
        private static FrmItemsView _frmInstance;
        public static FrmItemsView FrmInstance
        {
            get
            {
                if (FrmItemsView._frmInstance == null)
                {
                    FrmItemsView._frmInstance = new FrmItemsView();
                }
                return FrmItemsView._frmInstance;
            }
        }
        public FrmItemsView()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmItem frmItem = new FrmItem();
            frmItem.StartPosition = FormStartPosition.CenterParent;
            frmItem.ShowDialog();
            
        }
    }
}
