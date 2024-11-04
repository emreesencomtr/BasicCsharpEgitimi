namespace AracKullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Emre";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "Emre";
            label6.Text = "Esen";
            label8.Text = "Software Developer";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Software Developer";
            //label9.Text = textBox1.Text;
            textBox1.Text = "Emre";
            textBox2.Text = "Esen";
            textBox3.Text = "Software Developer";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
