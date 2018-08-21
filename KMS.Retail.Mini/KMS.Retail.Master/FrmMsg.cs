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
    public partial class FrmMsg : Form
    {
        static FrmMsg frmMsg;
        static string response = string.Empty;
        public FrmMsg()
        {
            InitializeComponent();
            lblMsg.Text = string.Empty;
            lblTitle.Text = string.Empty;
            btnNo.Visible = false;
            btnOK.Visible = false;
            btnYes.Visible = false;
            btnClose.Visible = false;
        }

        private void FrmMsg_Load(object sender, EventArgs e)
        {
           
        }
        public static string ConfirmBox(string title,string question)
        {
            frmMsg = new FrmMsg();
            frmMsg.lblTitle.Text = title;
            frmMsg.lblMsg.Text = question;
            frmMsg.btnYes.Visible = true;
            frmMsg.btnNo.Visible = true;
            
            frmMsg.ShowDialog();
            return response;
        }

        public static string MsgBox(string title, string message)
        {
            frmMsg = new FrmMsg();
            frmMsg.lblTitle.Text = title;
            frmMsg.lblMsg.Text = message;
            frmMsg.btnOK.Visible = true;
            frmMsg.btnClose.Visible = true;

            frmMsg.ShowDialog();
            return response;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            response = "1";
            frmMsg.Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            response = "2";
            frmMsg.Dispose();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            response = "4";
            frmMsg.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            response = "3";
            frmMsg.Dispose();
        }
    }
}
