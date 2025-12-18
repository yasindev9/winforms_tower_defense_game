namespace NdpOdev_TowerDefence
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Optima", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(782, 103);
            label1.TabIndex = 0;
            label1.Text = "NEON DEFENSE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 255, 128, 255);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 20, 15, 30);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Optima", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(0, 254);
            button1.Name = "button1";
            button1.Size = new Size(782, 99);
            button1.TabIndex = 1;
            button1.Text = "Emegi Geçenler";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 255, 128, 255);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 20, 15, 30);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Optima", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.AliceBlue;
            button2.Location = new Point(0, 155);
            button2.Name = "button2";
            button2.Size = new Size(782, 99);
            button2.TabIndex = 2;
            button2.Text = "OYNA";
            button2.UseVisualStyleBackColor = false;
            button2.MouseClick += button1_MouseClick;
            // 
            // FormMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(20, 15, 40);
            BackgroundImage = Properties.Resources.anamenuarka;
            ClientSize = new Size(782, 353);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NEON DEFENSE";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}