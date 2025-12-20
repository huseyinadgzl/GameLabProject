namespace GameLabProject.Forms
{
    partial class RegisterForm
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
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtSurname = new DevExpress.XtraEditors.TextEdit();
            this.txtUserNameR = new DevExpress.XtraEditors.TextEdit();
            this.txtPasswordR = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.smplebtnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNameR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordR.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(118, 111);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(125, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtUserNameR
            // 
            this.txtUserNameR.Location = new System.Drawing.Point(118, 151);
            this.txtUserNameR.Name = "txtUserNameR";
            this.txtUserNameR.Size = new System.Drawing.Size(125, 20);
            this.txtUserNameR.TabIndex = 2;
            // 
            // txtPasswordR
            // 
            this.txtPasswordR.Location = new System.Drawing.Point(118, 187);
            this.txtPasswordR.Name = "txtPasswordR";
            this.txtPasswordR.Size = new System.Drawing.Size(125, 20);
            this.txtPasswordR.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(91, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Ad:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(74, 114);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Soyad:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(49, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Kullanıcı Adı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(82, 190);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Şifre:";
            // 
            // smplebtnSave
            // 
            this.smplebtnSave.Location = new System.Drawing.Point(168, 226);
            this.smplebtnSave.Name = "smplebtnSave";
            this.smplebtnSave.Size = new System.Drawing.Size(75, 23);
            this.smplebtnSave.TabIndex = 8;
            this.smplebtnSave.Text = "Kayıt Ol";
            this.smplebtnSave.Click += new System.EventHandler(this.smplebtnSave_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 354);
            this.Controls.Add(this.smplebtnSave);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPasswordR);
            this.Controls.Add(this.txtUserNameR);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNameR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordR.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtSurname;
        private DevExpress.XtraEditors.TextEdit txtUserNameR;
        private DevExpress.XtraEditors.TextEdit txtPasswordR;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton smplebtnSave;
    }
}