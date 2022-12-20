namespace Schiff_versenken
{

    public partial class Form1 : Form
    {
        
        public string username;
        public int points;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible=false;
            label1.Visible= false;
            label2.Visible= true;
            textBox1.Visible= true;
            textBox2.Visible= true;
            label3.Visible= true;
            label4.Visible= true;
            button2.Visible = true;
            button3.Visible = true;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string spieler1;
            string spieler2;
            spieler1 = textBox1.Text;
            spieler2 = textBox2.Text;
            button2.Visible = false;
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Im Schiff versenken geht es darum, dass man durch Kooridnateneingabe des Feldes vom Gegner, die darauf schwimmende Schiffe abschiesst.");
        }
    }
}