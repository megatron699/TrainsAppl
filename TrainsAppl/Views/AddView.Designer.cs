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
            this.labelTrainType = new System.Windows.Forms.Label();
            this.labelDepTime = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelArrTime = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.trainNumBox = new System.Windows.Forms.ComboBox();
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainTypeBox = new System.Windows.Forms.ComboBox();
            this.departueBox = new System.Windows.Forms.ComboBox();
            this.arrTimePicker = new System.Windows.Forms.DateTimePicker();
            this.depTimePicker = new System.Windows.Forms.DateTimePicker();
            this.countUpDown = new System.Windows.Forms.NumericUpDown();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.trainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTrainNum
            // 
            this.labelTrainNum.AutoSize = true;
            this.labelTrainNum.Location = new System.Drawing.Point(29, 20);
            this.labelTrainNum.Name = "labelTrainNum";
            this.labelTrainNum.Size = new System.Drawing.Size(104, 17);
            this.labelTrainNum.TabIndex = 0;
            this.labelTrainNum.Text = "Номер Поезда";
            // 
            // labelTrainType
            // 
            this.labelTrainType.AutoSize = true;
            this.labelTrainType.Location = new System.Drawing.Point(29, 70);
            this.labelTrainType.Name = "labelTrainType";
            this.labelTrainType.Size = new System.Drawing.Size(84, 17);
            this.labelTrainType.TabIndex = 2;
            this.labelTrainType.Text = "Тип поезда";
            // 
            // labelDepTime
            // 
            this.labelDepTime.AutoSize = true;
            this.labelDepTime.Location = new System.Drawing.Point(29, 219);
            this.labelDepTime.Name = "labelDepTime";
            this.labelDepTime.Size = new System.Drawing.Size(140, 17);
            this.labelDepTime.TabIndex = 4;
            this.labelDepTime.Text = "Время отправления";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(29, 119);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(149, 17);
            this.labelDestination.TabIndex = 5;
            this.labelDestination.Text = "Назначение/отбытие";
            // 
            // labelArrTime
            // 
            this.labelArrTime.AutoSize = true;
            this.labelArrTime.Location = new System.Drawing.Point(29, 169);
            this.labelArrTime.Name = "labelArrTime";
            this.labelArrTime.Size = new System.Drawing.Size(119, 17);
            this.labelArrTime.TabIndex = 6;
            this.labelArrTime.Text = "Время прибытия";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(29, 270);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(108, 17);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "Кол-во вагонов";
            // 
            // trainNumBox
            // 
            this.trainNumBox.DataSource = this.trainBindingSource;
            this.trainNumBox.DisplayMember = "TrainNumber";
            this.trainNumBox.FormattingEnabled = true;
            this.trainNumBox.Location = new System.Drawing.Point(33, 41);
            this.trainNumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.trainTypeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trainTypeBox.Name = "trainTypeBox";
            this.trainTypeBox.Size = new System.Drawing.Size(121, 24);
            this.trainTypeBox.TabIndex = 2;
            // 
            // departueBox
            // 
            this.departueBox.FormattingEnabled = true;
            this.departueBox.Location = new System.Drawing.Point(33, 140);
            this.departueBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departueBox.Name = "departueBox";
            this.departueBox.Size = new System.Drawing.Size(121, 24);
            this.departueBox.TabIndex = 4;
            // 
            // arrTimePicker
            // 
            this.arrTimePicker.CustomFormat = "HH:mm";
            this.arrTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrTimePicker.Location = new System.Drawing.Point(33, 190);
            this.arrTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.depTimePicker.Location = new System.Drawing.Point(33, 240);
            this.depTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depTimePicker.Name = "depTimePicker";
            this.depTimePicker.ShowUpDown = true;
            this.depTimePicker.Size = new System.Drawing.Size(63, 22);
            this.depTimePicker.TabIndex = 6;
            this.depTimePicker.Value = new System.DateTime(2020, 2, 12, 0, 0, 0, 0);
            // 
            // countUpDown
            // 
            this.countUpDown.Location = new System.Drawing.Point(33, 290);
            this.countUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countUpDown.Name = "countUpDown";
            this.countUpDown.Size = new System.Drawing.Size(61, 22);
            this.countUpDown.TabIndex = 7;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(33, 318);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(137, 46);
            this.acceptButton.TabIndex = 10;
            this.acceptButton.Text = "Принять";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(33, 369);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(137, 46);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // trainBindingSource1
            // 
            this.trainBindingSource1.DataSource = typeof(TrainsAppl.Models.DB.Train);
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 420);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.countUpDown);
            this.Controls.Add(this.depTimePicker);
            this.Controls.Add(this.arrTimePicker);
            this.Controls.Add(this.departueBox);
            this.Controls.Add(this.trainTypeBox);
            this.Controls.Add(this.trainNumBox);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelArrTime);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelDepTime);
            this.Controls.Add(this.labelTrainType);
            this.Controls.Add(this.labelTrainNum);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddView";
            this.Text = "TrainsAppl";
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTrainNum;
        private System.Windows.Forms.Label labelTrainType;
        private System.Windows.Forms.Label labelDepTime;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelArrTime;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.ComboBox trainNumBox;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private System.Windows.Forms.ComboBox trainTypeBox;
        private System.Windows.Forms.ComboBox departueBox;
        private System.Windows.Forms.DateTimePicker arrTimePicker;
        private System.Windows.Forms.DateTimePicker depTimePicker;
        private System.Windows.Forms.NumericUpDown countUpDown;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource trainBindingSource1;
    }
}