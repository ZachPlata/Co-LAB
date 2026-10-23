namespace UESkillExchange
{
    partial class AuthForm
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
            components = new System.ComponentModel.Container();
            tabAuth = new TabControl();
            tabLogin = new TabPage();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            lblLoginPassword = new Label();
            txtLoginEmail = new TextBox();
            lblLoginEmail = new Label();
            tabRegister = new TabPage();
            txtRegPassword = new TextBox();
            txtRegDeptYear = new TextBox();
            txtRegEmail = new TextBox();
            txtRegName = new TextBox();
            lnkTerms = new LinkLabel();
            btnRegister = new Button();
            chkAgree = new CheckBox();
            lblRegDeptYear = new Label();
            lblRegPassword = new Label();
            lblRegEmail = new Label();
            lblRegName = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabAuth.SuspendLayout();
            tabLogin.SuspendLayout();
            tabRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabAuth
            // 
            tabAuth.Controls.Add(tabLogin);
            tabAuth.Controls.Add(tabRegister);
            tabAuth.Dock = DockStyle.Fill;
            tabAuth.Location = new Point(0, 0);
            tabAuth.Name = "tabAuth";
            tabAuth.SelectedIndex = 0;
            tabAuth.Size = new Size(404, 381);
            tabAuth.TabIndex = 0;
            // 
            // tabLogin
            // 
            tabLogin.Controls.Add(btnLogin);
            tabLogin.Controls.Add(txtLoginPassword);
            tabLogin.Controls.Add(lblLoginPassword);
            tabLogin.Controls.Add(txtLoginEmail);
            tabLogin.Controls.Add(lblLoginEmail);
            tabLogin.Location = new Point(4, 24);
            tabLogin.Name = "tabLogin";
            tabLogin.Padding = new Padding(3);
            tabLogin.Size = new Size(396, 353);
            tabLogin.TabIndex = 0;
            tabLogin.Text = "Login";
            tabLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(155, 205);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(155, 160);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(146, 23);
            txtLoginPassword.TabIndex = 3;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Location = new Point(95, 163);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(57, 15);
            lblLoginPassword.TabIndex = 2;
            lblLoginPassword.Text = "Password";
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.Location = new Point(155, 119);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.Size = new Size(146, 23);
            txtLoginEmail.TabIndex = 1;
            // 
            // lblLoginEmail
            // 
            lblLoginEmail.AutoSize = true;
            lblLoginEmail.Location = new Point(95, 122);
            lblLoginEmail.Name = "lblLoginEmail";
            lblLoginEmail.Size = new Size(53, 15);
            lblLoginEmail.TabIndex = 0;
            lblLoginEmail.Text = "UE Email";
            // 
            // tabRegister
            // 
            tabRegister.Controls.Add(txtRegPassword);
            tabRegister.Controls.Add(txtRegDeptYear);
            tabRegister.Controls.Add(txtRegEmail);
            tabRegister.Controls.Add(txtRegName);
            tabRegister.Controls.Add(lnkTerms);
            tabRegister.Controls.Add(btnRegister);
            tabRegister.Controls.Add(chkAgree);
            tabRegister.Controls.Add(lblRegDeptYear);
            tabRegister.Controls.Add(lblRegPassword);
            tabRegister.Controls.Add(lblRegEmail);
            tabRegister.Controls.Add(lblRegName);
            tabRegister.Location = new Point(4, 24);
            tabRegister.Name = "tabRegister";
            tabRegister.Padding = new Padding(3);
            tabRegister.Size = new Size(396, 353);
            tabRegister.TabIndex = 1;
            tabRegister.Text = "Register";
            tabRegister.UseVisualStyleBackColor = true;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(171, 128);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(157, 23);
            txtRegPassword.TabIndex = 11;
            // 
            // txtRegDeptYear
            // 
            txtRegDeptYear.Location = new Point(171, 167);
            txtRegDeptYear.Name = "txtRegDeptYear";
            txtRegDeptYear.Size = new Size(157, 23);
            txtRegDeptYear.TabIndex = 10;
            // 
            // txtRegEmail
            // 
            txtRegEmail.Location = new Point(171, 90);
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.Size = new Size(157, 23);
            txtRegEmail.TabIndex = 9;
            // 
            // txtRegName
            // 
            txtRegName.Location = new Point(171, 50);
            txtRegName.Name = "txtRegName";
            txtRegName.ShortcutsEnabled = false;
            txtRegName.Size = new Size(157, 23);
            txtRegName.TabIndex = 8;
            // 
            // lnkTerms
            // 
            lnkTerms.AutoSize = true;
            lnkTerms.Location = new Point(85, 221);
            lnkTerms.Name = "lnkTerms";
            lnkTerms.Size = new Size(216, 15);
            lnkTerms.TabIndex = 7;
            lnkTerms.TabStop = true;
            lnkTerms.Text = "Read UE Skill Exchange Terms of Service";
            lnkTerms.LinkClicked += lnkTerms_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(150, 290);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 32);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // chkAgree
            // 
            chkAgree.AutoSize = true;
            chkAgree.Location = new Point(103, 252);
            chkAgree.Name = "chkAgree";
            chkAgree.Size = new Size(183, 19);
            chkAgree.TabIndex = 5;
            chkAgree.Text = "I agree to the Terms of Service";
            chkAgree.UseVisualStyleBackColor = true;
            chkAgree.CheckedChanged += chkAgree_CheckedChanged;
            // 
            // lblRegDeptYear
            // 
            lblRegDeptYear.AutoSize = true;
            lblRegDeptYear.Location = new Point(47, 170);
            lblRegDeptYear.Name = "lblRegDeptYear";
            lblRegDeptYear.Size = new Size(118, 15);
            lblRegDeptYear.TabIndex = 3;
            lblRegDeptYear.Text = "Department and Year";
            // 
            // lblRegPassword
            // 
            lblRegPassword.AutoSize = true;
            lblRegPassword.Location = new Point(47, 131);
            lblRegPassword.Name = "lblRegPassword";
            lblRegPassword.Size = new Size(57, 15);
            lblRegPassword.TabIndex = 2;
            lblRegPassword.Text = "Password";
            // 
            // lblRegEmail
            // 
            lblRegEmail.AutoSize = true;
            lblRegEmail.Location = new Point(47, 93);
            lblRegEmail.Name = "lblRegEmail";
            lblRegEmail.Size = new Size(53, 15);
            lblRegEmail.TabIndex = 1;
            lblRegEmail.Text = "UE Email";
            // 
            // lblRegName
            // 
            lblRegName.AutoSize = true;
            lblRegName.Location = new Point(47, 53);
            lblRegName.Name = "lblRegName";
            lblRegName.Size = new Size(61, 15);
            lblRegName.TabIndex = 0;
            lblRegName.Text = "Full Name";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 381);
            Controls.Add(tabAuth);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UE Skill Exchange";
            tabAuth.ResumeLayout(false);
            tabLogin.ResumeLayout(false);
            tabLogin.PerformLayout();
            tabRegister.ResumeLayout(false);
            tabRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAuth;
        private TabPage tabLogin;
        private TabPage tabRegister;
        private Label lblLoginEmail;
        private Label lblLoginPassword;
        private TextBox txtLoginEmail;
        private TextBox txtLoginPassword;
        private Button btnLogin;
        private Button btnRegister;
        private CheckBox chkAgree;
        private Label lblRegDeptYear;
        private Label lblRegPassword;
        private Label lblRegEmail;
        private Label lblRegName;
        private ContextMenuStrip contextMenuStrip1;
        private LinkLabel lnkTerms;
        private TextBox txtRegPassword;
        private TextBox txtRegDeptYear;
        private TextBox txtRegEmail;
        private TextBox txtRegName;
    }
}