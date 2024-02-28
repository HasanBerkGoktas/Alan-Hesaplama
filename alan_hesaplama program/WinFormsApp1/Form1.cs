namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tabPageka.Show();
            tabPage1.Hide();
            radioButton1.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tabPaged.Show();
            tabPage1.Hide();
            radioButton3.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tabPageu.Show();
            tabPage1.Hide();
            radioButton2.Checked = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tabPagek.Show();
            tabPage1.Hide();
            radioButton4.Checked = false;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            geribt();
            tbtemizleme();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            geribt();
            tbtemizleme();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            geribt();
            tbtemizleme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            geribt();
            tbtemizleme();
        }

        public void tbtemizleme()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        public void geribt()
        {
            tabPage1.Show();
            tabPageka.Hide();
            tabPagek.Hide();
            tabPageu.Hide();
            tabPaged.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hesaplama islem = new Hesaplama();
            int kenar = Int32.Parse(textBox4.Text);
            double sonuc = islem.kupalan(kenar);
            label9.Text = sonuc.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hesaplama islem = new Hesaplama();
            int kenar = Int32.Parse(textBox1.Text);
            double sonuc = islem.karealan(kenar);
            label10.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hesaplama islem = new Hesaplama();
            int taban = Int32.Parse(textBox5.Text);
            int yukseklik = Int32.Parse(textBox2.Text);
            double sonuc = islem.ucgenalan(taban, yukseklik);
            label11.Text = sonuc.ToString();
        }


    }
}