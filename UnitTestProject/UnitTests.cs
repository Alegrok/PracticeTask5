using Microsoft.VisualStudio.TestTools.UnitTesting;
using static PracticeTask5.Program;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod01()
        {
            int n = 1;
            double max = 100;
            double[,] array = new double[n, n];
            array[0, 0] = max;
            Assert.AreEqual(max, FindMax(array));
        }

        [TestMethod]
        public void TestMethod02()
        {
            int n = 4;
            double falseMax = 101;
            double[,] array = CreateMatrix(n);
            array[1, 0] = falseMax;
            bool check = falseMax == FindMax(array);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void TestMethod03()
        {
            int n = 4;
            double falseMax = 101;
            double[,] array = CreateMatrix(n);
            array[1, 3] = falseMax;
            bool check = falseMax == FindMax(array);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void TestMethod04()
        {
            int n = 4;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[0, 1] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod05()
        {
            int n = 4;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[3, 1] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod06()
        {
            int n = 4;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[0, 0] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod07()
        {
            int n = 4;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[0, n - 1] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod08()
        {
            int n = 4;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[n / 2 - 1, n / 2 - 1] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod09()
        {
            int n = 4;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[n / 2, n / 2 - 1] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod10()
        {
            int n = 4;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[n / 2 - 1, n / 2] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod11()
        {
            int n = 4;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[n / 2, n / 2] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod12()
        {
            int n = 4;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[n - 1, 0] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod13()
        {
            int n = 4;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[n - 1, n - 1] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod14()
        {
            int n = 5;
            double falseMax = 101;
            double[,] array = CreateMatrix(n);
            array[1, 0] = falseMax;
            bool check = falseMax == FindMax(array);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void TestMethod15()
        {
            int n = 5;
            double falseMax = 101;
            double[,] array = CreateMatrix(n);
            array[1, 4] = falseMax;
            bool check = falseMax == FindMax(array);
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void TestMethod16()
        {
            int n = 5;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[0, 1] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod17()
        {
            int n = 5;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[3, 1] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod18()
        {
            int n = 5;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[0, 0] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod19()
        {
            int n = 5;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[0, n - 1] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod20()
        {
            int n = 5;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[n / 2, n / 2] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod21()
        {
            int n = 5;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[n - 1, 0] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod22()
        {
            int n = 5;
            double trueMax = 101;
            double[,] array = CreateMatrix(n);
            array[n - 1, n - 1] = trueMax;
            bool check = trueMax == FindMax(array);
            Assert.AreEqual(true, check);
        }
    }
}
