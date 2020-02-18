using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsAppl.Topology
{
    class Item
    {
        Pen whitePen;
        Pen greenPen;
        Pen grayPen;
        Pen dGrayPen = new Pen(Color.DarkGray, 6);
        SolidBrush lGraybrush;
        SolidBrush dGraybrush;



        public Item()
        {
            this.whitePen = new Pen(Color.White, 10);
            this.greenPen = new Pen(Color.Green, 10);
            this.grayPen = new Pen(Color.Gray, 2);
            this.lGraybrush = new SolidBrush(Color.LightGray);
            this.dGraybrush = new SolidBrush(Color.DarkGray);
        }

        public Pen WhitePen()
        {
            return whitePen;
        }

        public Pen GreenPen()
        {
            return greenPen;
        }

        public Pen GrayPen()
        {
            return grayPen;
        }

        public Pen DGrayPen()
        {
            return dGrayPen;
        }

        public SolidBrush LGraybrush()
        {
            return lGraybrush;
        }

        public SolidBrush DGraybrush()
        {
            return dGraybrush;
        }

    }
}
