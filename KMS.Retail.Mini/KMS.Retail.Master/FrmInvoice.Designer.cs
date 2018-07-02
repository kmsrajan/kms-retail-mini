namespace KMS.Retail.Master
{
    partial class FrmInvoice
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblInvoceNo = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.dgInvoices = new System.Windows.Forms.DataGridView();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbCancelled = new System.Windows.Forms.RadioButton();
            this.rbDraft = new System.Windows.Forms.RadioButton();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.pnlFotter = new System.Windows.Forms.Panel();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblFrmTitle = new System.Windows.Forms.Label();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoices)).BeginInit();
            this.pnlFotter.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.lblMobile);
            this.pnlBody.Controls.Add(this.lblInvoceNo);
            this.pnlBody.Controls.Add(this.txtInvoiceNo);
            this.pnlBody.Controls.Add(this.lblTo);
            this.pnlBody.Controls.Add(this.lblFrom);
            this.pnlBody.Controls.Add(this.dtTo);
            this.pnlBody.Controls.Add(this.dtFrom);
            this.pnlBody.Controls.Add(this.btnSearch);
            this.pnlBody.Controls.Add(this.txtMobile);
            this.pnlBody.Controls.Add(this.dgInvoices);
            this.pnlBody.Controls.Add(this.rbAll);
            this.pnlBody.Controls.Add(this.rbCancelled);
            this.pnlBody.Controls.Add(this.rbDraft);
            this.pnlBody.Controls.Add(this.rbCredit);
            this.pnlBody.Controls.Add(this.rbPaid);
            this.pnlBody.Location = new System.Drawing.Point(12, 60);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1055, 514);
            this.pnlBody.TabIndex = 4;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(281, 11);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(76, 20);
            this.lblMobile.TabIndex = 16;
            this.lblMobile.Text = "கை பேசி";
            // 
            // lblInvoceNo
            // 
            this.lblInvoceNo.AutoSize = true;
            this.lblInvoceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoceNo.Location = new System.Drawing.Point(10, 13);
            this.lblInvoceNo.Name = "lblInvoceNo";
            this.lblInvoceNo.Size = new System.Drawing.Size(81, 20);
            this.lblInvoceNo.TabIndex = 15;
            this.lblInvoceNo.Text = "ரசீது எண்";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(97, 7);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(166, 29);
            this.txtInvoiceNo.TabIndex = 14;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(934, 13);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(49, 20);
            this.lblTo.TabIndex = 13;
            this.lblTo.Text = "வரை";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(689, 13);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(52, 20);
            this.lblFrom.TabIndex = 12;
            this.lblFrom.Text = "முதல்";
            // 
            // dtTo
            // 
            this.dtTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Location = new System.Drawing.Point(747, 10);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(181, 26);
            this.dtTo.TabIndex = 11;
            // 
            // dtFrom
            // 
            this.dtFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Location = new System.Drawing.Point(502, 8);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(181, 26);
            this.dtFrom.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(989, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 29);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "தேடு";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(363, 7);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(133, 29);
            this.txtMobile.TabIndex = 8;
            // 
            // dgInvoices
            // 
            this.dgInvoices.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoices.Location = new System.Drawing.Point(3, 77);
            this.dgInvoices.Name = "dgInvoices";
            this.dgInvoices.Size = new System.Drawing.Size(1049, 432);
            this.dgInvoices.TabIndex = 7;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(14, 47);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(119, 24);
            this.rbAll.TabIndex = 4;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "அனைத்தும்";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbCancelled
            // 
            this.rbCancelled.AutoSize = true;
            this.rbCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCancelled.Location = new System.Drawing.Point(633, 47);
            this.rbCancelled.Name = "rbCancelled";
            this.rbCancelled.Size = new System.Drawing.Size(126, 24);
            this.rbCancelled.TabIndex = 3;
            this.rbCancelled.TabStop = true;
            this.rbCancelled.Text = "நிராகரித்தது";
            this.rbCancelled.UseVisualStyleBackColor = true;
            // 
            // rbDraft
            // 
            this.rbDraft.AutoSize = true;
            this.rbDraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDraft.Location = new System.Drawing.Point(529, 47);
            this.rbDraft.Name = "rbDraft";
            this.rbDraft.Size = new System.Drawing.Size(83, 24);
            this.rbDraft.TabIndex = 2;
            this.rbDraft.TabStop = true;
            this.rbDraft.Text = "வரைவு";
            this.rbDraft.UseVisualStyleBackColor = true;
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCredit.Location = new System.Drawing.Point(334, 47);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(172, 24);
            this.rbCredit.TabIndex = 1;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "பணம் செலுத்தாது";
            this.rbCredit.UseVisualStyleBackColor = true;
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaid.Location = new System.Drawing.Point(146, 47);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(182, 24);
            this.rbPaid.TabIndex = 0;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "பணம் செலுத்தியது";
            this.rbPaid.UseVisualStyleBackColor = true;
            // 
            // pnlFotter
            // 
            this.pnlFotter.Controls.Add(this.btnDuplicate);
            this.pnlFotter.Controls.Add(this.bntDelete);
            this.pnlFotter.Controls.Add(this.btnView);
            this.pnlFotter.Controls.Add(this.btnUpdate);
            this.pnlFotter.Controls.Add(this.btnPrint);
            this.pnlFotter.Location = new System.Drawing.Point(12, 575);
            this.pnlFotter.Name = "pnlFotter";
            this.pnlFotter.Size = new System.Drawing.Size(1055, 42);
            this.pnlFotter.TabIndex = 3;
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuplicate.Location = new System.Drawing.Point(601, 3);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(122, 34);
            this.btnDuplicate.TabIndex = 14;
            this.btnDuplicate.Text = "புதிய நகல்";
            this.btnDuplicate.UseVisualStyleBackColor = false;
            // 
            // bntDelete
            // 
            this.bntDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bntDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDelete.Location = new System.Drawing.Point(729, 3);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(114, 34);
            this.bntDelete.TabIndex = 13;
            this.bntDelete.Text = "நீக்கு";
            this.bntDelete.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(185, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(143, 34);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "விவரம்";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(334, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 34);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "திருத்தம் செய் ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(473, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(122, 34);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "அச்சிடு";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblFrmTitle);
            this.pnlTitle.Location = new System.Drawing.Point(12, 12);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1055, 47);
            this.pnlTitle.TabIndex = 2;
            // 
            // lblFrmTitle
            // 
            this.lblFrmTitle.AutoSize = true;
            this.lblFrmTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmTitle.Location = new System.Drawing.Point(418, 11);
            this.lblFrmTitle.Name = "lblFrmTitle";
            this.lblFrmTitle.Size = new System.Drawing.Size(238, 25);
            this.lblFrmTitle.TabIndex = 40;
            this.lblFrmTitle.Text = "விற்பனை விவரங்கள்";
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 629);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFotter);
            this.Controls.Add(this.pnlTitle);
            this.Name = "FrmInvoice";
            this.Text = "FrmInvoice";
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoices)).EndInit();
            this.pnlFotter.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.DataGridView dgInvoices;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbCancelled;
        private System.Windows.Forms.RadioButton rbDraft;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.Panel pnlFotter;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblFrmTitle;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblInvoceNo;
        private System.Windows.Forms.Button btnDuplicate;
    }
}