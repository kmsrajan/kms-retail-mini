using KMS.Retail.Common;
using KMS.Retail.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS.Retail.Master
{
    public partial class FrmNewSalesOrder : Form
    {
        Item CurrentItem=new Item();
        SoldItem soldItem = new SoldItem();
        List<SoldItem> soldItemColl = new List<SoldItem>();
        DataTable dtable = new DataTable();
        int itmId = 0;

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

                        //cmbPriceCatagory.Items.Clear();
                        
                        cmbPriceCatagory.DataSource = itemPriceColl;
                        cmbPriceCatagory.ValueMember = "Price";
                        cmbPriceCatagory.DisplayMember = "Name";

                        txtPrice.Text = cmbPriceCatagory.SelectedValue.ToString();
                        txtPrice.Enabled = false;
                        cmbPriceCatagory.Enabled = false;
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

            BindCatagory();
            SetGridViewStyle();


        }
        private void SetGridViewStyle()
        {
            dgItems.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dgItems.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgItems.RowTemplate.Height = 30;
            dgItems.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;
            dgItems.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);

            //dgItems.Columns.Add("ID", "ID");
            //dgItems.Columns.Add("Code", "Code");
            //dgItems.Columns.Add("Name", "Name");
            //dgItems.Columns.Add("DisplayName", "DisplayName");
            //dgItems.Columns.Add("MRP", "MRP");
            //dgItems.Columns.Add("SellingPrice", "Price");
            //dgItems.Columns.Add("Qty", "Qty");
            //dgItems.Columns.Add("Amount", "Amount");
            //dgItems.Columns.Add("Discount", "Discount");
        }

        private void BindCatagory()
        {
            MasterDataModel masterData = new MasterDataModel();
            DataTable dt = masterData.GetAllCategories();
            DataRow row = dt.NewRow();
            row[Constants.CON_FLD_CATAGORY_ID] = "0";
            row[Constants.CON_FLD_CATAGORY] = "அனைத்து வகைகளும்";
            dt.Rows.InsertAt(row, 0);
            cmbCategory.DataSource = dt;
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
                (lbItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", Constants.CON_COL_ITEM_CODE, txtItemCode.Text.Trim());
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
                if (!cmbCategory.SelectedValue.ToString().Equals("System.Data.DataRowView"))
                {
                    if (!cmbCategory.SelectedValue.ToString().Equals("0"))
                    {
                        if (!string.IsNullOrEmpty(txtItemCode.Text.Trim()))
                        {
                            (lbItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%' AND {2} LIKE '%{3}%'", Constants.CON_FLD_CATAGORY, cmbCategory.SelectedValue,Constants.CON_COL_ITEM_CODE,txtItemCode.Text.Trim());
                        }
                        else if (!string.IsNullOrEmpty(txtShortName.Text.Trim()))
                        {
                            (lbItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%' AND {2} LIKE '%{3}%'", Constants.CON_FLD_CATAGORY, cmbCategory.SelectedValue, Constants.CON_COL_ITEM_SHORT_NAME, txtShortName.Text.Trim());
                        }
                        else
                        {
                            (lbItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", Constants.CON_FLD_CATAGORY, cmbCategory.SelectedValue);
                        }
                    }
                    else
                    {
                        (lbItems.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                    }
                    if (lbItems.Items.Count > 0)
                    {
                        lbItems.SelectedIndex = 0;
                        txtItemName.Text = lbItems.Text;
                    }
                }
            }
        }

        private void txtShortName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtShortName.Text.Trim()))
            {
                txtItemCode.Text = string.Empty;
                (lbItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", Constants.CON_COL_ITEM_SHORT_NAME, txtShortName.Text.Trim());
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
            if (!IsValidPrice(double.Parse(CurrentItem.PurchasePrice.ToString())))
            {
                FrmMsg.MsgBox("Price validation failed", "Purchase price is grater than sales price");
                return;
            }

            if (!string.IsNullOrEmpty(txtQty.Text.Trim()))
            {
                if (int.Parse(txtQty.Text.Trim()) <= 0)
                {
                    FrmMsg.MsgBox("No quantity", "Please add quantity");
                    return;
                }
            }
            else
            {
                FrmMsg.MsgBox("No quantity", "Please add quantity");
                return;
            }

            soldItem=new SoldItem();
            soldItem.Code = CurrentItem.Code;
            soldItem.ID = itmId++.ToString();
            soldItem.Name = CurrentItem.Name;
            soldItem.DisplayName = CurrentItem.DisplayName;
            soldItem.SellingPrice = CurrentItem.SellingPrice;
            soldItem.Qty = int.Parse(txtQty.Text.Trim());
            soldItem.MRP = CurrentItem.MRP;
            soldItem.Amount = soldItem.Qty * soldItem.SellingPrice;

            soldItemColl.Add(soldItem);
            dtable = ToDataTable(soldItemColl);
            dgItems.DataSource = dtable;

            object sumAmount;
            sumAmount = dtable.Compute("Sum(Amount)", string.Empty);
            txtTotalAmount.Text = sumAmount.ToString();
            txtNetTotal.Text = sumAmount.ToString();

            object sumQty;
            sumQty = dtable.Compute("Sum(Qty)", string.Empty);
            txtTotalQty.Text = sumQty.ToString();
            txtDiscount.Text = "0";
            //if (!string.IsNullOrEmpty(txtDiscount.Text.Trim()))
            //{
            //    txtNetTotal.Text = Convert.ToString(decimal.Parse(txtTotalAmount.Text) - decimal.Parse(txtDiscount.Text));
            //}
        }
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
        private void AddNewItem(SoldItem item)
        {
            DataGridViewRow newItem =new DataGridViewRow();
            newItem.Cells[0].Value = item.ID.ToString();
            newItem.Cells[1].Value = item.Code.ToString();
            newItem.Cells[2].Value = item.Name.ToString();
            newItem.Cells[3].Value = item.DisplayName.ToString();
            newItem.Cells[4].Value = item.SellingPrice.ToString();
            newItem.Cells[5].Value = item.Qty.ToString();
            newItem.Cells[6].Value = item.MRP.ToString();
            newItem.Cells[7].Value = item.MRP.ToString();
            newItem.Cells[8].Value = Convert.ToString(soldItem.Qty * soldItem.SellingPrice);

            dgItems.Rows.Add();
        }
        private Item GetItemDetails(string ItemId)
        {
            CurrentItem = new Item();
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

        private void cmbPriceCatagory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Enabled = true;
        }

        private void txtPrice_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void lblPricecatagory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtPrice.Enabled = true;
            cmbPriceCatagory.Enabled = true;
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            //BindCatagory();
            dgItems.DataSource = soldItemColl;
            dgItems.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemCode.Text = string.Empty;
            txtShortName.Text = string.Empty;
            cmbCategory.SelectedIndex=0;

        }

        private void dgItems_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
           
        }

        private void dgItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiscount.Text.Trim()))
            {
                txtNetTotal.Text = Convert.ToString(decimal.Parse(txtTotalAmount.Text) - decimal.Parse(txtDiscount.Text));
            }
        }

        private void dgItems_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string itid=dgItems.SelectedRows[0].Cells["ID"].Value.ToString();
            var firstMatch = soldItemColl.First(s => s.ID == itid);
            soldItemColl.Remove(firstMatch);

            dtable = ToDataTable(soldItemColl);
            dtable.AcceptChanges();

            dgItems.DataSource = dtable;

        }
    }
}
