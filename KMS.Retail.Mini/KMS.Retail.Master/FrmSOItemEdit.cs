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
    public partial class FrmSOItemEdit : Form
    {
        static FrmSOItemEdit frmSoEdit;
        static string response = string.Empty;
        public FrmSOItemEdit()
        {
            InitializeComponent();
        }

        private void FrmSOItemEdit_Load(object sender, EventArgs e)
        {

        }
        public static string ItemBox(string Id, string qty, string code)
        {
            frmSoEdit = new FrmSOItemEdit();
            ItemDataModel itmModel = new ItemDataModel();
            List<ItemPrice> priceColl = new List<ItemPrice>();
            
            if (code != "0000") { 
                priceColl = itmModel.GetUniqueItem(Constants.CON_PARAM_ITEM_COMMON, Id);
                if (priceColl != null)
                {

                    frmSoEdit.cmbPriceCatagory.DataSource = priceColl;

                    frmSoEdit.cmbPriceCatagory.ValueMember = "Price";
                    frmSoEdit.cmbPriceCatagory.DisplayMember = "Name";
                    // frmSoEdit.txtPrice.ReadOnly = true;
                    frmSoEdit.txtPrice.Text = frmSoEdit.cmbPriceCatagory.SelectedValue.ToString();
                   
                }
            }
            
           

            frmSoEdit = new FrmSOItemEdit();
            frmSoEdit.txtQty.Text = qty.ToString();

            frmSoEdit.ShowDialog();
            return response;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {            
            if (IsValid())
            {
                response = string.Format("UPDATED|{0}|{1}", txtQty.Text, txtPrice.Text);
                frmSoEdit.Dispose();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            response = "DELETED";
            frmSoEdit.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            response = "CANCELLED";
            frmSoEdit.Dispose();
        }

        private void cmbPriceCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Text = cmbPriceCatagory.SelectedValue.ToString();
        }
        private bool IsValid()
        {
            bool isValid = true;
            try
            {
                if (!string.IsNullOrEmpty(txtPrice.Text.Trim()))
                {
                    if (double.Parse(txtPrice.Text.Trim()) <= 0)
                    {
                        lblMsg.Text = "Price cannot be zero or less than zero";
                        isValid = false;
                    }
                   
                }
                else
                {
                    lblMsg.Text = "Price cannot be empty";
                    isValid = false;
                }
                
                if (!string.IsNullOrEmpty(txtQty.Text.Trim()))
                {
                    if (int.Parse(txtQty.Text.Trim()) <= 0)
                    {
                        lblMsg.Text = "Please add quantity";
                        isValid = false;
                    }
                }
                else
                {
                    lblMsg.Text = "Please add quantity";
                    isValid = false;
                }
            }
            catch
            {
                isValid = false;
            }
            return isValid;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
        }
    }
}
