using KMS.Retail.Common;
using KMS.Retail.Model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KMS.Retail.Master
{
    public partial class FrmItemsView : Form
    {
        private static FrmItemsView _frmInstance;
        public Item CurrentItem = new Item();
        public static FrmItemsView FrmInstance
        {
            get
            {
                if (FrmItemsView._frmInstance == null)
                {
                    FrmItemsView._frmInstance = new FrmItemsView();
                }
                return FrmItemsView._frmInstance;
            }
        }
        public FrmItemsView()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmItem frmItem = new FrmItem();
            frmItem.StartPosition = FormStartPosition.CenterParent;
            if (frmItem.ShowDialog() == DialogResult.OK)
            {
                ItemDataModel itmModel = new ItemDataModel();
                dgItems.DataSource = itmModel.GetAllItems();
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FrmItem frmItem = new FrmItem();
            frmItem.CurrentItem = CurrentItem;
            frmItem.IsNew = false;
            frmItem.ReadOnly = true;
            frmItem.StartPosition = FormStartPosition.CenterParent;
            if (frmItem.ShowDialog() == DialogResult.OK)
            {
                ItemDataModel itmModel = new ItemDataModel();
                dgItems.DataSource = itmModel.GetAllItems();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmItem frmItem = new FrmItem();
            frmItem.CurrentItem = CurrentItem;
            frmItem.IsNew = false;
            frmItem.ReadOnly = false;
            frmItem.StartPosition = FormStartPosition.CenterParent;
            if (frmItem.ShowDialog() == DialogResult.OK)
            {
                ItemDataModel itmModel = new ItemDataModel();
                dgItems.DataSource = itmModel.GetAllItems();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemDataModel itmModel = new ItemDataModel();
            itmModel.DeleteItem(CurrentItem.ID);
        }
        private void FrmItemsView_Load(object sender, EventArgs e)
        {
            ItemDataModel itmModel = new ItemDataModel();
            dgItems.DataSource = itmModel.GetAllItems();
            dgItems.ForeColor = Color.Black;

            dgItems.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            dgItems.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgItems.AlternatingRowsDefaultCellStyle.BackColor =  Color.FloralWhite;
            dgItems.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);

            GetItemDetails(dgItems.Rows[0]);
        }

        private void dgItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetItemDetails(dgItems.Rows[e.RowIndex]);
        }


        private Item GetItemDetails(DataGridViewRow dgvRow)
        {
            CurrentItem = new Item();
            CurrentItem.ID = RefinedString(dgvRow.Cells[Constants.CON_COL_ITEM_ID]);
            CurrentItem.Code = RefinedString(dgvRow.Cells[Constants.CON_COL_ITEM_CODE]);
            CurrentItem.Name = RefinedString(dgvRow.Cells[Constants.CON_COL_ITEM_NAME]);
            CurrentItem.DisplayName = RefinedString(dgvRow.Cells[Constants.CON_COL_ITEM_NAME]);
            CurrentItem.ShortName = RefinedString(dgvRow.Cells[Constants.CON_COL_ITEM_SHORT_NAME]);
            CurrentItem.MRP = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_MRP]);
            CurrentItem.SellingPrice = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_SELLING_PRICE]);
            CurrentItem.PurchasePrice = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_PUR_PRICE]);
            CurrentItem.Qty = RefinedInteger(dgvRow.Cells[Constants.CON_COL_ITEM_QTY]);
            CurrentItem.WSPrice = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_WS_PRICE]);
            CurrentItem.SplPrice = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_SPL_PRICE]);
            CurrentItem.Status = RefinedString(dgvRow.Cells[Constants.CON_COL_ITEM_STATUS_ID]);
            CurrentItem.Category = RefinedString(dgvRow.Cells[Constants.CON_COL_ITEM_CATEGORY_ID]);
            CurrentItem.GST = RefinedInteger(dgvRow.Cells[Constants.CON_COL_ITEM_GST]);
            CurrentItem.Tax = RefinedDecimal(dgvRow.Cells[Constants.CON_COL_ITEM_TAX]);
            CurrentItem.DateCreated = RefinedString(dgvRow.Cells[Constants.CON_COL_ITEM_CREATED_DATE]);

            try
            {
                CurrentItem.Picture = (byte[])dgvRow.Cells[Constants.CON_COL_ITEM_PICTURE].Value;
            }
            catch
            {
                CurrentItem.Picture = null;
            }
            return CurrentItem;
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

        private void FrmItemsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmItemsView._frmInstance = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            if (rbDispName.Checked)
            {
                (dgItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("DisplayName LIKE '%{0}%'", txtItemSrch.Text);
            }
            if (rbItemCode.Checked)
            {
                (dgItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("ItemCode LIKE '%{0}%'", txtItemSrch.Text);
            }
            if (rbName.Checked)
            {
                (dgItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("ItemName LIKE '%{0}%'", txtItemSrch.Text);
            }
            if (rbShortName.Checked)
            {
                (dgItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("ShortName LIKE '%{0}%'", txtItemSrch.Text);
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            txtItemSrch.Text = string.Empty;
            ItemDataModel itmModel = new ItemDataModel();
            dgItems.DataSource = itmModel.GetAllItems();
        }
    }
}
