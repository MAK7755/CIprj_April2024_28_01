using NUnit.Framework;

namespace Tests_April2024
{
    [TestFixture]
    public class Form1Test
    {

        [Test]
        public void CorrectLength()
        {
            Form1 form = new Form1();
            int length = 10; 
            string result = form.RandomString(length);
            Assert.Equals(length, result.Length);
        }
    }
}