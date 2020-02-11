namespace TrainsAppl.Views
{
    partial class LoginView
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
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(20, 31);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(273, 22);
            this.LoginBox.TabIndex = 0;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(16, 11);
            this.LogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(47, 17);
            this.LogLabel.TabIndex = 1;
            this.LogLabel.Text = "Логин";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(16, 59);
            this.PassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(57, 17);
            this.PassLabel.TabIndex = 2;
            this.PassLabel.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Нет аккаунта?";
            // 
            // PassBox
            // 
            this.PassBox.CausesValidation = false;
            this.PassBox.Location = new System.Drawing.Point(20, 79);
            this.PassBox.Margin = new System.Windows.Forms.Padding(4);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(273, 22);
            this.PassBox.TabIndex = 4;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(17, 112);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(277, 47);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(132, 166);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(163, 28);
            this.SignUpButton.TabIndex = 6;
            this.SignUpButton.Text = "Зарегистрироваться";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 208);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.LoginBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginView";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignUpButton;
    }
}