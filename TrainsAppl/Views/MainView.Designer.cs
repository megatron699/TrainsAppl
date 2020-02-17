namespace TrainsAppl.Views
{
    partial class MainView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.топологиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРазработчикахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TopologyPage = new System.Windows.Forms.TabPage();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.numericHeavyCount = new System.Windows.Forms.NumericUpDown();
            this.labelHeavy = new System.Windows.Forms.Label();
            this.numericPassCount = new System.Windows.Forms.NumericUpDown();
            this.labelPass = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.mapBox = new System.Windows.Forms.PictureBox();
            this.TimeTablePage = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.TimeTableGrid = new System.Windows.Forms.DataGridView();
            this.ColTrainNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrainType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArrTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelModelTime = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.TopologyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeavyCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassCount)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).BeginInit();
            this.TimeTablePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.оРазработчикахToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.топологиюToolStripMenuItem,
            this.расписаниеToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // топологиюToolStripMenuItem
            // 
            this.топологиюToolStripMenuItem.Name = "топологиюToolStripMenuItem";
            this.топологиюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.топологиюToolStripMenuItem.Text = "Топологию";
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как ...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.СохранитьКакToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // оРазработчикахToolStripMenuItem
            // 
            this.оРазработчикахToolStripMenuItem.Name = "оРазработчикахToolStripMenuItem";
            this.оРазработчикахToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.оРазработчикахToolStripMenuItem.Text = "О разработчиках";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TopologyPage);
            this.tabControl.Controls.Add(this.TimeTablePage);
            this.tabControl.Location = new System.Drawing.Point(13, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(768, 585);
            this.tabControl.TabIndex = 1;
            // 
            // TopologyPage
            // 
            this.TopologyPage.Controls.Add(this.buttonConfirm);
            this.TopologyPage.Controls.Add(this.buttonEdit);
            this.TopologyPage.Controls.Add(this.numericHeavyCount);
            this.TopologyPage.Controls.Add(this.labelHeavy);
            this.TopologyPage.Controls.Add(this.numericPassCount);
            this.TopologyPage.Controls.Add(this.labelPass);
            this.TopologyPage.Controls.Add(this.panel);
            this.TopologyPage.Location = new System.Drawing.Point(4, 22);
            this.TopologyPage.Name = "TopologyPage";
            this.TopologyPage.Padding = new System.Windows.Forms.Padding(3);
            this.TopologyPage.Size = new System.Drawing.Size(760, 559);
            this.TopologyPage.TabIndex = 0;
            this.TopologyPage.Text = "Топология";
            this.TopologyPage.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Enabled = false;
            this.buttonConfirm.Location = new System.Drawing.Point(670, 148);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(83, 23);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Применить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Visible = false;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(664, 8);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(96, 25);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // numericHeavyCount
            // 
            this.numericHeavyCount.Enabled = false;
            this.numericHeavyCount.Location = new System.Drawing.Point(670, 121);
            this.numericHeavyCount.Name = "numericHeavyCount";
            this.numericHeavyCount.Size = new System.Drawing.Size(83, 20);
            this.numericHeavyCount.TabIndex = 6;
            this.numericHeavyCount.Visible = false;
            this.numericHeavyCount.ValueChanged += new System.EventHandler(this.NumericHeavyCount_ValueChanged);
            // 
            // labelHeavy
            // 
            this.labelHeavy.AutoSize = true;
            this.labelHeavy.Location = new System.Drawing.Point(671, 92);
            this.labelHeavy.Name = "labelHeavy";
            this.labelHeavy.Size = new System.Drawing.Size(95, 26);
            this.labelHeavy.TabIndex = 5;
            this.labelHeavy.Text = "Кол-во товарных \r\nпутей";
            this.labelHeavy.Visible = false;
            // 
            // numericPassCount
            // 
            this.numericPassCount.Enabled = false;
            this.numericPassCount.Location = new System.Drawing.Point(670, 50);
            this.numericPassCount.Name = "numericPassCount";
            this.numericPassCount.Size = new System.Drawing.Size(83, 20);
            this.numericPassCount.TabIndex = 4;
            this.numericPassCount.Visible = false;
            this.numericPassCount.ValueChanged += new System.EventHandler(this.NumericPassCount_ValueChanged);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(671, 8);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(83, 39);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Кол-во \r\nпассажирских \r\nпутей";
            this.labelPass.Visible = false;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.mapBox);
            this.panel.Location = new System.Drawing.Point(6, 6);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(658, 547);
            this.panel.TabIndex = 2;
            // 
            // mapBox
            // 
            this.mapBox.Location = new System.Drawing.Point(2, 2);
            this.mapBox.Margin = new System.Windows.Forms.Padding(2);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(1600, 800);
            this.mapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mapBox.TabIndex = 1;
            this.mapBox.TabStop = false;
            // 
            // TimeTablePage
            // 
            this.TimeTablePage.Controls.Add(this.buttonDelete);
            this.TimeTablePage.Controls.Add(this.buttonChange);
            this.TimeTablePage.Controls.Add(this.buttonAdd);
            this.TimeTablePage.Controls.Add(this.TimeTableGrid);
            this.TimeTablePage.Location = new System.Drawing.Point(4, 22);
            this.TimeTablePage.Name = "TimeTablePage";
            this.TimeTablePage.Padding = new System.Windows.Forms.Padding(3);
            this.TimeTablePage.Size = new System.Drawing.Size(760, 559);
            this.TimeTablePage.TabIndex = 1;
            this.TimeTablePage.Text = "Расписание";
            this.TimeTablePage.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(141, 537);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(61, 19);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(75, 537);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(62, 19);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(5, 537);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(65, 19);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // TimeTableGrid
            // 
            this.TimeTableGrid.AllowUserToAddRows = false;
            this.TimeTableGrid.AllowUserToDeleteRows = false;
            this.TimeTableGrid.AllowUserToResizeColumns = false;
            this.TimeTableGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TimeTableGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TimeTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeTableGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTrainNum,
            this.ColTrainType,
            this.ColWay,
            this.ColPlatform,
            this.ColDestination,
            this.ColArrTime,
            this.ColDepTime});
            this.TimeTableGrid.Location = new System.Drawing.Point(5, 6);
            this.TimeTableGrid.Margin = new System.Windows.Forms.Padding(2);
            this.TimeTableGrid.Name = "TimeTableGrid";
            this.TimeTableGrid.ReadOnly = true;
            this.TimeTableGrid.RowHeadersWidth = 51;
            this.TimeTableGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TimeTableGrid.RowTemplate.Height = 24;
            this.TimeTableGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TimeTableGrid.Size = new System.Drawing.Size(750, 514);
            this.TimeTableGrid.TabIndex = 0;
            // 
            // ColTrainNum
            // 
            this.ColTrainNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColTrainNum.Frozen = true;
            this.ColTrainNum.HeaderText = "Номер Поезда";
            this.ColTrainNum.MinimumWidth = 6;
            this.ColTrainNum.Name = "ColTrainNum";
            this.ColTrainNum.ReadOnly = true;
            this.ColTrainNum.Width = 98;
            // 
            // ColTrainType
            // 
            this.ColTrainType.Frozen = true;
            this.ColTrainType.HeaderText = "Тип поезда";
            this.ColTrainType.MinimumWidth = 6;
            this.ColTrainType.Name = "ColTrainType";
            this.ColTrainType.ReadOnly = true;
            this.ColTrainType.Width = 83;
            // 
            // ColWay
            // 
            this.ColWay.Frozen = true;
            this.ColWay.HeaderText = "Путь";
            this.ColWay.MinimumWidth = 6;
            this.ColWay.Name = "ColWay";
            this.ColWay.ReadOnly = true;
            this.ColWay.Width = 56;
            // 
            // ColPlatform
            // 
            this.ColPlatform.Frozen = true;
            this.ColPlatform.HeaderText = "Платформа";
            this.ColPlatform.MinimumWidth = 6;
            this.ColPlatform.Name = "ColPlatform";
            this.ColPlatform.ReadOnly = true;
            this.ColPlatform.Width = 91;
            // 
            // ColDestination
            // 
            this.ColDestination.Frozen = true;
            this.ColDestination.HeaderText = "Назначение/отбытие";
            this.ColDestination.MinimumWidth = 6;
            this.ColDestination.Name = "ColDestination";
            this.ColDestination.ReadOnly = true;
            this.ColDestination.Width = 140;
            // 
            // ColArrTime
            // 
            this.ColArrTime.Frozen = true;
            this.ColArrTime.HeaderText = "Время прибытия";
            this.ColArrTime.MinimumWidth = 6;
            this.ColArrTime.Name = "ColArrTime";
            this.ColArrTime.ReadOnly = true;
            this.ColArrTime.Width = 107;
            // 
            // ColDepTime
            // 
            this.ColDepTime.Frozen = true;
            this.ColDepTime.HeaderText = "Время отправления";
            this.ColDepTime.MinimumWidth = 6;
            this.ColDepTime.Name = "ColDepTime";
            this.ColDepTime.ReadOnly = true;
            this.ColDepTime.Width = 122;
            // 
            // labelModelTime
            // 
            this.labelModelTime.AutoSize = true;
            this.labelModelTime.Location = new System.Drawing.Point(247, 632);
            this.labelModelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModelTime.Name = "labelModelTime";
            this.labelModelTime.Size = new System.Drawing.Size(102, 13);
            this.labelModelTime.TabIndex = 2;
            this.labelModelTime.Text = "Модельное время:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(349, 632);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(34, 13);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "00:00";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 693);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelModelTime);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "TrainsAppl";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.TopologyPage.ResumeLayout(false);
            this.TopologyPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeavyCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassCount)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).EndInit();
            this.TimeTablePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimeTableGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TopologyPage;
        private System.Windows.Forms.TabPage TimeTablePage;
        private System.Windows.Forms.DataGridView TimeTableGrid;
        private System.Windows.Forms.PictureBox mapBox;
        private System.Windows.Forms.Label labelModelTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ToolStripMenuItem топологиюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrainNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrainType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArrTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepTime;
        private System.Windows.Forms.NumericUpDown numericHeavyCount;
        private System.Windows.Forms.Label labelHeavy;
        private System.Windows.Forms.NumericUpDown numericPassCount;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonEdit;
    }
}