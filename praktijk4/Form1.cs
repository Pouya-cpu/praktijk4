namespace praktijk4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;

            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;

            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;

            button4.BackColor = Color.Red;
            button4.ForeColor = Color.White;


            this.BackColor = Color.DarkSlateGray;


            button4.Click += Button4_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
