namespace Software1
{
    partial class ModProduct
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.DeletePart = new System.Windows.Forms.Button();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.SearchPart = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PartList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartResults = new System.Windows.Forms.ListView();
            this.ProductResultID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductResultName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductResultInv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductResultPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.AddProductBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddProductBox
            // 
            this.AddProductBox.Controls.Add(this.ErrorLabel);
            this.AddProductBox.Controls.Add(this.DeletePart);
            this.AddProductBox.Controls.Add(this.AddPartButton);
            this.AddProductBox.Controls.Add(this.SearchPart);
            this.AddProductBox.Controls.Add(this.Cancel);
            this.AddProductBox.Controls.Add(this.SaveButton);
            this.AddProductBox.Controls.Add(this.PartList);
            this.AddProductBox.Controls.Add(this.PartResults);
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
            this.AddProductBox.TabIndex = 2;
            this.AddProductBox.TabStop = false;
            this.AddProductBox.Text = "Modify Product";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorLabel.Location = new System.Drawing.Point(15, 390);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 32;
            // 
            // DeletePart
            // 
            this.DeletePart.Location = new System.Drawing.Point(795, 419);
            this.DeletePart.Name = "DeletePart";
            this.DeletePart.Size = new System.Drawing.Size(75, 23);
            this.DeletePart.TabIndex = 31;
            this.DeletePart.Text = "Delete";
            this.DeletePart.UseVisualStyleBackColor = true;
            this.DeletePart.Click += new System.EventHandler(this.DeletePart_Click);
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(795, 220);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(75, 23);
            this.AddPartButton.TabIndex = 30;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // SearchPart
            // 
            this.SearchPart.Location = new System.Drawing.Point(796, 44);
            this.SearchPart.Name = "SearchPart";
            this.SearchPart.Size = new System.Drawing.Size(75, 23);
            this.SearchPart.TabIndex = 29;
            this.SearchPart.Text = "Search";
            this.SearchPart.UseVisualStyleBackColor = true;
            this.SearchPart.Click += new System.EventHandler(this.SearchPart_Click);
            // 
            // Cancel
            // 
            this.Cancel.AutoEllipsis = true;
            this.Cancel.Location = new System.Drawing.Point(771, 482);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 28;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
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
            // PartList
            // 
            this.PartList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.PartList.FullRowSelect = true;
            this.PartList.GridLines = true;
            this.PartList.Location = new System.Drawing.Point(405, 288);
            this.PartList.Name = "PartList";
            this.PartList.Size = new System.Drawing.Size(466, 116);
            this.PartList.TabIndex = 24;
            this.PartList.UseCompatibleStateImageBehavior = false;
            this.PartList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product ID";
            this.columnHeader1.Width = 114;
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
            // PartResults
            // 
            this.PartResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductResultID,
            this.ProductResultName,
            this.ProductResultInv,
            this.ProductResultPrice});
            this.PartResults.FullRowSelect = true;
            this.PartResults.GridLines = true;
            this.PartResults.Location = new System.Drawing.Point(405, 92);
            this.PartResults.Name = "PartResults";
            this.PartResults.Size = new System.Drawing.Size(466, 117);
            this.PartResults.TabIndex = 23;
            this.PartResults.UseCompatibleStateImageBehavior = false;
            this.PartResults.View = System.Windows.Forms.View.Details;
            this.PartResults.SelectedIndexChanged += new System.EventHandler(this.PartResults_SelectedIndexChanged);
            // 
            // ProductResultID
            // 
            this.ProductResultID.Text = "Product ID";
            this.ProductResultID.Width = 113;
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
            // PartSearch
            // 
            this.PartSearch.Location = new System.Drawing.Point(559, 46);
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
            // ModProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 542);
            this.Controls.Add(this.AddProductBox);
            this.Name = "ModProduct";
            this.Text = "ModProductcs";
            this.AddProductBox.ResumeLayout(false);
            this.AddProductBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddProductBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button DeletePart;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button SearchPart;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ListView PartList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView PartResults;
        private System.Windows.Forms.ColumnHeader ProductResultID;
        private System.Windows.Forms.ColumnHeader ProductResultName;
        private System.Windows.Forms.ColumnHeader ProductResultInv;
        private System.Windows.Forms.ColumnHeader ProductResultPrice;
        private System.Windows.Forms.TextBox PartSearch;
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
    }
}