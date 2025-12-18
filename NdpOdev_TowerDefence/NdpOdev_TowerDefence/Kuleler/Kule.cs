using NdpOdev_TowerDefence.Dusmanlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpOdev_TowerDefence.Kuleler
{
    public abstract class Kule
    {
        public Point Konum {  get; set; }
        public Point PikselKonumu { get; set; }
        public int Fiyat {  get; set; }
        public int Hasar {  get; set; }
        public int Menzil {  get; set; }
        public int AtisHizi {  get; set; }
        public Color Renk {  get; set; }
        public int AtisSayaci { get; set; }
        public List<Dusman> VurulanHedefler { get; set; } = new List<Dusman>();
        public abstract void Saldir(List<Dusman> dusmanlar);

    }
}
