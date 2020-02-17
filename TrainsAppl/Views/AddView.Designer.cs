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
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTrainNum
            // 
            this.labelTrainNum.AutoSize = true;
            this.labelTrainNum.Location = new System.Drawing.Point(22, 16);
            this.labelTrainNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrainNum.Name = "labelTrainNum";
            this.labelTrainNum.Size = new System.Drawing.Size(82, 13);
            this.labelTrainNum.TabIndex = 0;
            this.labelTrainNum.Text = "Номер Поезда";
            // 
            // labelTrainType
            // 
            this.labelTrainType.AutoSize = true;
            this.labelTrainType.Location = new System.Drawing.Point(22, 57);
            this.labelTrainType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrainType.Name = "labelTrainType";
            this.labelTrainType.Size = new System.Drawing.Size(65, 13);
            this.labelTrainType.TabIndex = 2;
            this.labelTrainType.Text = "Тип поезда";
            // 
            // labelDepTime
            // 
            this.labelDepTime.AutoSize = true;
            this.labelDepTime.Location = new System.Drawing.Point(22, 178);
            this.labelDepTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDepTime.Name = "labelDepTime";
            this.labelDepTime.Size = new System.Drawing.Size(108, 13);
            this.labelDepTime.TabIndex = 4;
            this.labelDepTime.Text = "Время отправления";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(22, 97);
            this.labelDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(115, 13);
            this.labelDestination.TabIndex = 5;
            this.labelDestination.Text = "Назначение/отбытие";
            // 
            // labelArrTime
            // 
            this.labelArrTime.AutoSize = true;
            this.labelArrTime.Location = new System.Drawing.Point(22, 137);
            this.labelArrTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArrTime.Name = "labelArrTime";
            this.labelArrTime.Size = new System.Drawing.Size(92, 13);
            this.labelArrTime.TabIndex = 6;
            this.labelArrTime.Text = "Время прибытия";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(22, 219);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(85, 13);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "Кол-во вагонов";
            // 
            // trainNumBox
            // 
            this.trainNumBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trainBindingSource, "TrainNumber", true));
            this.trainNumBox.DataSource = this.trainBindingSource;
            this.trainNumBox.DisplayMember = "TrainNumber";
            this.trainNumBox.FormattingEnabled = true;
            this.trainNumBox.Location = new System.Drawing.Point(25, 33);
            this.trainNumBox.Margin = new System.Windows.Forms.Padding(2);
            this.trainNumBox.Name = "trainNumBox";
            this.trainNumBox.Size = new System.Drawing.Size(92, 21);
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
            this.trainTypeBox.Location = new System.Drawing.Point(25, 74);
            this.trainTypeBox.Margin = new System.Windows.Forms.Padding(2);
            this.trainTypeBox.Name = "trainTypeBox";
            this.trainTypeBox.Size = new System.Drawing.Size(92, 21);
            this.trainTypeBox.TabIndex = 2;
            // 
            // departueBox
            // 
            this.departueBox.FormattingEnabled = true;
            this.departueBox.Location = new System.Drawing.Point(25, 114);
            this.departueBox.Margin = new System.Windows.Forms.Padding(2);
            this.departueBox.Name = "departueBox";
            this.departueBox.Size = new System.Drawing.Size(92, 21);
            this.departueBox.TabIndex = 4;
            // 
            // arrTimePicker
            // 
            this.arrTimePicker.CustomFormat = "HH:mm";
            this.arrTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrTimePicker.Location = new System.Drawing.Point(25, 154);
            this.arrTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.arrTimePicker.Name = "arrTimePicker";
            this.arrTimePicker.ShowUpDown = true;
            this.arrTimePicker.Size = new System.Drawing.Size(45, 20);
            this.arrTimePicker.TabIndex = 5;
            this.arrTimePicker.Value = new System.DateTime(2020, 2, 12, 0, 0, 0, 0);
            // 
            // depTimePicker
            // 
            this.depTimePicker.CustomFormat = "HH:mm";
            this.depTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.depTimePicker.Location = new System.Drawing.Point(25, 195);
            this.depTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.depTimePicker.Name = "depTimePicker";
            this.depTimePicker.ShowUpDown = true;
            this.depTimePicker.Size = new System.Drawing.Size(48, 20);
            this.depTimePicker.TabIndex = 6;
            this.depTimePicker.Value = new System.DateTime(2020, 2, 12, 0, 0, 0, 0);
            // 
            // countUpDown
            // 
            this.countUpDown.Location = new System.Drawing.Point(25, 236);
            this.countUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.countUpDown.Name = "countUpDown";
            this.countUpDown.Size = new System.Drawing.Size(46, 20);
            this.countUpDown.TabIndex = 7;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(25, 258);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(103, 37);
            this.acceptButton.TabIndex = 10;
            this.acceptButton.Text = "Принять";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(25, 300);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 37);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 341);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddView";
            this.Text = "TrainsAppl";
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).EndInit();
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
    }
}