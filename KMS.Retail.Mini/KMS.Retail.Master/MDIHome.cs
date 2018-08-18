using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

using KMS.Retail.Common;

namespace KMS.Retail.Master
{
    public partial class MDIHome : Form
    {
        #region Private Properties

        private int childFormNumber = 0;
        Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion Private Properties

        #region Constructor
        public MDIHome()
        {
            InitializeComponent();
            this.Name = "test";
        }

        #endregion Constructor

        #region Public Properties
        #endregion Public Properties

        #region Public Methods
        #endregion Public Methods

        #region Private Methods

        #region Events


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

        #endregion Events

        #endregion Private Methods

        private void menuNewOrder_Click(object sender, EventArgs e)
        {
            FrmOrder activateForm = FrmOrder.FrmInstance;
            ActivateChildForm(activateForm, FormWindowState.Maximized);
        }

        private void menuItemDetails_Click(object sender, EventArgs e)
        {
            FrmItemsView activateForm = FrmItemsView.FrmInstance;
            ActivateChildForm(activateForm, FormWindowState.Maximized);
        }

        private void menuInvoiceDetails_Click(object sender, EventArgs e)
        {
            FrmInvoice activateForm = FrmInvoice.FrmInstance;
            ActivateChildForm(activateForm, FormWindowState.Maximized);
        }

        private void ActivateChildForm(Form activateForm, FormWindowState winState)
        {
            if (activateForm.WindowState == FormWindowState.Minimized)
                activateForm.WindowState = winState;

            MDIHome mdiRetailsMaster = new MDIHome();
            activateForm.MdiParent = this;
            activateForm.WindowState = winState;
            activateForm.Show();
            activateForm.Activate();
        }

        private void MDIHome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Screen.PrimaryScreen.WorkingArea;
        }

        private void menuNewItem_Click(object sender, EventArgs e)
        {
            FrmItem frmItem = new FrmItem();
            frmItem.StartPosition = FormStartPosition.CenterParent;
            frmItem.ShowDialog();
        }
    }
}
