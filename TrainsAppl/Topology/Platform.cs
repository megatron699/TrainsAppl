using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsAppl.Topology
{

    class Platform
    {

        SolidBrush lGraybrush = new SolidBrush(Color.LightGray);
        SolidBrush dGraybrush = new SolidBrush(Color.DarkGray);
        Pen dGrayPen = new Pen(Color.DarkGray, 6);
        private Rectangle rect;
        private Rectangle per;
        private Size size;
        private Item item;

        public Platform()
        {
            this.item = new Item();
        }

        public Rectangle Rect { get => rect; set => rect = value; }
        public Pen DGrayPen { get => dGrayPen; set => dGrayPen = value; }
        public SolidBrush DGraybrush { get => dGraybrush; set => dGraybrush = value; }
        public SolidBrush LGraybrush { get => lGraybrush; set => lGraybrush = value; }

        public static void AddPlatform(Graphics g, Point point, int h)
        {
            
            Item item = new Item();
            Size size = new Size(50, h);
            Rectangle rect = new Rectangle(point, size);
            g.FillRectangle(item.LGraybrush(), rect);
            g.DrawRectangle(item.DGrayPen(), rect);
        }



        public static void MainPlatform(Graphics g, Point point, int h)
        {
            SolidBrush b = new SolidBrush(Color.LightGray);
            Pen p = new Pen(Color.DarkGray, 6);
            Size s = new Size(150, h);
            Rectangle r = new Rectangle(point, s);
            g.FillRectangle(b, r);
            g.DrawRectangle(p, r);

        }
    }
}
