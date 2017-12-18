namespace ShopManagementSystem
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.lvBeverages = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBeverages = new System.Windows.Forms.TabPage();
            this.tabBakery = new System.Windows.Forms.TabPage();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tabDairy = new System.Windows.Forms.TabPage();
            this.tabNonFood = new System.Windows.Forms.TabPage();
            this.lvBakery = new System.Windows.Forms.ListView();
            this.lvDairy = new System.Windows.Forms.ListView();
            this.lvNFood = new System.Windows.Forms.ListView();
            this.lvBill = new System.Windows.Forms.ListView();
            this.btnPlus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExtPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.ProdId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBeverages.SuspendLayout();
            this.tabBakery.SuspendLayout();
            this.tabDairy.SuspendLayout();
            this.tabNonFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvBeverages
            // 
            this.lvBeverages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBeverages.LargeImageList = this.imageList1;
            this.lvBeverages.Location = new System.Drawing.Point(3, 3);
            this.lvBeverages.MultiSelect = false;
            this.lvBeverages.Name = "lvBeverages";
            this.lvBeverages.Size = new System.Drawing.Size(412, 363);
            this.lvBeverages.TabIndex = 0;
            this.lvBeverages.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(50, 50);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 80);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.toolStripSeparator4,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(80, 407);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 70);
            this.toolStripButton1.Text = "POS";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(78, 6);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBeverages);
            this.tabControl1.Controls.Add(this.tabBakery);
            this.tabControl1.Controls.Add(this.tabDairy);
            this.tabControl1.Controls.Add(this.tabNonFood);
            this.tabControl1.Location = new System.Drawing.Point(83, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 395);
            this.tabControl1.TabIndex = 3;
            // 
            // tabBeverages
            // 
            this.tabBeverages.Controls.Add(this.lvBeverages);
            this.tabBeverages.Location = new System.Drawing.Point(4, 22);
            this.tabBeverages.Name = "tabBeverages";
            this.tabBeverages.Padding = new System.Windows.Forms.Padding(3);
            this.tabBeverages.Size = new System.Drawing.Size(418, 369);
            this.tabBeverages.TabIndex = 0;
            this.tabBeverages.Text = "Beverages";
            this.tabBeverages.UseVisualStyleBackColor = true;
            // 
            // tabBakery
            // 
            this.tabBakery.Controls.Add(this.lvBakery);
            this.tabBakery.Location = new System.Drawing.Point(4, 22);
            this.tabBakery.Name = "tabBakery";
            this.tabBakery.Padding = new System.Windows.Forms.Padding(3);
            this.tabBakery.Size = new System.Drawing.Size(418, 369);
            this.tabBakery.TabIndex = 1;
            this.tabBakery.Text = "Bakery";
            this.tabBakery.UseVisualStyleBackColor = true;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 70);
            this.toolStripLabel1.Text = "Management";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(78, 6);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(80, 70);
            this.toolStripLabel2.Text = "Reports";
            this.toolStripLabel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(78, 6);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel3.Image")));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(80, 70);
            this.toolStripLabel3.Text = "Setup";
            this.toolStripLabel3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(78, 6);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.AutoSize = false;
            this.toolStripLabel4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel4.Image")));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(80, 70);
            this.toolStripLabel4.Text = "Logout";
            this.toolStripLabel4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tabDairy
            // 
            this.tabDairy.Controls.Add(this.lvDairy);
            this.tabDairy.Location = new System.Drawing.Point(4, 22);
            this.tabDairy.Name = "tabDairy";
            this.tabDairy.Size = new System.Drawing.Size(418, 369);
            this.tabDairy.TabIndex = 2;
            this.tabDairy.Text = "Dairy";
            this.tabDairy.UseVisualStyleBackColor = true;
            // 
            // tabNonFood
            // 
            this.tabNonFood.Controls.Add(this.lvNFood);
            this.tabNonFood.Location = new System.Drawing.Point(4, 22);
            this.tabNonFood.Name = "tabNonFood";
            this.tabNonFood.Size = new System.Drawing.Size(418, 369);
            this.tabNonFood.TabIndex = 3;
            this.tabNonFood.Text = "NonFood";
            this.tabNonFood.UseVisualStyleBackColor = true;
            // 
            // lvBakery
            // 
            this.lvBakery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBakery.LargeImageList = this.imageList2;
            this.lvBakery.Location = new System.Drawing.Point(3, 3);
            this.lvBakery.MultiSelect = false;
            this.lvBakery.Name = "lvBakery";
            this.lvBakery.Size = new System.Drawing.Size(412, 363);
            this.lvBakery.TabIndex = 1;
            this.lvBakery.UseCompatibleStateImageBehavior = false;
            // 
            // lvDairy
            // 
            this.lvDairy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDairy.LargeImageList = this.imageList3;
            this.lvDairy.Location = new System.Drawing.Point(0, 0);
            this.lvDairy.MultiSelect = false;
            this.lvDairy.Name = "lvDairy";
            this.lvDairy.Size = new System.Drawing.Size(418, 369);
            this.lvDairy.TabIndex = 1;
            this.lvDairy.UseCompatibleStateImageBehavior = false;
            // 
            // lvNFood
            // 
            this.lvNFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNFood.LargeImageList = this.imageList4;
            this.lvNFood.Location = new System.Drawing.Point(0, 0);
            this.lvNFood.MultiSelect = false;
            this.lvNFood.Name = "lvNFood";
            this.lvNFood.Size = new System.Drawing.Size(418, 369);
            this.lvNFood.TabIndex = 1;
            this.lvNFood.UseCompatibleStateImageBehavior = false;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.Qty,
            this.Price,
            this.ExtPrice,
            this.ProdId});
            this.lvBill.FullRowSelect = true;
            this.lvBill.Location = new System.Drawing.Point(512, 60);
            this.lvBill.MultiSelect = false;
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(302, 226);
            this.lvBill.TabIndex = 4;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPlus.Location = new System.Drawing.Point(705, 22);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlus.Size = new System.Drawing.Size(32, 32);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(743, 22);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(781, 22);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 118;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // ExtPrice
            // 
            this.ExtPrice.Text = "Ext Price";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(714, 292);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 8;
            this.txtSubTotal.Text = "0";
            // 
            // lblSubT
            // 
            this.lblSubT.AutoSize = true;
            this.lblSubT.Location = new System.Drawing.Point(648, 295);
            this.lblSubT.Name = "lblSubT";
            this.lblSubT.Size = new System.Drawing.Size(50, 13);
            this.lblSubT.TabIndex = 9;
            this.lblSubT.Text = "SubTotal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tax";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(714, 318);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtTotal.ForeColor = System.Drawing.Color.YellowGreen;
            this.txtTotal.Location = new System.Drawing.Point(714, 344);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.Text = "0";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(714, 371);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(99, 23);
            this.btnPay.TabIndex = 14;
            this.btnPay.Text = "Pay Bill";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Location = new System.Drawing.Point(516, 40);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(0, 13);
            this.lblBillNo.TabIndex = 15;
            // 
            // ProdId
            // 
            this.ProdId.Text = "ProdId";
            this.ProdId.Width = 0;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList4
            // 
            this.imageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList4.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 407);
            this.Controls.Add(this.lblBillNo);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblSubT);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lvBill);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "POS";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabBeverages.ResumeLayout(false);
            this.tabBakery.ResumeLayout(false);
            this.tabDairy.ResumeLayout(false);
            this.tabNonFood.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvBeverages;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBeverages;
        private System.Windows.Forms.TabPage tabBakery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.TabPage tabDairy;
        private System.Windows.Forms.TabPage tabNonFood;
        private System.Windows.Forms.ListView lvBakery;
        private System.Windows.Forms.ListView lvDairy;
        private System.Windows.Forms.ListView lvNFood;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader ExtPrice;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.ColumnHeader ProdId;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
    }
}