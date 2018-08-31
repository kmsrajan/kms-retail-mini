namespace KMS.Retail.Master
{
    partial class FrmNewSalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewSalesOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.btnAddNewStack = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblPricecatagory = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.cmbPriceCatagory = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.lblShortName = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTaxPercentage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.txtNetTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTax = new System.Windows.Forms.CheckedListBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnPayOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.btnSearchItem);
            this.panel1.Controls.Add(this.btnAddNewStack);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.lblPricecatagory);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.lbItems);
            this.panel1.Controls.Add(this.cmbPriceCatagory);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.txtShortName);
            this.panel1.Controls.Add(this.lblShortName);
            this.panel1.Controls.Add(this.lblCatagory);
            this.panel1.Controls.Add(this.txtItemCode);
            this.panel1.Controls.Add(this.pbItem);
            this.panel1.Controls.Add(this.lblItemCode);
            this.panel1.Location = new System.Drawing.Point(1, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 719);
            this.panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(5, 562);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 51);
            this.btnClear.TabIndex = 87;
            this.btnClear.Text = "சுத்தம் செய்";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Gray;
            this.txtAmount.Location = new System.Drawing.Point(266, 533);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(148, 24);
            this.txtAmount.TabIndex = 86;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearchItem.Location = new System.Drawing.Point(370, 1);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(48, 58);
            this.btnSearchItem.TabIndex = 3;
            this.btnSearchItem.Text = "All";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // btnAddNewStack
            // 
            this.btnAddNewStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStack.Location = new System.Drawing.Point(145, 562);
            this.btnAddNewStack.Name = "btnAddNewStack";
            this.btnAddNewStack.Size = new System.Drawing.Size(125, 51);
            this.btnAddNewStack.TabIndex = 12;
            this.btnAddNewStack.Text = "புதிய பொருள்";
            this.btnAddNewStack.UseVisualStyleBackColor = true;
            this.btnAddNewStack.Click += new System.EventHandler(this.btnAddNewStack_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(129, 63);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(288, 28);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(148, 433);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 20);
            this.label20.TabIndex = 46;
            this.label20.Text = "எண்ணிக்கை";
            // 
            // lblPricecatagory
            // 
            this.lblPricecatagory.AutoSize = true;
            this.lblPricecatagory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPricecatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricecatagory.Location = new System.Drawing.Point(152, 463);
            this.lblPricecatagory.Name = "lblPricecatagory";
            this.lblPricecatagory.Size = new System.Drawing.Size(64, 22);
            this.lblPricecatagory.TabIndex = 47;
            this.lblPricecatagory.Text = "வரைவு";
            this.lblPricecatagory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblPricecatagory_MouseDoubleClick);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(194, 494);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(57, 20);
            this.Price.TabIndex = 40;
            this.Price.Text = "விலை";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(283, 562);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(135, 51);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "சேர்";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(263, 497);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(153, 31);
            this.txtPrice.TabIndex = 71;
            this.txtPrice.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtPrice_MouseDoubleClick);
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.Info;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtItemName.Location = new System.Drawing.Point(3, 95);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(413, 29);
            this.txtItemName.TabIndex = 4;
            // 
            // lbItems
            // 
            this.lbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 24;
            this.lbItems.Location = new System.Drawing.Point(5, 130);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(412, 292);
            this.lbItems.TabIndex = 5;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // cmbPriceCatagory
            // 
            this.cmbPriceCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPriceCatagory.FormattingEnabled = true;
            this.cmbPriceCatagory.Location = new System.Drawing.Point(222, 463);
            this.cmbPriceCatagory.Name = "cmbPriceCatagory";
            this.cmbPriceCatagory.Size = new System.Drawing.Size(194, 28);
            this.cmbPriceCatagory.TabIndex = 70;
            this.cmbPriceCatagory.SelectedIndexChanged += new System.EventHandler(this.cmbPriceCatagory_SelectedIndexChanged);
            this.cmbPriceCatagory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmbPriceCatagory_MouseDoubleClick);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(263, 426);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(153, 31);
            this.txtQty.TabIndex = 6;
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // txtShortName
            // 
            this.txtShortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortName.Location = new System.Drawing.Point(129, 33);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(239, 26);
            this.txtShortName.TabIndex = 1;
            this.txtShortName.TextChanged += new System.EventHandler(this.txtShortName_TextChanged);
            this.txtShortName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortName_KeyDown);
            // 
            // lblShortName
            // 
            this.lblShortName.AutoSize = true;
            this.lblShortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortName.Location = new System.Drawing.Point(5, 36);
            this.lblShortName.Name = "lblShortName";
            this.lblShortName.Size = new System.Drawing.Size(118, 20);
            this.lblShortName.TabIndex = 25;
            this.lblShortName.Text = "குறுகிய பெயர்";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.Location = new System.Drawing.Point(5, 66);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(118, 20);
            this.lblCatagory.TabIndex = 21;
            this.lblCatagory.Text = "பொருள் வகை ";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(129, 2);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(239, 26);
            this.txtItemCode.TabIndex = 0;
            this.txtItemCode.TextChanged += new System.EventHandler(this.txtItemCode_TextChanged);
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            this.txtItemCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemCode_KeyPress);
            // 
            // pbItem
            // 
            this.pbItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbItem.Location = new System.Drawing.Point(5, 426);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(141, 129);
            this.pbItem.TabIndex = 20;
            this.pbItem.TabStop = false;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Location = new System.Drawing.Point(15, 4);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(106, 20);
            this.lblItemCode.TabIndex = 18;
            this.lblItemCode.Text = "பொருள் எண்";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1381, 64);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1332, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1131, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1078, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inv no:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.dgItems);
            this.panel3.Location = new System.Drawing.Point(428, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 677);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtTaxPercentage);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtTotalQty);
            this.panel5.Controls.Add(this.txtNetTotal);
            this.panel5.Controls.Add(this.txtDiscount);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtTotalAmount);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txtTax);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.cbTax);
            this.panel5.Location = new System.Drawing.Point(2, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(949, 79);
            this.panel5.TabIndex = 2;
            // 
            // txtTaxPercentage
            // 
            this.txtTaxPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaxPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxPercentage.Location = new System.Drawing.Point(3, 48);
            this.txtTaxPercentage.MaxLength = 2;
            this.txtTaxPercentage.Name = "txtTaxPercentage";
            this.txtTaxPercentage.Size = new System.Drawing.Size(54, 26);
            this.txtTaxPercentage.TabIndex = 14;
            this.txtTaxPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxbox_KeyPress);
            this.txtTaxPercentage.Leave += new System.EventHandler(this.txtTaxbox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(736, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "உருப்படி";
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQty.Location = new System.Drawing.Point(740, 35);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.ReadOnly = true;
            this.txtTotalQty.Size = new System.Drawing.Size(69, 38);
            this.txtTotalQty.TabIndex = 18;
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetTotal.Location = new System.Drawing.Point(512, 9);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.ReadOnly = true;
            this.txtNetTotal.Size = new System.Drawing.Size(217, 62);
            this.txtNetTotal.TabIndex = 17;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(371, 35);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(126, 38);
            this.txtDiscount.TabIndex = 16;
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(367, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 81;
            this.label10.Text = "தள்ளுபடி";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(220, 36);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(133, 38);
            this.txtTotalAmount.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(216, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 79;
            this.label9.Text = "மொத்த தொகை";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(75, 36);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(129, 38);
            this.txtTax.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "மொத்த வரி";
            // 
            // cbTax
            // 
            this.cbTax.BackColor = System.Drawing.SystemColors.Menu;
            this.cbTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTax.FormattingEnabled = true;
            this.cbTax.Items.AddRange(new object[] {
            "GST",
            "Tax"});
            this.cbTax.Location = new System.Drawing.Point(3, 4);
            this.cbTax.Name = "cbTax";
            this.cbTax.Size = new System.Drawing.Size(66, 42);
            this.cbTax.TabIndex = 13;
            this.cbTax.SelectedIndexChanged += new System.EventHandler(this.cbTax_SelectedIndexChanged);
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Location = new System.Drawing.Point(4, 77);
            this.dgItems.MultiSelect = false;
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            this.dgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItems.Size = new System.Drawing.Size(946, 593);
            this.dgItems.TabIndex = 19;
            this.dgItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellDoubleClick);
            this.dgItems.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgItems_CellMouseDoubleClick);
            this.dgItems.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgItems_UserDeletedRow);
            this.dgItems.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgItems_UserDeletingRow);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnSaveOrder);
            this.panel4.Controls.Add(this.btnPayOrder);
            this.panel4.Controls.Add(this.btnCancelOrder);
            this.panel4.Location = new System.Drawing.Point(428, 745);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(954, 44);
            this.panel4.TabIndex = 2;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveOrder.Image")));
            this.btnSaveOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveOrder.Location = new System.Drawing.Point(5, 4);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(120, 36);
            this.btnSaveOrder.TabIndex = 20;
            this.btnSaveOrder.Text = "சேமி  ";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayOrder.Location = new System.Drawing.Point(131, 3);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(165, 37);
            this.btnPayOrder.TabIndex = 21;
            this.btnPayOrder.Text = "பணம் செலுத்து";
            this.btnPayOrder.UseVisualStyleBackColor = true;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.Location = new System.Drawing.Point(304, 3);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(145, 36);
            this.btnCancelOrder.TabIndex = 22;
            this.btnCancelOrder.Text = "நிராகரி";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            // 
            // FrmNewSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 789);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmNewSalesOrder";
            this.Text = "FrmSalesOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewSalesOrder_FormClosing);
            this.Load += new System.EventHandler(this.FrmNewSalesOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Label lblShortName;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblPricecatagory;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbPriceCatagory;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnAddNewStack;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Button btnPayOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.TextBox txtNetTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox cbTax;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtTaxPercentage;
        private System.Windows.Forms.Button btnClear;
    }
}