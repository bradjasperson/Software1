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
            this.AddPartButton = new System.Windows.Forms.Button();
            this.PartSearchButton = new System.Windows.Forms.Button();
            this.PartSearch = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.Parts.SuspendLayout();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Parts
            // 
            this.Parts.Controls.Add(this.AddPartButton);
            this.Parts.Controls.Add(this.PartSearchButton);
            this.Parts.Controls.Add(this.PartSearch);
            this.Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parts.Location = new System.Drawing.Point(19, 84);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(592, 309);
            this.Parts.TabIndex = 1;
            this.Parts.TabStop = false;
            this.Parts.Text = "Parts";
            this.Parts.Enter += new System.EventHandler(this.Parts_Enter);
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(352, 108);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(75, 23);
            this.AddPartButton.TabIndex = 2;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // PartSearchButton
            // 
            this.PartSearchButton.Location = new System.Drawing.Point(499, 17);
            this.PartSearchButton.Name = "PartSearchButton";
            this.PartSearchButton.Size = new System.Drawing.Size(75, 23);
            this.PartSearchButton.TabIndex = 1;
            this.PartSearchButton.Text = "Search";
            this.PartSearchButton.UseVisualStyleBackColor = true;
            this.PartSearchButton.Click += new System.EventHandler(this.PartSearchButton_Click);
            // 
            // PartSearch
            // 
            this.PartSearch.Location = new System.Drawing.Point(283, 19);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Parts);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.Parts.ResumeLayout(false);
            this.Parts.PerformLayout();
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
    }
}

