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
                    MessageBox.Show("Giri� hakk�n�z kalmad�. Hesab�n�z bloke edildi.");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Yanl�� kullan�c� ad� veya �ifre. " + Access + " deneme hakk�n�z kald�.");
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Anasayfa anaSayfa = new Anasayfa();
        }
    }
}
