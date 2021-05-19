using NUnit.Framework;
using MorzeDecode;

namespace MorzeTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestSuccessCase()
        {
            string[] morzeArray = { ".- -... -.-.  .---- ..--- ...--", ".... . .-.. .-.. ---  .-- --- .-. .-.. -.." };
            foreach (string morzeText in morzeArray)
            {
                Morze.Decode(morzeText);
            }
        }

        [Test]
        public void TestErrorCase()
        {
            string morzeText = "*";
            Assert.AreEqual(morzeText, "Hello World");
        }

        [TestCase(".- -... -.-.  .---- ..--- ...--")]
        public void TestAttributesCase(string morzeText)
        {
            Morze.Decode(morzeText);
        }
    }
}