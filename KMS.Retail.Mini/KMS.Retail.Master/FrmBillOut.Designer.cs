namespace KMS.Retail.Master
{
    partial class FrmBillOut
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInvNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.cbPaid = new System.Windows.Forms.CheckBox();
            this.txtBalAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmountReceived = new System.Windows.Forms.TextBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblInvNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 62);
            this.panel1.TabIndex = 0;
            // 
            // lblInvNo
            // 
            this.lblInvNo.AutoSize = true;
            this.lblInvNo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblInvNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInvNo.Location = new System.Drawing.Point(231, 18);
            this.lblInvNo.Name = "lblInvNo";
            this.lblInvNo.Size = new System.Drawing.Size(0, 25);
            this.lblInvNo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "கட்டணம் பெறுதல்";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbPaymentMode);
            this.panel3.Controls.Add(this.cbPaid);
            this.panel3.Controls.Add(this.txtBalAmount);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtAmountReceived);
            this.panel3.Controls.Add(this.btnComplete);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.txtTotalAmount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 279);
            this.panel3.TabIndex = 2;
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMode.FormattingEnabled = true;
            this.cmbPaymentMode.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Paytm"});
            this.cmbPaymentMode.Location = new System.Drawing.Point(209, 42);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(228, 28);
            this.cmbPaymentMode.TabIndex = 21;
            // 
            // cbPaid
            // 
            this.cbPaid.AutoSize = true;
            this.cbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaid.Location = new System.Drawing.Point(78, 157);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(349, 29);
            this.cbPaid.TabIndex = 20;
            this.cbPaid.Text = "கட்டணம் பெறுதல் முடிந்தது";
            this.cbPaid.UseVisualStyleBackColor = true;
            this.cbPaid.CheckedChanged += new System.EventHandler(this.cbPaid_CheckedChanged);
            // 
            // txtBalAmount
            // 
            this.txtBalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtBalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalAmount.Location = new System.Drawing.Point(209, 111);
            this.txtBalAmount.Name = "txtBalAmount";
            this.txtBalAmount.Size = new System.Drawing.Size(228, 29);
            this.txtBalAmount.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(8, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "மீதம் உள்ள தொகை";
            // 
            // txtAmountReceived
            // 
            this.txtAmountReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountReceived.Location = new System.Drawing.Point(209, 76);
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.Size = new System.Drawing.Size(228, 29);
            this.txtAmountReceived.TabIndex = 17;
            this.txtAmountReceived.TextChanged += new System.EventHandler(this.txtAmountReceived_TextChanged);
            this.txtAmountReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountReceived_KeyPress);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnComplete.Location = new System.Drawing.Point(254, 205);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(132, 46);
            this.btnComplete.TabIndex = 16;
            this.btnComplete.Text = "நிறைவுற்றது";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPrint.Location = new System.Drawing.Point(91, 205);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(131, 46);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "அச்சிடு";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(209, 8);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(228, 29);
            this.txtTotalAmount.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(53, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "பெற்ற தொகை";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(40, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "மொத்த தொகை";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(59, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "கட்டண முறை";
            // 
            // FrmBillOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(453, 345);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBillOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBillOut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBillOut_FormClosing);
            this.Load += new System.EventHandler(this.FrmBillOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmountReceived;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbPaid;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.Label lblInvNo;
    }
}