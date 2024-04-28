using System.Text;

namespace CIprj_April2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Author: Mohammad Kiani Sheikhabadi

        //Description: This function generates random words.
        public void button1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputText = textBox2.Text;

            bool hasRepeatedLetters = inputText.GroupBy(c => c).Any(g => g.Count() > 1);

            label5.Text = hasRepeatedLetters.ToString();
        }
    }
}