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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listTokens = new System.Windows.Forms.ListView();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
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
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.топологиюToolStripMenuItem,
            this.расписаниеToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // топологиюToolStripMenuItem
            // 
            this.топологиюToolStripMenuItem.Name = "топологиюToolStripMenuItem";
            this.топологиюToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.топологиюToolStripMenuItem.Text = "Топологию";
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как ...";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // оРазработчикахToolStripMenuItem
            // 
            this.оРазработчикахToolStripMenuItem.Name = "оРазработчикахToolStripMenuItem";
            this.оРазработчикахToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.оРазработчикахToolStripMenuItem.Text = "О разработчиках";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TopologyPage);
            this.tabControl.Controls.Add(this.TimeTablePage);
            this.tabControl.Location = new System.Drawing.Point(17, 34);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1024, 720);
            this.tabControl.TabIndex = 1;
            // 
            // TopologyPage
            // 
            this.TopologyPage.Controls.Add(this.pictureBox1);
            this.TopologyPage.Controls.Add(this.listTokens);
            this.TopologyPage.Location = new System.Drawing.Point(4, 25);
            this.TopologyPage.Margin = new System.Windows.Forms.Padding(4);
            this.TopologyPage.Name = "TopologyPage";
            this.TopologyPage.Padding = new System.Windows.Forms.Padding(4);
            this.TopologyPage.Size = new System.Drawing.Size(1016, 691);
            this.TopologyPage.TabIndex = 0;
            this.TopologyPage.Text = "Топология";
            this.TopologyPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // listTokens
            // 
            this.listTokens.HideSelection = false;
            this.listTokens.Location = new System.Drawing.Point(823, 7);
            this.listTokens.Margin = new System.Windows.Forms.Padding(4);
            this.listTokens.Name = "listTokens";
            this.listTokens.Size = new System.Drawing.Size(177, 600);
            this.listTokens.TabIndex = 0;
            this.listTokens.UseCompatibleStateImageBehavior = false;
            // 
            // TimeTablePage
            // 
            this.TimeTablePage.Controls.Add(this.buttonDelete);
            this.TimeTablePage.Controls.Add(this.buttonChange);
            this.TimeTablePage.Controls.Add(this.buttonAdd);
            this.TimeTablePage.Controls.Add(this.TimeTableGrid);
            this.TimeTablePage.Location = new System.Drawing.Point(4, 25);
            this.TimeTablePage.Margin = new System.Windows.Forms.Padding(4);
            this.TimeTablePage.Name = "TimeTablePage";
            this.TimeTablePage.Padding = new System.Windows.Forms.Padding(4);
            this.TimeTablePage.Size = new System.Drawing.Size(1016, 691);
            this.TimeTablePage.TabIndex = 1;
            this.TimeTablePage.Text = "Расписание";
            this.TimeTablePage.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(188, 661);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(100, 661);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(82, 23);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(7, 661);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // TimeTableGrid
            // 
            this.TimeTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeTableGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTrainNum,
            this.ColTrainType,
            this.ColWay,
            this.ColPlatform,
            this.ColDestination,
            this.ColArrTime,
            this.ColDepTime});
            this.TimeTableGrid.Location = new System.Drawing.Point(7, 7);
            this.TimeTableGrid.Name = "TimeTableGrid";
            this.TimeTableGrid.RowHeadersWidth = 51;
            this.TimeTableGrid.RowTemplate.Height = 24;
            this.TimeTableGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TimeTableGrid.Size = new System.Drawing.Size(928, 412);
            this.TimeTableGrid.TabIndex = 0;
            // 
            // ColTrainNum
            // 
            this.ColTrainNum.Frozen = true;
            this.ColTrainNum.HeaderText = "Номер Поезда";
            this.ColTrainNum.MinimumWidth = 6;
            this.ColTrainNum.Name = "ColTrainNum";
            this.ColTrainNum.ReadOnly = true;
            this.ColTrainNum.Width = 125;
            // 
            // ColTrainType
            // 
            this.ColTrainType.Frozen = true;
            this.ColTrainType.HeaderText = "Тип поезда";
            this.ColTrainType.MinimumWidth = 6;
            this.ColTrainType.Name = "ColTrainType";
            this.ColTrainType.ReadOnly = true;
            this.ColTrainType.Width = 125;
            // 
            // ColWay
            // 
            this.ColWay.Frozen = true;
            this.ColWay.HeaderText = "Путь";
            this.ColWay.MinimumWidth = 6;
            this.ColWay.Name = "ColWay";
            this.ColWay.ReadOnly = true;
            this.ColWay.Width = 125;
            // 
            // ColPlatform
            // 
            this.ColPlatform.Frozen = true;
            this.ColPlatform.HeaderText = "Платформа";
            this.ColPlatform.MinimumWidth = 6;
            this.ColPlatform.Name = "ColPlatform";
            this.ColPlatform.ReadOnly = true;
            this.ColPlatform.Width = 125;
            // 
            // ColDestination
            // 
            this.ColDestination.Frozen = true;
            this.ColDestination.HeaderText = "Назначение/отбытие";
            this.ColDestination.MinimumWidth = 6;
            this.ColDestination.Name = "ColDestination";
            this.ColDestination.ReadOnly = true;
            this.ColDestination.Width = 125;
            // 
            // ColArrTime
            // 
            this.ColArrTime.Frozen = true;
            this.ColArrTime.HeaderText = "Время прибытия";
            this.ColArrTime.MinimumWidth = 6;
            this.ColArrTime.Name = "ColArrTime";
            this.ColArrTime.ReadOnly = true;
            this.ColArrTime.Width = 125;
            // 
            // ColDepTime
            // 
            this.ColDepTime.Frozen = true;
            this.ColDepTime.HeaderText = "Время отправления";
            this.ColDepTime.MinimumWidth = 6;
            this.ColDepTime.Name = "ColDepTime";
            this.ColDepTime.ReadOnly = true;
            this.ColDepTime.Width = 125;
            // 
            // labelModelTime
            // 
            this.labelModelTime.AutoSize = true;
            this.labelModelTime.Location = new System.Drawing.Point(329, 778);
            this.labelModelTime.Name = "labelModelTime";
            this.labelModelTime.Size = new System.Drawing.Size(130, 17);
            this.labelModelTime.TabIndex = 2;
            this.labelModelTime.Text = "Модельное время:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(465, 778);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(44, 17);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "00:00";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 853);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelModelTime);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Text = "TrainsAppl";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.TopologyPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ListView listTokens;
        private System.Windows.Forms.TabPage TimeTablePage;
        private System.Windows.Forms.DataGridView TimeTableGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelModelTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ToolStripMenuItem топологиюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrainNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrainType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArrTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepTime;
    }
}