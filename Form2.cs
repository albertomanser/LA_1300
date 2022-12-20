namespace Schiffeversenki
{
    public partial class Form2 : Form
    {
        public Form1 parent;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            parent = form1;

            label4.Visible = false;
            button3.Visible = false;

            this.Show();
            form1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = true;

            button1.Visible = false;
            button2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button3.Visible = true;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label4.Visible = false;
        }
    }
}
