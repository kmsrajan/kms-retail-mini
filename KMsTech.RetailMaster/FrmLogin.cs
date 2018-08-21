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
    public partial class FrmLogin : Form
    {
        private static FrmLogin _frmInstance;
        public static FrmLogin FrmInstance
        {
            get
            {
                if (FrmLogin._frmInstance == null)
                {
                    FrmLogin._frmInstance = new FrmLogin();
                }
                return FrmLogin._frmInstance;
            }
        }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Validate User Name and Pwd againest user table details
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPwd.Text))
            {
                //Create a application variable to hold logged in user details
                MdiRetailMaster.UserName = txtUserName.Text;
                MdiRetailMaster.FirstName = "FirstName";
                MdiRetailMaster.LastName = "LastName";
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
