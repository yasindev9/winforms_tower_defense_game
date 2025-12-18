using NdpOdev_TowerDefence.Dusmanlar;
using NdpOdev_TowerDefence.Kuleler;
using System.Reflection;

namespace NdpOdev_TowerDefence
{
    public partial class Form1 : Form
    {
        //harita deðiþkenleri
        int[,] harita = new int[12, 24];
        private List<Point> yolKoordinatlari = new List<Point>();
        private const int BASLANGIC = 4;
        private const int YOL = 1;
        private const int BITIS = 2;

        //düþman yönetimi
        private List<Dusman> sahnedekiDusmanlar = new List<Dusman>();

        //oyun deðiþkenleri
        private int mevcutDalga = 1;
        private int dalgaDusmanSayisi = 18;
        private int uretilenDusmanSayisi = 0;
        private int oyuncuAltin = 400;
        private int oyuncuCan = 20;
        private int oyuncuSkor = 0;

        //timer tanýmlarý
        private System.Windows.Forms.Timer tmrOyunDongusu = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer tmrSpawn = new System.Windows.Forms.Timer();

        //sahnedeki tüm kuleler
        private List<Kule> kuleler = new List<Kule>();
        //oyuncunun seçtiði kule
        private int secilenKuleTipi = 0;
        //mouse konumu
        private Point mouseKonumu = new Point(-1, -1);
        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
                    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                    null, pnlOyunAlani, new object[] { true });
            this.AutoSize = false;
            this.ClientSize = new Size(1200, 750);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            harita = HaritaOlustur();
            InsaatAlaniBelirle();
            pnlOyunAlani.Invalidate();
            pnlAlt.Invalidate();
            pnlUst.Invalidate();
            pnlOyunAlani.SendToBack();
            pnlDevam.Visible = false;
            pnlOyunBitti.Visible = false;
            pnlBuyucu.Visible = false;
            pnlOkcu.Visible = false;
            pnlTopcu.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrOyunDongusu.Interval = 20;
            tmrOyunDongusu.Tick += TmrOyunDongusu_Tick;
            tmrOyunDongusu.Start();

            tmrSpawn.Interval = 1500;
            tmrSpawn.Tick += TmrSpawn_Tick;
            tmrSpawn.Start();
        }
        private void pnlOyunAlani_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int toplamSatir = harita.GetLength(0);
            int toplamSutun = harita.GetLength(1);

            SolidBrush insaatZemini = new SolidBrush(Color.FromArgb(15, 80, 200, 255));
            Pen insaatCercevesi = new Pen(Color.FromArgb(60, 100, 100, 255), 1);
            Pen yolKenarKalemi = new Pen(Color.FromArgb(80, 200, 180, 255), 4);

            for (int r = 0; r < toplamSatir; r++)
            {
                for (int c = 0; c < toplamSutun; c++)
                {
                    int x = c * 50; int y = r * 50;
                    int hucre = harita[r, c];

                    if (hucre == 3)
                    {
                        g.FillRectangle(insaatZemini, x, y, 50, 50);
                        g.DrawRectangle(insaatCercevesi, x, y, 50, 50);
                    }
                    if (hucre == YOL || hucre == BASLANGIC || hucre == BITIS)
                    {
                        if (r == 0 || !YolMu(r - 1, c)) g.DrawLine(yolKenarKalemi, x, y, x + 50, y); // Üst
                        if (r == toplamSatir - 1 || !YolMu(r + 1, c)) g.DrawLine(yolKenarKalemi, x, y + 50, x + 50, y + 50); // Alt
                        if (c == 0 || !YolMu(r, c - 1)) g.DrawLine(yolKenarKalemi, x, y, x, y + 50); // Sol
                        if (c == toplamSutun - 1 || !YolMu(r, c + 1)) g.DrawLine(yolKenarKalemi, x + 50, y, x + 50, y + 50); // Sað
                    }
                }
            }

            if (yolKoordinatlari.Count > 1)
            {
                Color baslangicRenk = Color.FromArgb(0, 255, 255);
                Color bitisRenk = Color.FromArgb(255, 0, 128);

                for (int i = 0; i < yolKoordinatlari.Count - 1; i++)
                {
                    Point p1 = yolKoordinatlari[i];
                    Point p2 = yolKoordinatlari[i + 1];

                    Point merkez1 = new Point(p1.X * 50 + 25, p1.Y * 50 + 25);
                    Point merkez2 = new Point(p2.X * 50 + 25, p2.Y * 50 + 25);

                    float oran = (float)i / yolKoordinatlari.Count;

                    int r = (int)(baslangicRenk.R + (bitisRenk.R - baslangicRenk.R) * oran);
                    int green = (int)(baslangicRenk.G + (bitisRenk.G - baslangicRenk.G) * oran);
                    int b = (int)(baslangicRenk.B + (bitisRenk.B - baslangicRenk.B) * oran);

                    Color oAnkiRenk = Color.FromArgb(r, green, b);

                    using (Pen yolKalemi = new Pen(oAnkiRenk, 6))
                    {
                        yolKalemi.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        yolKalemi.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        g.DrawLine(yolKalemi, merkez1, merkez2);
                    }
                }
                Point baslangicNoktasi = yolKoordinatlari[0];
                Point baslangicMerkez = new Point(baslangicNoktasi.X * 50 + 25, baslangicNoktasi.Y * 50 + 25);
                Point baslangicSolKenar = new Point(baslangicNoktasi.X * 50, baslangicNoktasi.Y * 50 + 25); // En sol

                using (Pen baslangicKalem = new Pen(baslangicRenk, 6))
                {
                    g.DrawLine(baslangicKalem, baslangicSolKenar, baslangicMerkez);
                }

                Point bitisNoktasi = yolKoordinatlari[yolKoordinatlari.Count - 1];
                Point bitisMerkez = new Point(bitisNoktasi.X * 50 + 25, bitisNoktasi.Y * 50 + 25);
                Point bitisSagKenar = new Point(bitisNoktasi.X * 50 + 50, bitisNoktasi.Y * 50 + 25); // En sað

                using (Pen bitisKalem = new Pen(bitisRenk, 6))
                {
                    g.DrawLine(bitisKalem, bitisMerkez, bitisSagKenar);
                }
            }

            foreach (Dusman d in sahnedekiDusmanlar)
            {
                SolidBrush dusmanFircasi = new SolidBrush(d.renk);
                g.FillEllipse(dusmanFircasi, d.konum.X - 15, d.konum.Y - 15, 30, 30);
                g.DrawEllipse(Pens.White, d.konum.X - 15, d.konum.Y - 15, 30, 30);
                float canYuzdesi = (float)d.can / (float)d.maxCan;

                g.FillRectangle(Brushes.Red, d.konum.X - 15, d.konum.Y - 25, 30, 5);
                g.FillRectangle(Brushes.LimeGreen, d.konum.X - 15, d.konum.Y - 25, 30 * canYuzdesi, 5);
            }

            foreach (Kule k in kuleler)
            {
                int x = k.PikselKonumu.X;
                int y = k.PikselKonumu.Y;
                Rectangle taban = new Rectangle(x - 20, y - 20, 40, 40);
                g.FillRectangle(new SolidBrush(Color.FromArgb(40, 40, 40)), taban);
                g.DrawRectangle(new Pen(k.Renk, 2), taban);

                if (k is OkKulesi)
                {
                    g.FillEllipse(new SolidBrush(k.Renk), x - 10, y - 10, 20, 20);
                }
                else if (k is TopKulesi)
                {
                    g.FillEllipse(new SolidBrush(Color.DarkRed), x - 15, y - 15, 30, 30);
                    g.FillEllipse(new SolidBrush(k.Renk), x - 8, y - 8, 16, 16);
                    g.DrawEllipse(Pens.White, x - 15, y - 15, 30, 30);
                }
                else if (k is BuyuKulesi)
                {
                    Point[] kristalNoktalari = {
                        new Point(x, y - 15),
                        new Point(x + 10, y),
                        new Point(x, y + 15),
                        new Point(x - 10, y)
                        };
                    g.FillPolygon(new SolidBrush(k.Renk), kristalNoktalari);
                    g.DrawPolygon(Pens.White, kristalNoktalari);
                    g.FillEllipse(Brushes.White, x - 3, y - 3, 6, 6);
                }
                if (k.VurulanHedefler.Count > 0 && k.AtisSayaci > k.AtisHizi - 10)
                {
                    Point kuleMerkez = k.PikselKonumu;
                    if (k is OkKulesi)
                    {
                        foreach (var hedef in k.VurulanHedefler)
                        {
                            using (Pen lazerKalemi = new Pen(k.Renk, 2))
                            {
                                g.DrawLine(lazerKalemi, kuleMerkez, hedef.konum);
                            }
                        }
                    }
                    else if (k is TopKulesi)
                    {
                        int patlamaCapi = 40;
                        using (SolidBrush patlamaFircasi = new SolidBrush(Color.FromArgb(150, 255, 69, 0)))
                        using (Pen sokDalgasi = new Pen(Color.White, 2))
                        {
                            foreach (var hedef in k.VurulanHedefler)
                            {
                                g.FillEllipse(patlamaFircasi, hedef.konum.X - patlamaCapi / 2, hedef.konum.Y - patlamaCapi / 2, patlamaCapi, patlamaCapi);
                                g.DrawEllipse(sokDalgasi, hedef.konum.X - patlamaCapi / 2, hedef.konum.Y - patlamaCapi / 2, patlamaCapi, patlamaCapi);
                            }
                        }
                    }
                    else if (k is BuyuKulesi)
                    {
                        Random rnd = new Random();
                        using (Pen yildirimKalemi = new Pen(Color.Cyan, 2))
                        {
                            foreach (var hedef in k.VurulanHedefler)
                            {
                                Point ortaNokta = new Point((kuleMerkez.X + hedef.konum.X) / 2, (kuleMerkez.Y + hedef.konum.Y) / 2);
                                ortaNokta.X += rnd.Next(-15, 16);
                                ortaNokta.Y += rnd.Next(-15, 16);

                                g.DrawLine(yildirimKalemi, kuleMerkez, ortaNokta);
                                g.DrawLine(yildirimKalemi, ortaNokta, hedef.konum);
                                g.FillEllipse(Brushes.White, hedef.konum.X - 4, hedef.konum.Y - 4, 8, 8);
                            }
                        }
                    }
                }
            }
            if (secilenKuleTipi != 0 && mouseKonumu.X != -1)
            {
                if (mouseKonumu.X < 24 && mouseKonumu.Y < 12)
                {
                    int menzilKare = 0;
                    Color temaRengi = Color.White;
                    if (secilenKuleTipi == 1) { menzilKare = 3; temaRengi = Color.LimeGreen; }
                    else if (secilenKuleTipi == 2) { menzilKare = 2; temaRengi = Color.OrangeRed; }
                    else if (secilenKuleTipi == 3) { menzilKare = 4; temaRengi = Color.MediumPurple; }

                    int yaricap = menzilKare * 50;
                    int merkezX = mouseKonumu.X * 50 + 25;
                    int merkezY = mouseKonumu.Y * 50 + 25;

                    using (SolidBrush menzilFircasi = new SolidBrush(Color.FromArgb(50, temaRengi)))
                    {
                        g.FillEllipse(menzilFircasi, merkezX - yaricap, merkezY - yaricap, yaricap * 2, yaricap * 2);
                    }

                    using (Pen menzilKalemi = new Pen(Color.FromArgb(150, temaRengi), 2))
                    {
                        menzilKalemi.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        g.DrawEllipse(menzilKalemi, merkezX - yaricap, merkezY - yaricap, yaricap * 2, yaricap * 2);
                    }
                    using (SolidBrush hayaletFirca = new SolidBrush(Color.FromArgb(100, temaRengi)))
                    {
                        g.FillRectangle(hayaletFirca, mouseKonumu.X * 50 + 5, mouseKonumu.Y * 50 + 5, 40, 40);
                    }
                }
            }
        }
        private bool YolMu(int r, int c)
        {
            if (r < 0 || c < 0 || r >= 12 || c >= 24) return false;
            int val = harita[r, c];
            return val == YOL || val == BASLANGIC || val == BITIS;
        }

        private int[,] HaritaOlustur()
        {
            yolKoordinatlari.Clear();
            int[,] harita = new int[12, 24];
            Random rnd = new Random();
            int satir = rnd.Next(1, 11);
            int sutun = 0;
            harita[satir, sutun] = BASLANGIC;
            yolKoordinatlari.Add(new Point(sutun, satir));
            while (sutun < 23)
            {
                int ilerlemeMiktari = rnd.Next(2, 5);
                for (int i = 0; i < ilerlemeMiktari; i++)
                {
                    sutun++;
                    if (sutun >= 23) break;
                    harita[satir, sutun] = YOL;
                    yolKoordinatlari.Add(new Point(sutun, satir));
                }

                if (sutun >= 23) break;

                int hedefSatir = rnd.Next(Math.Max(1, satir - 4), Math.Min(11, satir + 5));

                while (satir != hedefSatir)
                {
                    if (satir < hedefSatir) satir++;
                    else satir--;
                    harita[satir, sutun] = YOL;
                    yolKoordinatlari.Add(new Point(sutun, satir));
                }
            }
            harita[satir, 23] = BITIS;
            yolKoordinatlari.Add(new Point(23, satir));
            pnlOyunAlani.Invalidate();
            return harita;
        }

        private void InsaatAlaniBelirle()
        {
            int satirSayisi = harita.GetLength(0);
            int sutunSayisi = harita.GetLength(1);

            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    if (harita[i, j] == 1 || harita[i, j] == 2)
                    {
                        Isaretle(i, j);
                    }
                }
            }
        }

        private void Isaretle(int merkezSatir, int merkezSutun)
        {
            int menzil = 2;

            int satir = harita.GetLength(0);
            int sutun = harita.GetLength(1);

            for (int i = -menzil; i < menzil; i++)
            {
                for (int j = -menzil; j < menzil; j++)
                {
                    int hedefSatir = merkezSatir + i;
                    int hedefSutun = merkezSutun + j;

                    if (hedefSatir >= 0 && hedefSatir < satir &&
                    hedefSutun >= 0 && hedefSutun < sutun)
                    {
                        if (harita[hedefSatir, hedefSutun] == 0)
                        {
                            harita[hedefSatir, hedefSutun] = 3;
                        }
                    }
                }
            }
        }

        private void TmrSpawn_Tick(object sender, EventArgs e)
        {
            if (uretilenDusmanSayisi >= dalgaDusmanSayisi)
            {
                return;
            }

            Random rnd = new Random();

            Point baslangicKare = yolKoordinatlari[0];
            Point baslangicPiksel = new Point(baslangicKare.X * 50 + 25, baslangicKare.Y * 50 + 25);

            Dusman yeniDusman = null;

            int rastgeleTip = rnd.Next(1, Math.Min(mevcutDalga + 1, 4));

            switch (rastgeleTip)
            {
                case 1: yeniDusman = new NormalDusman(baslangicPiksel); break;
                case 2: yeniDusman = new HizliDusman(baslangicPiksel); break;
                case 3: yeniDusman = new TankDusman(baslangicPiksel); break;
                default: yeniDusman = new NormalDusman(baslangicPiksel); break;
            }

            sahnedekiDusmanlar.Add(yeniDusman);
            uretilenDusmanSayisi++;
        }

        private void TmrOyunDongusu_Tick(object sender, EventArgs e)
        {
            coinLabel.Text = "Altýn: " + oyuncuAltin;
            hpLabel.Text = "Can: " + oyuncuCan;
            waveLabel.Text = "Dalga: " + mevcutDalga;
            scoreLabel.Text = "Skor: " + oyuncuSkor;

            foreach (Kule k in kuleler)
            {
                k.Saldir(sahnedekiDusmanlar);
            }

            for (int i = sahnedekiDusmanlar.Count - 1; i >= 0; i--)
            {
                Dusman d = sahnedekiDusmanlar[i];

                if (d.can <= 0)
                {
                    oyuncuAltin += d.odul;
                    oyuncuSkor += d.odul * 2;
                    sahnedekiDusmanlar.RemoveAt(i);
                    continue;
                }

                bool ulastiMi = d.HareketEt(yolKoordinatlari);
                if (ulastiMi)
                {
                    oyuncuCan -= 5;
                    sahnedekiDusmanlar.RemoveAt(i);

                    if (oyuncuCan <= 0)
                    {
                        pnlOyunBitti.Visible = true;
                        pnlOyunBitti.BringToFront();
                        skorSon.Text = "Skor: " + oyuncuSkor.ToString();
                        tmrOyunDongusu.Stop();
                        tmrSpawn.Stop();
                    }
                }
            }
            if (sahnedekiDusmanlar.Count == 0 && uretilenDusmanSayisi >= dalgaDusmanSayisi)
            {
                tmrOyunDongusu.Stop();
                tmrSpawn.Stop();
                int sonrakiDalga = mevcutDalga;
                sonrakiDalga++;
                pnlDevam.Visible = true;
                panelSkor.Text = "Mevcut Skor: " + oyuncuSkor.ToString();
                panelAltin.Text = "Mevcut Altýn: " + oyuncuAltin.ToString();
                panelDalga.Text = "Sonraki Dalga: " + sonrakiDalga.ToString();
            }

            pnlOyunAlani.Invalidate();
        }

        private void OyunuSifirla()
        {
            tmrOyunDongusu.Stop();
            tmrSpawn.Stop();

            sahnedekiDusmanlar.Clear();
            kuleler.Clear();
            yolKoordinatlari.Clear();

            oyuncuCan = 20;
            oyuncuAltin = 400; 
            oyuncuSkor = 0;
            mevcutDalga = 1;
            uretilenDusmanSayisi = 0;
            dalgaDusmanSayisi = 18; 

            secilenKuleTipi = 0;
            pnlOkcu.Visible = false;
            pnlTopcu.Visible = false;
            pnlBuyucu.Visible = false;

            harita = HaritaOlustur();
            InsaatAlaniBelirle();
            pnlOyunBitti.Visible = false;
            pnlDevam.Visible = false; 

            coinLabel.Text = "Altýn: " + oyuncuAltin;
            hpLabel.Text = "Can: " + oyuncuCan;
            waveLabel.Text = "Dalga: " + mevcutDalga;
            scoreLabel.Text = "Skor: " + oyuncuSkor;

            tmrOyunDongusu.Start();
            tmrSpawn.Start();

            pnlOyunAlani.Invalidate();
        }

        private void btnOkcu_MouseClick(object sender, MouseEventArgs e)
        {
            secilenKuleTipi = 1;
            pnlBuyucu.Visible = false;
            pnlOkcu.Visible = true;
            pnlTopcu.Visible = false;
        }
        private void btnTopcu_MouseClick(object sender, MouseEventArgs e)
        {
            secilenKuleTipi = 2;
            pnlBuyucu.Visible = false;
            pnlOkcu.Visible = false;
            pnlTopcu.Visible = true;
        }
        private void btnBuyucu_MouseClick(object sender, MouseEventArgs e)
        {
            secilenKuleTipi = 3;
            pnlBuyucu.Visible = true;
            pnlOkcu.Visible = false;
            pnlTopcu.Visible = false;
        }

        private void pnlOyunAlani_MouseClick(object sender, MouseEventArgs e)
        {
            int sutun = e.X / 50;
            int satir = e.Y / 50;

            if (sutun >= 24 || satir >= 12) return;
            {
                if (harita[satir, sutun] == 3)
                {
                    Kule yeniKule = null;
                    switch (secilenKuleTipi)
                    {
                        case 1:
                            if (oyuncuAltin >= 100)
                            {
                                oyuncuAltin -= 100;
                                yeniKule = new OkKulesi(new Point(sutun, satir));
                            }
                            break;

                        case 2:
                            if (oyuncuAltin >= 250)
                            {
                                oyuncuAltin -= 250;
                                yeniKule = new TopKulesi(new Point(sutun, satir));
                            }
                            break;

                        case 3:
                            if (oyuncuAltin >= 200)
                            {
                                oyuncuAltin -= 200;
                                yeniKule = new BuyuKulesi(new Point(sutun, satir));
                            }
                            break;
                    }

                    if (yeniKule != null)
                    {
                        kuleler.Add(yeniKule);
                        harita[satir, sutun] = 5;
                        coinLabel.Text = "Altýn: " + oyuncuAltin;
                    }
                    else if (secilenKuleTipi != 0)
                    {
                        MessageBox.Show("YETERSÝZ ALTIN", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (harita[satir, sutun] == 5)
                {
                    MessageBox.Show("BURDA ZATEN KULE VAR", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void pnlOyunAlani_MouseMove(object sender, MouseEventArgs e)
        {
            int sutun = e.X / 50;
            int satir = e.Y / 50;
            if (mouseKonumu.X != sutun || mouseKonumu.Y != satir)
            {
                mouseKonumu = new Point(sutun, satir);
                if (secilenKuleTipi != 0)
                {
                    pnlOyunAlani.Invalidate();
                }
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            pnlDevam.Visible = false;
            oyuncuAltin += 20 * mevcutDalga;
            mevcutDalga++;
            dalgaDusmanSayisi += 2 * mevcutDalga;
            uretilenDusmanSayisi = 0;
            tmrOyunDongusu.Start();
            tmrSpawn.Start();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            OyunuSifirla();
        }
    }
}
