namespace ShopManagementSystem
{
    partial class AddProducts
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
            this.ProductList = new System.Windows.Forms.ListView();
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PurchasePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InsertedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreatedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sMSDataSet = new ShopManagementSystem.SMSDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new ShopManagementSystem.SMSDataSetTableAdapters.CategoriesTableAdapter();
            this.lblCN = new System.Windows.Forms.Label();
            this.lblPN = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPprice = new System.Windows.Forms.TextBox();
            this.txtSprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.bynUpload = new System.Windows.Forms.Button();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.ImagePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCatS = new System.Windows.Forms.Label();
            this.txtFCategory = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtFId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUnfilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ProductList.AutoArrange = false;
            this.ProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductId,
            this.CategoryName,
            this.ProductName,
            this.Quantity,
            this.PurchasePrice,
            this.SalePrice,
            this.InsertedBy,
            this.CreatedDate,
            this.ImagePath,
            this.Description});
            this.ProductList.FullRowSelect = true;
            this.ProductList.HideSelection = false;
            this.ProductList.HotTracking = true;
            this.ProductList.HoverSelection = true;
            this.ProductList.Location = new System.Drawing.Point(12, 306);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(1029, 177);
            this.ProductList.TabIndex = 2;
            this.ProductList.UseCompatibleStateImageBehavior = false;
            this.ProductList.View = System.Windows.Forms.View.Details;
            this.ProductList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProductList_MouseDoubleClick);
            // 
            // ProductId
            // 
            this.ProductId.Text = "Product ID";
            this.ProductId.Width = 66;
            // 
            // CategoryName
            // 
            this.CategoryName.Text = "Category Name";
            this.CategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CategoryName.Width = 100;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductName.Width = 105;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.Width = 70;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.Text = "Purchase Price";
            this.PurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PurchasePrice.Width = 90;
            // 
            // SalePrice
            // 
            this.SalePrice.Text = "Sale Price";
            this.SalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InsertedBy
            // 
            this.InsertedBy.Text = "Inserted By";
            this.InsertedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InsertedBy.Width = 90;
            // 
            // CreatedDate
            // 
            this.CreatedDate.Text = "Created Date";
            this.CreatedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreatedDate.Width = 100;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 239;
            // 
            // sMSDataSet
            // 
            this.sMSDataSet.DataSetName = "SMSDataSet";
            this.sMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.sMSDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Location = new System.Drawing.Point(10, 46);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(83, 13);
            this.lblCN.TabIndex = 5;
            this.lblCN.Text = "Category Name:";
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.Location = new System.Drawing.Point(351, 46);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(78, 13);
            this.lblPN.TabIndex = 6;
            this.lblPN.Text = "Product Name:";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(435, 41);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(182, 20);
            this.txtPName.TabIndex = 7;
            // 
            // cbCategory
            // 
            this.cbCategory.DataSource = this.categoriesBindingSource;
            this.cbCategory.DisplayMember = "CategoryName";
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(99, 43);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(182, 21);
            this.cbCategory.TabIndex = 3;
            this.cbCategory.ValueMember = "Id";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(736, 87);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(175, 20);
            this.nudQuantity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantity:";
            // 
            // txtPprice
            // 
            this.txtPprice.Location = new System.Drawing.Point(99, 87);
            this.txtPprice.Name = "txtPprice";
            this.txtPprice.Size = new System.Drawing.Size(182, 20);
            this.txtPprice.TabIndex = 9;
            // 
            // txtSprice
            // 
            this.txtSprice.Location = new System.Drawing.Point(435, 86);
            this.txtSprice.Name = "txtSprice";
            this.txtSprice.Size = new System.Drawing.Size(182, 20);
            this.txtSprice.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sale Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Purchase Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(922, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "User Name:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(96, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "User Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(892, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Current Date:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(974, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 13);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Current Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 135);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(747, 81);
            this.txtDescription.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(852, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add/Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(852, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(852, 193);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Image:";
            // 
            // txtImage
            // 
            this.txtImage.Enabled = false;
            this.txtImage.Location = new System.Drawing.Point(736, 43);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(175, 20);
            this.txtImage.TabIndex = 26;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(951, 86);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(90, 20);
            this.txtId.TabIndex = 27;
            // 
            // bynUpload
            // 
            this.bynUpload.Location = new System.Drawing.Point(925, 41);
            this.bynUpload.Name = "bynUpload";
            this.bynUpload.Size = new System.Drawing.Size(116, 23);
            this.bynUpload.TabIndex = 28;
            this.bynUpload.Text = "Select Image";
            this.bynUpload.UseVisualStyleBackColor = true;
            this.bynUpload.Click += new System.EventHandler(this.bynUpload_Click);
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(614, 9);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(0, 13);
            this.lblImagePath.TabIndex = 29;
            this.lblImagePath.Visible = false;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(163, 9);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(13, 13);
            this.lblUserId.TabIndex = 30;
            this.lblUserId.Text = "1";
            this.lblUserId.Visible = false;
            // 
            // ImagePath
            // 
            this.ImagePath.Text = "Image Path";
            this.ImagePath.Width = 100;
            // 
            // lblCatS
            // 
            this.lblCatS.AutoSize = true;
            this.lblCatS.Location = new System.Drawing.Point(76, 253);
            this.lblCatS.Name = "lblCatS";
            this.lblCatS.Size = new System.Drawing.Size(89, 13);
            this.lblCatS.TabIndex = 31;
            this.lblCatS.Text = "Filter By Category";
            // 
            // txtFCategory
            // 
            this.txtFCategory.Location = new System.Drawing.Point(13, 280);
            this.txtFCategory.Name = "txtFCategory";
            this.txtFCategory.Size = new System.Drawing.Size(227, 20);
            this.txtFCategory.TabIndex = 32;
            this.txtFCategory.TextChanged += new System.EventHandler(this.txtFCategory_TextChanged);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(286, 280);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(227, 20);
            this.txtFName.TabIndex = 33;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // txtFId
            // 
            this.txtFId.Location = new System.Drawing.Point(559, 280);
            this.txtFId.Name = "txtFId";
            this.txtFId.Size = new System.Drawing.Size(227, 20);
            this.txtFId.TabIndex = 34;
            this.txtFId.TextChanged += new System.EventHandler(this.txtFId_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Filter By Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(653, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Filter By ID";
            // 
            // btnUnfilter
            // 
            this.btnUnfilter.Location = new System.Drawing.Point(852, 277);
            this.btnUnfilter.Name = "btnUnfilter";
            this.btnUnfilter.Size = new System.Drawing.Size(189, 23);
            this.btnUnfilter.TabIndex = 37;
            this.btnUnfilter.Text = "Unfilter Products";
            this.btnUnfilter.UseVisualStyleBackColor = true;
            this.btnUnfilter.Click += new System.EventHandler(this.btnUnfilter_Click);
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 497);
            this.Controls.Add(this.btnUnfilter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFId);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtFCategory);
            this.Controls.Add(this.lblCatS);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.bynUpload);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSprice);
            this.Controls.Add(this.txtPprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.lblPN);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.ProductList);
            this.Name = "AddProducts";
            this.Text = "AddProducts";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ProductList;
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader CategoryName;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader InsertedBy;
        private System.Windows.Forms.ColumnHeader CreatedDate;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader PurchasePrice;
        private System.Windows.Forms.ColumnHeader SalePrice;
        private SMSDataSet sMSDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private SMSDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.Label lblPN;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPprice;
        private System.Windows.Forms.TextBox txtSprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button bynUpload;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ColumnHeader ImagePath;
        private System.Windows.Forms.Label lblCatS;
        private System.Windows.Forms.TextBox txtFCategory;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtFId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUnfilter;
    }
}

