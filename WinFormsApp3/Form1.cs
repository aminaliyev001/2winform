namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm");
            button1.Image = Properties.Resources.Palace_of_the_Shirvanshahs_Baku_Flame_Towers_Icherisheher_Baku_Azerbaijan;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DateTime utcNow = DateTime.UtcNow;
            DateTime londonsaat = utcNow.AddHours(1);
            label2.Text = londonsaat.ToString("HH:mm");
            button1.Image = Properties.Resources.london;
        }
    }
}