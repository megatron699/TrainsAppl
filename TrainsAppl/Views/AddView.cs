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

namespace TrainsAppl.Views
{
    public partial class AddView : Form
    {
        private readonly TrainDBContext _context = new TrainDBContext();
        public AddView(int timeTableId)
        {
            
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

        }
    }
}
