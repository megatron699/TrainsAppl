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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРазработчикахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TopologyPage = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TimeTablePage = new System.Windows.Forms.TabPage();
            this.TimeTableGrid = new System.Windows.Forms.DataGridView();
            this.ColTrainNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColrrTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TopologyPage.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
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
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
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
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // оРазработчикахToolStripMenuItem
            // 
            this.оРазработчикахToolStripMenuItem.Name = "оРазработчикахToolStripMenuItem";
            this.оРазработчикахToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.оРазработчикахToolStripMenuItem.Text = "О разработчиках";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TopologyPage);
            this.tabControl1.Controls.Add(this.TimeTablePage);
            this.tabControl1.Location = new System.Drawing.Point(17, 34);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 505);
            this.tabControl1.TabIndex = 1;
            // 
            // TopologyPage
            // 
            this.TopologyPage.Controls.Add(this.listView1);
            this.TopologyPage.Location = new System.Drawing.Point(4, 25);
            this.TopologyPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopologyPage.Name = "TopologyPage";
            this.TopologyPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopologyPage.Size = new System.Drawing.Size(1025, 476);
            this.TopologyPage.TabIndex = 0;
            this.TopologyPage.Text = "Топология";
            this.TopologyPage.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(840, 7);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(160, 457);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // TimeTablePage
            // 
            this.TimeTablePage.Controls.Add(this.TimeTableGrid);
            this.TimeTablePage.Location = new System.Drawing.Point(4, 25);
            this.TimeTablePage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeTablePage.Name = "TimeTablePage";
            this.TimeTablePage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeTablePage.Size = new System.Drawing.Size(1025, 476);
            this.TimeTablePage.TabIndex = 1;
            this.TimeTablePage.Text = "Расписание";
            this.TimeTablePage.UseVisualStyleBackColor = true;
            // 
            // TimeTableGrid
            // 
            this.TimeTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeTableGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTrainNum,
            this.ColWay,
            this.ColPlatform,
            this.ColDestination,
            this.ColDepTime,
            this.ColrrTime});
            this.TimeTableGrid.Location = new System.Drawing.Point(7, 7);
            this.TimeTableGrid.Name = "TimeTableGrid";
            this.TimeTableGrid.RowHeadersWidth = 51;
            this.TimeTableGrid.RowTemplate.Height = 24;
            this.TimeTableGrid.Size = new System.Drawing.Size(803, 412);
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
            this.ColDestination.HeaderText = "Пункт назначения";
            this.ColDestination.MinimumWidth = 6;
            this.ColDestination.Name = "ColDestination";
            this.ColDestination.ReadOnly = true;
            this.ColDestination.Width = 125;
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
            // ColrrTime
            // 
            this.ColrrTime.Frozen = true;
            this.ColrrTime.HeaderText = "Время прибытия";
            this.ColrrTime.MinimumWidth = 6;
            this.ColrrTime.Name = "ColrrTime";
            this.ColrrTime.ReadOnly = true;
            this.ColrrTime.Width = 125;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainView";
            this.Text = "TrainsAppl";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TopologyPage.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TopologyPage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage TimeTablePage;
        private System.Windows.Forms.DataGridView TimeTableGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrainNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColrrTime;
    }
}