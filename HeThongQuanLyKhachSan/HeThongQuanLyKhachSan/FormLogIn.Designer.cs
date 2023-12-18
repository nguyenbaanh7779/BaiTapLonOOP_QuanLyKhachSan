namespace HeThongQuanLyKhachSan
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.lableWrongUserNameOrPassword = new System.Windows.Forms.Label();
            this.UserLogin = new System.Windows.Forms.Panel();
            this.UserLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            resources.ApplyResources(this.buttonLogin, "buttonLogin");
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lableWrongUserNameOrPassword
            // 
            resources.ApplyResources(this.lableWrongUserNameOrPassword, "lableWrongUserNameOrPassword");
            this.lableWrongUserNameOrPassword.ForeColor = System.Drawing.Color.Red;
            this.lableWrongUserNameOrPassword.Name = "lableWrongUserNameOrPassword";
            // 
            // UserLogin
            // 
            resources.ApplyResources(this.UserLogin, "UserLogin");
            this.UserLogin.Controls.Add(this.label1);
            this.UserLogin.Controls.Add(this.lableWrongUserNameOrPassword);
            this.UserLogin.Controls.Add(this.txtUsername);
            this.UserLogin.Controls.Add(this.buttonLogin);
            this.UserLogin.Controls.Add(this.label2);
            this.UserLogin.Controls.Add(this.txtPassword);
            this.UserLogin.Controls.Add(this.label3);
            this.UserLogin.Name = "UserLogin";
            // 
            // FormLogIn
            // 
            this.AcceptButton = this.buttonLogin;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserLogin);
            this.DoubleBuffered = true;
            this.Name = "FormLogIn";
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.UserLogin.ResumeLayout(false);
            this.UserLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private Button buttonLogin;
        private Label lableWrongUserNameOrPassword;
        private Panel UserLogin;
    }
}