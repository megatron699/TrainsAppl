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
        Timetable timetable;
      //  MainView view;
        private readonly TrainDBContext _context = new TrainDBContext();
        public AddView(int timeTableId, LinkedList<Timetable> records)
        {
            this.records = records;
            InitializeComponent();
            if (timeTableId > -1)
            {
                var timetable = _context.Timetables.FirstOrDefault(time => time.Id == timeTableId);
                trainNumBox.Text = timetable.TrainNumber.ToString();
                trainTypeBox.Text = timetable.Type;
                departueBox.Text = timetable.Destination;
                depTimePicker.Value = timetable.DepartureTime;
                arrTimePicker.Value = timetable.ArrivalTime;
                countUpDown.Value = timetable.WagonCount;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            try  {int.Parse(trainNumBox.Text); }
            catch { throw new Exception("Недопустимое значение - "); }
            //if trainTypeBox.Text =  { int.Parse(trainNumBox.Text); }
            //catch { throw new Exception("Недопустимое значение - "); }
            //try { int.Parse(trainNumBox.Text); }
            //catch { throw new Exception("Недопустимое значение - "); }
            //try { int.Parse(trainNumBox.Text); }
            //catch { throw new Exception("Недопустимое значение - "); }
            //try { int.Parse(trainNumBox.Text); }
            //catch { throw new Exception("Недопустимое значение - "); }
            //try { int.Parse(trainNumBox.Text); }
            //catch { throw new Exception("Недопустимое значение - "); }

            Timetable timetable  = new Timetable
            {
                TrainNumber = int.Parse(trainNumBox.Text),
                Type = trainTypeBox.Text,
                Destination = departueBox.Text,
                DepartureTime = depTimePicker.Value,
                ArrivalTime = arrTimePicker.Value,
                WagonCount = int.Parse(countUpDown.Text)
            };
            _context.Timetables.Add(timetable);
            _context.SaveChanges();
            try
            {
                records.AddLast(timetable);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
           // view.UpdateTable(records);
        }
    }
}
