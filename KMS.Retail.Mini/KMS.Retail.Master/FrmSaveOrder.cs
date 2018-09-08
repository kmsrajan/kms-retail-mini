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
        static bool PayNow = false;
        static Invoice invoice = new Invoice();
        public FrmSaveOrder()
        {
            InitializeComponent();
        }
        public static Invoice SaveSalesOrder(Invoice invc)
        {
            invoice = invc;
            frmSave = new FrmSaveOrder();
            if (!string.IsNullOrEmpty(invc.Mobile))
            {
                frmSave.txtMobile.Text = invc.Mobile;
            }
            if (!string.IsNullOrEmpty(invc.CustName))
            {
                frmSave.txtCustName.Text = invc.CustName;
            }
            if (!string.IsNullOrEmpty(invc.CustAddress))
            {
                frmSave.txtAddress.Text = invc.CustAddress;
            }
           
            frmSave.ShowDialog();

            return invoice;
        }
        public static Invoice MakePayment(Invoice invc)
        {
            PayNow = true;
            invoice = invc;

            frmSave = new FrmSaveOrder();
            if (!string.IsNullOrEmpty(invc.Mobile))
            {
                frmSave.txtMobile.Text = invc.Mobile;
            }
            if (!string.IsNullOrEmpty(invc.CustName))
            {
                frmSave.txtCustName.Text = invc.CustName;
            }
            if (!string.IsNullOrEmpty(invc.CustAddress))
            {
                frmSave.txtAddress.Text = invc.CustAddress;
            }

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
            }
            else
            {              
                if (string.IsNullOrEmpty(invoice.InvoiceStatus))
                {
                    invoice.InvoiceStatus = Constants.InvoiceResponse.CANCELLED.ToString();
                    invoice.BillingStatus  = Constants.BillingStatus.CANCELLED.ToString();
                }
                else
                {
                    invoice.BillingStatus = Constants.BillingStatus.CHANGES_CANCELLED.ToString();
                }               
            }         
            frmSave.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string res = string.Empty;
            if (string.IsNullOrEmpty(txtMobile.Text))
            {
                FrmMsg.MsgBox("வாடிக்கையாளர்", "கைபேசி எண்ணை பதிவு செய்யவும்");
                return;
            }

            invoice.CustName = txtCustName.Text;
            invoice.Mobile = txtMobile.Text;
            invoice.CustAddress = txtAddress.Text;
            invoice.CustomerDetails = "ADDED";

            if (PayNow)
            {
                invoice.InvoiceStatus = Constants.InvoiceResponse.SAVED.ToString();
            }
            else
            {
                res = FrmMsg.ConfirmBox("விற்பனை நகல்", "இந்த விற்பனை நகலை சேமிக்க சம்மதமா?");
                if (res == Constants.Response.YES.ToString())
                {
                    //Save the invoice
                    invoice.InvoiceStatus = Constants.InvoiceResponse.SAVED.ToString();
                    invoice.BillingStatus = Constants.InvoiceResponse.SAVED.ToString();
                }
                if (res == Constants.Response.NO.ToString())
                {                    
                    invoice.InvoiceStatus = Constants.InvoiceResponse.CANCELLED.ToString();
                    invoice.BillingStatus = Constants.InvoiceResponse.CANCELLED.ToString();
                }
            }
            frmSave.Dispose();
        }

        private void FrmSaveOrder_Load(object sender, EventArgs e)
        {

        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetNumber(sender, e, txtMobile.Text, 0);
        }
        private void GetNumber(object sender, KeyPressEventArgs e, string val, int decimaldigit)
        {
            if (decimaldigit > 0)
            {
                // Verify that the pressed key isn't CTRL or any non-numeric digit
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // If you want, you can allow decimal (float) numbers
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
                string[] parts = val.Split('.');

                if (val.Split('.').Length > 1)
                {
                    if (val.Split('.')[1].Length > (decimaldigit - 1) || val.Split('.').Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
