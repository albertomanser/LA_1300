using System.CodeDom;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string cord;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            cord = textBox1.Text;
            if (cord == "1A")
            {
                pictureBox1.Visible= true;
            }
            if (cord == "2A")
            {
                pictureBox2.Visible = true;
            }
            if (cord == "3A")
            {
                pictureBox3.Visible = true;
            }
            if (cord == "4A")
            {
                pictureBox4.Visible = true;
            }
            if (cord == "4C")
            {
                pictureBox5.Visible = true;
            }
            if (cord == "3C")
            {
                pictureBox6.Visible = true;
            }
            if (cord == "2C")
            {
                pictureBox7.Visible = true;
            }
            if (cord == "1C")
            {
                pictureBox8.Visible = true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}