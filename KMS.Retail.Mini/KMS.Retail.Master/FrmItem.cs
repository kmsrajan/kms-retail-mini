using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KMS.Retail.Model;
using KMS.Retail.Common;


namespace KMS.Retail.Master
{
    public partial class FrmItem : Form
    {

        public FrmItem()
        {
            InitializeComponent();
        }

        public FrmItem(Item itm, bool isNew,bool isView)
        {
            if (!isNew && !isView)
            {
                SetItemFields(itm);
                SetItemFieldsState(true);
            }
            else if (!isNew && isView)
            {
                SetItemFields(itm);
                SetItemFieldsState(false);
            }
            else
            {
                SetItemFieldsState(true);
            }
            
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void SetItemFields(Item itm)
        {
            txtItemId.Text = itm.ID;
            txtItemCode.Text = itm.Code;
            txtItemName.Text = itm.Name;
            txtItemShortName.Text = itm.ShortName;
            txtItemDispName.Text = itm.DisplayName;
            txtPurchasePrice.Text = itm.PurchasePrice;
            txtSellingPrice.Text = itm.SellingPrice;
            txtWSPrice.Text = itm.WSPrice;
            txtSplPrice.Text = itm.GCPrice;
            txtMRP.Text = itm.MRP;
            txtGST.Text = itm.GST;
            txtTax.Text = itm.Tax;
            txtQty.Text = itm.Qty;
            picItemImage.Text = itm.Picture;
            cmbCategory.Text = itm.Category;
            cmbItemStatus.Text = itm.Status;           
        }
        private Item GetItemInObject()
        {
            Item itm = new Item();
            itm.ID= txtItemId.Text;
            itm.Code= txtItemCode.Text;
            itm.Name = txtItemName.Text;
            itm.ShortName= txtItemShortName.Text;
            itm.DisplayName= txtItemDispName.Text;
            itm.PurchasePrice= txtPurchasePrice.Text;
            itm.SellingPrice= txtSellingPrice.Text;
            itm.WSPrice= txtWSPrice.Text;
            itm.GCPrice= txtSplPrice.Text;
            itm.MRP= txtMRP.Text;
            itm.GST= txtGST.Text;
            itm.Tax= txtTax.Text;
            itm.Qty= txtQty.Text;
            itm.Picture= picItemImage.Text;
            itm.Category= cmbCategory.Text;
            itm.Status= cmbItemStatus.Text;
            return itm;
        }
        private void SetItemFieldsState(bool state)
        {
            txtItemId.Enabled = false;
            txtItemCode.Enabled = state;
            txtItemName.Enabled = state;
            txtItemShortName.Enabled = state;
            txtItemDispName.Enabled = state;
            txtPurchasePrice.Enabled = state;
            txtSellingPrice.Enabled = state;
            txtWSPrice.Enabled = state;
            txtSplPrice.Enabled = state;
            txtMRP.Enabled = state;
            txtGST.Enabled = state;
            txtTax.Enabled = state;
            txtQty.Enabled = state;
            picItemImage.Enabled = state;
            cmbCategory.Enabled = state;
            cmbItemStatus.Enabled = state;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ShowConfirmDialog(Constants.CONST_MSG_002, "Save");
            SetItemFieldsState(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ShowConfirmDialog(Constants.CONST_MSG_003, "Save");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ShowConfirmDialog(Constants.CONST_MSG_001, "Save");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowConfirmDialog(Constants.CONST_MSG_001, "Save");
            this.Close();
        }
        public static bool ShowConfirmDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,

            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            // prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK;

        }
    }
}
