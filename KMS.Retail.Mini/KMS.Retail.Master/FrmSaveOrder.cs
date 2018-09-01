using KMS.Retail.Common;
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
        static bool PayNow =false;
        static Invoice invoice=new Invoice();
        public FrmSaveOrder()
        {
            InitializeComponent();
        }
        public static string SaveSalesOrder(Invoice invc)
        {           
            invoice = invc;

            frmSave = new FrmSaveOrder();            
            frmSave.ShowDialog();

           
            return response;
        }
        public static Invoice MakePayment(Invoice invc)
        {
            //invc.CustName = frmSave.txtCustName.Text;
            //invc.Mobile = frmSave.txtMobile.Text;
            //invc.CustAddress = frmSave.txtAddress.Text;
            PayNow = true;
            invoice = invc;

            frmSave = new FrmSaveOrder();
            frmSave.btnSave.Text = "Next";
            frmSave.btnCancel.Text = "Skip";
            frmSave.ShowDialog();

            return invoice;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            string res = string.Empty;
            if (PayNow)
            {
                invoice.CustName = "வாடிக்கையாளர்";
                invoice.Mobile = "123456789";
                invoice.CustAddress = "வாடிக்கையாளர்";
                invoice.CustomerDetails = "SKIPPED";
                res = Constants.Response.SUCCESS.ToString();
            }
            else
            {
                 res = FrmMsg.ConfirmBox("விற்பனை நகல்", "நகலை நிராகரித்தால் இதனை மீண்டும் பெற இயலாது. சம்மதமா?");
            }
            response = res;
            frmSave.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string res = string.Empty;
            if (PayNow)
            {
                invoice.CustName = txtCustName.Text;
                invoice.Mobile = txtMobile.Text;
                invoice.CustAddress = txtAddress.Text;
                invoice.CustomerDetails = "ADDED";
                res = Constants.Response.SUCCESS.ToString();
            }
            else
            {
                res = FrmMsg.ConfirmBox("விற்பனை நகல்", "இந்த விற்பனை நகலை சேமிக்க சம்மதமா?");
                if (res == Constants.Response.YES.ToString())
                {
                    //Save the invoice
                    res = Constants.Response.SUCCESS.ToString();
                    FrmMsg.MsgBox("விற்பனை நகல்", "விற்பனை நகலை சேமிக்கப்பட்டுவிட்டது");

                }
                if (res == Constants.Response.NO.ToString())
                {
                    res = Constants.Response.FAIL.ToString();
                    FrmMsg.MsgBox("விற்பனை நகல்", "விற்பனை நகலை நிராகரிக்கப்பட்டுவிட்டது");

                }
            }
            response = res;
            frmSave.Dispose();
        }

        private void FrmSaveOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
