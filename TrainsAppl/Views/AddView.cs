using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainsAppl.DAL;
using TrainsAppl.Models.DB;

namespace TrainsAppl.Views
{
    public partial class AddView : Form
    {
        LinkedList<Timetable> records;
        

        
        //  MainView view;
        private readonly TrainDBContext _context = new TrainDBContext();
        DateTime defTime;
        public AddView(int timeTableId, LinkedList<Timetable> records)
        {
            Int32 train = new Int32();
            this.records = records;
            
            InitializeComponent();
            defTime = arrTimePicker.Value;
            for (int i = 0;i < 20; i++) 
            {
                train = 301 + i * 7;
                trainNumBox.Items.Add(train);
            }
            for (int i = 0; i < 20; i++)
            {
                train = 851 + i * 2;
                trainNumBox.Items.Add(train);
            }
            for (int i = 0; i < 20; i++)
            {
                train = 901 + i * 7;
                trainNumBox.Items.Add(train);
            }
            


            if (timeTableId > -1)
            {
                var timetable = _context.Timetables.FirstOrDefault(time => time.Id == timeTableId);
                trainNumBox.Text = timetable.TrainNumber.ToString();
                trainTypeBox.Text = timetable.Type;
                departueBox.Text = timetable.Destination;
                arrTimePicker.Value.AddMinutes(timetable.ArrivalTime.TotalMinutes); 
                depTimePicker.Value.AddMinutes(timetable.DepartureTime.TotalMinutes);
                countUpDown.Value = timetable.WagonCount;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            try { int.Parse(trainNumBox.Text); }
            catch { MessageBox.Show("Недопустимое значение - номер поезда", "Ошибка работы с расписанием:"); }
            if ((trainTypeBox.Text != "Пассажирский") && (trainTypeBox.Text != "Электропоезд") && (trainTypeBox.Text != "Товарный")) { MessageBox.Show("Недопустимое значение - тип поезда", "Ошибка работы с расписанием:"); }
            else
            {
                TimeSpan span = depTimePicker.Value - arrTimePicker.Value;
                double relative = span.TotalMinutes;
                if (Math.Abs(relative) < 30) { MessageBox.Show("Недопустимое значение - время стоянки должно быть как минимум 30 минут ", "Ошибка работы с расписанием:"); }
                else
                {
                    Timetable timetable = new Timetable
                    {
                        TrainNumber = int.Parse(trainNumBox.Text),
                        Type = trainTypeBox.Text,
                        Departue = departueBox.Text,
                        Destination = destinationBox.Text,
                        ArrivalTime = arrTimePicker.Value - arrTimePicker.Value.Date,
                        DepartureTime = depTimePicker.Value - depTimePicker.Value.Date,
                        WagonCount = int.Parse(countUpDown.Text)
                    };
                    _context.Timetables.Add(timetable);
                    _context.SaveChanges();
                
                try
                {
                    records.AddLast(timetable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                    Close();
                }
                
                // view.UpdateTable(records);
            }
        }

        private void trainNumBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trainNumBox.SelectedIndex < 20) { trainTypeBox.SelectedIndex = 0; }
            else
            if (trainNumBox.SelectedIndex < 40) { trainTypeBox.SelectedIndex = 1; }
            else
            if (trainNumBox.SelectedIndex < 60) { trainTypeBox.SelectedIndex = 2; }
        }

        private void arrTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (depTimePicker.Value == defTime)
            {
                depTimePicker.Value = arrTimePicker.Value;
                depTimePicker.Value.AddMinutes(30); 
            }
        }

        private void departueBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}