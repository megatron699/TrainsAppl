using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainsApp.DAL;

namespace TrainsAppl
{
    public partial class Form1 : Form
    {
        private readonly TrainDBContext _context = new TrainDBContext();
        public Form1()
        {
            _context.Users.First(c => c.Id == 1);
            InitializeComponent();
        }
    }
}
