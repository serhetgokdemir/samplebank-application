namespace TRBank
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bcek = new CheckBox();
            bmusteri = new CheckBox();
            bodeme = new CheckBox();
            bbasvuru = new CheckBox();
            bcikis = new CheckBox();
            byatir = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(475, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 157);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(407, 289);
            label1.Name = "label1";
            label1.Size = new Size(345, 31);
            label1.TabIndex = 9;
            label1.Text = "Hoşgeldiniz, Sayın ............................";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(494, 340);
            label2.Name = "label2";
            label2.Size = new Size(113, 31);
            label2.TabIndex = 10;
            label2.Text = "Bakiyeniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(599, 340);
            label3.Name = "label3";
            label3.Size = new Size(26, 31);
            label3.TabIndex = 11;
            label3.Text = "0";
            // 
            // bcek
            // 
            bcek.AutoSize = true;
            bcek.BackColor = SystemColors.ActiveCaption;
            bcek.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bcek.Location = new Point(952, 170);
            bcek.Name = "bcek";
            bcek.Size = new Size(197, 58);
            bcek.TabIndex = 12;
            bcek.Text = "Para Çek";
            bcek.UseVisualStyleBackColor = false;
            bcek.CheckedChanged += bcek_CheckedChanged;
            // 
            // bmusteri
            // 
            bmusteri.AutoSize = true;
            bmusteri.BackColor = SystemColors.ActiveCaption;
            bmusteri.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bmusteri.Location = new Point(12, 440);
            bmusteri.Name = "bmusteri";
            bmusteri.Size = new Size(371, 58);
            bmusteri.TabIndex = 14;
            bmusteri.Text = "Müşteri Hizmetleri";
            bmusteri.UseVisualStyleBackColor = false;
            bmusteri.CheckedChanged += bmusteri_CheckedChanged;
            // 
            // bodeme
            // 
            bodeme.AutoSize = true;
            bodeme.BackColor = SystemColors.ActiveCaption;
            bodeme.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bodeme.Location = new Point(12, 305);
            bodeme.Name = "bodeme";
            bodeme.Size = new Size(264, 58);
            bodeme.TabIndex = 15;
            bodeme.Text = "Ödemelerim";
            bodeme.UseVisualStyleBackColor = false;
            bodeme.CheckedChanged += bodeme_CheckedChanged;
            // 
            // bbasvuru
            // 
            bbasvuru.AutoSize = true;
            bbasvuru.BackColor = SystemColors.ActiveCaption;
            bbasvuru.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bbasvuru.Location = new Point(877, 305);
            bbasvuru.Name = "bbasvuru";
            bbasvuru.Size = new Size(272, 58);
            bbasvuru.TabIndex = 16;
            bbasvuru.Text = "Başvurularım";
            bbasvuru.UseVisualStyleBackColor = false;
            bbasvuru.CheckedChanged += bbasvuru_CheckedChanged;
            // 
            // bcikis
            // 
            bcikis.AutoSize = true;
            bcikis.BackColor = SystemColors.ActiveCaption;
            bcikis.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            bcikis.Location = new Point(952, 440);
            bcikis.Name = "bcikis";
            bcikis.Size = new Size(200, 58);
            bcikis.TabIndex = 17;
            bcikis.Text = "Çıkış Yap";
            bcikis.UseVisualStyleBackColor = false;
            bcikis.CheckedChanged += bcikis_CheckedChanged;
            // 
            // byatir
            // 
            byatir.AutoSize = true;
            byatir.BackColor = SystemColors.ActiveCaption;
            byatir.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            byatir.Location = new Point(12, 170);
            byatir.Name = "byatir";
            byatir.Size = new Size(207, 58);
            byatir.TabIndex = 18;
            byatir.Text = "Para Yatır";
            byatir.UseVisualStyleBackColor = false;
            byatir.CheckedChanged += byatir_CheckedChanged;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1161, 686);
            Controls.Add(byatir);
            Controls.Add(bcikis);
            Controls.Add(bbasvuru);
            Controls.Add(bodeme);
            Controls.Add(bmusteri);
            Controls.Add(bcek);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 13.8F);
            Margin = new Padding(4);
            Name = "Anasayfa";
            Text = "Anasayfa";
            Load += Anasayfa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox bcek;
        private CheckBox bmusteri;
        private CheckBox bodeme;
        private CheckBox bbasvuru;
        private CheckBox bcikis;
        private CheckBox byatir;
    }
}