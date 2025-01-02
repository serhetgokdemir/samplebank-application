namespace TRBank
{
    partial class ParaCek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaCek));
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(630, 101);
            label3.Name = "label3";
            label3.Size = new Size(26, 31);
            label3.TabIndex = 23;
            label3.Text = "0";
            // 
            // button2
            // 
            button2.Location = new Point(630, 281);
            button2.Name = "button2";
            button2.Size = new Size(117, 43);
            button2.TabIndex = 22;
            button2.Text = "Geri Dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(428, 281);
            button1.Name = "button1";
            button1.Size = new Size(117, 43);
            button1.TabIndex = 21;
            button1.Text = "Çek";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(373, 205);
            label1.Name = "label1";
            label1.Size = new Size(424, 31);
            label1.TabIndex = 20;
            label1.Text = "Lütfen Çekmek İstediğiniz Miktarı Giriniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(518, 101);
            label2.Name = "label2";
            label2.Size = new Size(113, 31);
            label2.TabIndex = 19;
            label2.Text = "Bakiyeniz:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(428, 150);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(319, 38);
            maskedTextBox1.TabIndex = 18;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // ParaCek
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
            Name = "ParaCek";
            Text = "ParaCek";
            Load += ParaCek_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
    }
}