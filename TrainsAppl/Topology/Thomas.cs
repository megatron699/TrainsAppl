﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrainsAppl.Topology
{
    class Thomas
    {
        private Image loco;
        private Image vagon;
        private Image rloco;
        private Image rvagon;
        private int count;
        private int type;
        private Item item;

        public Thomas(int count, int type)
        {
            this.count = count;
            this.type = type;
            this.item = new Item();

            switch (type)
            {
                case 0:
                    this.loco = Properties.Resources.passTrain;
                    this.vagon = Properties.Resources.passVagon;
                    this.rloco = Properties.Resources.passRevTrain;
                    this.rvagon = Properties.Resources.passRevVagon;
                    break;
                case 1:
                    this.loco = Properties.Resources.elTrain;
                    this.vagon = Properties.Resources.elVagon;
                    this.rloco = Properties.Resources.elRevTrain;
                    this.rvagon = Properties.Resources.elRevVagon;
                    break;
                case 2:
                    this.loco = Properties.Resources.heavyTrain;
                    this.vagon = Properties.Resources.heavyVagon;
                    this.rloco = Properties.Resources.heavyRevTrain;
                    this.rvagon = Properties.Resources.heavyRevVagon;
                    break;
            }


        }

        public Models.DB.Train Train
        {
            get => default;
            set
            {
            }
        }

        public Pointer Pointer
        {
            get => default;
            set
            {
            }
        }

        public Image GetLoco()
        {
            return loco;
        }

        public void SetLoco(Image value)
        {
            loco = value;
        }

        public Image GetVagon()
        {
            return vagon;
        }

        public void SetVagon(Image value)
        {
            vagon = value;
        }
        public int GetCount()
        {
            return count;
        }

        public void SetCount(int value)
        {
            count = value;
        }

        public int GetType()
        {
            return type;
        }

        public void SetType(byte value)
        {
            type = value;
        }

        public Image GetRVagon()
        {
            return rvagon;
        }

        public void SetRVagon(Image value)
        {
            rvagon = value;
        }

        public Image GetRLoco()
        {
            return rloco;
        }

        public void SetRLoco(Image value)
        {
            rloco = value;
        }

        public void RunIn(Graphics g, Pointer top, int way)
        {
            switch (this.GetType())
            {
                case 0:
                    for (int i = 0; i < this.GetCount(); i++) // первый пассажирский путь
                    {
                        try
                        {
                            g.DrawImage(this.GetVagon(), top.sector[i * 2, way * 2 + 1]);
                        }
                        catch { }
                    }
                    try
                    {
                        g.DrawImage(this.GetLoco(), top.sector[count * 2, way * 2 + 1]);
                    }
                    catch { }
                    break;

                case 1:
            
                g.DrawImage(this.GetRLoco(), top.sector[0, way * 2 + 1]);
                for (int i = 1; i < this.GetCount(); i++) // первый пассажирский путь
                {
                    try
                    {
                        g.DrawImage(this.GetVagon(), top.sector[i * 3, way * 2 + 1]);
                    }
                    catch { }
                }
                try
                {
                    g.DrawImage(this.GetLoco(), top.sector[count * 3, way * 2 + 1]);
                }
                catch { }
                    break;
                case 2:

            
                for (int i = 0; i < this.GetCount(); i++) // первый пассажирский путь
                {
                    try
                    {
                        g.DrawImage(this.GetVagon(), top.sector[i * 2, way * 2 + 2]);
                    }
                    catch { }
                }
                try
                {
                    g.DrawImage(this.GetLoco(), top.sector[count * 2, way * 2 + 2]);
                }
                catch { }
                    break;
            }
            g.DrawImage(Properties.Resources.platform, top.sector[0, 0]);

        }
        public void RunOut(Graphics g, Pointer top, int way)
        {
            if(this.type != 2)
                for (int i = 0; i < top.sector.GetLength(0); i += 3)
                {
                            g.DrawImage(Properties.Resources.railAway, top.sector[i, (way-1) * 2 + 3]);
                        
                        if (way != 1) Platform.AddPlatform(g, top.sector[0, 6 + (way - 2) / 2 * 4], top.sector.GetLength(0)*50);
                        else for (int j = 1; j < top.sector.GetLength(0); j += 4) //Разметка главной платформы
                        {
                            g.DrawLine(item.GreenPen(), 150, j*50, 150, j*50 + 100);
                        }

                }
                else
                {  
                    for (int i = 0; i < top.sector.GetLength(0); i += 3)
                    {
                        g.DrawImage(Properties.Resources.railAway, top.sector[i, (way-1) * 2 + 4]);
                    }
                    
                
                }
            g.DrawImage(Properties.Resources.platform, top.sector[0, 0]);

        }
    }
}
