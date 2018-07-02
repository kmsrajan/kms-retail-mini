namespace KMS.Retail.Master
{
    partial class FrmItem
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
            System.Windows.Forms.Button btnDelete;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnPicture = new System.Windows.Forms.Button();
            this.cmbItemStatus = new System.Windows.Forms.ComboBox();
            this.picItemImage = new System.Windows.Forms.PictureBox();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.Label();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblItemStatus = new System.Windows.Forms.Label();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.lblMRP = new System.Windows.Forms.Label();
            this.txtSplPrice = new System.Windows.Forms.TextBox();
            this.lblSplPrice = new System.Windows.Forms.Label();
            this.txtWSPrice = new System.Windows.Forms.TextBox();
            this.lblWSPrice = new System.Windows.Forms.Label();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.lclSellingPrice = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.txtItemDispName = new System.Windows.Forms.TextBox();
            this.lblItemDispName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemShortName = new System.Windows.Forms.TextBox();
            this.lblItemShortName = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDelete.Location = new System.Drawing.Point(296, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(122, 34);
            btnDelete.TabIndex = 69;
            btnDelete.Text = "நீக்கு";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 53);
            this.panel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(179, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(219, 25);
            this.label15.TabIndex = 39;
            this.label15.Text = "பொருள் விவரங்கள்";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.lblCategory);
            this.panel2.Controls.Add(this.btnPicture);
            this.panel2.Controls.Add(this.cmbItemStatus);
            this.panel2.Controls.Add(this.picItemImage);
            this.panel2.Controls.Add(this.txtCreatedDate);
            this.panel2.Controls.Add(this.textBox14);
            this.panel2.Controls.Add(this.txtTax);
            this.panel2.Controls.Add(this.txtGST);
            this.panel2.Controls.Add(this.lblGST);
            this.panel2.Controls.Add(this.lblItemStatus);
            this.panel2.Controls.Add(this.txtMRP);
            this.panel2.Controls.Add(this.lblMRP);
            this.panel2.Controls.Add(this.txtSplPrice);
            this.panel2.Controls.Add(this.lblSplPrice);
            this.panel2.Controls.Add(this.txtWSPrice);
            this.panel2.Controls.Add(this.lblWSPrice);
            this.panel2.Controls.Add(this.txtSellingPrice);
            this.panel2.Controls.Add(this.lclSellingPrice);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.lblQty);
            this.panel2.Controls.Add(this.txtPurchasePrice);
            this.panel2.Controls.Add(this.lblPurchasePrice);
            this.panel2.Controls.Add(this.txtItemDispName);
            this.panel2.Controls.Add(this.lblItemDispName);
            this.panel2.Controls.Add(this.txtItemName);
            this.panel2.Controls.Add(this.lblItemName);
            this.panel2.Controls.Add(this.txtItemShortName);
            this.panel2.Controls.Add(this.lblItemShortName);
            this.panel2.Controls.Add(this.txtItemCode);
            this.panel2.Controls.Add(this.lblItemCode);
            this.panel2.Controls.Add(this.txtItemId);
            this.panel2.Controls.Add(this.lblItemID);
            this.panel2.Location = new System.Drawing.Point(2, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 506);
            this.panel2.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(209, 430);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(355, 28);
            this.cmbCategory.TabIndex = 70;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(80, 433);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(118, 20);
            this.lblCategory.TabIndex = 69;
            this.lblCategory.Text = "பொருள் வகை ";
            // 
            // btnPicture
            // 
            this.btnPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicture.Location = new System.Drawing.Point(382, 348);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(182, 34);
            this.btnPicture.TabIndex = 68;
            this.btnPicture.Text = "பொருள் படம்";
            this.btnPicture.UseVisualStyleBackColor = true;
            // 
            // cmbItemStatus
            // 
            this.cmbItemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemStatus.FormattingEnabled = true;
            this.cmbItemStatus.Location = new System.Drawing.Point(209, 465);
            this.cmbItemStatus.Name = "cmbItemStatus";
            this.cmbItemStatus.Size = new System.Drawing.Size(355, 28);
            this.cmbItemStatus.TabIndex = 66;
            // 
            // picItemImage
            // 
            this.picItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItemImage.Location = new System.Drawing.Point(382, 182);
            this.picItemImage.Name = "picItemImage";
            this.picItemImage.Size = new System.Drawing.Size(182, 160);
            this.picItemImage.TabIndex = 65;
            this.picItemImage.TabStop = false;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedDate.Location = new System.Drawing.Point(382, 7);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.ReadOnly = true;
            this.txtCreatedDate.Size = new System.Drawing.Size(182, 29);
            this.txtCreatedDate.TabIndex = 64;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(424, 395);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(140, 29);
            this.textBox14.TabIndex = 63;
            // 
            // txtTax
            // 
            this.txtTax.AutoSize = true;
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(384, 401);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(34, 20);
            this.txtTax.TabIndex = 62;
            this.txtTax.Text = "Tax";
            // 
            // txtGST
            // 
            this.txtGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGST.Location = new System.Drawing.Point(210, 395);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(166, 29);
            this.txtGST.TabIndex = 61;
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGST.Location = new System.Drawing.Point(154, 401);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(42, 20);
            this.lblGST.TabIndex = 60;
            this.lblGST.Text = "GST";
            // 
            // lblItemStatus
            // 
            this.lblItemStatus.AutoSize = true;
            this.lblItemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemStatus.Location = new System.Drawing.Point(60, 471);
            this.lblItemStatus.Name = "lblItemStatus";
            this.lblItemStatus.Size = new System.Drawing.Size(136, 20);
            this.lblItemStatus.TabIndex = 59;
            this.lblItemStatus.Text = "பொருள் நிலவரம்";
            // 
            // txtMRP
            // 
            this.txtMRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRP.Location = new System.Drawing.Point(210, 360);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(166, 29);
            this.txtMRP.TabIndex = 58;
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRP.Location = new System.Drawing.Point(154, 366);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(44, 20);
            this.lblMRP.TabIndex = 56;
            this.lblMRP.Text = "MRP";
            // 
            // txtSplPrice
            // 
            this.txtSplPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSplPrice.Location = new System.Drawing.Point(210, 325);
            this.txtSplPrice.Name = "txtSplPrice";
            this.txtSplPrice.Size = new System.Drawing.Size(166, 29);
            this.txtSplPrice.TabIndex = 55;
            // 
            // lblSplPrice
            // 
            this.lblSplPrice.AutoSize = true;
            this.lblSplPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplPrice.Location = new System.Drawing.Point(90, 331);
            this.lblSplPrice.Name = "lblSplPrice";
            this.lblSplPrice.Size = new System.Drawing.Size(108, 20);
            this.lblSplPrice.TabIndex = 54;
            this.lblSplPrice.Text = "சிறப்பு விலை";
            // 
            // txtWSPrice
            // 
            this.txtWSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWSPrice.Location = new System.Drawing.Point(210, 289);
            this.txtWSPrice.Name = "txtWSPrice";
            this.txtWSPrice.Size = new System.Drawing.Size(166, 29);
            this.txtWSPrice.TabIndex = 53;
            // 
            // lblWSPrice
            // 
            this.lblWSPrice.AutoSize = true;
            this.lblWSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWSPrice.Location = new System.Drawing.Point(2, 295);
            this.lblWSPrice.Name = "lblWSPrice";
            this.lblWSPrice.Size = new System.Drawing.Size(194, 20);
            this.lblWSPrice.TabIndex = 52;
            this.lblWSPrice.Text = "மொத்த விற்பனை விலை";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingPrice.Location = new System.Drawing.Point(210, 254);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(166, 29);
            this.txtSellingPrice.TabIndex = 51;
            // 
            // lclSellingPrice
            // 
            this.lclSellingPrice.AutoSize = true;
            this.lclSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclSellingPrice.Location = new System.Drawing.Point(64, 260);
            this.lclSellingPrice.Name = "lclSellingPrice";
            this.lclSellingPrice.Size = new System.Drawing.Size(134, 20);
            this.lclSellingPrice.TabIndex = 50;
            this.lclSellingPrice.Text = "விற்பனை விலை";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(210, 218);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(166, 29);
            this.txtQty.TabIndex = 49;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(89, 219);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(109, 20);
            this.lblQty.TabIndex = 48;
            this.lblQty.Text = "எண்ணிக்கை";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasePrice.Location = new System.Drawing.Point(210, 182);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(166, 29);
            this.txtPurchasePrice.TabIndex = 47;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasePrice.Location = new System.Drawing.Point(47, 188);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(149, 20);
            this.lblPurchasePrice.TabIndex = 46;
            this.lblPurchasePrice.Text = "கொள்முதல் விலை";
            // 
            // txtItemDispName
            // 
            this.txtItemDispName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDispName.Location = new System.Drawing.Point(210, 147);
            this.txtItemDispName.Name = "txtItemDispName";
            this.txtItemDispName.Size = new System.Drawing.Size(354, 29);
            this.txtItemDispName.TabIndex = 45;
            // 
            // lblItemDispName
            // 
            this.lblItemDispName.AutoSize = true;
            this.lblItemDispName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDispName.Location = new System.Drawing.Point(93, 156);
            this.lblItemDispName.Name = "lblItemDispName";
            this.lblItemDispName.Size = new System.Drawing.Size(105, 20);
            this.lblItemDispName.TabIndex = 44;
            this.lblItemDispName.Text = "காட்சி பெயர்";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(210, 112);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(354, 29);
            this.txtItemName.TabIndex = 43;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(75, 118);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(121, 20);
            this.lblItemName.TabIndex = 42;
            this.lblItemName.Text = "பொருள்  பெயர்";
            // 
            // txtItemShortName
            // 
            this.txtItemShortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemShortName.Location = new System.Drawing.Point(210, 77);
            this.txtItemShortName.Name = "txtItemShortName";
            this.txtItemShortName.Size = new System.Drawing.Size(354, 29);
            this.txtItemShortName.TabIndex = 41;
            // 
            // lblItemShortName
            // 
            this.lblItemShortName.AutoSize = true;
            this.lblItemShortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemShortName.Location = new System.Drawing.Point(80, 83);
            this.lblItemShortName.Name = "lblItemShortName";
            this.lblItemShortName.Size = new System.Drawing.Size(118, 20);
            this.lblItemShortName.TabIndex = 40;
            this.lblItemShortName.Text = "குறுகிய பெயர்";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(210, 42);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(354, 29);
            this.txtItemCode.TabIndex = 39;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Location = new System.Drawing.Point(93, 48);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(109, 20);
            this.lblItemCode.TabIndex = 38;
            this.lblItemCode.Text = "பொருள் எண் ";
            // 
            // txtItemId
            // 
            this.txtItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemId.Location = new System.Drawing.Point(210, 7);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(166, 29);
            this.txtItemId.TabIndex = 37;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.Location = new System.Drawing.Point(153, 16);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(43, 20);
            this.lblItemID.TabIndex = 36;
            this.lblItemID.Text = "எண்";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(btnDelete);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(2, 563);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 50);
            this.panel3.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(10, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 34);
            this.btnEdit.TabIndex = 70;
            this.btnEdit.Text = "திருத்தம் செய் ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(435, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 34);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.Text = "வெளியேறு";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(158, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 34);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "சேமி  ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 614);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmItem";
            this.Text = "FrmItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label txtTax;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblItemStatus;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.TextBox txtSplPrice;
        private System.Windows.Forms.Label lblSplPrice;
        private System.Windows.Forms.TextBox txtWSPrice;
        private System.Windows.Forms.Label lblWSPrice;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.Label lclSellingPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.TextBox txtItemDispName;
        private System.Windows.Forms.Label lblItemDispName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemShortName;
        private System.Windows.Forms.Label lblItemShortName;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picItemImage;
        private System.Windows.Forms.ComboBox cmbItemStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnEdit;
    }
}