using Algorithm;
using System.Security.Cryptography;



namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        private AlgorithmBase<int> algorithm = new BubbleSort<int>();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                algorithm.Items.Add(value);
                label1.Text += " " + value;
            }
            textBox2.Text = "";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            algorithm.Sort();
            foreach (var item in algorithm.Items)
            {
                label2.ResetText();
                label2.Text += " | " + item;
            }
            algorithm.Sort();
            foreach (var item in algorithm.Items)
            {
                label3.Text += " | " + item;

            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);

            button2_Click_1(sender, e);

        }

    }
}