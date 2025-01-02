namespace TRBank
{
    
    public partial class Login : Form
    {
        private int UserName = 0000;
        private int Password = 0000;
        private int Access = 3;

        Anasayfa anaSayfa = new Anasayfa();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(maskedTextBox1.Text)== 0000 && Convert.ToInt32(maskedTextBox2.Text) == 0000)
            {
                anaSayfa.Show();
                this.Hide();
                
            }
            else
            {
                Access--;
                if (Access == 0)
                {
                    MessageBox.Show("Giriþ hakkýnýz kalmadý. Hesabýnýz bloke edildi.");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Yanlýþ kullanýcý adý veya þifre. " + Access + " deneme hakkýnýz kaldý.");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Anasayfa anaSayfa = new Anasayfa();
        }
    }
}
