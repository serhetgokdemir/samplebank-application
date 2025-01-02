namespace TRBank
{
    partial class ParaYatir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaYatir));
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(429, 151);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(319, 38);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(519, 102);
            label2.Name = "label2";
            label2.Size = new Size(113, 31);
            label2.TabIndex = 12;
            label2.Text = "Bakiyeniz:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(374, 206);
            label1.Name = "label1";
            label1.Size = new Size(432, 31);
            label1.TabIndex = 14;
            label1.Text = "Lütfen Yatırmak İstediğiniz Miktarı Giriniz";
            // 
            // button1
            // 
            button1.Location = new Point(429, 282);
            button1.Name = "button1";
            button1.Size = new Size(117, 43);
            button1.TabIndex = 15;
            button1.Text = "Yatır";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(631, 282);
            button2.Name = "button2";
            button2.Size = new Size(117, 43);
            button2.TabIndex = 16;
            button2.Text = "Geri Dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(631, 102);
            label3.Name = "label3";
            label3.Size = new Size(26, 31);
            label3.TabIndex = 17;
            label3.Text = "0";
            // 
            // ParaYatir
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1161, 686);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(maskedTextBox1);
            Font = new Font("Segoe UI", 13.8F);
            Margin = new Padding(4);
            Name = "ParaYatir";
            Text = "ParaYatir";
            Load += ParaYatir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}