using NdpOdev_TowerDefence.Dusmanlar;

public class HizliDusman : Dusman
{
    public HizliDusman(Point baslangicKonumu)
    {
        this.konum = baslangicKonumu;
        this.can = 140;
        this.maxCan = 140;
        this.hiz = 8;
        this.odul = 30;
        this.renk = Color.Cyan;
    }
}