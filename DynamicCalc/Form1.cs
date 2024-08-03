using System.Data;

namespace DynamicCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Buttons_Clicked(object sender, EventArgs e)
        {


        }
        private void Allbtns_Clicked(object sender, EventArgs e)
        {

        }
        private void Allbutns_Clicked(object sender, EventArgs e)
        {

        }
        private void btnEqual_Clicked(object sender, EventArgs e)
        {

        }






        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtScreen.Clear();
        }


        private void AllButtons(object sender, EventArgs e)
        {
            Button button = sender as Button;

            TxtScreen.AppendText(button.Text);

        }

        private void EquiButton(object sender, EventArgs e)
        {
            try
            {

                DataTable table = new DataTable();
                var result = table.Compute(TxtScreen.Text, string.Empty);
                TxtScreen.Text = result.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Expression", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
