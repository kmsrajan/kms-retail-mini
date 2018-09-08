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
    public partial class FrmSalesInvoices : Form
    {
        Invoice CurrentInvc = new Invoice();
        public static FrmSalesInvoices _frmInstance;
        public static FrmSalesInvoices FrmInstance
        {
            get
            {
                if (FrmSalesInvoices._frmInstance == null)
                {
                    FrmSalesInvoices._frmInstance = new FrmSalesInvoices();
                }
                return FrmSalesInvoices._frmInstance;
            }

        }
        public FrmSalesInvoices()
        {
            InitializeComponent();
        }
        private String RefinedString(DataGridViewCell input)
        {
            String val = string.Empty;
            if (input.Value != null)
            {
                val = Convert.ToString(input.Value);
            }

            return val;
        }

        private Decimal RefinedDecimal(DataGridViewCell input)
        {
            Decimal val = 0;
            if (input.Value != null)
            {
                val = Convert.ToDecimal(input.Value);
            }

            return val;
        }

        private int RefinedInteger(DataGridViewCell input)
        {
            int val = 0;
            if (input.Value != null)
            {
                val = Convert.ToInt32(input.Value);
            }

            return val;
        }
        private void FrmSalesInvoices_Load(object sender, EventArgs e)
        {
            InvoiceDataModel incModel = new InvoiceDataModel();
            dgInvoices.DataSource = incModel.GetAllInvoices();
            dgInvoices.ForeColor = Color.Black;

            dgInvoices.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dgInvoices.RowsDefaultCellStyle.BackColor = Color.Honeydew;
            dgInvoices.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;
            dgInvoices.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void FrmSalesInvoices_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmSalesInvoices._frmInstance = null;
        }

        private void dgInvoices_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetCurrentInvoice(dgInvoices.CurrentRow);
            FillInvoiceDetails();
        }

        private void FillInvoiceDetails()
        {
            if (CurrentInvc.InvoiceStatus.ToUpperInvariant() == Constants.InvoiceResponse.PAID.ToString())
            {
                pnlStatus.BackColor = Color.Green;
                
            }
            if (CurrentInvc.InvoiceStatus == Constants.InvoiceResponse.SAVED.ToString())
            {
                pnlStatus.BackColor = Color.OrangeRed;
            }
            if (CurrentInvc.InvoiceStatus == Constants.InvoiceResponse.CANCELLED.ToString())
            {
                pnlStatus.BackColor = Color.Gray;
            }
            lblInvStatus.Text =string.Format("{0}: {1}",CurrentInvc.InvoiceNo,CurrentInvc.InvoiceStatus);
            txtCustName.Text = CurrentInvc.CustName;
            txtCustNo.Text = CurrentInvc.CustName;
            txtMobile.Text = CurrentInvc.Mobile;
            txtInvcNo.Text = CurrentInvc.InvoiceNo;
            txtDate.Text = CurrentInvc.CreatedDate;
            txtDiscount.Text = CurrentInvc.Discount;
            txtTotalAmount.Text = CurrentInvc.TotalAmount;
            txtTotalTax.Text = CurrentInvc.TotalTax;
            txtReceivedAmount.Text = CurrentInvc.AmountReceived.ToString();
            txtPaymentMode.Text = CurrentInvc.PaymentMode;
        }
        private Invoice GetCurrentInvoice(DataGridViewRow dgvRow)
        {
            CurrentInvc = new Invoice();
            try
            {
              //  DataRow[] result = (lbItems.DataSource as DataTable).Select(string.Format("{0} = {1}", Constants.CON_COL_ITEM_ID, ItemId));
                if (dgvRow!=null)
                {
                    CurrentInvc.ID = CurrentInvc.ID = RefinedString(dgvRow.Cells[Constants.CON_COL_INVC_ID]);
                    CurrentInvc.InvoiceNo = RefinedString(dgvRow.Cells[Constants.CON_COL_INVC_NO]);
                    CurrentInvc.CustName = RefinedString(dgvRow.Cells[Constants.CON_COL_INVC_CUST_NAME]);
                    CurrentInvc.CustAddress = RefinedString(dgvRow.Cells[Constants.CON_COL_INVC_CUST_ADS]);
                    CurrentInvc.Mobile = RefinedString(dgvRow.Cells[Constants.CON_COL_INVC_MOBILE]);
                    CurrentInvc.InvoiceStatus = RefinedString(dgvRow.Cells[Constants.CON_COL_INVC_STAUTS]);
                    CurrentInvc.AmountReceived = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_INVC_AMT_RECEIVED]);
                    CurrentInvc.CreatedDate = RefinedString(dgvRow.Cells[Constants.CON_COL_INVC_DATE]);
                    CurrentInvc.Discount = RefinedString(dgvRow.Cells[Constants.CON_COL_INVC_DISCOUNT]);
                    CurrentInvc.NetTotal = RefinedString(dgvRow.Cells[Constants.CON_COL_INVC_NET_TOTAL]);
                    CurrentInvc.PaymentMode = RefinedString(dgvRow.Cells[Constants.CON_COL_INVC_PAY_MODE]);
                    CurrentInvc.TaxType = RefinedString(dgvRow.Cells[Constants.CON_COL_INVC_TAX_TYPE]);
                    CurrentInvc.TotalAmount = RefinedString(dgvRow.Cells[Constants.CON_COL_INVC_TOTAL_AMT]);
                    CurrentInvc.TotalTax = RefinedString(dgvRow.Cells[Constants.CON_COL_INVC_TOTAL_TAX]);


                    //try
                    //{
                    //    CurrentInvc.Picture = (byte[])result.FirstOrDefault()[Constants.CON_COL_ITEM_PICTURE];
                    //}
                    //catch
                    //{
                    //    CurrentInvc.Picture = null;
                    //}
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return CurrentInvc;
        }

        private void dgInvoices_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GetCurrentInvoice(dgInvoices.Rows[e.RowIndex]);
            FillInvoiceDetails();
        }
    }
}
