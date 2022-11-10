using StudentServiceLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentTest
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void Score11_ReturnError()
        {
            Student s = new Student();

            s.Id = 2;
            s.Age = 12;
            s.Name = "Toan";
            s.Score = 11;
            char letter = s.getLetterScore();
            Assert.AreEqual("Score must not exeed 10.0", letter);
        }

        [TestMethod]
        public void Score10_ReturnA()
        {
            Student s = new Student();

            s.Id = 2;
            s.Age = 12;
            s.Name = "Toan";
            s.Score = 10;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Score96_ReturnA()
        {
            Student s = new Student();

            s.Id = 2;
            s.Age = 12;
            s.Name = "Toan";
            s.Score = 9.6;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Score8_ReturnA()
        {
            Student s = new Student();

            s.Id = 2;
            s.Age = 12;
            s.Name = "Toan";
            s.Score = 8.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Score7_ReturnB()
        {
            Student s = new Student();

            s.Id = 1;
            s.Age = 12;
            s.Name = "Toan";
            s.Score = 7;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Score65_ReturnC()
        {
            Student s = new Student();

            s.Id = 1;
            s.Age = 12;
            s.Name = "Toan";
            s.Score = 6.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void Score5_ReturnC()
        {
            Student s = new Student();

            s.Id = 1;
            s.Age = 12;
            s.Name = "Toan";
            s.Score = 5;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void Score35_ReturnD()
        {
            Student s = new Student();

            s.Id = 1;
            s.Age = 12;
            s.Name = "Toan";
            s.Score = 3.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void Score34_ReturnE()
        {
            Student s = new Student();

            s.Id = 1;
            s.Age = 12;
            s.Name = "Toan";
            s.Score = 3.4;
            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }
    }
}