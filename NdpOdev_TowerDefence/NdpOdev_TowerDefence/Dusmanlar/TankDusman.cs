using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpOdev_TowerDefence.Dusmanlar
{
    public  class TankDusman : Dusman
    {
        public TankDusman(Point baslangicKonum) {
            this.konum = baslangicKonum;
            this.can = 1000;
            this.maxCan = 1000;
            this.hiz = 1;
            this.odul = 40;
            this.renk = Color.Red;
        }
    }
}
