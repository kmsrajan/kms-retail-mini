using KMS.Retail.Model;
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
    public partial class FrmSaveOrder : Form
    {
        static FrmSaveOrder frmSave;
        static string response = string.Empty;
        public FrmSaveOrder()
        {
            InitializeComponent();
        }
        public static string SaveSalesOrder(Invoice invc)
        {
            invc.CustName = frmSave.txtCustName.Text;
            invc.Mobile = frmSave.txtMobile.Text;
            invc.CustAddress = frmSave.txtAddress.Text;

            frmSave = new FrmSaveOrder();
            frmSave.ShowDialog();
            return response;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            string res=FrmMsg.ConfirmBox("விற்பனை நகல்", "நகலை நிராகரித்தால் இதனை மீண்டும் பெற இயலாது. சம்மதமா?");
            if (response == "1")
            {
                response = "1";
            }
            if (res == "2")
            {
                response = "1";
            }
            if (res == "3")
            {
                response = "1";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string res = FrmMsg.ConfirmBox("விற்பனை நகல்", "இந்த விற்பனை நகலை சேமிக்க சம்மதமா?");
            if (res == "1")
            {
                FrmMsg.MsgBox("விற்பனை நகல்", "விற்பனை நகலை சேமிக்கப்பட்டுவிட்டது");
                response = "1";

            }
            if (res == "2")
            {
                FrmMsg.MsgBox("விற்பனை நகல்", "விற்பனை நகலை நிராகரிக்கப்பட்டுவிட்டது");
                response = "1";
            }
            if (res == "3")
            {
                response = "1";
            }
        }
    }
}
