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

    // Ensure the string has no repeated letters
    bool repeated = generated.Distinct().Count() != generated.Length;
    Assert.False(repeated, "The text should not have any repeated letters...");

    // Set the generated string in textBox2 for the button2_Click to check
    form.textBox2.Text = generated;  
    form.button2_Click(null, EventArgs.Empty);  

    // Ensure label5 indicates no repeated letters
    repeated = bool.Parse(form.label5.Text);
    Assert.False(repeated, "The text should not have any repeated letters...");
}

    }
}
