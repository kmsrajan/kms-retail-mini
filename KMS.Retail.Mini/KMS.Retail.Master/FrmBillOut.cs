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
    public partial class FrmBillOut : Form
    {
        static FrmBillOut frmBillout;
        static string response = string.Empty;
        static Invoice invoice = new Invoice();
        public FrmBillOut()
        {
            InitializeComponent();
        }

        private void cbPaid_CheckedChanged(object sender, EventArgs e)
        {
            string res = string.Empty;
            if (cbPaid.Checked)
            {
                invoice.PaymentMode = cmbPaymentMode.Text;
                invoice.AmountReceived = txtAmountReceived.Text.Trim();
                invoice.PaymentStatus = Constants.Response.SUCCESS.ToString();
                invoice.InvoiceStatus = "Paid";
                invoice.BalanceAmount = Convert.ToString(decimal.Parse(invoice.AmountReceived) - decimal.Parse(invoice.NetTotal));
                txtBalAmount.Text = invoice.BalanceAmount;
                //Save the invoice

                lblInvNo.Text = "";
                InvoiceDataModel invModel = new InvoiceDataModel();
                invModel.AddNewInvoice(invoice);

                res = FrmMsg.ConfirmBox("Payment","Is payment completed?");
                if (res == Constants.Response.YES.ToString())
                {

                    txtAmountReceived.Enabled = false;
                    btnComplete.Visible = true;
                    btnPrint.Visible = true;
                }
                else
                {
                    txtAmountReceived.Enabled = true;
                    btnComplete.Visible = false;
                    btnPrint.Visible = false;
                    cbPaid.Checked = false;
                }
            }
            else
            {
                txtAmountReceived.Enabled = true;
                btnComplete.Visible = false;
                btnPrint.Visible = false;
            }
        }
        public static string MakePayment(Invoice invc)
        {
            //invc.CustName = frmSave.txtCustName.Text;
            //invc.Mobile = frmSave.txtMobile.Text;
            //invc.CustAddress = frmSave.txtAddress.Text;
    
            frmBillout = new FrmBillOut();
            invoice = invc;
            frmBillout.btnComplete.Visible = false;
            frmBillout.btnPrint.Visible = false;
            frmBillout.ShowDialog();
            return response;
        }
        private void FrmBillOut_Load(object sender, EventArgs e)
        {
            cmbPaymentMode.SelectedText = "Cash";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            response = Constants.Response.SUCCESS.ToString();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            response = Constants.Response.SUCCESS.ToString();
        }

        private void FrmBillOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void txtAmountReceived_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmountReceived.Text))
            {
                if (decimal.Parse(txtAmountReceived.Text) > 0)
                {
                    txtBalAmount.Text = Convert.ToString(decimal.Parse(txtAmountReceived.Text) - decimal.Parse(invoice.NetTotal));
                    invoice.BalanceAmount = txtBalAmount.Text;
                    invoice.AmountReceived = txtAmountReceived.Text;
                }
            }
        }
    }
}
