namespace Software1
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.Parts = new System.Windows.Forms.GroupBox();
            this.DelPartButton = new System.Windows.Forms.Button();
            this.PartResults = new System.Windows.Forms.ListView();
            this.PartResultID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartResultName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartResultInv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartResultPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModPartButton = new System.Windows.Forms.Button();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.PartSearchButton = new System.Windows.Forms.Button();
            this.PartSearch = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.GroupBox();
            this.ProductDeleteButton = new System.Windows.Forms.Button();
            this.ProductResults = new System.Windows.Forms.ListView();
            this.ProductResultID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductResultName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductResultInv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductResultPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductModifyButton = new System.Windows.Forms.Button();
            this.ProductAddButton = new System.Windows.Forms.Button();
            this.ProductSearchButton = new System.Windows.Forms.Button();
            this.ProductSearch = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.Parts.SuspendLayout();
            this.Products.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Parts
            // 
            this.Parts.Controls.Add(this.DelPartButton);
            this.Parts.Controls.Add(this.PartResults);
            this.Parts.Controls.Add(this.ModPartButton);
            this.Parts.Controls.Add(this.AddPartButton);
            this.Parts.Controls.Add(this.PartSearchButton);
            this.Parts.Controls.Add(this.PartSearch);
            this.Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parts.Location = new System.Drawing.Point(15, 60);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(429, 309);
            this.Parts.TabIndex = 1;
            this.Parts.TabStop = false;
            this.Parts.Text = "Parts";
            // 
            // DelPartButton
            // 
            this.DelPartButton.Location = new System.Drawing.Point(288, 194);
            this.DelPartButton.Name = "DelPartButton";
            this.DelPartButton.Size = new System.Drawing.Size(75, 23);
            this.DelPartButton.TabIndex = 5;
            this.DelPartButton.Text = "Delete";
            this.DelPartButton.UseVisualStyleBackColor = true;
            this.DelPartButton.Click += new System.EventHandler(this.DelPartButton_Click);
            // 
            // PartResults
            // 
            this.PartResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PartResultID,
            this.PartResultName,
            this.PartResultInv,
            this.PartResultPrice});
            this.PartResults.FullRowSelect = true;
            this.PartResults.GridLines = true;
            this.PartResults.Location = new System.Drawing.Point(6, 73);
            this.PartResults.Name = "PartResults";
            this.PartResults.Size = new System.Drawing.Size(414, 97);
            this.PartResults.TabIndex = 4;
            this.PartResults.UseCompatibleStateImageBehavior = false;
            this.PartResults.View = System.Windows.Forms.View.Details;
            this.PartResults.SelectedIndexChanged += new System.EventHandler(this.PartResults_SelectedIndexChanged);
            // 
            // PartResultID
            // 
            this.PartResultID.Text = "Part ID";
            // 
            // PartResultName
            // 
            this.PartResultName.Text = "Part Name";
            this.PartResultName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartResultName.Width = 120;
            // 
            // PartResultInv
            // 
            this.PartResultInv.Text = "Inventory Level";
            this.PartResultInv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartResultInv.Width = 100;
            // 
            // PartResultPrice
            // 
            this.PartResultPrice.Text = "Price/Cost Per Unit";
            this.PartResultPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartResultPrice.Width = 130;
            // 
            // ModPartButton
            // 
            this.ModPartButton.Location = new System.Drawing.Point(186, 194);
            this.ModPartButton.Name = "ModPartButton";
            this.ModPartButton.Size = new System.Drawing.Size(75, 23);
            this.ModPartButton.TabIndex = 3;
            this.ModPartButton.Text = "Modify";
            this.ModPartButton.UseVisualStyleBackColor = true;
            this.ModPartButton.Click += new System.EventHandler(this.ModPartButton_Click);
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(88, 194);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(75, 23);
            this.AddPartButton.TabIndex = 2;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // PartSearchButton
            // 
            this.PartSearchButton.Location = new System.Drawing.Point(320, 17);
            this.PartSearchButton.Name = "PartSearchButton";
            this.PartSearchButton.Size = new System.Drawing.Size(75, 23);
            this.PartSearchButton.TabIndex = 1;
            this.PartSearchButton.Text = "Search";
            this.PartSearchButton.UseVisualStyleBackColor = true;
            this.PartSearchButton.Click += new System.EventHandler(this.PartSearchButton_Click);
            // 
            // PartSearch
            // 
            this.PartSearch.Location = new System.Drawing.Point(88, 17);
            this.PartSearch.Name = "PartSearch";
            this.PartSearch.Size = new System.Drawing.Size(210, 20);
            this.PartSearch.TabIndex = 0;
            this.PartSearch.TextChanged += new System.EventHandler(this.PartSearch_TextChanged);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label.Location = new System.Drawing.Point(15, 13);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(256, 20);
            this.Label.TabIndex = 2;
            this.Label.Text = "Inventory Management System";
            // 
            // Products
            // 
            this.Products.Controls.Add(this.ProductDeleteButton);
            this.Products.Controls.Add(this.ProductResults);
            this.Products.Controls.Add(this.ProductModifyButton);
            this.Products.Controls.Add(this.ProductAddButton);
            this.Products.Controls.Add(this.ProductSearchButton);
            this.Products.Controls.Add(this.ProductSearch);
            this.Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.Location = new System.Drawing.Point(517, 60);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(445, 309);
            this.Products.TabIndex = 3;
            this.Products.TabStop = false;
            this.Products.Text = "Products";
            // 
            // ProductDeleteButton
            // 
            this.ProductDeleteButton.Location = new System.Drawing.Point(288, 194);
            this.ProductDeleteButton.Name = "ProductDeleteButton";
            this.ProductDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ProductDeleteButton.TabIndex = 5;
            this.ProductDeleteButton.Text = "Delete";
            this.ProductDeleteButton.UseVisualStyleBackColor = true;
            this.ProductDeleteButton.Click += new System.EventHandler(this.ProductDeleteButton_Click);
            // 
            // ProductResults
            // 
            this.ProductResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductResultID,
            this.ProductResultName,
            this.ProductResultInv,
            this.ProductResultPrice});
            this.ProductResults.FullRowSelect = true;
            this.ProductResults.GridLines = true;
            this.ProductResults.Location = new System.Drawing.Point(6, 73);
            this.ProductResults.Name = "ProductResults";
            this.ProductResults.Size = new System.Drawing.Size(433, 97);
            this.ProductResults.TabIndex = 4;
            this.ProductResults.UseCompatibleStateImageBehavior = false;
            this.ProductResults.View = System.Windows.Forms.View.Details;
            this.ProductResults.SelectedIndexChanged += new System.EventHandler(this.ProductResults_SelectedIndexChanged);
            // 
            // ProductResultID
            // 
            this.ProductResultID.Text = "Product ID";
            this.ProductResultID.Width = 75;
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
            // ProductModifyButton
            // 
            this.ProductModifyButton.Location = new System.Drawing.Point(186, 194);
            this.ProductModifyButton.Name = "ProductModifyButton";
            this.ProductModifyButton.Size = new System.Drawing.Size(75, 23);
            this.ProductModifyButton.TabIndex = 3;
            this.ProductModifyButton.Text = "Modify";
            this.ProductModifyButton.UseVisualStyleBackColor = true;
            this.ProductModifyButton.Click += new System.EventHandler(this.ProductModifyButton_Click);
            // 
            // ProductAddButton
            // 
            this.ProductAddButton.Location = new System.Drawing.Point(88, 194);
            this.ProductAddButton.Name = "ProductAddButton";
            this.ProductAddButton.Size = new System.Drawing.Size(75, 23);
            this.ProductAddButton.TabIndex = 2;
            this.ProductAddButton.Text = "Add";
            this.ProductAddButton.UseVisualStyleBackColor = true;
            this.ProductAddButton.Click += new System.EventHandler(this.ProductAddButton_Click);
            // 
            // ProductSearchButton
            // 
            this.ProductSearchButton.Location = new System.Drawing.Point(320, 17);
            this.ProductSearchButton.Name = "ProductSearchButton";
            this.ProductSearchButton.Size = new System.Drawing.Size(75, 23);
            this.ProductSearchButton.TabIndex = 1;
            this.ProductSearchButton.Text = "Search";
            this.ProductSearchButton.UseVisualStyleBackColor = true;
            this.ProductSearchButton.Click += new System.EventHandler(this.ProductSearchButton_Click);
            // 
            // ProductSearch
            // 
            this.ProductSearch.Location = new System.Drawing.Point(88, 17);
            this.ProductSearch.Name = "ProductSearch";
            this.ProductSearch.Size = new System.Drawing.Size(210, 20);
            this.ProductSearch.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(853, 397);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(107, 35);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorLabel.Location = new System.Drawing.Point(21, 397);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 453);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Parts);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.Parts.ResumeLayout(false);
            this.Parts.PerformLayout();
            this.Products.ResumeLayout(false);
            this.Products.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Parts;
        private System.Windows.Forms.Button PartSearchButton;
        private System.Windows.Forms.TextBox PartSearch;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button ModPartButton;
        private System.Windows.Forms.ListView PartResults;
        private System.Windows.Forms.ColumnHeader PartResultID;
        private System.Windows.Forms.ColumnHeader PartResultName;
        private System.Windows.Forms.Button DelPartButton;
        private System.Windows.Forms.ColumnHeader PartResultInv;
        private System.Windows.Forms.ColumnHeader PartResultPrice;
        private System.Windows.Forms.GroupBox Products;
        private System.Windows.Forms.Button ProductDeleteButton;
        private System.Windows.Forms.ListView ProductResults;
        private System.Windows.Forms.ColumnHeader ProductResultID;
        private System.Windows.Forms.ColumnHeader ProductResultName;
        private System.Windows.Forms.ColumnHeader ProductResultInv;
        private System.Windows.Forms.ColumnHeader ProductResultPrice;
        private System.Windows.Forms.Button ProductModifyButton;
        private System.Windows.Forms.Button ProductAddButton;
        private System.Windows.Forms.Button ProductSearchButton;
        private System.Windows.Forms.TextBox ProductSearch;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

