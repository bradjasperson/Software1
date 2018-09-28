namespace Software1
{
    partial class AddProduct
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
            this.AddProductBox = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProductResultID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductResultName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductResultInv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductResultPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartSearchButton = new System.Windows.Forms.Button();
            this.PartSearch = new System.Windows.Forms.TextBox();
            this.ROProductID = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.EnterMin = new System.Windows.Forms.TextBox();
            this.EnterMax = new System.Windows.Forms.TextBox();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.EnterPrice = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.EnterInv = new System.Windows.Forms.TextBox();
            this.InvLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EnterProductName = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddProductBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddProductBox
            // 
            this.AddProductBox.Controls.Add(this.CancelButton);
            this.AddProductBox.Controls.Add(this.SaveButton);
            this.AddProductBox.Controls.Add(this.DeletePartButton);
            this.AddProductBox.Controls.Add(this.AddPartButton);
            this.AddProductBox.Controls.Add(this.listView2);
            this.AddProductBox.Controls.Add(this.listView1);
            this.AddProductBox.Controls.Add(this.PartSearchButton);
            this.AddProductBox.Controls.Add(this.PartSearch);
            this.AddProductBox.Controls.Add(this.ROProductID);
            this.AddProductBox.Controls.Add(this.IdLabel);
            this.AddProductBox.Controls.Add(this.EnterMin);
            this.AddProductBox.Controls.Add(this.EnterMax);
            this.AddProductBox.Controls.Add(this.MinLabel);
            this.AddProductBox.Controls.Add(this.MaxLabel);
            this.AddProductBox.Controls.Add(this.EnterPrice);
            this.AddProductBox.Controls.Add(this.PriceLabel);
            this.AddProductBox.Controls.Add(this.EnterInv);
            this.AddProductBox.Controls.Add(this.InvLabel);
            this.AddProductBox.Controls.Add(this.NameLabel);
            this.AddProductBox.Controls.Add(this.EnterProductName);
            this.AddProductBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductBox.Location = new System.Drawing.Point(12, 12);
            this.AddProductBox.Name = "AddProductBox";
            this.AddProductBox.Size = new System.Drawing.Size(877, 521);
            this.AddProductBox.TabIndex = 1;
            this.AddProductBox.TabStop = false;
            this.AddProductBox.Text = "Add Product";
            this.AddProductBox.Enter += new System.EventHandler(this.AddProductBox_Enter);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoEllipsis = true;
            this.SaveButton.Location = new System.Drawing.Point(675, 482);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Location = new System.Drawing.Point(757, 391);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(89, 34);
            this.DeletePartButton.TabIndex = 26;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(757, 196);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(89, 39);
            this.AddPartButton.TabIndex = 25;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(432, 288);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(414, 97);
            this.listView2.TabIndex = 24;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Inventory Level";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price/Cost Per Unit";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 130;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductResultID,
            this.ProductResultName,
            this.ProductResultInv,
            this.ProductResultPrice});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(432, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(414, 97);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ProductResultID
            // 
            this.ProductResultID.Text = "Product ID";
            // 
            // ProductResultName
            // 
            this.ProductResultName.Text = "Product Name";
            this.ProductResultName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductResultName.Width = 120;
            // 
            // ProductResultInv
            // 
            this.ProductResultInv.Text = "Inventory Level";
            this.ProductResultInv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductResultInv.Width = 100;
            // 
            // ProductResultPrice
            // 
            this.ProductResultPrice.Text = "Price/Cost Per Unit";
            this.ProductResultPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductResultPrice.Width = 130;
            // 
            // PartSearchButton
            // 
            this.PartSearchButton.Location = new System.Drawing.Point(771, 44);
            this.PartSearchButton.Name = "PartSearchButton";
            this.PartSearchButton.Size = new System.Drawing.Size(75, 23);
            this.PartSearchButton.TabIndex = 22;
            this.PartSearchButton.Text = "Search";
            this.PartSearchButton.UseVisualStyleBackColor = true;
            this.PartSearchButton.Click += new System.EventHandler(this.PartSearchButton_Click);
            // 
            // PartSearch
            // 
            this.PartSearch.Location = new System.Drawing.Point(540, 44);
            this.PartSearch.Name = "PartSearch";
            this.PartSearch.Size = new System.Drawing.Size(210, 20);
            this.PartSearch.TabIndex = 21;
            // 
            // ROProductID
            // 
            this.ROProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROProductID.Location = new System.Drawing.Point(137, 157);
            this.ROProductID.Name = "ROProductID";
            this.ROProductID.ReadOnly = true;
            this.ROProductID.Size = new System.Drawing.Size(231, 20);
            this.ROProductID.TabIndex = 20;
            this.ROProductID.Text = "Auto Gen";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(12, 160);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(68, 13);
            this.IdLabel.TabIndex = 19;
            this.IdLabel.Text = "Product ID";
            // 
            // EnterMin
            // 
            this.EnterMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterMin.Location = new System.Drawing.Point(282, 303);
            this.EnterMin.Name = "EnterMin";
            this.EnterMin.Size = new System.Drawing.Size(85, 20);
            this.EnterMin.TabIndex = 13;
            this.EnterMin.Text = "Min";
            // 
            // EnterMax
            // 
            this.EnterMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterMax.Location = new System.Drawing.Point(136, 303);
            this.EnterMax.Name = "EnterMax";
            this.EnterMax.Size = new System.Drawing.Size(85, 20);
            this.EnterMax.TabIndex = 12;
            this.EnterMax.Text = "Max";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(238, 310);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(27, 13);
            this.MinLabel.TabIndex = 11;
            this.MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(9, 303);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(30, 13);
            this.MaxLabel.TabIndex = 10;
            this.MaxLabel.Text = "Max";
            // 
            // EnterPrice
            // 
            this.EnterPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPrice.Location = new System.Drawing.Point(136, 267);
            this.EnterPrice.Name = "EnterPrice";
            this.EnterPrice.Size = new System.Drawing.Size(231, 20);
            this.EnterPrice.TabIndex = 7;
            this.EnterPrice.Text = "Price/Cost";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(9, 267);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(67, 13);
            this.PriceLabel.TabIndex = 6;
            this.PriceLabel.Text = "Price/Cost";
            // 
            // EnterInv
            // 
            this.EnterInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterInv.Location = new System.Drawing.Point(136, 231);
            this.EnterInv.Name = "EnterInv";
            this.EnterInv.Size = new System.Drawing.Size(231, 20);
            this.EnterInv.TabIndex = 5;
            this.EnterInv.Text = "Inventory Count";
            // 
            // InvLabel
            // 
            this.InvLabel.AutoSize = true;
            this.InvLabel.Location = new System.Drawing.Point(9, 231);
            this.InvLabel.Name = "InvLabel";
            this.InvLabel.Size = new System.Drawing.Size(60, 13);
            this.InvLabel.TabIndex = 4;
            this.InvLabel.Text = "Inventory";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 196);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // EnterProductName
            // 
            this.EnterProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterProductName.Location = new System.Drawing.Point(136, 193);
            this.EnterProductName.Name = "EnterProductName";
            this.EnterProductName.Size = new System.Drawing.Size(231, 20);
            this.EnterProductName.TabIndex = 2;
            this.EnterProductName.Text = "Product Name";
            // 
            // CancelButton
            // 
            this.CancelButton.AutoEllipsis = true;
            this.CancelButton.Location = new System.Drawing.Point(771, 482);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 28;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 545);
            this.Controls.Add(this.AddProductBox);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.AddProductBox.ResumeLayout(false);
            this.AddProductBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddProductBox;
        private System.Windows.Forms.TextBox ROProductID;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox EnterMin;
        private System.Windows.Forms.TextBox EnterMax;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.TextBox EnterPrice;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox EnterInv;
        private System.Windows.Forms.Label InvLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox EnterProductName;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ProductResultID;
        private System.Windows.Forms.ColumnHeader ProductResultName;
        private System.Windows.Forms.ColumnHeader ProductResultInv;
        private System.Windows.Forms.ColumnHeader ProductResultPrice;
        private System.Windows.Forms.Button PartSearchButton;
        private System.Windows.Forms.TextBox PartSearch;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button CancelButton;
    }
}