namespace Schiffeversenki
{
    public partial class Form1 : Form
    {

        Point point1;
        public Form2 form2;
        public Form1()
        {
            InitializeComponent();

            form2 = new Form2(this);
            form2.Hide();

            point1 = new Point(629, 54);
            point1 = new Point(694, 54);
            point1 = new Point(771, 54);
            point1 = new Point(845, 54);
            point1 = new Point(911, 54);
            point1 = new Point(629, 123);
            point1 = new Point(700, 123);
            point1 = new Point(772, 123);
            point1 = new Point(846, 123);
            point1 = new Point(911, 123);
            point1 = new Point(629, 193);
            point1 = new Point(701, 193);
            point1 = new Point(771, 193);
            point1 = new Point(847, 193);
            point1 = new Point(921, 193);
            point1 = new Point(629, 265);
            point1 = new Point(702, 265);
            point1 = new Point(774, 265);
            point1 = new Point(849, 265);
            point1 = new Point(921, 265);
            point1 = new Point(629, 339);
            point1 = new Point(702, 339);
            point1 = new Point(771, 339);
            point1 = new Point(852, 339);
            point1 = new Point(921, 339);

            button1.Visible = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;   
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string Booteingabe = textBox1.Text;

            switch (Booteingabe)
            {
                case "A1":
                    label2.Location = new Point(629, 54);
                    break;
                case "A2":
                    label2.Location = new Point(694, 54);
                    break;
                case "A3":
                    label2.Location = new Point(771, 54);
                    break;
                case "A4":
                    label2.Location = new Point(845, 54);
                    break;
                case "A5":
                    label2.Location = new Point(911, 54);
                    break;
                case "B1":
                    label2.Location = new Point(629, 123);
                    break;
                case "B2":
                    label2.Location = new Point(700, 123);
                    break;
                case "B3":
                    label2.Location = new Point(772, 123);
                    break;
                case "B4":
                    label2.Location = new Point(846, 123);
                    break;
                case "B5":
                    label2.Location = new Point(911, 123);
                    break;
                case "C1":
                    label2.Location = new Point(629, 193);
                    break;
                case "C2":
                    label2.Location = new Point(701, 193);
                    break;
                case "C3":
                    label2.Location = new Point(771, 193);
                    break;
                case "C4":
                    label2.Location = new Point(847, 193);
                    break;
                case "C5":
                    label2.Location = new Point(921, 193);
                    break;
                case "D1":
                    label2.Location = new Point(629, 265);
                    break;
                case "D2":
                    label2.Location = new Point(702, 265);
                    break;
                case "D3":
                    label2.Location = new Point(774, 265);
                    break;
                case "D4":
                    label2.Location = new Point(849, 265);
                    break;
                case "D5":
                    label2.Location = new Point(921, 265);
                    break;
                case "E1":
                    label2.Location = new Point(629, 339);
                    break;
                case "E2":
                    label2.Location = new Point(702, 339);
                    break;
                case "E3":
                    label2.Location = new Point(771, 339);
                    break;
                case "E4":
                    label2.Location = new Point(852, 339);
                    break;
                case "E5":
                    label2.Location = new Point(921, 339);
                    break;


                    switch (Booteingabe)
                    {
                        case "A1":
                            label3.Location = new Point(629, 54);
                            break;
                        case "A2":
                            label3.Location = new Point(694, 54);
                            break;
                        case "A3":
                            label3.Location = new Point(771, 54);
                            break;
                        case "A4":
                            label3.Location = new Point(845, 54);
                            break;
                        case "A5":
                            label3.Location = new Point(911, 54);
                            break;
                        case "B1":
                            label3.Location = new Point(629, 123);
                            break;
                        case "B2":
                            label3.Location = new Point(700, 123);
                            break;
                        case "B3":
                            label3.Location = new Point(772, 123);
                            break;
                        case "B4":
                            label3.Location = new Point(846, 123);
                            break;
                        case "B5":
                            label3.Location = new Point(911, 123);
                            break;
                        case "C1":
                            label3.Location = new Point(629, 193);
                            break;
                        case "C2":
                            label3.Location = new Point(701, 193);
                            break;
                        case "C3":
                            label3.Location = new Point(771, 193);
                            break;
                        case "C4":
                            label3.Location = new Point(847, 193);
                            break;
                        case "C5":
                            label3.Location = new Point(921, 193);
                            break;
                        case "D1":
                            label3.Location = new Point(629, 265);
                            break;
                        case "D2":
                            label3.Location = new Point(702, 265);
                            break;
                        case "D3":
                            label3.Location = new Point(774, 265);
                            break;
                        case "D4":
                            label3.Location = new Point(849, 265);
                            break;
                        case "D5":
                            label3.Location = new Point(921, 265);
                            break;
                        case "E1":
                            label3.Location = new Point(629, 339);
                            break;
                        case "E2":
                            label3.Location = new Point(702, 339);
                            break;
                        case "E3":
                            label3.Location = new Point(771, 339);
                            break;
                        case "E4":
                            label3.Location = new Point(852, 339);
                            break;
                        case "E5":
                            label3.Location = new Point(921, 339);
                            break;
                    }
            }
        
               
            
                
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            
            button1.Visible = true;
            pictureBox1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            form2.Show();
            this.Hide();
        }
    }
}