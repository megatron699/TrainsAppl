using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainsAppl.DAL;
using TrainsAppl.Models.DB;
using TrainsAppl.Topology;

namespace TrainsAppl.Views
{
    public partial class MainView : Form
    {
        private readonly TrainDBContext _context = new TrainDBContext();
        public LinkedList<Timetable> Records { get; set; }
        public string Path { get; set; }
        public Graphics G { get; set; }
        public Image DefaultImage { get; set; }
        public Pointer Topology { get; set; }
        public MainView(bool userRole)
        {
            InitializeComponent();
            if (!userRole)
            {
                buttonEdit.Enabled = false;
                buttonEdit.Hide();
                создатьToolStripMenuItem.HideDropDown();
                сохранитьToolStripMenuItem.HideDropDown();
                сохранитьКакToolStripMenuItem.HideDropDown();
                buttonChange.Hide();
                buttonDelete.Hide();
                buttonAdd.Hide();
            }

        }
      

    private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tabControl.SelectedIndex.Equals(0)) { }
            else 
            {
              OpenFileDialog openFile = new OpenFileDialog();
              openFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
              Path = openFile.FileName;
            }

        }
        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex.Equals(0)) { }
            else { }
        }

        private void СохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex.Equals(0)) { }
            else 
            {        
                Timetable timetable = new Timetable();
                SaveFileDialog saveFile = new SaveFileDialog();
         
               saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
               Path = saveFile.FileName;

                if (Records != null)
               {

                    var record = Records.First;
                   using (StreamWriter streamWriter = new StreamWriter(Path))
                    {
                       while (record != null)
                        {
                            streamWriter.WriteLine($"{timetable.TrainNumber},{timetable.Type},{timetable.Way}, {timetable.Platform}, " +
                                $"{timetable.Destination}, {timetable.DepartureTime}, {timetable.ArrivalTime}");
                            record = record.Next;
                       }
                   }
                } 
            }

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddView addView = new AddView(-1, Records);
            addView.ShowDialog();

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                TimeTableGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (TimeTableGrid.Rows.GetRowCount(DataGridViewElementStates.Selected) != 1)
                    throw new Exception("Выберите один пункт расписания");
                else
                {

                    AddView addView = new AddView(Convert.ToInt32(TimeTableGrid[0, TimeTableGrid.CurrentRow.Index]), Records);

                    addView.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка работы с расписанием:");
            }

            //var timetableInDb = _context.Timetables.First(timetable => timetable.Id == !!!);

        }

        private void NumericPassCount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((numericHeavyCount.Value == 0 && numericPassCount.Value > 15) || (numericHeavyCount.Value > 0 && numericPassCount.Value + numericHeavyCount.Value > 14))

                {
                    numericPassCount.DownButton();
                    throw new Exception("Пожалуйста, хватит...");
                }
                else
                { 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка изменения числа путей в топологии:");
            }
        }

        private void NumericHeavyCount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((numericHeavyCount.Value == 0 && numericPassCount.Value > 15) || (numericHeavyCount.Value > 0 && numericPassCount.Value + numericHeavyCount.Value > 14))
                {
                    numericHeavyCount.DownButton();
                    throw new Exception("Пожалуйста, хватит...");
                }
                else
                {
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка изменения числа путей в топологии:");
            }
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            using (G = Graphics.FromImage(mapBox.Image))
            {
                int j = new int();
                G.Clear(Color.White);
                G.DrawImage(Properties.Resources.DefaultPicture, Topology.sector[0, 0]);
                if (numericPassCount.Value != 1)
                for (int ji = 2; ji < numericPassCount.Value; ji++)
                {
                    for (int i = 0; i < Topology.sector.GetLength(0); i += 3)
                    {
                        G.DrawImage(Properties.Resources.rail, Topology.sector[i, ji * 2 + 3]);
                    }
                    if (j != 1) Platform.AddPlatform(G, Topology.sector[0, 6 + (j - 2) / 2 * 4], mapBox.Height);
                }
                while (j < numericHeavyCount.Value)
                {
                    for (int i = 0; i < Topology.sector.GetLength(0); i += 3)
                    {
                        G.DrawImage(Properties.Resources.rail, Topology.sector[i, j * 2 + 3]);
                    }
                    j++;
                }
            }
            labelHeavy.Visible = false;
            labelPass.Visible = false;
            numericHeavyCount.Enabled = false;
            numericHeavyCount.Visible = false;
            numericPassCount.Enabled = false;
            numericPassCount.Visible = false;
            buttonConfirm.Enabled = false;
            buttonConfirm.Visible = false;
            buttonEdit.Enabled = true;
            buttonEdit.Visible = true;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            buttonEdit.Enabled = false;
            buttonEdit.Visible = false;
            labelHeavy.Visible = true;
            labelPass.Visible = true;
            numericHeavyCount.Enabled = true;
            numericHeavyCount.Visible = true;
            numericPassCount.Enabled = true;
            numericPassCount.Visible = true;
            buttonConfirm.Enabled = true;
            buttonConfirm.Visible = true;

        }
        public void UpdateTable(LinkedList<Timetable> Records)
        {
            TimeTableGrid.Rows.Clear();
            if (Records.First != null)
            {
                LinkedListNode<Timetable> node = Records.First;
                TimeTableGrid.Rows.Add(node.Value.TrainNumber.ToString(), node.Value.Type.ToString(), node.Value.Way.ToString(), 
                    node.Value.Platform.ToString(), node.Value.Destination.ToString(), node.Value.ArrivalTime.ToString(), 
                    node.Value.DepartureTime.ToString());
                while (node.Next != null)
                {
                    node = node.Next;
                    TimeTableGrid.Rows.Add(node.Value.TrainNumber.ToString(), node.Value.Type.ToString(), node.Value.Way.ToString(),
                    node.Value.Platform.ToString(), node.Value.Destination.ToString(), node.Value.ArrivalTime.ToString(),
                    node.Value.DepartureTime.ToString());
                }
            }
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Records = new LinkedList<Timetable>();
            AddView addView = new AddView(-1, Records);
            addView.ShowDialog();
            UpdateTable(Records);
        }

        private void ТопологиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapBox.Image = new Bitmap(mapBox.Width, mapBox.Height);         
            Item item = new Item();
            Platform[] platforms = new Platform[7];
            G = mapBox.CreateGraphics();
            using (G = Graphics.FromImage(mapBox.Image))
            {
                DateTime date1 = new DateTime(0, 0);
                Topology = new Pointer();
                G.Clear(Color.White);
                Topology.DoMap(mapBox.Width, mapBox.Height);
                for (int i = 0; i < mapBox.Width + 1; i += 50) //Координатная сетка: вертикальные
                {
                    G.DrawLine(item.GrayPen(), i, 0, i, mapBox.Height);
                }
                for (int i = 0; i < mapBox.Height + 1; i += 50) //Координатная сетка: горизонтальные
                {
                    G.DrawLine(item.GrayPen(), 0, i, mapBox.Width, i);
                }


                for (int i = 0; i < Topology.sector.GetLength(0); i += 3) // первый пассажирский путь
                {
                    G.DrawImage(Properties.Resources.rail, Topology.sector[i, 3]);
                }


                Platform.MainPlatform(G, Topology.sector[0, 0], mapBox.Height); //Главная платформа
                G.DrawImage(Properties.Resources.platform, 0, 0, mapBox.Width / 16, mapBox.Height); //Станция
                for (int i = 50; i < mapBox.Height; i += 200) //Разметка главной платформы
                {
                    G.DrawLine(item.GreenPen(), 150, i, 150, i + 100);
                }
            }
     //       DefaultImage = mapBox.Image;
     //       DefaultImage.Save("C:\\Users\\Maximus\\Source\\Repos\\TrainsAppl\\TrainsAppl\\Resources\\DefaultPicture.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }


}
