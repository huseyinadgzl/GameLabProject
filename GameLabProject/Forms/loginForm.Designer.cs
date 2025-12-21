namespace GameLabProject
{
    partial class loginForm
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
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.smplBtnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.smplBtnCreate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(204, 149);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(123, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(204, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(123, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // smplBtnLogin
            // 
            this.smplBtnLogin.Location = new System.Drawing.Point(252, 221);
            this.smplBtnLogin.Name = "smplBtnLogin";
            this.smplBtnLogin.Size = new System.Drawing.Size(75, 23);
            this.smplBtnLogin.TabIndex = 2;
            this.smplBtnLogin.Text = "Giriş Yap";
            this.smplBtnLogin.Click += new System.EventHandler(this.smplBtnLogin_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(132, 152);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(59, 13);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Kullanıcı Adı:";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(165, 188);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(26, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Şifre:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(153, 228);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Hesabınız Yok mu?";
            // 
            // smplBtnCreate
            // 
            this.smplBtnCreate.Location = new System.Drawing.Point(153, 247);
            this.smplBtnCreate.Name = "smplBtnCreate";
            this.smplBtnCreate.Size = new System.Drawing.Size(75, 23);
            this.smplBtnCreate.TabIndex = 6;
            this.smplBtnCreate.Text = "Hesap Oluştur";
            this.smplBtnCreate.Click += new System.EventHandler(this.smplBtnCreate_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 415);
            this.Controls.Add(this.smplBtnCreate);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.smplBtnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "loginForm";
            this.Text = "loginForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton smplBtnLogin;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton smplBtnCreate;
    }
}