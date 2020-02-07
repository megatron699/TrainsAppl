namespace TrainsAppl.Views
{
    partial class RegView
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
            this.SignInButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LogLabel = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(12, 173);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(253, 37);
            this.SignInButton.TabIndex = 13;
            this.SignInButton.Text = "Зарегистрироваться";
            this.SignInButton.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(119, 233);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(55, 28);
            this.LoginButton.TabIndex = 12;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // PassBox
            // 
            this.PassBox.CausesValidation = false;
            this.PassBox.Location = new System.Drawing.Point(12, 73);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(253, 20);
            this.PassBox.TabIndex = 11;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Уже есть аккаунт?";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(9, 57);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(45, 13);
            this.PassLabel.TabIndex = 9;
            this.PassLabel.Text = "Пароль";
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(12, 9);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(38, 13);
            this.LogLabel.TabIndex = 8;
            this.LogLabel.Text = "Логин";
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(12, 25);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(253, 20);
            this.LoginBox.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(12, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Подтвердите пароль";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 150);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(250, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Поставьте галочку, если вы администратор";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // RegView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 269);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.LoginBox);
            this.Name = "RegView";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}