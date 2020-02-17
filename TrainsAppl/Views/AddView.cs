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
        public AddView(int timeTableId, LinkedList<Timetable> records)
        {
            this.records = records;
            InitializeComponent();
            if (timeTableId > -1) 
            {

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

            Timetable timetable = new Timetable
            {
                TrainNumber = int.Parse(trainNumBox.Text),
                Type = trainTypeBox.Text,
                Destination = departueBox.Text,
                DepartureTime = depTimePicker.Value,
                ArrivalTime = arrTimePicker.Value,
                WagonCount = int.Parse(countUpDown.Text)
            };
            _context.ArrivalDeparture.Add(timetable);
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
