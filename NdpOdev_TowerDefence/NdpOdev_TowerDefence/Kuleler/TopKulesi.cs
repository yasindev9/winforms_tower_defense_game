using NdpOdev_TowerDefence.Dusmanlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpOdev_TowerDefence.Kuleler
{
    public class TopKulesi : Kule
    {
        public TopKulesi(Point gridKonum) { 
            this.Konum = gridKonum;
            this.PikselKonumu = new Point(gridKonum.X * 50 + 25, gridKonum.Y * 50 + 25);

            this.Fiyat = 250;
            this.Hasar = 50;
            this.Menzil = 2;
            this.AtisHizi = 60;
            this.Renk = Color.OrangeRed;
        }

        public override void Saldir(List<Dusman> dusmanlar)
        {
            if (AtisSayaci == 0) VurulanHedefler.Clear();
            if (AtisSayaci > 0)
            {
                AtisSayaci--;
                return;
            }

            bool birineVurdukMu = false;
            double menzilPiksel = this.Menzil * 50;

            foreach (Dusman d in dusmanlar)
            {
                double mesafe = Math.Sqrt(Math.Pow(d.konum.X - this.PikselKonumu.X, 2) +
                                          Math.Pow(d.konum.Y - this.PikselKonumu.Y, 2));
                if (mesafe <= menzilPiksel)
                {
                    d.can -= this.Hasar;
                    birineVurdukMu = true;
                    this.VurulanHedefler.Add(d);
                }
            }

            if (birineVurdukMu)
            {
                this.AtisSayaci = this.AtisHizi;
            }
        }
    }
}
