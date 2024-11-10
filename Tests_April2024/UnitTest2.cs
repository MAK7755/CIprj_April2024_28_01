using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_April2024
{
    public class Form1Tests
    {

        //Author: Mohammad Kiani Sheikhabadi

        /*Description: This function checks if button1_Click method is working 
         properly.*/

        [Fact]
        public void Button1_Click_Check()
        {
            Form1 form = new Form1();
            form.numericUpDown1.Value = 10; 
            form.button1_Click(null, null);
            Assert.False(string.IsNullOrEmpty(form.textBox1.Text));
        }
    }
}
