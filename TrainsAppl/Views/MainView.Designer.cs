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
            this.ColDepartue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColArrTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelModelTime = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.TimeMode = new System.Windows.Forms.TrackBar();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.TopologyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeavyCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassCount)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).BeginInit();
            this.TimeTablePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMode)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1065, 28);
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
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // топологиюToolStripMenuItem
            // 
            this.топологиюToolStripMenuItem.Name = "топологиюToolStripMenuItem";
            this.топологиюToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.топологиюToolStripMenuItem.Text = "Топологию";
            this.топологиюToolStripMenuItem.Click += new System.EventHandler(this.ТопологиюToolStripMenuItem_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как ...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.СохранитьКакToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // оРазработчикахToolStripMenuItem
            // 
            this.оРазработчикахToolStripMenuItem.Name = "оРазработчикахToolStripMenuItem";
            this.оРазработчикахToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.оРазработчикахToolStripMenuItem.Text = "О разработчиках";
            this.оРазработчикахToolStripMenuItem.Click += new System.EventHandler(this.оРазработчикахToolStripMenuItem_Click);
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
            this.tabControl.Location = new System.Drawing.Point(13, 32);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1039, 722);
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
            this.TopologyPage.Location = new System.Drawing.Point(4, 25);
            this.TopologyPage.Margin = new System.Windows.Forms.Padding(4);
            this.TopologyPage.Name = "TopologyPage";
            this.TopologyPage.Padding = new System.Windows.Forms.Padding(4);
            this.TopologyPage.Size = new System.Drawing.Size(1031, 693);
            this.TopologyPage.TabIndex = 0;
            this.TopologyPage.Text = "Топология";
            this.TopologyPage.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Enabled = false;
            this.buttonConfirm.Location = new System.Drawing.Point(893, 182);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(111, 28);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Применить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Visible = false;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(885, 10);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(128, 31);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // numericHeavyCount
            // 
            this.numericHeavyCount.Enabled = false;
            this.numericHeavyCount.Location = new System.Drawing.Point(893, 149);
            this.numericHeavyCount.Margin = new System.Windows.Forms.Padding(4);
            this.numericHeavyCount.Name = "numericHeavyCount";
            this.numericHeavyCount.Size = new System.Drawing.Size(111, 22);
            this.numericHeavyCount.TabIndex = 6;
            this.numericHeavyCount.Visible = false;
            this.numericHeavyCount.ValueChanged += new System.EventHandler(this.NumericHeavyCount_ValueChanged);
            // 
            // labelHeavy
            // 
            this.labelHeavy.AutoSize = true;
            this.labelHeavy.Location = new System.Drawing.Point(895, 113);
            this.labelHeavy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeavy.Name = "labelHeavy";
            this.labelHeavy.Size = new System.Drawing.Size(123, 34);
            this.labelHeavy.TabIndex = 5;
            this.labelHeavy.Text = "Кол-во товарных \r\nпутей";
            this.labelHeavy.Visible = false;
            // 
            // numericPassCount
            // 
            this.numericPassCount.Enabled = false;
            this.numericPassCount.Location = new System.Drawing.Point(893, 62);
            this.numericPassCount.Margin = new System.Windows.Forms.Padding(4);
            this.numericPassCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPassCount.Name = "numericPassCount";
            this.numericPassCount.Size = new System.Drawing.Size(111, 22);
            this.numericPassCount.TabIndex = 4;
            this.numericPassCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPassCount.Visible = false;
            this.numericPassCount.ValueChanged += new System.EventHandler(this.NumericPassCount_ValueChanged);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(895, 10);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(103, 51);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Кол-во \r\nпассажирских \r\nпутей";
            this.labelPass.Visible = false;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.mapBox);
            this.panel.Location = new System.Drawing.Point(8, 7);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(877, 673);
            this.panel.TabIndex = 2;
            // 
            // mapBox
            // 
            this.mapBox.Location = new System.Drawing.Point(3, 2);
            this.mapBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.TimeTablePage.Location = new System.Drawing.Point(4, 25);
            this.TimeTablePage.Margin = new System.Windows.Forms.Padding(4);
            this.TimeTablePage.Name = "TimeTablePage";
            this.TimeTablePage.Padding = new System.Windows.Forms.Padding(4);
            this.TimeTablePage.Size = new System.Drawing.Size(1031, 693);
            this.TimeTablePage.TabIndex = 1;
            this.TimeTablePage.Text = "Расписание";
            this.TimeTablePage.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(198, 644);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(81, 40);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Enabled = false;
            this.buttonChange.Location = new System.Drawing.Point(100, 644);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(92, 40);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(7, 644);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 40);
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
            this.ColDepartue,
            this.ColDestination,
            this.ColArrTime,
            this.ColDepTime,
            this.ColWay,
            this.ColPlatform});
            this.TimeTableGrid.Location = new System.Drawing.Point(7, 7);
            this.TimeTableGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeTableGrid.Name = "TimeTableGrid";
            this.TimeTableGrid.ReadOnly = true;
            this.TimeTableGrid.RowHeadersWidth = 51;
            this.TimeTableGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TimeTableGrid.RowTemplate.Height = 24;
            this.TimeTableGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TimeTableGrid.Size = new System.Drawing.Size(1006, 633);
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
            this.ColTrainNum.Width = 122;
            // 
            // ColTrainType
            // 
            this.ColTrainType.Frozen = true;
            this.ColTrainType.HeaderText = "Тип поезда";
            this.ColTrainType.MinimumWidth = 6;
            this.ColTrainType.Name = "ColTrainType";
            this.ColTrainType.ReadOnly = true;
            this.ColTrainType.Width = 104;
            // 
            // ColDepartue
            // 
            this.ColDepartue.Frozen = true;
            this.ColDepartue.HeaderText = "Отбытие";
            this.ColDepartue.MinimumWidth = 6;
            this.ColDepartue.Name = "ColDepartue";
            this.ColDepartue.ReadOnly = true;
            this.ColDepartue.Width = 96;
            // 
            // ColDestination
            // 
            this.ColDestination.Frozen = true;
            this.ColDestination.HeaderText = "Назначение";
            this.ColDestination.MinimumWidth = 6;
            this.ColDestination.Name = "ColDestination";
            this.ColDestination.ReadOnly = true;
            this.ColDestination.Width = 118;
            // 
            // ColArrTime
            // 
            this.ColArrTime.Frozen = true;
            this.ColArrTime.HeaderText = "Время прибытия";
            this.ColArrTime.MinimumWidth = 6;
            this.ColArrTime.Name = "ColArrTime";
            this.ColArrTime.ReadOnly = true;
            this.ColArrTime.Width = 136;
            // 
            // ColDepTime
            // 
            this.ColDepTime.Frozen = true;
            this.ColDepTime.HeaderText = "Время отправления";
            this.ColDepTime.MinimumWidth = 6;
            this.ColDepTime.Name = "ColDepTime";
            this.ColDepTime.ReadOnly = true;
            this.ColDepTime.Width = 154;
            // 
            // ColWay
            // 
            this.ColWay.Frozen = true;
            this.ColWay.HeaderText = "Путь";
            this.ColWay.MinimumWidth = 6;
            this.ColWay.Name = "ColWay";
            this.ColWay.ReadOnly = true;
            this.ColWay.Width = 68;
            // 
            // ColPlatform
            // 
            this.ColPlatform.Frozen = true;
            this.ColPlatform.HeaderText = "Платформа";
            this.ColPlatform.MinimumWidth = 6;
            this.ColPlatform.Name = "ColPlatform";
            this.ColPlatform.ReadOnly = true;
            this.ColPlatform.Width = 114;
            // 
            // labelModelTime
            // 
            this.labelModelTime.AutoSize = true;
            this.labelModelTime.Location = new System.Drawing.Point(239, 778);
            this.labelModelTime.Name = "labelModelTime";
            this.labelModelTime.Size = new System.Drawing.Size(130, 17);
            this.labelModelTime.TabIndex = 2;
            this.labelModelTime.Text = "Модельное время:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(380, 778);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(44, 17);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "00:00";
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(169, 778);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(64, 50);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "■";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPause.Location = new System.Drawing.Point(100, 778);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(64, 50);
            this.buttonPause.TabIndex = 6;
            this.buttonPause.Text = "❚❚";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlay.Location = new System.Drawing.Point(31, 778);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(64, 50);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "▶";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // TimeMode
            // 
            this.TimeMode.Enabled = false;
            this.TimeMode.LargeChange = 1;
            this.TimeMode.Location = new System.Drawing.Point(432, 773);
            this.TimeMode.Margin = new System.Windows.Forms.Padding(4);
            this.TimeMode.Maximum = 2;
            this.TimeMode.Name = "TimeMode";
            this.TimeMode.Size = new System.Drawing.Size(139, 56);
            this.TimeMode.TabIndex = 8;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(243, 811);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Maximum = 1439;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(181, 17);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 9;
            this.progressBar.Visible = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 853);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.TimeMode);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonPlay);
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
            this.TopologyPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeavyCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassCount)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).EndInit();
            this.TimeTablePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimeTableGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMode)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericHeavyCount;
        private System.Windows.Forms.Label labelHeavy;
        private System.Windows.Forms.NumericUpDown numericPassCount;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TrackBar TimeMode;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrainNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrainType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepartue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColArrTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlatform;
    }
}