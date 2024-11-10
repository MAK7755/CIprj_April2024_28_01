using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Xunit;
using CIprj_April2024;

namespace Tests_April2024
{

    public class IntegrationTest
    {
        //This test generates a random string of specified lenght, then sets the textBox2 input to this text and checks it for repeated letters.
        [Fact]
        public void Check()
        {
            var form = new Form1();
            int length = 10;  
            form.numericUpDown1.Value = length;

            // Triggers button1_Click to generate random string
            form.button1_Click(null, EventArgs.Empty);  

            // Retrieves the generated string from textBox1
            string generated = form.textBox1.Text;

            // Check that the generated string has the correct length
            Assert.Equal(length, generated.Length);

            // Use the generated string to check for repeated letters
            form.textBox2.Text = generated;  
            form.button2_Click(null, EventArgs.Empty);  

            bool repeated = bool.Parse(form.label5.Text);
            Assert.False(repeated, "The text should not have any repeated letters...");
        }
    }
}
