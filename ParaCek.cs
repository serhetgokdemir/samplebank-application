using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRBank
{
    public partial class ParaCek : Form
    {
        private Anasayfa anaSayfa;

        public Anasayfa AnaSayfaInstance
        {
            get
            {
                if (anaSayfa == null || anaSayfa.IsDisposed)
                    anaSayfa = new Anasayfa();
                return anaSayfa;
            }
        }

        public ParaCek()
        {
            InitializeComponent();

        }

        private void ParaCek_Load(object sender, EventArgs e)
        {
            label3.Text = Account.Balance.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(maskedTextBox1.Text) > Account.Balance || Convert.ToInt32(maskedTextBox1.Text) <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz.");
            }
            else
            {
                MessageBox.Show("Talep ettiğiniz miktarı aşağıdaki bölmeden alınız...%");
                this.Hide();
                AnaSayfaInstance.Show();
                int minusBalance = Convert.ToInt32(maskedTextBox1.Text);
                Account.Balance -= minusBalance;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfaInstance.Show();
        }
    }
}
