namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "+";
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            Calc c1 = new Calc();
            label1.Text ="= " + c1.Add(x, y).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int s = 1;
            textBox1.Text += s.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = 2;
            textBox2.Text += a.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "-";
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox1.Text);
            Calc c1 = new Calc();
            label1.Text ="= "+ c1.Subtract(x, y).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "*";
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            Calc c1 = new Calc();
            label1.Text ="= "+ c1.Multiply(x, y).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "/";
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            Calc c1 = new Calc();
            label1.Text ="= "+ c1.Divide(x, y).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = 3;
            textBox2.Text += a.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a = 4;
            textBox2.Text += a.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = 5;
            textBox2.Text += a.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a = 6;
            textBox2.Text += a.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int a = 7;
            textBox2.Text += a.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int a = 8;
            textBox2.Text += a.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a = 9;
            textBox2.Text += a.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int a = 0;
            textBox2.Text += a.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int index = 14;
            string k = "";
            string[] calc = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "+", "-", "*", "/" };
            for (int i = 1; i <= index;i++)
            if (calc[i] == "+")
            {
                    textBox2.Text = calc[i];
            }


        }
    }
}
