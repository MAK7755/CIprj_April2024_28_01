﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_April2024
{
    [TestFixture]
    public class Form1_Tests
    {
        //Author: Mohammad Kiani Sheikhabadi

        /*Description: This function checks if button2_Click method 
         is working properly*/
        [Test]
        public void Button2_Click_Check()
        {
            Form1 form = new Form1();
            form.textBox2.Text = "TestString"; 
            form.button2_Click(null, null);
            Assert.Equal("True", form.label5.Text); 
        }
    }
}
