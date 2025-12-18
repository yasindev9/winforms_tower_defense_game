namespace NdpOdev_TowerDefence
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlUst = new Panel();
            scoreLabel = new Label();
            waveLabel = new Label();
            hpLabel = new Label();
            coinLabel = new Label();
            pnlAlt = new Panel();
            pnlBuyucu = new Panel();
            pnlTopcu = new Panel();
            pnlOkcu = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            btnBuyucu = new Button();
            btnTopcu = new Button();
            btnOkcu = new Button();
            pnlOyunAlani = new Panel();
            pnlDevam = new Panel();
            pnlOyunBitti = new Panel();
            skorSon = new Label();
            restartButton = new Button();
            label11 = new Label();
            panelDalga = new Label();
            panelAltin = new Label();
            panelSkor = new Label();
            btnSonraki = new Button();
            label1 = new Label();
            pnlUst.SuspendLayout();
            pnlAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlOyunAlani.SuspendLayout();
            pnlDevam.SuspendLayout();
            pnlOyunBitti.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUst
            // 
            pnlUst.BackColor = Color.FromArgb(45, 30, 75);
            pnlUst.BackgroundImage = Properties.Resources.ustBar2;
            pnlUst.Controls.Add(scoreLabel);
            pnlUst.Controls.Add(waveLabel);
            pnlUst.Controls.Add(hpLabel);
            pnlUst.Controls.Add(coinLabel);
            pnlUst.Dock = DockStyle.Top;
            pnlUst.Location = new Point(0, 0);
            pnlUst.Name = "pnlUst";
            pnlUst.Size = new Size(1200, 50);
            pnlUst.TabIndex = 0;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.Font = new Font("Optima", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            scoreLabel.ForeColor = Color.FromArgb(192, 0, 0);
            scoreLabel.Location = new Point(863, 14);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(102, 24);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "Skor: 1000";
            // 
            // waveLabel
            // 
            waveLabel.AutoSize = true;
            waveLabel.BackColor = Color.Transparent;
            waveLabel.Font = new Font("Optima", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            waveLabel.ForeColor = Color.Cyan;
            waveLabel.Location = new Point(612, 14);
            waveLabel.Name = "waveLabel";
            waveLabel.Size = new Size(109, 24);
            waveLabel.TabIndex = 2;
            waveLabel.Text = "Dalga: 1/10";
            // 
            // hpLabel
            // 
            hpLabel.AutoSize = true;
            hpLabel.BackColor = Color.Transparent;
            hpLabel.Font = new Font("Optima", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            hpLabel.ForeColor = Color.FromArgb(0, 192, 0);
            hpLabel.Location = new Point(405, 14);
            hpLabel.Name = "hpLabel";
            hpLabel.Size = new Size(86, 24);
            hpLabel.TabIndex = 1;
            hpLabel.Text = "Can: 100";
            // 
            // coinLabel
            // 
            coinLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            coinLabel.AutoSize = true;
            coinLabel.BackColor = Color.Transparent;
            coinLabel.Font = new Font("Optima", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            coinLabel.ForeColor = Color.Yellow;
            coinLabel.Location = new Point(183, 14);
            coinLabel.Name = "coinLabel";
            coinLabel.Size = new Size(84, 24);
            coinLabel.TabIndex = 0;
            coinLabel.Text = "Altın: 10";
            // 
            // pnlAlt
            // 
            pnlAlt.BackColor = Color.FromArgb(45, 30, 75);
            pnlAlt.BackgroundImage = Properties.Resources.altBar3;
            pnlAlt.Controls.Add(pnlBuyucu);
            pnlAlt.Controls.Add(pnlTopcu);
            pnlAlt.Controls.Add(pnlOkcu);
            pnlAlt.Controls.Add(pictureBox3);
            pnlAlt.Controls.Add(pictureBox2);
            pnlAlt.Controls.Add(pictureBox1);
            pnlAlt.Controls.Add(label4);
            pnlAlt.Controls.Add(label3);
            pnlAlt.Controls.Add(label7);
            pnlAlt.Controls.Add(label6);
            pnlAlt.Controls.Add(label5);
            pnlAlt.Controls.Add(label2);
            pnlAlt.Controls.Add(btnBuyucu);
            pnlAlt.Controls.Add(btnTopcu);
            pnlAlt.Controls.Add(btnOkcu);
            pnlAlt.Dock = DockStyle.Bottom;
            pnlAlt.Location = new Point(0, 603);
            pnlAlt.Name = "pnlAlt";
            pnlAlt.Size = new Size(1200, 100);
            pnlAlt.TabIndex = 1;
            // 
            // pnlBuyucu
            // 
            pnlBuyucu.BackColor = Color.Gold;
            pnlBuyucu.Location = new Point(1100, 40);
            pnlBuyucu.Name = "pnlBuyucu";
            pnlBuyucu.Size = new Size(20, 20);
            pnlBuyucu.TabIndex = 5;
            // 
            // pnlTopcu
            // 
            pnlTopcu.BackColor = Color.Gold;
            pnlTopcu.Location = new Point(701, 40);
            pnlTopcu.Name = "pnlTopcu";
            pnlTopcu.Size = new Size(20, 20);
            pnlTopcu.TabIndex = 5;
            // 
            // pnlOkcu
            // 
            pnlOkcu.BackColor = Color.Gold;
            pnlOkcu.Location = new Point(279, 40);
            pnlOkcu.Name = "pnlOkcu";
            pnlOkcu.Size = new Size(20, 20);
            pnlOkcu.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.buyucuKulebtn;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Location = new Point(816, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 80);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.MouseClick += btnBuyucu_MouseClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.topcuKulebtn;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(408, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.MouseClick += btnTopcu_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.okcuKulebtn2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(8, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += btnOkcu_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Optima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(902, 10);
            label4.Name = "label4";
            label4.Size = new Size(159, 28);
            label4.TabIndex = 3;
            label4.Text = "Büyücü Kulesi";
            label4.MouseClick += btnBuyucu_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Optima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(494, 10);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 3;
            label3.Text = "Topçu Kulesi";
            label3.MouseClick += btnTopcu_MouseClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Optima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Gold;
            label7.Location = new Point(902, 56);
            label7.Name = "label7";
            label7.Size = new Size(125, 34);
            label7.TabIndex = 3;
            label7.Text = "200 Altın";
            label7.MouseClick += btnBuyucu_MouseClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Optima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(494, 56);
            label6.Name = "label6";
            label6.Size = new Size(125, 34);
            label6.TabIndex = 3;
            label6.Text = "250 Altın";
            label6.MouseClick += btnTopcu_MouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Optima", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(94, 56);
            label5.Name = "label5";
            label5.Size = new Size(125, 34);
            label5.TabIndex = 3;
            label5.Text = "100 Altın";
            label5.MouseClick += btnOkcu_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Optima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(94, 10);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 3;
            label2.Text = "Okçu Kulesi";
            label2.MouseClick += btnOkcu_MouseClick;
            // 
            // btnBuyucu
            // 
            btnBuyucu.BackColor = Color.Transparent;
            btnBuyucu.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuyucu.Cursor = Cursors.Hand;
            btnBuyucu.FlatAppearance.BorderSize = 0;
            btnBuyucu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuyucu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuyucu.FlatStyle = FlatStyle.Flat;
            btnBuyucu.Font = new Font("Optima", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBuyucu.Location = new Point(816, 10);
            btnBuyucu.Name = "btnBuyucu";
            btnBuyucu.Size = new Size(400, 80);
            btnBuyucu.TabIndex = 2;
            btnBuyucu.UseVisualStyleBackColor = false;
            btnBuyucu.MouseClick += btnBuyucu_MouseClick;
            // 
            // btnTopcu
            // 
            btnTopcu.BackColor = Color.Transparent;
            btnTopcu.BackgroundImageLayout = ImageLayout.Stretch;
            btnTopcu.Cursor = Cursors.Hand;
            btnTopcu.FlatAppearance.BorderSize = 0;
            btnTopcu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTopcu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTopcu.FlatStyle = FlatStyle.Flat;
            btnTopcu.Font = new Font("Optima", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTopcu.Location = new Point(408, 10);
            btnTopcu.Name = "btnTopcu";
            btnTopcu.Size = new Size(400, 80);
            btnTopcu.TabIndex = 1;
            btnTopcu.UseVisualStyleBackColor = false;
            btnTopcu.MouseClick += btnTopcu_MouseClick;
            // 
            // btnOkcu
            // 
            btnOkcu.BackColor = Color.Transparent;
            btnOkcu.BackgroundImageLayout = ImageLayout.Zoom;
            btnOkcu.Cursor = Cursors.Hand;
            btnOkcu.FlatAppearance.BorderSize = 0;
            btnOkcu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOkcu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOkcu.FlatStyle = FlatStyle.Flat;
            btnOkcu.Font = new Font("Optima", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOkcu.ImageAlign = ContentAlignment.MiddleLeft;
            btnOkcu.Location = new Point(8, 10);
            btnOkcu.Name = "btnOkcu";
            btnOkcu.Size = new Size(400, 80);
            btnOkcu.TabIndex = 0;
            btnOkcu.UseVisualStyleBackColor = false;
            btnOkcu.MouseClick += btnOkcu_MouseClick;
            // 
            // pnlOyunAlani
            // 
            pnlOyunAlani.BackColor = Color.FromArgb(20, 15, 40);
            pnlOyunAlani.BackgroundImage = Properties.Resources.arkaPlan2;
            pnlOyunAlani.Controls.Add(pnlOyunBitti);
            pnlOyunAlani.Controls.Add(pnlDevam);
            pnlOyunAlani.Dock = DockStyle.Fill;
            pnlOyunAlani.Location = new Point(0, 0);
            pnlOyunAlani.Name = "pnlOyunAlani";
            pnlOyunAlani.Size = new Size(1200, 703);
            pnlOyunAlani.TabIndex = 2;
            pnlOyunAlani.Paint += pnlOyunAlani_Paint;
            pnlOyunAlani.MouseClick += pnlOyunAlani_MouseClick;
            pnlOyunAlani.MouseMove += pnlOyunAlani_MouseMove;
            // 
            // pnlDevam
            // 
            pnlDevam.BackColor = Color.FromArgb(45, 30, 75);
            pnlDevam.BackgroundImage = Properties.Resources.kutuArka;
            pnlDevam.BackgroundImageLayout = ImageLayout.Center;
            pnlDevam.BorderStyle = BorderStyle.FixedSingle;
            pnlDevam.Controls.Add(panelDalga);
            pnlDevam.Controls.Add(panelAltin);
            pnlDevam.Controls.Add(panelSkor);
            pnlDevam.Controls.Add(btnSonraki);
            pnlDevam.Controls.Add(label1);
            pnlDevam.Location = new Point(350, 150);
            pnlDevam.Name = "pnlDevam";
            pnlDevam.Size = new Size(500, 350);
            pnlDevam.TabIndex = 0;
            // 
            // pnlOyunBitti
            // 
            pnlOyunBitti.BackColor = Color.FromArgb(45, 30, 75);
            pnlOyunBitti.BackgroundImage = Properties.Resources.kutuArka;
            pnlOyunBitti.BackgroundImageLayout = ImageLayout.Center;
            pnlOyunBitti.BorderStyle = BorderStyle.FixedSingle;
            pnlOyunBitti.Controls.Add(skorSon);
            pnlOyunBitti.Controls.Add(restartButton);
            pnlOyunBitti.Controls.Add(label11);
            pnlOyunBitti.Location = new Point(347, 151);
            pnlOyunBitti.Name = "pnlOyunBitti";
            pnlOyunBitti.Size = new Size(500, 350);
            pnlOyunBitti.TabIndex = 3;
            // 
            // skorSon
            // 
            skorSon.AutoSize = true;
            skorSon.BackColor = Color.Transparent;
            skorSon.Font = new Font("Optima", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            skorSon.ForeColor = Color.FromArgb(192, 0, 0);
            skorSon.Location = new Point(209, 148);
            skorSon.Name = "skorSon";
            skorSon.Size = new Size(92, 24);
            skorSon.TabIndex = 2;
            skorSon.Text = "Skor: xxx";
            // 
            // restartButton
            // 
            restartButton.BackColor = Color.Transparent;
            restartButton.Cursor = Cursors.Hand;
            restartButton.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            restartButton.FlatStyle = FlatStyle.Flat;
            restartButton.Font = new Font("Optima", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            restartButton.ForeColor = Color.AliceBlue;
            restartButton.Location = new Point(187, 250);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(125, 50);
            restartButton.TabIndex = 1;
            restartButton.Text = "TEKRAR DENE";
            restartButton.UseVisualStyleBackColor = false;
            restartButton.Click += restartButton_Click;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Optima", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.AliceBlue;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(498, 93);
            label11.TabIndex = 0;
            label11.Text = "OYUN BİTTİ";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDalga
            // 
            panelDalga.AutoSize = true;
            panelDalga.BackColor = Color.Transparent;
            panelDalga.Font = new Font("Optima", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panelDalga.ForeColor = Color.Cyan;
            panelDalga.Location = new Point(166, 182);
            panelDalga.Name = "panelDalga";
            panelDalga.Size = new Size(172, 24);
            panelDalga.TabIndex = 2;
            panelDalga.Text = "Sıradaki Dalga: xx";
            // 
            // panelAltin
            // 
            panelAltin.AutoSize = true;
            panelAltin.BackColor = Color.Transparent;
            panelAltin.Font = new Font("Optima", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panelAltin.ForeColor = Color.Yellow;
            panelAltin.Location = new Point(170, 137);
            panelAltin.Name = "panelAltin";
            panelAltin.Size = new Size(168, 24);
            panelAltin.TabIndex = 2;
            panelAltin.Text = "Mevcut Altın: xxx";
            // 
            // panelSkor
            // 
            panelSkor.AutoSize = true;
            panelSkor.BackColor = Color.Transparent;
            panelSkor.Font = new Font("Optima", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panelSkor.ForeColor = Color.FromArgb(192, 0, 0);
            panelSkor.Location = new Point(170, 93);
            panelSkor.Name = "panelSkor";
            panelSkor.Size = new Size(166, 24);
            panelSkor.TabIndex = 2;
            panelSkor.Text = "Mevcut Skor: xxx";
            // 
            // btnSonraki
            // 
            btnSonraki.BackColor = Color.Transparent;
            btnSonraki.Cursor = Cursors.Hand;
            btnSonraki.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnSonraki.FlatStyle = FlatStyle.Flat;
            btnSonraki.Font = new Font("Optima", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSonraki.ForeColor = Color.AliceBlue;
            btnSonraki.Location = new Point(187, 250);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(125, 50);
            btnSonraki.TabIndex = 1;
            btnSonraki.Text = "DEVAM ET";
            btnSonraki.UseVisualStyleBackColor = false;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Optima", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(498, 93);
            label1.TabIndex = 0;
            label1.Text = "DALGA TAMAMLANDI!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1200, 703);
            Controls.Add(pnlAlt);
            Controls.Add(pnlUst);
            Controls.Add(pnlOyunAlani);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Neon Defense";
            Load += Form1_Load;
            pnlUst.ResumeLayout(false);
            pnlUst.PerformLayout();
            pnlAlt.ResumeLayout(false);
            pnlAlt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlOyunAlani.ResumeLayout(false);
            pnlDevam.ResumeLayout(false);
            pnlDevam.PerformLayout();
            pnlOyunBitti.ResumeLayout(false);
            pnlOyunBitti.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUst;
        private Panel pnlAlt;
        private Panel pnlOyunAlani;
        private Label coinLabel;
        private Label hpLabel;
        private Label scoreLabel;
        private Label waveLabel;
        private Button btnOkcu;
        private Button btnBuyucu;
        private Button btnTopcu;
        private Panel pnlDevam;
        private Button btnSonraki;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel pnlBuyucu;
        private Panel pnlTopcu;
        private Panel pnlOkcu;
        private Label panelSkor;
        private Label panelDalga;
        private Label panelAltin;
        private Panel pnlOyunBitti;
        private Label label8;
        private Label label9;
        private Label skorSon;
        private Button restartButton;
        private Label label11;
    }
}
