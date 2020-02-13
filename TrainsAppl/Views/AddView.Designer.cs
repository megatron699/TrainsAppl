namespace TrainsAppl.Views
{
    partial class AddView
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
            this.components = new System.ComponentModel.Container();
            this.labelTrainNum = new System.Windows.Forms.Label();
            this.labelPlatform = new System.Windows.Forms.Label();
            this.labelTrainType = new System.Windows.Forms.Label();
            this.labelWay = new System.Windows.Forms.Label();
            this.labelDepTime = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelArrTime = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.trainNumBox = new System.Windows.Forms.ComboBox();
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainTypeBox = new System.Windows.Forms.ComboBox();
            this.wayBox = new System.Windows.Forms.ComboBox();
            this.platformBox = new System.Windows.Forms.Label();
            this.departueBox = new System.Windows.Forms.ComboBox();
            this.arrTimePicker = new System.Windows.Forms.DateTimePicker();
            this.depTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTrainNum
            // 
            this.labelTrainNum.AutoSize = true;
            this.labelTrainNum.Location = new System.Drawing.Point(30, 20);
            this.labelTrainNum.Name = "labelTrainNum";
            this.labelTrainNum.Size = new System.Drawing.Size(104, 17);
            this.labelTrainNum.TabIndex = 0;
            this.labelTrainNum.Text = "Номер Поезда";
            // 
            // labelPlatform
            // 
            this.labelPlatform.AutoSize = true;
            this.labelPlatform.Location = new System.Drawing.Point(30, 170);
            this.labelPlatform.Name = "labelPlatform";
            this.labelPlatform.Size = new System.Drawing.Size(85, 17);
            this.labelPlatform.TabIndex = 1;
            this.labelPlatform.Text = "Платформа";
            // 
            // labelTrainType
            // 
            this.labelTrainType.AutoSize = true;
            this.labelTrainType.Location = new System.Drawing.Point(30, 70);
            this.labelTrainType.Name = "labelTrainType";
            this.labelTrainType.Size = new System.Drawing.Size(84, 17);
            this.labelTrainType.TabIndex = 2;
            this.labelTrainType.Text = "Тип поезда";
            // 
            // labelWay
            // 
            this.labelWay.AutoSize = true;
            this.labelWay.Location = new System.Drawing.Point(30, 120);
            this.labelWay.Name = "labelWay";
            this.labelWay.Size = new System.Drawing.Size(39, 17);
            this.labelWay.TabIndex = 3;
            this.labelWay.Text = "Путь";
            // 
            // labelDepTime
            // 
            this.labelDepTime.AutoSize = true;
            this.labelDepTime.Location = new System.Drawing.Point(30, 320);
            this.labelDepTime.Name = "labelDepTime";
            this.labelDepTime.Size = new System.Drawing.Size(140, 17);
            this.labelDepTime.TabIndex = 4;
            this.labelDepTime.Text = "Время отправления";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(30, 220);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(149, 17);
            this.labelDestination.TabIndex = 5;
            this.labelDestination.Text = "Назначение/отбытие";
            // 
            // labelArrTime
            // 
            this.labelArrTime.AutoSize = true;
            this.labelArrTime.Location = new System.Drawing.Point(30, 270);
            this.labelArrTime.Name = "labelArrTime";
            this.labelArrTime.Size = new System.Drawing.Size(119, 17);
            this.labelArrTime.TabIndex = 6;
            this.labelArrTime.Text = "Время прибытия";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(30, 370);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(108, 17);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "Кол-во вагонов";
            // 
            // trainNumBox
            // 
            this.trainNumBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trainBindingSource, "TrainNumber", true));
            this.trainNumBox.DataSource = this.trainBindingSource;
            this.trainNumBox.DisplayMember = "TrainNumber";
            this.trainNumBox.FormattingEnabled = true;
            this.trainNumBox.Location = new System.Drawing.Point(33, 41);
            this.trainNumBox.Name = "trainNumBox";
            this.trainNumBox.Size = new System.Drawing.Size(121, 24);
            this.trainNumBox.TabIndex = 0;
            this.trainNumBox.ValueMember = "TrainNumber";
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataSource = typeof(TrainsAppl.Models.DB.Train);
            // 
            // trainTypeBox
            // 
            this.trainTypeBox.FormattingEnabled = true;
            this.trainTypeBox.Items.AddRange(new object[] {
            "Пассажирский",
            "Товарный",
            "Электропоезд"});
            this.trainTypeBox.Location = new System.Drawing.Point(33, 91);
            this.trainTypeBox.Name = "trainTypeBox";
            this.trainTypeBox.Size = new System.Drawing.Size(121, 24);
            this.trainTypeBox.TabIndex = 2;
            // 
            // wayBox
            // 
            this.wayBox.FormattingEnabled = true;
            this.wayBox.Location = new System.Drawing.Point(33, 141);
            this.wayBox.Name = "wayBox";
            this.wayBox.Size = new System.Drawing.Size(121, 24);
            this.wayBox.TabIndex = 3;
            // 
            // platformBox
            // 
            this.platformBox.AutoSize = true;
            this.platformBox.Location = new System.Drawing.Point(33, 191);
            this.platformBox.Name = "platformBox";
            this.platformBox.Size = new System.Drawing.Size(16, 17);
            this.platformBox.TabIndex = 9;
            this.platformBox.Text = "0";
            // 
            // departueBox
            // 
            this.departueBox.FormattingEnabled = true;
            this.departueBox.Location = new System.Drawing.Point(33, 241);
            this.departueBox.Name = "departueBox";
            this.departueBox.Size = new System.Drawing.Size(121, 24);
            this.departueBox.TabIndex = 4;
            // 
            // arrTimePicker
            // 
            this.arrTimePicker.CustomFormat = "HH:mm";
            this.arrTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrTimePicker.Location = new System.Drawing.Point(33, 291);
            this.arrTimePicker.Name = "arrTimePicker";
            this.arrTimePicker.ShowUpDown = true;
            this.arrTimePicker.Size = new System.Drawing.Size(59, 22);
            this.arrTimePicker.TabIndex = 5;
            this.arrTimePicker.Value = new System.DateTime(2020, 2, 12, 0, 0, 0, 0);
            // 
            // depTimePicker
            // 
            this.depTimePicker.CustomFormat = "HH:mm";
            this.depTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.depTimePicker.Location = new System.Drawing.Point(33, 341);
            this.depTimePicker.Name = "depTimePicker";
            this.depTimePicker.ShowUpDown = true;
            this.depTimePicker.Size = new System.Drawing.Size(62, 22);
            this.depTimePicker.TabIndex = 6;
            this.depTimePicker.Value = new System.DateTime(2020, 2, 12, 0, 0, 0, 0);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(33, 391);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(33, 419);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(137, 45);
            this.acceptButton.TabIndex = 10;
            this.acceptButton.Text = "Принять";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(33, 470);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(137, 45);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 528);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.depTimePicker);
            this.Controls.Add(this.arrTimePicker);
            this.Controls.Add(this.departueBox);
            this.Controls.Add(this.platformBox);
            this.Controls.Add(this.wayBox);
            this.Controls.Add(this.trainTypeBox);
            this.Controls.Add(this.trainNumBox);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelArrTime);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelDepTime);
            this.Controls.Add(this.labelWay);
            this.Controls.Add(this.labelTrainType);
            this.Controls.Add(this.labelPlatform);
            this.Controls.Add(this.labelTrainNum);
            this.Name = "AddView";
            this.Text = "TrainsAppl";
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTrainNum;
        private System.Windows.Forms.Label labelPlatform;
        private System.Windows.Forms.Label labelTrainType;
        private System.Windows.Forms.Label labelWay;
        private System.Windows.Forms.Label labelDepTime;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelArrTime;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.ComboBox trainNumBox;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private System.Windows.Forms.ComboBox trainTypeBox;
        private System.Windows.Forms.ComboBox wayBox;
        private System.Windows.Forms.Label platformBox;
        private System.Windows.Forms.ComboBox departueBox;
        private System.Windows.Forms.DateTimePicker arrTimePicker;
        private System.Windows.Forms.DateTimePicker depTimePicker;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
    }
}