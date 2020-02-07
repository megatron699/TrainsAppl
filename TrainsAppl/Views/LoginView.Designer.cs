﻿namespace TrainsAppl.Views
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
            this.SignInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(15, 25);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(206, 20);
            this.LoginBox.TabIndex = 0;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(12, 9);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(38, 13);
            this.LogLabel.TabIndex = 1;
            this.LogLabel.Text = "Логин";
            this.LogLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(12, 48);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(45, 13);
            this.PassLabel.TabIndex = 2;
            this.PassLabel.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Нет аккаунта?";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // PassBox
            // 
            this.PassBox.CausesValidation = false;
            this.PassBox.Location = new System.Drawing.Point(15, 64);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(206, 20);
            this.PassBox.TabIndex = 4;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(13, 91);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(208, 38);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(99, 135);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(122, 23);
            this.SignInButton.TabIndex = 6;
            this.SignInButton.Text = "Зарегистрироваться";
            this.SignInButton.UseVisualStyleBackColor = true;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 169);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.LoginBox);
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
        private System.Windows.Forms.Button SignInButton;
    }
}