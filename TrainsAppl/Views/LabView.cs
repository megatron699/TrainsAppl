using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainsAppl.Views
{
    public partial class LabView : Form
    {
        public LabView()
        {
            InitializeComponent();
        }

        private void LabView_Load(object sender, EventArgs e)
        {
            label2.Text = "«Система моделирования работы железнодорожной станции» была создана в качестве учебной \n" +
               "программы в ходе курса «Технология программирования». Она предназначена для создания модели \n" +
               "железнодорожной станции (ждс) и наглядной демонстрации ее работы. Программа имеет средства для\n" +
               "создания топологии ждс и расписания движения поездов различных категорий. \n";
            label3.Text = "Пользователь имеет возможность создать собственную модель жд станции, используя предоставленные \n" +
                "графические элементы, и, составив расписание, просмотреть работу станции в модельном времени или\n" +
                "выбрать для запуска уже имеющуюся ждс.";
        }
    }
}
