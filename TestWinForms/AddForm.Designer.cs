namespace TestWinForms
{
    partial class AddForm
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
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.AgeTxt = new System.Windows.Forms.TextBox();
            this.Add2Btn = new DevExpress.XtraEditors.SimpleButton();
            this.NameLbl = new DevExpress.XtraEditors.LabelControl();
            this.AddressLbl = new DevExpress.XtraEditors.LabelControl();
            this.AgeLbl = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(36, 45);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(156, 20);
            this.NameTxt.TabIndex = 0;
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(36, 91);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(156, 20);
            this.AddressTxt.TabIndex = 1;
            // 
            // AgeTxt
            // 
            this.AgeTxt.Location = new System.Drawing.Point(36, 135);
            this.AgeTxt.Name = "AgeTxt";
            this.AgeTxt.Size = new System.Drawing.Size(156, 20);
            this.AgeTxt.TabIndex = 2;
            // 
            // Add2Btn
            // 
            this.Add2Btn.Location = new System.Drawing.Point(74, 178);
            this.Add2Btn.Name = "Add2Btn";
            this.Add2Btn.Size = new System.Drawing.Size(75, 23);
            this.Add2Btn.TabIndex = 3;
            this.Add2Btn.Text = "Add";
            this.Add2Btn.Click += new System.EventHandler(this.Add2Btn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.Location = new System.Drawing.Point(198, 52);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(27, 13);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Name";
            // 
            // AddressLbl
            // 
            this.AddressLbl.Location = new System.Drawing.Point(198, 91);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(39, 13);
            this.AddressLbl.TabIndex = 5;
            this.AddressLbl.Text = "Address";
            // 
            // AgeLbl
            // 
            this.AgeLbl.Location = new System.Drawing.Point(198, 135);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(19, 13);
            this.AgeLbl.TabIndex = 6;
            this.AgeLbl.Text = "Age";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 245);
            this.Controls.Add(this.AgeLbl);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.Add2Btn);
            this.Controls.Add(this.AgeTxt);
            this.Controls.Add(this.AddressTxt);
            this.Controls.Add(this.NameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox AgeTxt;
        private DevExpress.XtraEditors.SimpleButton Add2Btn;
        private DevExpress.XtraEditors.LabelControl NameLbl;
        private DevExpress.XtraEditors.LabelControl AddressLbl;
        private DevExpress.XtraEditors.LabelControl AgeLbl;
    }
}