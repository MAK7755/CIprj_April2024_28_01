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
        public void Button2_Click_ChecksForRepeatedLetters()
        {
            Form1 form = new Form1();
            form.textBox2.Text = "TestString"; 
            form.button2_Click(null, null);
            Assert.AreEqual("True", form.label5.Text); 
        }
    }
}
