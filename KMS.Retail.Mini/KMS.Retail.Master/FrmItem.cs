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
using System.Security;

namespace KMS.Retail.Master
{
    public partial class FrmItem : Form
    {
        public ItemDataModel itmModel = new ItemDataModel();

        public Item CurrentItem { get; set; }
        public bool IsNew { get; set; }
        public bool ReadOnly { get; set; }

        public FrmItem()
        {
            InitializeComponent();
            SetItemFieldsState(true);
            txtCreatedDate.Text = DateTime.Now.ToString("dd - MMMM - yyyy");
            
            
        }

        //public FrmItem(Item itm, bool isNew,bool isView)
        //{
        //    //if (!isNew && !isView)
        //    //{
        //    //    SetItemFields(itm);
        //    //    SetItemFieldsState(true);
        //    //}
        //    //else if (!isNew && isView)
        //    //{
        //    //    SetItemFields(itm);
        //    //    SetItemFieldsState(false);
        //    //}
        //    //else
        //    //{
        //    //    SetItemFieldsState(true);
        //    //}
        //    CurrentItem = itm;
        //    IsNew = isNew;
        //    ReadOnly = isView;


        //}
       
        private void SetItemFields(Item itm)
        {
            txtItemId.Text = string.IsNullOrEmpty(itm.ID)?string.Empty: itm.ID;
            txtItemCode.Text = itm.Code;
            txtItemName.Text = itm.Name;
            txtItemShortName.Text = itm.ShortName;
            txtItemDispName.Text = itm.DisplayName;
            txtPurchasePrice.Text = itm.PurchasePrice.ToString();
            txtSellingPrice.Text = itm.SellingPrice.ToString();
            txtWSPrice.Text = itm.WSPrice.ToString();
            txtSplPrice.Text = itm.SplPrice.ToString();
            txtMRP.Text = itm.MRP.ToString();
            txtGST.Text = itm.GST.ToString();
            lblTax.Text = itm.Tax.ToString();
            txtQty.Text = itm.Qty.ToString();
            cmbCategory.SelectedValue = Int32.Parse(itm.Category);
            cmbItemStatus.SelectedValue = Int32.Parse(itm.Status);
            if (itm.Picture != null)
            {
                picItemImage.Image = Global.ByteArrayToImage(itm.Picture);
            }
            else
            {
                picItemImage.Image = null;
            }
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
            lblTax.Enabled = state;
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
            ItemDataModel itmModel = new ItemDataModel();
            itmModel.SaveItem(GetItemDetails());
            string res=FrmMsg.MsgBox("Success", "Item updates successfully");
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ShowConfirmDialog(Constants.CONST_MSG_001, "Save");
            ItemDataModel itmModel = new ItemDataModel();
            itmModel.DeleteItem(GetItemDetails().ID);
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowConfirmDialog(Constants.CONST_MSG_001, "Save");
            FrmItemsView activateForm = FrmItemsView.FrmInstance; activateForm.Activate();
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

        private Item GetItemDetails()
        {
            Item item = new Item();
            item.ID = Global.GetVal(txtItemId.Text);
            item.Code = Global.GetVal(txtItemCode.Text);
            item.Name = Global.GetVal(txtItemName.Text);
            item.DisplayName = Global.GetVal(txtItemDispName.Text);
            item.ShortName = Global.GetVal(txtItemShortName.Text);
            item.PurchasePrice = Convert.ToDecimal(Global.GetVal(txtPurchasePrice.Text,Constants.CON_DT_DEC));
            item.MRP = Convert.ToDecimal(Global.GetVal(txtMRP.Text, Constants.CON_DT_DEC));
            item.SellingPrice = Convert.ToDecimal(Global.GetVal(txtSellingPrice.Text, Constants.CON_DT_DEC));
            item.WSPrice = Convert.ToDecimal(Global.GetVal(txtWSPrice.Text, Constants.CON_DT_DEC));
            item.SplPrice = Convert.ToDecimal(Global.GetVal(txtSplPrice.Text, Constants.CON_DT_DEC));
            item.Qty = Int32.Parse(Global.GetVal(txtQty.Text, Constants.CON_DT_INT));
            item.GST = Convert.ToDecimal(Global.GetVal(txtGST.Text, Constants.CON_DT_DEC));
            item.Tax = Convert.ToDecimal(Global.GetVal(txtTax.Text, Constants.CON_DT_DEC));
            item.Status = Global.GetVal(cmbItemStatus.SelectedValue.ToString());
            item.Category = Global.GetVal(cmbCategory.SelectedValue.ToString());

            if (picItemImage.Image != null)
            {
                ImageConverter imgCon = new ImageConverter();
                item.Picture = (byte[])imgCon.ConvertTo(picItemImage.Image, typeof(byte[]));
            }


            return item;
        }

        private void FrmItem_Load(object sender, EventArgs e)
        {
            MasterDataModel masterData = new MasterDataModel();
            //set item status
            cmbItemStatus.DataSource = masterData.GetAllStatuses();
            cmbItemStatus.ValueMember = "SID";
            cmbItemStatus.DisplayMember = "StatusName";

            cmbCategory.DataSource = masterData.GetAllCategories();
            cmbCategory.ValueMember = "CID";
            cmbCategory.DisplayMember = "Category";

            if (!IsNew && !ReadOnly )
            {
                if (CurrentItem != null)
                {
                    SetItemFields(CurrentItem);
                    SetItemFieldsState(true);
                    
                }
            }
            else if (!IsNew && ReadOnly)
            {
                SetItemFields(CurrentItem);
                SetItemFieldsState(false);
            }
            else
            {
                SetItemFieldsState(true);
                btnCancel.Enabled = false;
            }
        }
        private void btnPicture_Click(object sender, EventArgs e)
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
                        picItemImage.Image = Global.ScaleImage(loadedImage, picItemImage.Width, picItemImage.Height);

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

        private void MetadaValidation()
        {
            try
            {

            }
            catch { }

        }

        private void txtSellingPrice_Leave(object sender, EventArgs e)
        {
            string img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Done.PNG";
            if (string.IsNullOrEmpty(txtSellingPrice.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Blank.PNG";
            }
            if (Convert.ToDecimal(Global.GetVal(txtSellingPrice.Text, Constants.CON_DT_DEC)) <= 0)
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Stop.PNG";
            }
            if (Convert.ToDecimal(Global.GetVal(txtPurchasePrice.Text,Constants.CON_DT_DEC)) >= Convert.ToDecimal(Global.GetVal(txtSellingPrice.Text, Constants.CON_DT_DEC)))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\calcissue.PNG";
            }

            pbSellingPrice.Image = Image.FromFile(img);
            pbSellingPrice.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtItemCode_Leave(object sender, EventArgs e)
        {
            string img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Done.PNG";
            if (string.IsNullOrEmpty(txtItemCode.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Blank.PNG";
            }

            //Check if duplicate
            if(itmModel.IsValidItem(Constants.CON_SP_GET_ITEM_BY_CODE,Constants.CON_PARAM_ITEM_COMMON, txtItemCode.Text,txtItemId.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Stop.PNG";
            }


            pbCode.Image = Image.FromFile(img);
            pbCode.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtItemShortName_Leave(object sender, EventArgs e)
        {
            string img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Done.PNG";
            if (string.IsNullOrEmpty(txtItemShortName.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Blank.PNG";
            }

            //Check if duplicate
            if (itmModel.IsValidItem(Constants.CON_SP_GET_ITEM_BY_SHORTNAME,Constants.CON_PARAM_ITEM_COMMON, txtItemShortName.Text, txtItemId.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Stop.PNG";
            }

            pbShortName.Image = Image.FromFile(img);
            pbShortName.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtItemName_Leave(object sender, EventArgs e)
        {
            string img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Done.PNG";
            if (string.IsNullOrEmpty(txtItemName.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Blank.PNG";
            }

            //Check if duplicate
            if (itmModel.IsValidItem(Constants.CON_SP_GET_ITEM_BY_NAME, Constants.CON_PARAM_ITEM_COMMON, txtItemName.Text, txtItemId.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Stop.PNG";
            }

            pbName.Image = Image.FromFile(img);
            pbName.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }

        private void txtItemDispName_Leave(object sender, EventArgs e)
        {
            string img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Done.PNG";
            if (string.IsNullOrEmpty(txtItemDispName.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Blank.PNG";
            }

            //Check if duplicate
            if (itmModel.IsValidItem(Constants.CON_SP_GET_ITEM_BY_DISPNAME,Constants.CON_PARAM_ITEM_COMMON, txtItemDispName.Text, txtItemId.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Stop.PNG";
            }

            pbDisplayName.Image = Image.FromFile(img);
            pbDisplayName.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtPurchasePrice_Leave(object sender, EventArgs e)
        {
            string img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Done.PNG";
            if (string.IsNullOrEmpty(txtPurchasePrice.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Blank.PNG";
            }
            if (Convert.ToDecimal(Global.GetVal(txtPurchasePrice.Text, Constants.CON_DT_DEC)) <= 0)
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Stop.PNG";
            }
           

            pbPurPrice.Image = Image.FromFile(img);
            pbPurPrice.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            string img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Done.PNG";
            if (string.IsNullOrEmpty(txtQty.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Blank.PNG";
            }
            if (Convert.ToDecimal(Global.GetVal(txtQty.Text, Constants.CON_DT_DEC)) <= 0)
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Stop.PNG";
            }


            pbQty.Image = Image.FromFile(img);
            pbQty.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void txtWSPrice_Leave(object sender, EventArgs e)
        {
            string img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Done.PNG";
            if (string.IsNullOrEmpty(txtWSPrice.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Blank.PNG";
            }
            if (Convert.ToDecimal(Global.GetVal(txtWSPrice.Text, Constants.CON_DT_DEC)) <= 0)
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Stop.PNG";
            }
            if (Convert.ToDecimal(Global.GetVal(txtPurchasePrice.Text, Constants.CON_DT_DEC)) >= Convert.ToDecimal(Global.GetVal(txtWSPrice.Text, Constants.CON_DT_DEC)))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\calcissue.PNG";
            }
            pbWSPrice.Image = Image.FromFile(img);
            pbWSPrice.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtSplPrice_Leave(object sender, EventArgs e)
        {
            string img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Done.PNG";
            if (string.IsNullOrEmpty(txtSplPrice.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Blank.PNG";
            }
            if (Convert.ToDecimal(Global.GetVal(txtSplPrice.Text, Constants.CON_DT_DEC)) <= 0)
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Stop.PNG";
            }
            if (Convert.ToDecimal(Global.GetVal(txtPurchasePrice.Text, Constants.CON_DT_DEC)) >= Convert.ToDecimal(Global.GetVal(txtSplPrice.Text, Constants.CON_DT_DEC)))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\calcissue.PNG";
            }
            pbSplPrice.Image = Image.FromFile(img);
            pbSplPrice.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtMRP_Leave(object sender, EventArgs e)
        {
            string img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Done.PNG";
            if (string.IsNullOrEmpty(txtMRP.Text))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Blank.PNG";
            }
            if (Convert.ToDecimal(Global.GetVal(txtMRP.Text, Constants.CON_DT_DEC)) <= 0)
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\Stop.PNG";
            }
            if (Convert.ToDecimal(Global.GetVal(txtPurchasePrice.Text, Constants.CON_DT_DEC)) >= Convert.ToDecimal(Global.GetVal(txtMRP.Text, Constants.CON_DT_DEC)))
            {
                img = @"D:\KMS_REPO\KMS.Retail.Mini\KMS.Retail.Master\Images\calcissue.PNG";
            }
            pbMRP.Image = Image.FromFile(img);
            pbMRP.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FrmItem_FormClosed(object sender, FormClosedEventArgs e)
        {
           this.DialogResult=DialogResult.OK;
        }
    }
}
