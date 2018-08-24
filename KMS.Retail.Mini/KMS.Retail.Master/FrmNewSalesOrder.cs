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
    public partial class FrmNewSalesOrder : Form
    {
        private static FrmNewSalesOrder _frmInstance;
        public static FrmNewSalesOrder FrmInstance
        {
            get
            {
                if (FrmNewSalesOrder._frmInstance == null)
                {
                    FrmNewSalesOrder._frmInstance = new FrmNewSalesOrder();
                }
                return FrmNewSalesOrder._frmInstance;
            }
        }
        public FrmNewSalesOrder()
        {
            InitializeComponent();
        }

        private void cbTax_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtItemName.Text = lbItems.Text;
            List<ItemPrice> itemPriceColl = new List<ItemPrice>();
            try
            {
                if (!string.IsNullOrEmpty(lbItems.SelectedValue.ToString()))
                {
                    if (!lbItems.SelectedValue.ToString().Equals("System.Data.DataRowView"))
                    {
                        Item itm=GetItemDetails(lbItems.SelectedValue.ToString());

                        if(itm.SellingPrice > 0)
                        {
                            itemPriceColl.Add(new ItemPrice(Constants.CON_COL_ITEM_SELLING_PRICE, itm.SellingPrice.ToString()));
                        }
                        if (itm.WSPrice > 0)
                        {
                            itemPriceColl.Add(new ItemPrice(Constants.CON_COL_ITEM_WS_PRICE, itm.WSPrice.ToString()));
                        }
                        if (itm.SplPrice > 0)
                        {
                            itemPriceColl.Add(new ItemPrice(Constants.CON_COL_ITEM_SPL_PRICE, itm.SplPrice.ToString()));

                            if (itm.MRP > 0)
                            {
                                itemPriceColl.Add(new ItemPrice(Constants.CON_COL_ITEM_MRP, itm.MRP.ToString()));
                            }
                        }
                                                
                        txtQty.Text = itm.Qty.ToString();

                        if (itm.Picture != null)
                        {
                            pbItem.Image = Global.ByteArrayToImage(itm.Picture);
                        }
                        else
                        {
                            pbItem.Image = null;
                        }

                        cmbPriceCatagory.DataSource = itemPriceColl;
                        cmbPriceCatagory.ValueMember = "Price";
                        cmbPriceCatagory.DisplayMember = "Name";

                        cmbPriceCatagory.SelectedText = Constants.CON_COL_ITEM_SELLING_PRICE;

                    }
                }
            }
            catch { }

        }

        private void FrmNewSalesOrder_Load(object sender, EventArgs e)
        {
            //load all items in to listbox
            ItemDataModel itmModel = new ItemDataModel();
            lbItems.DataSource = itmModel.GetAllAvailableItems();
            lbItems.DisplayMember =Constants.CON_COL_ITEM_DISP_NAME;
            lbItems.ValueMember = Constants.CON_COL_ITEM_ID;
                        
            MasterDataModel masterData = new MasterDataModel();
            cmbCategory.DataSource = masterData.GetAllCategories();
            cmbCategory.ValueMember = Constants.CON_FLD_CATAGORY_ID;
            cmbCategory.DisplayMember = Constants.CON_FLD_CATAGORY;

        }

        private void FrmNewSalesOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmNewSalesOrder._frmInstance = null;
        }

        private void txtItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Down) {
                lbItems.Focus();
            }
            
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItemCode.Text.Trim()))
            {
                txtShortName.Text = string.Empty;
                (lbItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'",Constants.CON_COL_ITEM_CODE,txtItemCode.Text.Trim());
                if (lbItems.Items.Count > 0)
                {
                    lbItems.SelectedIndex = 0;
                    txtItemName.Text = lbItems.Text;
                }
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbCategory.SelectedValue.ToString()))
            {
                
                (lbItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'",Constants.CON_FLD_CATAGORY, cmbCategory.SelectedValue);
                if (lbItems.Items.Count > 0)
                {
                    lbItems.SelectedIndex = 0;
                    txtItemName.Text = lbItems.Text;
                }
            }
        }

        private void txtShortName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtShortName.Text.Trim()))
            {
                txtItemCode.Text = string.Empty;
                (lbItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'",Constants.CON_COL_ITEM_SHORT_NAME,txtShortName.Text.Trim());
                if (lbItems.Items.Count > 0)
                {
                    lbItems.SelectedIndex = 0;
                    txtItemName.Text = lbItems.Text;
                    GetItemDetails(lbItems.SelectedValue.ToString());
                }
            }
        }

        private void txtShortName_KeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Down)
            {
                lbItems.Focus();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!IsValidPrice(10.52))
            {
                FrmMsg.MsgBox("Price validation failed", "Purchase price is grater than sales price");
            }
        }

        private Item GetItemDetails(string ItemId)
        {
            Item CurrentItem = new Item();
            try
            {
                DataRow[] result = (lbItems.DataSource as DataTable).Select(string.Format("{0} = {1}",Constants.CON_COL_ITEM_ID,ItemId));
                if (result.Count() == 1)
                {
                    CurrentItem.ID = result.FirstOrDefault()[Constants.CON_COL_ITEM_ID].ToString();
                    CurrentItem.ID = RefinedString(result.FirstOrDefault()[Constants.CON_COL_ITEM_ID].ToString());
                    CurrentItem.Code = RefinedString(result.FirstOrDefault()[Constants.CON_COL_ITEM_CODE].ToString());
                    CurrentItem.Name = RefinedString(result.FirstOrDefault()[Constants.CON_COL_ITEM_NAME].ToString());
                    CurrentItem.DisplayName = RefinedString(result.FirstOrDefault()[Constants.CON_COL_ITEM_NAME].ToString());
                    CurrentItem.ShortName = RefinedString(result.FirstOrDefault()[Constants.CON_COL_ITEM_SHORT_NAME].ToString());
                    CurrentItem.MRP = RefinedDecimal(result.FirstOrDefault()[Constants.CON_COL_ITEM_MRP].ToString());
                    CurrentItem.SellingPrice = RefinedDecimal(result.FirstOrDefault()[Constants.CON_COL_ITEM_SELLING_PRICE].ToString());
                    CurrentItem.PurchasePrice = RefinedDecimal(result.FirstOrDefault()[Constants.CON_COL_ITEM_PUR_PRICE].ToString());
                    CurrentItem.Qty = RefinedInteger(result.FirstOrDefault()[Constants.CON_COL_ITEM_QTY].ToString());
                    CurrentItem.WSPrice = RefinedDecimal(result.FirstOrDefault()[Constants.CON_COL_ITEM_WS_PRICE].ToString());
                    CurrentItem.SplPrice = RefinedDecimal(result.FirstOrDefault()[Constants.CON_COL_ITEM_SPL_PRICE].ToString());
                    CurrentItem.Status = RefinedString(result.FirstOrDefault()[Constants.CON_COL_ITEM_STATUS_ID].ToString());
                    CurrentItem.Category = RefinedString(result.FirstOrDefault()[Constants.CON_COL_ITEM_CATEGORY_ID].ToString());
                    CurrentItem.GST = RefinedInteger(result.FirstOrDefault()[Constants.CON_COL_ITEM_GST].ToString());
                    CurrentItem.Tax = RefinedDecimal(result.FirstOrDefault()[Constants.CON_COL_ITEM_TAX].ToString());
                    CurrentItem.DateCreated = RefinedString(result.FirstOrDefault()[Constants.CON_COL_ITEM_CREATED_DATE].ToString());

                    try
                    {
                        CurrentItem.Picture = (byte[])result.FirstOrDefault()[Constants.CON_COL_ITEM_PICTURE];
                    }
                    catch
                    {
                        CurrentItem.Picture = null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return CurrentItem;
        }
        private bool IsValidPrice(double purPrice)
        {
            bool isValid = true;
            try
            {
                if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
                {
                    isValid = false;
                }
                else
                {
                    //check if modified price is less than purchase price
                    if (double.Parse(txtPrice.Text.Trim()) < purPrice)
                    {
                        isValid = false;
                    }
                    
                }
            }
            catch
            {
                isValid = false;
            }
            return isValid;
        }


        private String RefinedString(string input)
        {
            String val = string.Empty;
            if (input != null)
            {
                val = Convert.ToString(input);
            }

            return val;
        }

        private Decimal RefinedDecimal(string input)
        {
            Decimal val = 0;
            if (input != null)
            {
                val = Convert.ToDecimal(input);
            }

            return val;
        }

        private int RefinedInteger(string input)
        {
            int val = 0;
            if (input != null)
            {
                val = Convert.ToInt32(input);
            }

            return val;
        }

        private void cmbPriceCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Text = cmbPriceCatagory.SelectedValue.ToString();
            GetTotalAmount();
        }

        private void GetTotalAmount()
        {
            if (string.IsNullOrEmpty(txtQty.Text))
            {
                txtAmount.Text = string.Empty;
            }
            else
            {
                if (!txtPrice.Text.Equals("KMS.Retail.Model.ItemPrice"))
                {
                    txtAmount.Text = Convert.ToString(decimal.Parse(txtQty.Text.Trim()) * decimal.Parse(txtPrice.Text));
                }
            }
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            GetTotalAmount();
        }

        private void btnAddNewStack_Click(object sender, EventArgs e)
        {
            FrmItem frmItem = new FrmItem();
            frmItem.StartPosition = FormStartPosition.CenterParent;
            if (frmItem.ShowDialog() == DialogResult.OK)
            {
                ItemDataModel itmModel = new ItemDataModel();
                lbItems.DataSource = itmModel.GetAllAvailableItems();
                lbItems.DisplayMember = Constants.CON_COL_ITEM_DISP_NAME;
                lbItems.ValueMember = Constants.CON_COL_ITEM_ID;

                MasterDataModel masterData = new MasterDataModel();
                cmbCategory.DataSource = masterData.GetAllCategories();
                cmbCategory.ValueMember = Constants.CON_FLD_CATAGORY_ID;
                cmbCategory.DisplayMember = Constants.CON_FLD_CATAGORY;
            }
        }
    }
}
