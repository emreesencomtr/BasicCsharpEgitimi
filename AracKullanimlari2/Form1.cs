namespace AracKullanimlari2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kastamonu");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Gedson");
            listBox1.Items.Add("Ali");
            listBox1.Items.Add("Veli");
            listBox1.Items.Add("K�rk");
            listBox1.Items.Add("Dokuz");
            listBox1.Items.Add("Elli");
            listBox1.Items.Add("Ay�ecik");
            listBox1.Items.Add("Fatmac�k");
            listBox1.Items.Add("C�k C�k");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }
    }
}
