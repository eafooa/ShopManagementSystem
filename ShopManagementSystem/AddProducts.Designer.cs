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
            this.ProductList = new System.Windows.Forms.ListView();
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InsertedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreatedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PurchasePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductId,
            this.CategoryName,
            this.ProductName,
            this.Quantity,
            this.PurchasePrice,
            this.SalePrice,
            this.InsertedBy,
            this.CreatedDate,
            this.Description});
            this.ProductList.Location = new System.Drawing.Point(47, 102);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(617, 97);
            this.ProductList.TabIndex = 2;
            this.ProductList.UseCompatibleStateImageBehavior = false;
            this.ProductList.View = System.Windows.Forms.View.Details;
            // 
            // ProductId
            // 
            this.ProductId.Text = "ProductId";
            // 
            // CategoryName
            // 
            this.CategoryName.Text = "CategoryName";
            // 
            // ProductName
            // 
            this.ProductName.Text = "ProductName";
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            // 
            // InsertedBy
            // 
            this.InsertedBy.DisplayIndex = 4;
            this.InsertedBy.Text = "InsertedBy";
            // 
            // CreatedDate
            // 
            this.CreatedDate.DisplayIndex = 5;
            this.CreatedDate.Text = "CreatedDate";
            // 
            // Description
            // 
            this.Description.DisplayIndex = 6;
            this.Description.Text = "Description";
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.Text = "PurchasePrice";
            // 
            // SalePrice
            // 
            this.SalePrice.Text = "SalePrice";
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 497);
            this.Controls.Add(this.ProductList);
            this.Name = "AddProducts";
            this.Text = "AddProducts";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            this.ResumeLayout(false);

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
    }
}

