using System.Data;
namespace Calc
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        //my lines

        private void button_Pressed(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;
            txtOutput.Text = currentCalculation;
        }

        private void button_Equals_Pressed(object sender, EventArgs e)
        {
            string formattedCalc = currentCalculation.ToString();
            try
            {
                txtOutput.Text = new DataTable().Compute(formattedCalc, null).ToString();
                currentCalculation = txtOutput.Text;
            }
            catch (Exception ex) 
            {
                txtOutput.Text = "FAIL";
                currentCalculation = "";
            }
        }

        private void button_Clear(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
            currentCalculation = "";
        }
        private void button_ClearEntry(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            { 
            //1+1
            currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }
            txtOutput.Text = currentCalculation;
        }
    }
}
