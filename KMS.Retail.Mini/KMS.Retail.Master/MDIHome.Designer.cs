namespace KMS.Retail.Master
{
    partial class MDIHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIHome));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuNewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInvoiceDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuNewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewOrder,
            this.menuItemDetails,
            this.menuInvoiceDetails,
            this.menuHelp,
            this.menuNewItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1312, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menuNewOrder
            // 
            this.menuNewOrder.Name = "menuNewOrder";
            this.menuNewOrder.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuNewOrder.Size = new System.Drawing.Size(126, 25);
            this.menuNewOrder.Text = "புதிய ரசீது";
            this.menuNewOrder.Click += new System.EventHandler(this.menuNewOrder_Click);
            // 
            // menuItemDetails
            // 
            this.menuItemDetails.Name = "menuItemDetails";
            this.menuItemDetails.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuItemDetails.Size = new System.Drawing.Size(212, 25);
            this.menuItemDetails.Text = "பொருட்கள் விவரம்";
            this.menuItemDetails.Click += new System.EventHandler(this.menuItemDetails_Click);
            // 
            // menuInvoiceDetails
            // 
            this.menuInvoiceDetails.Name = "menuInvoiceDetails";
            this.menuInvoiceDetails.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuInvoiceDetails.Size = new System.Drawing.Size(198, 25);
            this.menuInvoiceDetails.Text = "விற்பனை விவரம்";
            this.menuInvoiceDetails.Click += new System.EventHandler(this.menuInvoiceDetails_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.menuHelp.Size = new System.Drawing.Size(82, 25);
            this.menuHelp.Text = "உதவி";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(145, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 742);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1312, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuNewItem
            // 
            this.menuNewItem.Name = "menuNewItem";
            this.menuNewItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuNewItem.Size = new System.Drawing.Size(85, 25);
            this.menuNewItem.Text = "NewItem";
            this.menuNewItem.Visible = false;
            this.menuNewItem.Click += new System.EventHandler(this.menuNewItem_Click);
            // 
            // MDIHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 764);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIHome";
            this.Text = "ஜெ ஜெ மளிகை";
            this.Load += new System.EventHandler(this.MDIHome_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menuItemDetails;
        private System.Windows.Forms.ToolStripMenuItem menuInvoiceDetails;
        private System.Windows.Forms.ToolStripMenuItem menuNewOrder;
        private System.Windows.Forms.ToolStripMenuItem menuNewItem;
    }
}



