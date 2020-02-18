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
    public partial class DevView : Form
    {
        public DevView()
        {
            InitializeComponent();
            
        }

        private void DevView_Load(object sender, EventArgs e)
        {


            labelAlex.Text = "Мартюшов Александр \n" +
                "состоит в Самарском областном клубе \n" +
                "Авторской песни имени Валерия Грушина, \n" +
                "играет в компьютерные игры, а еще говорит, \n" +
                "что в школе много чем занимался";
            labelMike.Text = "Клашкин Михаил\n" +
                "любит разные игры: компьютерные, \n" +
                "настольные, а также в лазертаг, \n" +
                "а в школе Миша был каратэ-пацан и ходил \n" +
                "на древковое оружие, но больше всего на свете \n" +
                "Миша любит спать, он спит везде на парах,\n" +
                "дома, ладно хоть за рулем не спит";
            labelJulya.Text = "Севостьянова Юлия\n" +
                "закончила школу с уклоном на английский, \n" +
                "также закончила школу искусств №4, \n" +
                "помимо этого Юля ходила учиться играть на гитаре,\n" +
                "но так тяга к музыке у нее не проявилась, \n" +
                "сейчас Юля продолжает активную жизнь \n" +
                "и состоит в СПО <<Рассвет>>";
            labelIryna.Text = "Султангулова Ирина \n" +
                "играла  в волейбол за районную сборную,\n" +
                "а после в в сборной университета,\n" +
                "также Ирина любит смотреть сериалы и иногда читать";
            labelTitle.Text = "Все авторы являются студентами очного отделения Самарского университета,\n" +
                "факультета информатики, направления ИВТ";
            groupBoxAlex.Visible = true;
            groupBoxMike.Visible = true;
            groupBoxJulya.Visible = true;
            groupBoxIryna.Visible = true;
            labelTitle.Visible = true;




        }

    }
}
