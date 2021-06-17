
namespace Lab3_ProductMaintenance
{
    partial class FrmProdMaint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblHeaders = new System.Windows.Forms.Label();
            this.LstData = new System.Windows.Forms.ListBox();
            this.MnuCustomerUpdate = new System.Windows.Forms.MenuStrip();
            this.MnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuModify = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCustomerUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblHeaders
            // 
            this.LblHeaders.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblHeaders.Location = new System.Drawing.Point(116, 75);
            this.LblHeaders.Name = "LblHeaders";
            this.LblHeaders.Size = new System.Drawing.Size(992, 23);
            this.LblHeaders.TabIndex = 0;
            // 
            // LstData
            // 
            this.LstData.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstData.FormattingEnabled = true;
            this.LstData.ItemHeight = 18;
            this.LstData.Location = new System.Drawing.Point(116, 101);
            this.LstData.Name = "LstData";
            this.LstData.Size = new System.Drawing.Size(992, 292);
            this.LstData.TabIndex = 1;
            // 
            // MnuCustomerUpdate
            // 
            this.MnuCustomerUpdate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MnuCustomerUpdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAdd,
            this.MnuModify,
            this.MnuRemove,
            this.MnuExit});
            this.MnuCustomerUpdate.Location = new System.Drawing.Point(0, 0);
            this.MnuCustomerUpdate.Name = "MnuCustomerUpdate";
            this.MnuCustomerUpdate.Size = new System.Drawing.Size(1188, 29);
            this.MnuCustomerUpdate.TabIndex = 2;
            this.MnuCustomerUpdate.Text = "Add";
            // 
            // MnuAdd
            // 
            this.MnuAdd.Name = "MnuAdd";
            this.MnuAdd.Size = new System.Drawing.Size(50, 25);
            this.MnuAdd.Text = "&Add";
            this.MnuAdd.Click += new System.EventHandler(this.MnuAdd_Click);
            // 
            // MnuModify
            // 
            this.MnuModify.Name = "MnuModify";
            this.MnuModify.Size = new System.Drawing.Size(71, 25);
            this.MnuModify.Text = "&Modify";
            this.MnuModify.Click += new System.EventHandler(this.MnuModify_Click);
            // 
            // MnuRemove
            // 
            this.MnuRemove.Name = "MnuRemove";
            this.MnuRemove.Size = new System.Drawing.Size(79, 25);
            this.MnuRemove.Text = "&Remove";
            this.MnuRemove.Click += new System.EventHandler(this.MnuRemove_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(46, 25);
            this.MnuExit.Text = "E&xit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // FrmProdMaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 505);
            this.Controls.Add(this.LstData);
            this.Controls.Add(this.LblHeaders);
            this.Controls.Add(this.MnuCustomerUpdate);
            this.MainMenuStrip = this.MnuCustomerUpdate;
            this.Name = "FrmProdMaint";
            this.Text = "Product Maintenance";
            this.Load += new System.EventHandler(this.FrmProdMaint_Load);
            this.MnuCustomerUpdate.ResumeLayout(false);
            this.MnuCustomerUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHeaders;
        private System.Windows.Forms.ListBox LstData;
        private System.Windows.Forms.MenuStrip MnuCustomerUpdate;
        public System.Windows.Forms.ToolStripMenuItem MnuAdd;
        public System.Windows.Forms.ToolStripMenuItem MnuModify;
        public System.Windows.Forms.ToolStripMenuItem MnuRemove;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
    }
}

