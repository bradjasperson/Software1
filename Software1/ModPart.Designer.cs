namespace Software1
{
    partial class ModPart
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
            this.ModPartGrp = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // ModPartGrp
            // 
            this.ModPartGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartGrp.Location = new System.Drawing.Point(345, 94);
            this.ModPartGrp.Name = "ModPartGrp";
            this.ModPartGrp.Size = new System.Drawing.Size(200, 100);
            this.ModPartGrp.TabIndex = 0;
            this.ModPartGrp.TabStop = false;
            this.ModPartGrp.Text = "Modify Part";
            this.ModPartGrp.Enter += new System.EventHandler(this.ModPartGrp_Enter);
            // 
            // ModPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModPartGrp);
            this.Name = "ModPart";
            this.Text = "ModPart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ModPartGrp;
    }
}