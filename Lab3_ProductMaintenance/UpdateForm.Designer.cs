
namespace Lab3_ProductMaintenance
{
    partial class FrmUpdate
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
            this.LblProdCode = new System.Windows.Forms.Label();
            this.TxtProdcode = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtVersion = new System.Windows.Forms.TextBox();
            this.LblVersion = new System.Windows.Forms.Label();
            this.LblReleaseDate = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.DtTimePickRelease = new System.Windows.Forms.DateTimePicker();
            this.LblValidProdc = new System.Windows.Forms.Label();
            this.LblValidName = new System.Windows.Forms.Label();
            this.LblValidVersion = new System.Windows.Forms.Label();
            this.LblValidDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblProdCode
            // 
            this.LblProdCode.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblProdCode.Location = new System.Drawing.Point(123, 95);
            this.LblProdCode.Name = "LblProdCode";
            this.LblProdCode.Size = new System.Drawing.Size(160, 23);
            this.LblProdCode.TabIndex = 0;
            this.LblProdCode.Text = "Product code:";
            // 
            // TxtProdcode
            // 
            this.TxtProdcode.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtProdcode.Location = new System.Drawing.Point(318, 94);
            this.TxtProdcode.Name = "TxtProdcode";
            this.TxtProdcode.Size = new System.Drawing.Size(395, 29);
            this.TxtProdcode.TabIndex = 0;
            this.TxtProdcode.Tag = "Product code ";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(318, 156);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(395, 29);
            this.TxtName.TabIndex = 1;
            this.TxtName.Tag = "Name";
            // 
            // LblName
            // 
            this.LblName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblName.Location = new System.Drawing.Point(123, 157);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(160, 23);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Name:";
            // 
            // TxtVersion
            // 
            this.TxtVersion.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtVersion.Location = new System.Drawing.Point(318, 216);
            this.TxtVersion.Name = "TxtVersion";
            this.TxtVersion.Size = new System.Drawing.Size(395, 29);
            this.TxtVersion.TabIndex = 2;
            this.TxtVersion.Tag = "Version";
            // 
            // LblVersion
            // 
            this.LblVersion.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVersion.Location = new System.Drawing.Point(123, 217);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(160, 23);
            this.LblVersion.TabIndex = 4;
            this.LblVersion.Text = "Version:";
            // 
            // LblReleaseDate
            // 
            this.LblReleaseDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblReleaseDate.Location = new System.Drawing.Point(123, 277);
            this.LblReleaseDate.Name = "LblReleaseDate";
            this.LblReleaseDate.Size = new System.Drawing.Size(160, 23);
            this.LblReleaseDate.TabIndex = 6;
            this.LblReleaseDate.Text = "Release date:";
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnOk.Location = new System.Drawing.Point(271, 380);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(90, 41);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.Btn_Add_Modify);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.Location = new System.Drawing.Point(480, 379);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 41);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // DtTimePickRelease
            // 
            this.DtTimePickRelease.CalendarFont = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtTimePickRelease.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtTimePickRelease.Location = new System.Drawing.Point(318, 277);
            this.DtTimePickRelease.MaximumSize = new System.Drawing.Size(1000, 50);
            this.DtTimePickRelease.Name = "DtTimePickRelease";
            this.DtTimePickRelease.Size = new System.Drawing.Size(324, 29);
            this.DtTimePickRelease.TabIndex = 3;
         //   this.DtTimePickRelease.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DtTimePickRelease_MouseDown);
            // 
            // LblValidProdc
            // 
            this.LblValidProdc.ForeColor = System.Drawing.Color.Red;
            this.LblValidProdc.Location = new System.Drawing.Point(318, 126);
            this.LblValidProdc.Name = "LblValidProdc";
            this.LblValidProdc.Size = new System.Drawing.Size(395, 18);
            this.LblValidProdc.TabIndex = 7;
            this.LblValidProdc.Visible = false;
            // 
            // LblValidName
            // 
            this.LblValidName.ForeColor = System.Drawing.Color.Red;
            this.LblValidName.Location = new System.Drawing.Point(318, 188);
            this.LblValidName.Name = "LblValidName";
            this.LblValidName.Size = new System.Drawing.Size(395, 18);
            this.LblValidName.TabIndex = 8;
            this.LblValidName.Visible = false;
            // 
            // LblValidVersion
            // 
            this.LblValidVersion.ForeColor = System.Drawing.Color.Red;
            this.LblValidVersion.Location = new System.Drawing.Point(318, 248);
            this.LblValidVersion.Name = "LblValidVersion";
            this.LblValidVersion.Size = new System.Drawing.Size(395, 18);
            this.LblValidVersion.TabIndex = 9;
            this.LblValidVersion.Visible = false;
            // 
            // LblValidDate
            // 
            this.LblValidDate.ForeColor = System.Drawing.Color.Red;
            this.LblValidDate.Location = new System.Drawing.Point(318, 309);
            this.LblValidDate.Name = "LblValidDate";
            this.LblValidDate.Size = new System.Drawing.Size(395, 18);
            this.LblValidDate.TabIndex = 10;
            this.LblValidDate.Visible = false;
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblValidDate);
            this.Controls.Add(this.LblValidVersion);
            this.Controls.Add(this.LblValidName);
            this.Controls.Add(this.LblValidProdc);
            this.Controls.Add(this.DtTimePickRelease);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LblReleaseDate);
            this.Controls.Add(this.TxtVersion);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtProdcode);
            this.Controls.Add(this.LblProdCode);
            this.Name = "FrmUpdate";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProdCode;
        public System.Windows.Forms.TextBox TxtProdcode;
        public System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        public System.Windows.Forms.TextBox TxtVersion;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label LblReleaseDate;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        public System.Windows.Forms.DateTimePicker DtTimePickRelease;
        public System.Windows.Forms.Label LblValidProdc;
        public System.Windows.Forms.Label LblValidName;
        public System.Windows.Forms.Label LblValidVersion;
        public System.Windows.Forms.Label LblValidDate;
    }
}