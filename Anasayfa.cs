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
    public partial class Anasayfa : Form
    {
        private Login login;

        public Login loginInstance
        {
            get
            {
                if (login == null || login.IsDisposed)
                    login = new Login();
                return login;
            }
        }

        private string UserName = "Serhet Gökdemir";

        ParaYatir paraYatir = new ParaYatir();
        ParaCek paraCek = new ParaCek();

        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            UpdateBalance();
            label1.Text = "Hoşgeldiniz, Sayın " + UserName;
        }

        private void byatir_CheckedChanged(object sender, EventArgs e)
        {
            paraYatir.Show();
            this.Hide();
        }

        private void bcek_CheckedChanged(object sender, EventArgs e)
        {
            paraCek.Show();
            this.Hide();
        }

        private void bodeme_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bekleyen Ödemeniz Bulunmamaktadır.");
        }

        private void bbasvuru_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bekleyen Başvurunuz Bulunmamaktadır.");
        }

        private void bmusteri_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bankamız En Kısa Sürede Sizinle Telefon Üzerinden İletişime Geçecektir.");
        }
        public void UpdateBalance()
        {
            label3.Text = Convert.ToString(Account.Balance);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            UpdateBalance();
        }

        private void bcikis_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış Yapılıyor...%");
            this.Hide();
            loginInstance.Show();
            MessageBox.Show("Başarıyla Çıkış Yapıldı.");
        }
    }

    public static class Account
    {
        private static decimal balance = 20000;
        public static decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
