using NdpOdev_TowerDefence.Dusmanlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpOdev_TowerDefence.Kuleler
{
    public class BuyuKulesi : Kule
    {
        public BuyuKulesi(Point gridKonum) { 
            this.Konum = gridKonum;
            this.PikselKonumu = new Point(gridKonum.X * 50 + 25, gridKonum.Y * 50 + 25);

            this.Fiyat = 200;
            this.Hasar = 25;
            this.Menzil = 4;
            this.AtisHizi = 30;
            this.Renk = Color.MediumPurple;
        }

        public override void Saldir(List<Dusman> dusmanlar)
        {
            if (AtisSayaci == 0) VurulanHedefler.Clear();

            if (AtisSayaci > 0)
            {
                AtisSayaci--;
                return;
            }
            double menzilPiksel = this.Menzil * 50;

            var hedefler = dusmanlar
                .Where(d => Math.Sqrt(Math.Pow(d.konum.X - this.PikselKonumu.X, 2) +
                                      Math.Pow(d.konum.Y - this.PikselKonumu.Y, 2)) <= menzilPiksel)
                .OrderBy(d => Math.Sqrt(Math.Pow(d.konum.X - this.PikselKonumu.X, 2) +
                                        Math.Pow(d.konum.Y - this.PikselKonumu.Y, 2)))
                .Take(5)
                .ToList();

            if (hedefler.Count > 0)
            {
                foreach (var d in hedefler)
                {
                    d.can -= this.Hasar;
                }

                this.VurulanHedefler.AddRange(hedefler);
                this.AtisSayaci = this.AtisHizi;
            }
        }
    }
}
