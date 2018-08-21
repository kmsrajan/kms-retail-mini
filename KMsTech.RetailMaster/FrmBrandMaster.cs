using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KMsTech.RetailInterfaces;
using KMsTech.RetailEntities;
using KMsTech.RetailController;
using KMsTech.RetailCommon;


namespace KMsTech.RetailMaster
{
    public partial class FrmBrandMaster : Form, IBrandView
    {
        private static FrmBrandMaster _frmInstance;
        BrandController brandCtl;

        public DataTable BrandsCollection
        {
            get;
            set;
        }

        public static FrmBrandMaster FrmInstance
        {
            get
            {
                if (FrmBrandMaster._frmInstance == null)
                {
                    FrmBrandMaster._frmInstance = new FrmBrandMaster();
                }
                return FrmBrandMaster._frmInstance;
            }
        }

        public FrmBrandMaster()
        {
            InitializeComponent();
            
            brandCtl = new BrandController(this);
        }

        private void FrmBrandMaster_Load(object sender, EventArgs e)
        {
            SetBrand(true);
            Clear();
            GetAllBrands();
            dgvBrands.DataSource = BrandsCollection;
        }

        public void SaveBrand(Brand brand)
        {
            brandCtl.SaveBrand(GetBrandDetails());
            dgvBrands.DataSource = BrandsCollection;
        }

        public void DeleteBrand(string brandID)
        {
            brandCtl.DeleteBrand(brandID);
            dgvBrands.DataSource = BrandsCollection;
        }

        public void GetAllBrands()
        {
            brandCtl.GetAllBrands();
        }

        private void SetBrand(bool isActive)
        {
            txtBrandID.Enabled = false;
            txtBrandName.Enabled = isActive;
            txtBrandDispName.Enabled = isActive;
            rbActive.Enabled = isActive;
            rbInactive.Enabled = isActive;
        }

        private void SetBrand(Brand brand)
        {
            txtBrandID.Text = brand.BrandId;
            txtBrandName.Text = brand.Name;
            txtBrandDispName.Text = brand.DisplayName;
            if (brand.Status.Equals("1"))
            {
                rbActive.Checked = true;
            }
            else
            {
                rbInactive.Checked = true;
            }
        }

        private void Clear()
        {
            txtBrandID.Text = string.Empty;
            txtBrandName.Text = string.Empty;
            txtBrandDispName.Text = string.Empty;
            rbActive.Checked = true;
        }

        private void GetSelectedBrand(DataGridViewRow dgvRow)
        {
            Brand brand = new Brand();
            brand.BrandId = RefinedString(dgvRow.Cells[Constants.CON_COL_BRAND_ID]);
            brand.Name = RefinedString(dgvRow.Cells[Constants.CON_COL_BRAND_NAME]);
            brand.DisplayName = RefinedString(dgvRow.Cells[Constants.CON_COL_BRAND_DISP_NAME]);
            brand.Status = RefinedString(dgvRow.Cells[Constants.CON_COL_BRAND_STATUS]);

            SetBrand(brand);
        }

        private Brand GetBrandDetails()
        {
            Brand brand = new Brand();
            brand.BrandId = txtBrandID.Text;
            brand.Name = txtBrandName.Text;
            brand.DisplayName = txtBrandDispName.Text;
            if (rbActive.Checked)
            {
                brand.Status = "1";
            }
            else
            {
                brand.Status = "0";
            }

            return brand;
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




        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Clear();
            SetBrand(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetBrand(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBrand(GetBrandDetails());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBrand(txtBrandID.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmBrandMaster._frmInstance = null;
            this.Close();
        }

        private void dgvBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBrands.Rows[e.RowIndex].Selected = true;
        }

        private void dgvBrands_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetSelectedBrand(dgvBrands.Rows[e.RowIndex]);
            
            SetBrand(false);
        }

        private void dgvBrands_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetSelectedBrand(dgvBrands.Rows[e.RowIndex]);
            SetBrand(true);
        }

        private void dgvBrands_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvBrands.Rows[e.RowIndex].Selected = true;
            GetSelectedBrand(dgvBrands.Rows[e.RowIndex]);
            SetBrand(false);
        }

    }
}