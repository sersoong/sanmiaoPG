namespace sanmiaoPG
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageLogin = new System.Windows.Forms.TabPage();
            this.pageSettings = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.pageLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageLogin);
            this.tabControl1.Controls.Add(this.pageSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // pageLogin
            // 
            this.pageLogin.Controls.Add(this.panel1);
            this.pageLogin.Location = new System.Drawing.Point(4, 22);
            this.pageLogin.Name = "pageLogin";
            this.pageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.pageLogin.Size = new System.Drawing.Size(792, 424);
            this.pageLogin.TabIndex = 0;
            this.pageLogin.Text = "登录";
            this.pageLogin.UseVisualStyleBackColor = true;
            // 
            // pageSettings
            // 
            this.pageSettings.Location = new System.Drawing.Point(4, 22);
            this.pageSettings.Name = "pageSettings";
            this.pageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.pageSettings.Size = new System.Drawing.Size(792, 424);
            this.pageSettings.TabIndex = 1;
            this.pageSettings.Text = "设置";
            this.pageSettings.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Controls.Add(this.textUser);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Location = new System.Drawing.Point(50, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 316);
            this.panel1.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(35, 92);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(41, 12);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "用户名";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(35, 131);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(29, 12);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "密码";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(82, 89);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(219, 21);
            this.textUser.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(82, 128);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(219, 21);
            this.textPassword.TabIndex = 3;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(82, 198);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "三淼IT控制台";
            this.tabControl1.ResumeLayout(false);
            this.pageLogin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageLogin;
        private System.Windows.Forms.TabPage pageSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
    }
}

