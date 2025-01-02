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
    public partial class ParaYatir : Form
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

        public ParaYatir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Girdiğiniz miktar hesabınıza yatırıldı.");
            this.Hide();
            AnaSayfaInstance.Show();
            int plusBalance = Convert.ToInt32(maskedTextBox1.Text);
            Account.Balance += plusBalance;
        }

        private void ParaYatir_Load(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(Account.Balance);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfaInstance.Show();
        }
    }

}
