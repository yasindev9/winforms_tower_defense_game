using NdpOdev_TowerDefence.Dusmanlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpOdev_TowerDefence.Kuleler
{
    public class OkKulesi : Kule
    {
        public OkKulesi(Point gridKonum) { 
            this.Konum = gridKonum;
            this.PikselKonumu = new Point(gridKonum.X * 50 + 25, gridKonum.Y * 50 + 25);

            this.Fiyat = 100;
            this.Hasar = 15;
            this.Menzil = 3;
            this.AtisHizi = 20;
            this.Renk = Color.LimeGreen;
        }

        public override void Saldir(List<Dusman> dusmanlar)
        {
            if (AtisSayaci == 0) VurulanHedefler.Clear();
            if (AtisSayaci > 0)
            {
                AtisSayaci--;
                return;
            }

            Dusman enYakin = null;
            double enKisaMesafe = double.MaxValue;
            double menzilPiksel = this.Menzil * 50;

            foreach (Dusman d in dusmanlar)
            {
                double mesafe = Math.Sqrt(Math.Pow(d.konum.X - this.PikselKonumu.X, 2) +
                                          Math.Pow(d.konum.Y - this.PikselKonumu.Y, 2));

                if (mesafe <= menzilPiksel && mesafe < enKisaMesafe)
                {
                    enKisaMesafe = mesafe;
                    enYakin = d;
                }
            }

            if (enYakin != null) 
            {
                enYakin.can -= this.Hasar;
                this.VurulanHedefler.Add(enYakin);
                this.AtisSayaci = this.AtisHizi;
            }
        }
    }
}
