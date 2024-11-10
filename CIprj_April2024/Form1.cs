using System.Text;

namespace CIprj_April2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        //Author: Mohammad Kiani Sheikhabadi

        //Description: This function generates random words.
        public void button1_Click(object sender, EventArgs e)
        {
            int lenght = (int)numericUpDown1.Value;
            string randomString = RandomString(lenght);
            textBox1.Text = randomString;
        }

        public string RandomString(int lenght)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string result = "";
            Random random = new Random();
            for(int i = 0; i < lenght; i++)
            {
                int randomIndex = random.Next(chars.Length);
                char randomChar = chars[randomIndex];
                result += randomChar;
            }
            return result;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /*Description: This function returns True/False if there is/isn't
        repeated letters in the given text.*/
        private void button2_Click(object sender, EventArgs e)
        {
            string inputText = textBox2.Text;

            bool hasRepeatedLetters = inputText.GroupBy(c => c).Any(g => g.Count() > 1);

            label5.Text = hasRepeatedLetters.ToString();
        }
    }
}
