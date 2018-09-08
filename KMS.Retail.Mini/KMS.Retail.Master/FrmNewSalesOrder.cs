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
        Invoice CurrentInvc = new Invoice();

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
                        if (itm.Code != "0000")
                        {
                            if (itm.SellingPrice > 0)
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
                            //cmbPriceCatagory.Items.Clear();

                            cmbPriceCatagory.DataSource = itemPriceColl;
                            cmbPriceCatagory.ValueMember = "Price";
                            cmbPriceCatagory.DisplayMember = "Name";

                            txtPrice.Text = cmbPriceCatagory.SelectedValue.ToString();
                            txtPrice.Enabled = false;
                            cmbPriceCatagory.Enabled = false;
                        }
                        else
                        {
                            txtPrice.Enabled = true ;
                            txtQty.Text = string.Empty;
                            txtPrice.Text = string.Empty;
                            cmbPriceCatagory.Enabled = false;
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

            lblInvoice.Text = "New draft";

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
            if (e.KeyCode == Keys.Down)
            {
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
                //FrmMsg.MsgBox("Price validation failed", "Purchase price is grater than sales price");
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
            soldItem.ItemId = CurrentItem.ID;
            soldItem.Code = CurrentItem.Code;
            soldItem.ID = itmId++.ToString();
            soldItem.Name = CurrentItem.Name;
            soldItem.DisplayName = CurrentItem.DisplayName;
            soldItem.SellingPrice =decimal.Parse(txtPrice.Text);
            soldItem.Qty = int.Parse(txtQty.Text.Trim());
            if (CurrentItem.Code != "0000")
            {
                soldItem.MRP = CurrentItem.MRP;
            }
            else
            {
                soldItem.MRP = 0;
            }
            soldItem.Amount = soldItem.Qty * soldItem.SellingPrice;
            
            soldItemColl.Add(soldItem);
            dtable = ToDataTable(soldItemColl);
            dgItems.DataSource = dtable;

            //object sumAmount;
            //sumAmount = dtable.Compute("Sum(Amount)", string.Empty);
            //txtTotalAmount.Text = sumAmount.ToString();
            BillAmountCalculator();

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
                    FrmMsg.MsgBox("Price validation failed", "Price cannot be empty");
                    isValid = false;
                }
                else if (double.Parse(txtPrice.Text.Trim())<=0)
                {
                    FrmMsg.MsgBox("Price validation failed", "Price cannot be zero or less than zero");
                    isValid = false;
                }
                else
                {
                    //check if modified price is less than purchase price
                    if (double.Parse(txtPrice.Text.Trim()) < purPrice)
                    {
                        FrmMsg.MsgBox("Price validation failed", "Purchase price is grater than sales price");
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
                    if (!string.IsNullOrEmpty(txtPrice.Text)){
                        txtAmount.Text = Math.Round((decimal.Parse(txtQty.Text.Trim()) * decimal.Parse(txtPrice.Text)),2).ToString();
                    }
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
            string response=FrmSOItemEdit.ItemBox(dgItems.Rows[e.RowIndex].Cells["ItemId"].Value.ToString(), dgItems.Rows[e.RowIndex].Cells["Qty"].Value.ToString(), dgItems.Rows[e.RowIndex].Cells["Code"].Value.ToString());
            if (response.ToLowerInvariant().StartsWith("update"))
            {
                string[] resVal = response.Split('|');

                dgItems.Rows[e.RowIndex].Cells["Qty"].Value = resVal[1];
                dgItems.Rows[e.RowIndex].Cells["SellingPrice"].Value = resVal[2];

                dgItems.Rows[e.RowIndex].Cells["Amount"].Value = decimal.Parse(resVal[2])*decimal.Parse(resVal[1]);
                BillAmountCalculator();
            }
            return;
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiscount.Text.Trim()))
            {
                txtNetTotal.Text = Convert.ToString(decimal.Parse(txtTotalAmount.Text)+ decimal.Parse(txtTax.Text) - decimal.Parse(txtDiscount.Text));
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

        private void txtTaxbox_Leave(object sender, EventArgs e)
        {
            BillAmountCalculator();
               
        }

        private void txtTaxbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetNumber(sender, e, txtTaxPercentage.Text, 2);
            BillAmountCalculator();
        }

        private void BillAmountCalculator()
        {
            double taxPer = 0.0;
            //double totalAmt = double.Parse(txtTaxPercentage.Text.Trim());
            //double taxPer = double.Parse(txtTaxPercentage.Text.Trim());
            //double taxPer = double.Parse(txtTaxPercentage.Text.Trim());
            //double taxPer = double.Parse(txtTaxPercentage.Text.Trim());

            double totalTax = 0.0;
            double totalAmt = 0.0;
            double discount = 0.0;
            double netTotal = 0.0;

            //total withour tax
            if (dgItems.Rows.Count > 0)
            {
                object sumAmount;
                sumAmount = dtable.Compute("Sum(Amount)", string.Empty);
                totalAmt =double.Parse(sumAmount.ToString());
            }

            //total tax calculation
            if (!string.IsNullOrEmpty(txtTaxPercentage.Text))
            {
                taxPer=double.Parse(txtTaxPercentage.Text.Trim());
                if (taxPer > 0)
                {
                    totalTax = (double.Parse(txtTotalAmount.Text) / 100) * double.Parse(txtTaxPercentage.Text);
                }

            }

            //net total calculation
            if (string.IsNullOrEmpty(txtDiscount.Text))
            {
                netTotal=totalAmt+totalTax;
            }
            else
            {
                discount = double.Parse(txtDiscount.Text);
                netTotal = totalAmt + totalTax-discount;
            }

            //fill text box
            txtTotalAmount.Text = Convert.ToString(totalAmt);
            txtTax.Text = Convert.ToString(totalTax);
            txtNetTotal.Text = Convert.ToString(netTotal);
        }

        private void dgItems_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            string res = string.Empty;
            string invcId = string.Empty;

            if (dgItems.Rows.Count > 0)
            {
                PrepareInvoice();
                CurrentInvc = FrmSaveOrder.SaveSalesOrder(CurrentInvc);

                if (CurrentInvc.BillingStatus == Constants.BillingStatus.SAVED.ToString())
                {
                    InvoiceDataModel invModel = new InvoiceDataModel();
                    CurrentInvc.InvoiceStatus = Constants.InvoiceResponse.SAVED.ToString();
                    CurrentInvc.PaymentMode = string.Empty;
                    CurrentInvc.AmountReceived = 0;
                    invcId=invModel.SaveInvoice(CurrentInvc);
                    if (!string.IsNullOrEmpty(invcId))
                    {
                        CurrentInvc.ID = invcId;
                    }
                 
                    lblInvoice.Text = CurrentInvc.ID;
                    txtStatus.Text= CurrentInvc.InvoiceStatus.ToString();

                    FrmMsg.MsgBox("விவரம்", "இந்த ரசீது விற்பனை பட்டியலில் சேமிக்கப்பட்டுவிட்டது");
                }
                if (CurrentInvc.BillingStatus == Constants.BillingStatus.CANCELLED.ToString())
                {
                    res = FrmMsg.MsgBox("விற்பனை நகல்", "இந்த ரசீது இதுவரை சேமிக்கப் படவில்லை");                
                }
                if(CurrentInvc.BillingStatus == Constants.BillingStatus.CHANGES_CANCELLED.ToString())
            {
                res = FrmMsg.MsgBox("விற்பனை நகல்", "இந்த ரசீதின் மாற்றங்கள் சேமிக்கப்படவில்லை");
            }

            }
            else
            {
                FrmMsg.MsgBox("விவரம்", "பொருள் ஏதும் அட்டவணையில் இல்லை");
            }
        }
        private void PrepareInvoice()
        {
            Invoice inv = new Invoice();

            DataTable itemsDt = (DataTable)(dgItems.DataSource);

            CurrentInvc.Items = itemsDt;
            CurrentInvc.TotalAmount = txtTotalAmount.Text;
            CurrentInvc.TaxType = string.Empty;
            CurrentInvc.TotalTax = txtTax.Text;
            CurrentInvc.Discount = txtDiscount.Text;
            CurrentInvc.NetTotal = txtNetTotal.Text;
            CurrentInvc.PaymentMode = string.Empty;
            CurrentInvc.BillingStatus = string.Empty;
            CurrentInvc.AmountReceived = 0;
            CurrentInvc.CreatedDate = DateTime.Now.ToString();
           
        }
        private void btnPayOrder_Click(object sender, EventArgs e)
        {
            if (dgItems.Rows.Count > 0)
            {
                PrepareInvoice();
                CurrentInvc = FrmSaveOrder.MakePayment(CurrentInvc);
                if (!string.IsNullOrEmpty(CurrentInvc.CustomerDetails))
                {
                    string res= FrmBillOut.MakePayment(CurrentInvc);
                    if (res == Constants.Response.SUCCESS.ToString())
                    {
                        FrmMsg.MsgBox("விவரம்", "இந்த ரசீது விற்பனை  பட்டியலில் சேமிக்கப் பட்டுவிட்டது");
                        this.Close();
                    }
                }
            }
            else
            {
                FrmMsg.MsgBox("விவரம்", "பொருள் ஏதும் அட்டவணையில் இல்லை");
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (dgItems.Rows.Count > 0)
            {
                string res=FrmMsg.ConfirmBox("விற்பனை நகல்", "நகலை நிராகரித்தால் இதனை மீண்டும் பெற இயலாது. சம்மதமா?");
                //Invoice invc = PrepareInvoice();
                //InvoiceDataModel invModel = new InvoiceDataModel();
                //invc.InvoiceStatus = Constants.InvoiceResponse.CANCELLED.ToString();
                //invModel.AddNewInvoice(invc);
                if (res == Constants.Response.YES.ToString())
                {
                    FrmMsg.MsgBox("விற்பனை நகல்", "ரசீது நிராகரிக்கப் பட்டுவிட்டது.");
                    this.Close();
                }
            }
        }

        private void btnClearInvoice_Click(object sender, EventArgs e)
        {
            NewInvoice();
        }
        private void NewInvoice()
        {
            CurrentItem = new Item();
            soldItem = new SoldItem();
            soldItemColl = new List<SoldItem>();
            dtable = new DataTable();
            itmId = 0;
            txtDiscount.Text = string.Empty;
            txtNetTotal.Text = string.Empty;
            txtTax.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
            txtTotalQty.Text = string.Empty;
            lblInvoice.Text = "New draft";

            soldItemColl.Clear();
            soldItemColl = new List<SoldItem>();
            dtable.Clear();
            dgItems.DataSource = dtable;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //// Verify that the pressed key isn't CTRL or any non-numeric digit
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            //// If you want, you can allow decimal (float) numbers
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
            GetNumber(sender,e,txtQty.Text,2);
        }
        private void GetNumber(object sender, KeyPressEventArgs e,string val,int decimaldigit)
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
        

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetNumber(sender, e,txtPrice.Text,2);
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            GetTotalAmount();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            GetTotalAmount();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            GetTotalAmount();
        }

        private void FrmNewSalesOrder_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode){
                case Keys.F1:
                    btnAddItem_Click(null, null);
                    
                    break;
                case Keys.F2:
                    txtItemCode.Focus();
                    break;
                case Keys.F3:
                    cmbCategory.Focus();
                    break;
                case Keys.F4:
                    txtQty.Focus();
                    break;
                //case Keys.F11:
                //    btnCancelOrder_Click(null, null);
                //    break;
                //case Keys.F5:
                //    btnAddNewStack_Click(null, null);
                //    break;
                //case Keys.F12:
                //    btnClear_Click(null, null);
                //    break;                  
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                btnClear_Click(null, null);
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                btnAddNewStack_Click(null, null);
            }
        }

        private void txtTaxPercentage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetNumber(sender, e, txtDiscount.Text, 2);
        }
    }
}
