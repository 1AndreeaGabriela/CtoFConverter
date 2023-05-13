using System.Security.Cryptography.X509Certificates;

namespace CtoFConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                String c, f;
                c = textBox1.Text;
                f = textBox2.Text;

                int ci = int.Parse(c);
                double calc = ci * 9 / 5 + 32;

                textBox2.Text = calc.ToString();




            }
            catch (Exception) { MessageBox.Show("TRY AGAIN!"); }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = " ";
        }
    }
}