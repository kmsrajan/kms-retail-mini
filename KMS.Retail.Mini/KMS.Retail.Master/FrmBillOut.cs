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
            string invcId = string.Empty;
            if (cbPaid.Checked)
            {
                invoice.PaymentMode = cmbPaymentMode.Text;
                invoice.AmountReceived = decimal.Parse(txtAmountReceived.Text.Trim());
                invoice.BillingStatus = Constants.Response.SUCCESS.ToString();
                invoice.InvoiceStatus = Constants.InvoiceResponse.PAID.ToString();
                invoice.BalanceAmount = Convert.ToString(invoice.AmountReceived - decimal.Parse(invoice.NetTotal));
                txtBalAmount.Text = invoice.BalanceAmount;

                //Save the invoice
                lblInvNo.Text = string.Empty;
                InvoiceDataModel invModel = new InvoiceDataModel();
                invcId= invModel.SaveInvoice(invoice);
                if (!string.IsNullOrEmpty(invcId))
                {
                    invoice.ID = invcId;
                }

                res = FrmMsg.ConfirmBox("கட்டணம்", "பணம் பெறப்பட்டு விட்டதா?");
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
            frmBillout = new FrmBillOut();
            invoice = invc;
            frmBillout.btnComplete.Visible = false;
            frmBillout.btnPrint.Visible = false;
            frmBillout.txtTotalAmount.Text = invoice.TotalAmount.ToString();
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
                    invoice.AmountReceived =decimal.Parse(txtAmountReceived.Text);
                }
            }
        }

        private void txtAmountReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetNumber(sender,e,txtAmountReceived.Text,2);
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
