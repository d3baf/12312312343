namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1 = 0;
        double num2 = 0;
        double num3 = 0;
        bool isOperat = false;
        private string operate;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isOperat == false)
                numder(ref num1, sender, textBox1);

            else
                numder(ref num2, sender, textBox2);

        }

        private void numder(ref double num, object sender, TextBox textBox)
        {
            num1 *= 10;
            num1 += double.Parse(((Button)sender).Text);
            textBox1.Text = num.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            isOperat = true;
            operate = ((Button)sender).Text;
        }




        private void button13_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operate)
            {
                case "+": num3 = num1 + num2; break;
                case "-": num3 = num1 - num2; break;
                case "*": num3 = num1 * num2; break;
                case "/": num3 = num1 / num2; break;
            }
            textBox3.Text = num3.ToString();
        }
    }
}
