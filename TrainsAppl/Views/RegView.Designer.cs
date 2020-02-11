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
            this.ConfirmBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkRole = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(16, 213);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(4);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(337, 46);
            this.SignInButton.TabIndex = 13;
            this.SignInButton.Text = "Зарегистрироваться";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(159, 287);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(73, 34);
            this.LoginButton.TabIndex = 12;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PassBox
            // 
            this.PassBox.CausesValidation = false;
            this.PassBox.Location = new System.Drawing.Point(16, 90);
            this.PassBox.Margin = new System.Windows.Forms.Padding(4);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(336, 22);
            this.PassBox.TabIndex = 11;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Уже есть аккаунт?";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(12, 70);
            this.PassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(57, 17);
            this.PassLabel.TabIndex = 9;
            this.PassLabel.Text = "Пароль";
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(16, 11);
            this.LogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(47, 17);
            this.LogLabel.TabIndex = 8;
            this.LogLabel.Text = "Логин";
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(16, 31);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(336, 22);
            this.LoginBox.TabIndex = 7;
            // 
            // ConfirmBox
            // 
            this.ConfirmBox.CausesValidation = false;
            this.ConfirmBox.Location = new System.Drawing.Point(16, 151);
            this.ConfirmBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmBox.Name = "ConfirmBox";
            this.ConfirmBox.Size = new System.Drawing.Size(336, 22);
            this.ConfirmBox.TabIndex = 15;
            this.ConfirmBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Подтвердите пароль";
            // 
            // checkRole
            // 
            this.checkRole.AutoSize = true;
            this.checkRole.Location = new System.Drawing.Point(20, 185);
            this.checkRole.Margin = new System.Windows.Forms.Padding(4);
            this.checkRole.Name = "checkRole";
            this.checkRole.Size = new System.Drawing.Size(320, 21);
            this.checkRole.TabIndex = 16;
            this.checkRole.Text = "Поставьте галочку, если вы администратор";
            this.checkRole.UseVisualStyleBackColor = true;
            // 
            // RegView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 331);
            this.Controls.Add(this.checkRole);
            this.Controls.Add(this.ConfirmBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.LoginBox);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox ConfirmBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkRole;
    }
}