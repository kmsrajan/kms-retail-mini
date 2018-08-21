using KMsTech.RetailInterfaces;
using KMsTech.RetailEntities;
using KMsTech.RetailCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KMsTech.RetailController;
using System.Security;

namespace KMsTech.RetailMaster
{
    public partial class FrmItems : Form, IItemView,IStatusView,IBrandView,ICategoryView,IScaleView
    {
        private static FrmItems _frmInstance;
        ItemController itemCtl;
        ScaleController sclaeCtl;
        StatusController stautsCtl;
        CategoryController catCtl;
        BrandController brndCtl;

        public DataTable ItemsCollection { get; set; }
        public DataTable StatusCollection { get; set; }
        public DataTable ScaleCollection { get; set; }
        public DataTable CatCollection { get; set; }
        public DataTable BrandsCollection { get; set; }        

        public static FrmItems FrmInstance
        {
            get
            {
                if (FrmItems._frmInstance == null)
                {
                    FrmItems._frmInstance = new FrmItems();
                }
                return FrmItems._frmInstance;
            }
        }

        public FrmItems()
        {
            InitializeComponent();
            itemCtl = new ItemController(this);
            catCtl = new CategoryController(this);
            stautsCtl = new StatusController(this);
            sclaeCtl = new ScaleController(this);
            brndCtl = new BrandController(this);
        }

        private void FrmItems_Load(object sender, EventArgs e)
        {


            GetAllMaster();
            //set item status
            cmbStatus.DataSource = StatusCollection;
            cmbStatus.ValueMember = "SID";
            cmbStatus.DisplayMember = "StatusName";


            //set item scale
            cmbScale.DataSource = ScaleCollection;
            cmbScale.ValueMember = "SCID";
            cmbScale.DisplayMember = "Scale";

            //set item categories
            cmbCategory.DataSource = CatCollection;
            cmbCategory.ValueMember = "ICID";
            cmbCategory.DisplayMember = "CategoryName";


            cmbBrand.DataSource = BrandsCollection;
            cmbBrand.ValueMember = "BID";
            cmbBrand.DisplayMember = "BrandName";

            SetItem(true);
           // Clear();
            GetAllItems();
            dgvItems.DataSource = ItemsCollection;
        }

        public void SaveItem(Item item)
        {
            itemCtl.SaveItem(item);
            dgvItems.DataSource = ItemsCollection;
        }

        public void DeleteItem(string iCode)
        {
            itemCtl.DeleteItem(iCode);
            dgvItems.DataSource = ItemsCollection;
        }

        public void GetAllItems()
        {
            itemCtl.GetAllItems();
        }

        public void GetAllMaster()
        {
           // masterCtl.GetAllCategories();
            //masterCtl.GetAllScales();
            
            stautsCtl.GetAllStatuses();
            sclaeCtl.GetAllScales();
            catCtl.GetAllCategories();
            brndCtl.GetAllBrands();

        }
        
        public void GetAllStatuses()
        {
           // masterCtl.GetAllCategories();
            //masterCtl.GetAllScales();
            stautsCtl.GetAllStatuses();

        }

        public void GetAllCategories()
        {
           // masterCtl.GetAllCategories();
            //masterCtl.GetAllScales();
            catCtl.GetAllCategories();

        }

        private void SetItem(bool isActive)
        {
            //enable or disable the field based on input param
            txtItemCode.Enabled = isActive;
            txtItemName.Enabled = isActive;
            txtItemDispName.Enabled = isActive;
            txtAlert.Enabled = isActive;
            txtExpense.Enabled = isActive;
            txtMrp.Enabled = isActive;
            txtNewStock.Enabled = isActive;
            txtSellingPrice.Enabled = isActive;
            txtPurPrice.Enabled = isActive;
            txtQty.Enabled = isActive;
            txtShortName.Enabled = isActive;
            txtStock.Enabled = isActive;
            txtUnit.Enabled = isActive;
            txtWSprice.Enabled = isActive;
            txtNewSellingPrice.Enabled = isActive;
            txtNewWSPrice.Enabled = isActive;
        }

        private void SetItem(Item item)
        {
            //set all item details
            txtItemCode.Text = item.ItemCode;
            txtItemName.Text = item.ItemName;
            txtItemDispName.Text = item.DisplayName;
            txtAlert.Text = Convert.ToString(item.Alert);
            txtExpense.Text = Convert.ToString(item.Expense);
            txtMrp.Text = Convert.ToString(item.MRP);
            txtNewStock.Text = Convert.ToString(item.NewStock);
            txtSellingPrice.Text = Convert.ToString(item.SellingPrice);
            txtPurPrice.Text = Convert.ToString(item.PurPrice);
            txtQty.Text = Convert.ToString(item.Qty);
            txtShortName.Text = item.ShortName;
            txtStock.Text = Convert.ToString(item.Stock);
            txtUnit.Text = Convert.ToString(item.Unit);
            txtWSprice.Text = Convert.ToString(item.WSPrice);
            txtNewSellingPrice.Text = Convert.ToString(item.NewSellingPrice);
            txtNewWSPrice.Text = Convert.ToString(item.NewWSPrice);
            if (item.Picture != null)
            {
                picItem.Image = Common.ByteArrayToImage(item.Picture);
            }
            else
            {
                picItem.Image = null;
            }
        }

        private void Clear()
        {
           //clear all text boxes
            txtItemCode.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtItemDispName.Text = string.Empty;
            txtAlert.Text = string.Empty;
            txtExpense.Text = string.Empty;
            txtMrp.Text = string.Empty;
            txtNewStock.Text = string.Empty;
            txtSellingPrice.Text = string.Empty;
            txtPurPrice.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtShortName.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtWSprice.Text = string.Empty;
            txtNewSellingPrice.Text = string.Empty;
            txtNewWSPrice.Text = string.Empty;
        }

        private void GetSelectedItem(DataGridViewRow dgvRow)
        {
            //Brand brand = new Brand();
            //brand.BrandId = RefinedString(dgvRow.Cells[Constants.CON_COL_BRAND_ID]);
            //brand.Name = RefinedString(dgvRow.Cells[Constants.CON_COL_BRAND_NAME]);
            //brand.DisplayName = RefinedString(dgvRow.Cells[Constants.CON_COL_BRAND_DISP_NAME]);
            //brand.Status = RefinedString(dgvRow.Cells[Constants.CON_COL_BRAND_STATUS]);

            //SetBrand(brand);

            Item item = new Item();
            item.ItemCode = RefinedString(dgvRow.Cells[Constants.CON_COL_ITEM_CODE]);
            item.ItemName = RefinedString(dgvRow.Cells[Constants.CON_COL_ITEM_NAME]);
            item.DisplayName = RefinedString(dgvRow.Cells[Constants.CON_COL_ITEM_NAME]);
            item.ShortName = RefinedString(dgvRow.Cells[Constants.CON_COL_ITEM_SHORT_NAME]);
            item.Alert = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_ALERT]);
            item.Expense = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_EXPENSE]);
            item.MRP = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_MRP]);
            item.NewStock = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_NEW_STACK]);
            item.SellingPrice = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_SELLING_PRICE]);
            item.PurPrice = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_PUR_PRICE]);
            item.Qty = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_QTY]);
            item.Stock = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_STOCK]);
            item.Unit = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_UNIT]);
            item.WSPrice = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_WS_PRICE]);
            item.NewSellingPrice = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_NEW_SELLING_PRICE]);
            item.NewWSPrice = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_NEW_WS_PRICE]);
            item.Status = RefinedInteger(dgvRow.Cells[Constants.CON_COL_ITEM_STATUS_ID]);
            item.Brand = RefinedInteger(dgvRow.Cells[Constants.CON_COL_ITEM_BRAND_ID]);
            item.Category = RefinedInteger(dgvRow.Cells[Constants.CON_COL_ITEM_CATEGORY_ID]);
            item.Scale = RefinedInteger(dgvRow.Cells[Constants.CON_COL_ITEM_SCALE_ID]);
            //if (cbIsPacked.Checked)
            //{
            //    item.IsPacked = true;
            //}
            //else
            //{
            //    item.IsPacked = false;
            //}
            try
            {
                item.Picture = (byte[])dgvRow.Cells[Constants.CON_COL_ITEM_PICTURE].Value;
            }
            catch
            {
                item.Picture = null;
            }

            SetItem(item);
        }

        private Item GetItemDetails()
        {
            Item item = new Item();
            item.ItemCode=txtItemCode.Text;
            item.ItemName=txtItemName.Text;
            item.DisplayName=txtItemDispName.Text;
            item.ShortName = txtShortName.Text;
            item.Alert = Convert.ToDecimal(txtAlert.Text);
            item.Expense = Convert.ToDecimal(txtExpense.Text);
            item.MRP = Convert.ToDecimal(txtMrp.Text);
            item.NewStock = Convert.ToDecimal(txtNewStock.Text);
            item.SellingPrice = Convert.ToDecimal(txtSellingPrice.Text);
            item.PurPrice = Convert.ToDecimal(txtPurPrice.Text);
            item.Qty = Convert.ToDecimal(txtQty.Text);
            item.ShortName = item.ShortName;
            item.Stock = Convert.ToDecimal(txtStock.Text);
            item.Unit = Convert.ToDecimal(txtUnit.Text);
            item.WSPrice = Convert.ToDecimal(txtWSprice.Text);
            item.NewSellingPrice = Convert.ToDecimal(txtNewSellingPrice.Text);
            item.NewWSPrice = Convert.ToDecimal(txtNewWSPrice.Text);
            item.Status = Int32.Parse(cmbStatus.SelectedValue.ToString());
            item.Brand = Int32.Parse(cmbBrand.SelectedValue.ToString());
            item.Category = Int32.Parse(cmbCategory.SelectedValue.ToString());
            item.Scale = Int32.Parse(cmbScale.SelectedValue.ToString());
            if (cbIsPacked.Checked)
            {
                item.IsPacked = true;
            }
            else
            {
                item.IsPacked = false;
            }
            if (picItem.Image != null)
            {
                ImageConverter imgCon = new ImageConverter();
                item.Picture = (byte[])imgCon.ConvertTo(picItem.Image, typeof(byte[]));
            }

            return item;
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
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem(GetItemDetails());
        }

        private void picItem_Click(object sender, EventArgs e)
        {
            //get picture and place it in this box
            DialogResult dr = this.fdImageBrowse.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                foreach (String file in fdImageBrowse.FileNames)
                {
                    // Create a PictureBox.
                    try
                    {
                        // PictureBox pb = new PictureBox();
                        Image loadedImage = Image.FromFile(file);
                        //Common.ScaleImage(loadedImage, 110, 125);
                        picItem.Image = Common.ScaleImage(loadedImage, picItem.Width, picItem.Height);

                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
        }

        
        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvItems.Rows[e.RowIndex].Selected = true;
            //GetSelectedItem(dgvItems.Rows[e.RowIndex]);
           // SetItem(false);
        }

        private void dgvItems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetSelectedItem(dgvItems.Rows[e.RowIndex]);
            SetItem(false);
        }

        private void dgvItems_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetSelectedItem(dgvItems.Rows[e.RowIndex]);
            SetItem(true);
        }

        private void dgvItems_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvItems.Rows[e.RowIndex].Selected = true;
            GetSelectedItem(dgvItems.Rows[e.RowIndex]);
            SetItem(false);
        }

        private void rbAllItems_CheckedChanged(object sender, EventArgs e)
        {
            GetAllItems();
            dgvItems.DataSource = ItemsCollection;
        }

        private void rbActiveItems_CheckedChanged(object sender, EventArgs e)
        {
            var results = from myRow in ItemsCollection.AsEnumerable()
                          where myRow.Field<Int64>(Constants.CON_COL_ITEM_STATUS_ID) == 1
                          select myRow;
            dgvItems.DataSource = results.CopyToDataTable();
        }

        private void rbInactiveItems_CheckedChanged(object sender, EventArgs e)
        {
            var results = from myRow in ItemsCollection.AsEnumerable()
                          where myRow.Field<Int64>(Constants.CON_COL_ITEM_STATUS_ID) == 0
                          select myRow;
            dgvItems.DataSource = results.CopyToDataTable();
        }

        private void rbLowStock_CheckedChanged(object sender, EventArgs e)
        {
            var results = from myRow in ItemsCollection.AsEnumerable()
                          where myRow.Field<decimal>(Constants.CON_COL_ITEM_STOCK) <= myRow.Field<decimal>(Constants.CON_COL_ITEM_ALERT)
                          select myRow;
            dgvItems.DataSource = results.CopyToDataTable();
        }

        private void cmbPack_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indx=cmbPack.SelectedIndex.ToString();
            
            var results = from myRow in ItemsCollection.AsEnumerable()
                          select myRow;
            dgvItems.DataSource = results.CopyToDataTable();
        }

        public void GetAllStatus()
        {
            throw new NotImplementedException();
        }

        public void SaveBrand(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void DeleteBrand(string brandID)
        {
            throw new NotImplementedException();
        }

        public void GetAllBrands()
        {
            throw new NotImplementedException();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
