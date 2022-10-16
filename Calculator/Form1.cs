using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }

            Button button=(Button)sender;
            textBox1.Text = textBox1.Text+button.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string same=textBox1.Text;
            var result = new DataTable().Compute(same, null);
            textBox1.Text=result.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}