namespace DynamicCalculator
{
    public partial class Form1 : Form
    {
        public double Num { get; set; }

        public string Operator { get; set; }

        public Form1()
        {
            InitializeComponent();
            //TxtScreen.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {


        }
        private void button9_Click_1(object sender, EventArgs e)
        {

        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {

        }

        private void AllButtons_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }










        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtScreen.Clear();
        }



        private void AllBtns_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                TxtScreen.AppendText(button.Text);
            }
        }
    }
}
