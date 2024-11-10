using NUnit.Framework;

namespace Tests_April2024
{
    [TestFixture]
    public class Form1Test
    {

        //Author: Mohammad Kiani Sheikhabadi

        /*Description: This function checks if the string created
         by the RandomString method has a correct lenght.*/

        [Test]

        public void correctLenght()
        {
            Form1 form = new Form1();
            int length = 6;
            string result = form.RandomString(length);
            Assert.Equals(length, result.Length);
        }
    }
}