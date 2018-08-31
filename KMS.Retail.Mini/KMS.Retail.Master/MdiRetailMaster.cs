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
    public partial class MdiRetailMaster : Form
    {
        private int childFormNumber = 0;

        public static String UserName { get; set; }
        public static String FirstName { get; set; }
        public static String LastName { get; set; }

        public MdiRetailMaster()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MdiRetailMaster_Load(object sender, EventArgs e)
        {

            //Open login window and set  global variable with logged in user details
            //FrmLogin activateForm = FrmLogin.FrmInstance;
            //ActivateChildForm(activateForm, FormWindowState.Normal);
           // MdiRetailMaster mdiRetailsMaster = new MdiRetailMaster();
            //activateForm.MdiParent = this;
            
            //activateForm.WindowState = FormWindowState.Normal;
            //activateForm.ShowDialog();
            

        }

        private void ActivateChildForm(Form activateForm, FormWindowState winState)
        {
            
            if (activateForm.WindowState == FormWindowState.Minimized)
                activateForm.WindowState = winState;

            MdiRetailMaster mdiRetailsMaster = new MdiRetailMaster();
            activateForm.MdiParent = this;
            activateForm.WindowState = winState;
            activateForm.Show();
            activateForm.Activate();
        }

        private void tslItems_Click(object sender, EventArgs e)
        {
            FrmItemsView activateForm = FrmItemsView.FrmInstance;
            ActivateChildForm(activateForm, FormWindowState.Maximized);
        }

        private void tsbNewOrder_Click(object sender, EventArgs e)
        {
            FrmNewSalesOrder activateForm = FrmNewSalesOrder.FrmInstance;
            ActivateChildForm(activateForm, FormWindowState.Maximized);
        }

        private void tslSO_Click(object sender, EventArgs e)
        {
            FrmInvoice activateForm = FrmInvoice.FrmInstance;
            ActivateChildForm(activateForm, FormWindowState.Maximized);

        }

        private void fileMenu_Click(object sender, EventArgs e)
        {
            //Open sales order window 
            FrmNewSalesOrder activateForm = FrmNewSalesOrder.FrmInstance;
            ActivateChildForm(activateForm, FormWindowState.Maximized);
        }
    }
}
