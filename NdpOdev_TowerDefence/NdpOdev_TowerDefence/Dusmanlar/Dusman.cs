using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpOdev_TowerDefence.Dusmanlar
{
    public abstract class Dusman
    {
        public Point konum { get; set; }
        public int yolAdimi { get; set; }
        public double can { get; set; }
        public double maxCan { get; set; }
        public int hiz { get; set; }
        public int odul { get; set; }
        public Color renk { get; set; }

        public bool HareketEt(List<Point> yolListesi)
        {
            if (yolAdimi >= yolListesi.Count - 1) return true;

            Point hedef = yolListesi[yolAdimi + 1];
            int hedefX = hedef.X * 50 + 25;
            int hedefY = hedef.Y * 50 + 25;

            if (konum.X < hedefX) konum = new Point(konum.X + hiz, konum.Y);
            if (konum.X > hedefX) konum = new Point(konum.X - hiz, konum.Y);
            if (konum.Y < hedefY) konum = new Point(konum.X, konum.Y + hiz);
            if (konum.Y > hedefY) konum = new Point(konum.X, konum.Y - hiz);

            if (Math.Abs(konum.X - hedefX) < hiz && Math.Abs(konum.Y - hedefY) < hiz)
            {
                yolAdimi++;
            }

            return false;
        }
    }
}
