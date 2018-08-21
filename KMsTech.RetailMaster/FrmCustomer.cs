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
using System.Security;
using System.IO;

namespace KMsTech.RetailMaster
{
    public partial class FrmCustomer : Form, ICustomerView
    {
        private static FrmCustomer _frmInstance;
        
        CustomerController custCtl;
        
        DataTable allCustomers;
        
        public static FrmCustomer FrmInstance
        {
            get
            {
                if (FrmCustomer._frmInstance == null)
                {
                    FrmCustomer._frmInstance = new FrmCustomer();
                }
                return FrmCustomer._frmInstance;
            }
        }
       
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.fdImageBrowse.Filter =
                "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                "All files (*.*)|*.*";

            // Allow the user to select multiple images.
            this.fdImageBrowse.Multiselect = false;
            this.fdImageBrowse.Title = "My Image Browser";
        }

        private void FrmCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmCustomer._frmInstance = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        public bool SaveCustomer(Customer customer)
        {
            custCtl = new CustomerController(this);

            return custCtl.SaveCustomer(customer);
        }

        public List<Customer> SearchCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(string customerID)
        {
            bool isDeleted = false;
           if(!string.IsNullOrEmpty(txtCustomerID.Text.Trim()))
           {
               custCtl = new CustomerController(this);

               isDeleted= custCtl.DeleteCustomer(txtCustomerID.Text.Trim());
                
           }
           return isDeleted;
        }

        public Customer DuplicateCustomer(Customer customer)
        {
            return null;
        }

        public void ClearCustomer()
        {
            txtCustomerID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtAddress1.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPin.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            rbActive.Checked = true;
        }
        
        private void SetCustomer(Customer cust)
        {
            txtCustomerID.Text = cust.CustomerID;
            txtFirstName.Text = cust.FirstName;
            txtLastName.Text = cust.LastName;
            txtAddress1.Text = cust.Address1;
            txtStreet.Text = cust.Street;
            txtCity.Text = cust.City;
            txtPin.Text = cust.Pin;
            txtMobile.Text = cust.Mobile;
            txtPhone.Text = cust.Phone;
            txtEmail.Text = cust.Email;

            if (cust.Status.Equals("1"))
                rbActive.Checked = true;
            else
                rbInactive.Checked = true;

            if (cust.Photo != null)
            {
                pictPhoto.Image = Common.ByteArrayToImage(cust.Photo);
            }
            else
            {
                pictPhoto.Image = null;
            }

        }
        
        private void SetCustomer(bool readOnly)
        {
            txtCustomerID.Enabled = readOnly;
            txtFirstName.Enabled= readOnly;
            txtLastName.Enabled= readOnly;
            txtAddress1.Enabled= readOnly;
            txtStreet.Enabled= readOnly;
            txtCity.Enabled= readOnly;
            txtPin.Enabled= readOnly;
            txtMobile.Enabled= readOnly;
            txtPhone.Enabled= readOnly;
            txtEmail.Enabled= readOnly;
            rbActive.Enabled = readOnly;
            rbInactive.Enabled = readOnly;
        }

        public void RefreshAllCustomer()
        {
            custCtl = new CustomerController(this);
            allCustomers = custCtl.GetAllCustomers();
            //rbAllCustomer.Checked = true;
           // dgvCustomers.DataSource = allCustomers;
           
            if (rbActiveCustomer.Checked)
            {
                rbActiveCustomer_CheckedChanged(null,null);
            }
            if (rbInactiveCustomer.Checked)
            {
                rbInactiveCustomer_CheckedChanged(null, null);
            }
            if (rbAllCustomer.Checked)
            {
                rbAllCustomer.Checked = true;
                dgvCustomers.DataSource = allCustomers;
            }
        }

        private Customer GetSelectedRow(DataGridViewRow dgvRow )
        {
            Customer cust = new Customer();
            cust.CustomerID = RefinedString(dgvRow.Cells[Constants.CON_COL_CUSTOMER_CID]);
            cust.FirstName = RefinedString(dgvRow.Cells[Constants.CON_COL_CUSTOMER_FIRSTNAME]);
            cust.LastName = RefinedString(dgvRow.Cells[Constants.CON_COL_CUSTOMER_LASTNAME]);
            cust.Address1 = RefinedString(dgvRow.Cells[Constants.CON_COL_CUSTOMER_ADDRESS1]);
            cust.City = RefinedString(dgvRow.Cells[Constants.CON_COL_CUSTOMER_CITY]);
            cust.Pin = RefinedString(dgvRow.Cells[Constants.CON_COL_CUSTOMER_PIN]);
            cust.Street = RefinedString(dgvRow.Cells[Constants.CON_COL_CUSTOMER_STREET]);
            cust.Mobile = RefinedString(dgvRow.Cells[Constants.CON_COL_CUSTOMER_MOBILE]);
            cust.Phone = RefinedString(dgvRow.Cells[Constants.CON_COL_CUSTOMER_PHONE]);
            cust.Email = RefinedString(dgvRow.Cells[Constants.CON_COL_CUSTOMER_EMAIL]);
            cust.Status = RefinedString(dgvRow.Cells[Constants.CON_COL_CUSTOMER_STATUS]);
            try
            {
                cust.Photo = (byte[])dgvRow.Cells[Constants.CON_COL_CUSTOMER_PHOTO].Value;
            }
            catch
            {
                cust.Photo = null;
            }
            return cust;
        }

        private String RefinedString(DataGridViewCell input)
        {
            String val = string.Empty;
            if (input.Value != null)
            {
                val= Convert.ToString(input.Value);
            }

            return val;

        }
        
        public Customer GetCustomerOrders(string customerID)
        {
            custCtl = new CustomerController(this);
            custCtl.GetCustomerOrders(customerID);
            return null;
        }

        public void CloseForm()
        {
             FrmCustomer._frmInstance = null;
            this.Close();
        }

        public Customer GetCurrentCustomer() {

            Customer cust = new Customer();
            cust.FirstName = txtFirstName.Text.Trim();
            cust.LastName = txtLastName.Text.Trim();
            cust.Address1 = txtAddress1.Text.Trim();
            cust.City = txtCity.Text.Trim();
            cust.Pin = txtPin.Text.Trim();
            cust.Street = txtStreet.Text.Trim();
            cust.CustomerID  = txtCustomerID.Text.Trim();
            cust.Mobile = txtMobile.Text.Trim();
            cust.Phone = txtPhone.Text.Trim();
            cust.Email = txtEmail.Text.Trim();
            if (rbActive.Checked)
                cust.Status =  Constants.CustomerStatus.Active.ToString();
            else
                cust.Status = Constants.CustomerStatus.Inactive.ToString();

            if (pictPhoto.Image != null)
            {
                ImageConverter imgCon = new ImageConverter();
                cust.Photo = (byte[])imgCon.ConvertTo(pictPhoto.Image, typeof(byte[]));
            }

            return cust;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                ClearCustomer();
                btnDelete.Enabled = false;
                btnDuplicate.Enabled = false;
                btnSelect.Enabled = false;
                btnOrders.Enabled = false;
                btnUpdate.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //enable all controls if disabled
            SetCustomer(true);

            //save customers
            
            SaveCustomer(GetCurrentCustomer());

            // SaveCustomer(GetCurrentCustomer(), false);
                        
           // RefreshAllCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteCustomer(txtCustomerID.Text.Trim());
                RefreshAllCustomer();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           List<Customer> customersColl= SearchCustomer(GetCurrentCustomer());
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                GetCurrentCustomer();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            SetCustomer(true);
            txtCustomerID.Text = string.Empty;

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomerID.Text.Trim()))
            {
                GetCustomerOrders(txtCustomerID.Text.Trim());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearCustomer();
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            RefreshAllCustomer();
            //check all customer ratio button
            rbAllCustomer.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCustomer(GetCurrentCustomer());            
            RefreshAllCustomer();

           
        }

        private void rbAllCustomer_CheckedChanged(object sender, EventArgs e)
        {
            //load all customers and keep in local dataset to serve all search queries           
            RefreshAllCustomer();
            dgvCustomers.DataSource = allCustomers;
        }

        private void rbActiveCustomer_CheckedChanged(object sender, EventArgs e)
        {
            //fire search query aginest local dataset to get only active data

            var results = from myRow in allCustomers.AsEnumerable()
                          where myRow.Field<string>(Constants.CON_COL_CUSTOMER_STATUS) == "1"
                          select myRow;
            dgvCustomers.DataSource = results.CopyToDataTable();
        }

        private void rbInactiveCustomer_CheckedChanged(object sender, EventArgs e)
        {
            //fire search query aginest local dataset to get only inactive data
            var results = from myRow in allCustomers.AsEnumerable()
                          where myRow.Field<string>(Constants.CON_COL_CUSTOMER_STATUS) == "0"
                          select myRow;
            dgvCustomers.DataSource = results.CopyToDataTable();
        }

        private void rbSearchResult_CheckedChanged(object sender, EventArgs e)
        {
            //fire search query aginest live database 
        }

        private void dgvCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetCustomer(GetSelectedRow(dgvCustomers.Rows[e.RowIndex]));
            SetCustomer(false);
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnDuplicate.Enabled = true;
        }

        private void dgvCustomers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            SetCustomer(GetSelectedRow(dgvCustomers.Rows[e.RowIndex]));
            SetCustomer(true);
        }

        private void dgvCustomers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCustomers.Rows[e.RowIndex].Selected = true;
        }

        private void dgvCustomers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCustomers.Rows[e.RowIndex].Selected = true;
        }

        private void pictPhoto_Click(object sender, EventArgs e)
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
                        pictPhoto.Image = Common.ScaleImage(loadedImage,pictPhoto.Width,pictPhoto.Height); 
                        
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
                
    }
}
