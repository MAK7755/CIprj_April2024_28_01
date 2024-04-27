using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_April2024
{
    [TestFixture]
    public class Form1Tests
    {
        [Test]
        public void Button1_Click_GeneratesRandomStringInTextBox()
        {
            Form1 form = new Form1();
            form.numericUpDown1.Value = 10; 
            form.button1_Click(null, null);
            Assert.IsFalse(string.IsNullOrEmpty(form.textBox1.Text));
        }
    }
}
