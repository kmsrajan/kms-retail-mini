namespace KMS.Retail.Master
{
    partial class FrmItemsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFrmTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtItemSrch = new System.Windows.Forms.TextBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbDispName = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbShortName = new System.Windows.Forms.RadioButton();
            this.rbItemCode = new System.Windows.Forms.RadioButton();
            this.pnlHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.Sienna;
            this.pnlHeader.Controls.Add(this.lblFrmTitle);
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1082, 47);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFrmTitle
            // 
            this.lblFrmTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFrmTitle.AutoSize = true;
            this.lblFrmTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFrmTitle.Location = new System.Drawing.Point(418, 11);
            this.lblFrmTitle.Name = "lblFrmTitle";
            this.lblFrmTitle.Size = new System.Drawing.Size(268, 25);
            this.lblFrmTitle.TabIndex = 40;
            this.lblFrmTitle.Text = "பொருட்கள் விவரங்கள்";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Location = new System.Drawing.Point(1, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 42);
            this.panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Sienna;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(735, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 34);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "நீக்கு";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Sienna;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.Window;
            this.btnView.Location = new System.Drawing.Point(530, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(186, 34);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "பொருள் விவரம்";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(328, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(181, 34);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "திருத்தம் செய் ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Sienna;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNew.Location = new System.Drawing.Point(109, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 34);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "புதிய பொருள் சேர்";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtItemSrch);
            this.panel3.Controls.Add(this.dgItems);
            this.panel3.Controls.Add(this.rbAll);
            this.panel3.Controls.Add(this.rbDispName);
            this.panel3.Controls.Add(this.rbName);
            this.panel3.Controls.Add(this.rbShortName);
            this.panel3.Controls.Add(this.rbItemCode);
            this.panel3.Location = new System.Drawing.Point(1, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1082, 568);
            this.panel3.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Sienna;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Location = new System.Drawing.Point(990, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 29);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "தேடு";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtItemSrch
            // 
            this.txtItemSrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSrch.Location = new System.Drawing.Point(735, 10);
            this.txtItemSrch.Name = "txtItemSrch";
            this.txtItemSrch.Size = new System.Drawing.Size(252, 29);
            this.txtItemSrch.TabIndex = 5;
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgItems.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgItems.Location = new System.Drawing.Point(3, 45);
            this.dgItems.MultiSelect = false;
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgItems.RowTemplate.Height = 25;
            this.dgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItems.ShowEditingIcon = false;
            this.dgItems.Size = new System.Drawing.Size(1076, 518);
            this.dgItems.TabIndex = 7;
            this.dgItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellClick);
            this.dgItems.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgItems_ColumnHeaderMouseClick);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbAll.Location = new System.Drawing.Point(11, 10);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(119, 24);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "அனைத்தும்";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbDispName
            // 
            this.rbDispName.AutoSize = true;
            this.rbDispName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDispName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbDispName.Location = new System.Drawing.Point(602, 10);
            this.rbDispName.Name = "rbDispName";
            this.rbDispName.Size = new System.Drawing.Size(131, 24);
            this.rbDispName.TabIndex = 4;
            this.rbDispName.Text = "காட்சி பெயர்";
            this.rbDispName.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbName.Location = new System.Drawing.Point(443, 10);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(148, 24);
            this.rbName.TabIndex = 3;
            this.rbName.Text = "பொருள்  பெயர்";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // rbShortName
            // 
            this.rbShortName.AutoSize = true;
            this.rbShortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShortName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbShortName.Location = new System.Drawing.Point(289, 10);
            this.rbShortName.Name = "rbShortName";
            this.rbShortName.Size = new System.Drawing.Size(142, 24);
            this.rbShortName.TabIndex = 2;
            this.rbShortName.Text = "குறுகிய பெயர்";
            this.rbShortName.UseVisualStyleBackColor = true;
            // 
            // rbItemCode
            // 
            this.rbItemCode.AutoSize = true;
            this.rbItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbItemCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbItemCode.Location = new System.Drawing.Point(143, 10);
            this.rbItemCode.Name = "rbItemCode";
            this.rbItemCode.Size = new System.Drawing.Size(134, 24);
            this.rbItemCode.TabIndex = 1;
            this.rbItemCode.Text = "பொருள் எண் ";
            this.rbItemCode.UseVisualStyleBackColor = true;
            // 
            // FrmItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmItemsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmItemsView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmItemsView_FormClosing);
            this.Load += new System.EventHandler(this.FrmItemsView_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFrmTitle;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbDispName;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbShortName;
        private System.Windows.Forms.RadioButton rbItemCode;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtItemSrch;
    }
}