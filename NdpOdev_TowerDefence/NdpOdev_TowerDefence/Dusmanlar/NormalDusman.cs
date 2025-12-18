using NdpOdev_TowerDefence.Dusmanlar;

public class NormalDusman : Dusman
{
    public NormalDusman(Point baslangicKonumu)
    {
        this.konum = baslangicKonumu;
        this.can = 200;
        this.maxCan = 200;
        this.hiz = 3; 
        this.odul = 20;
        this.renk = Color.Yellow;
    }
}