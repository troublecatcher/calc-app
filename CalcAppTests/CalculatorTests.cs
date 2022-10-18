using CalcApp;

namespace CalcAppTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalcTestSum()
        {
            var a = 1;
            var b = 1.5;
            var op = "+";
            var calculator = new Calculator();
            var result = calculator.Calc(a, b, op);
            Assert.IsTrue(result == a+b);
        }

        [TestMethod]
        public void CalcTestSubs()
        {
            var a = 2;
            var b = 2.5;
            var op = "-";
            var calculator = new Calculator();
            var result = calculator.Calc(a, b, op);
            Assert.IsTrue(result == a - b);
        }

        [TestMethod]
        public void CalcTestMult()
        {
            var a = 3;
            var b = 3.5;
            var op = "*";
            var calculator = new Calculator();
            double result = calculator.Calc(a, b, op);
            Assert.IsTrue(result == a * b);
        }

        [TestMethod]
        public void CalcTestDiv()
        {
            var a = 4;
            var b = 0;
            var op = "/";
            var calculator = new Calculator();
            double result = calculator.Calc(a, b, op);
            Assert.IsTrue(result == a / b);
        }

        [TestMethod]
        public void CalcTestNegative()
        {
            var a = 5.5;
            var b = 4.5;
            var op = "null";
            var calculator = new Calculator();
            Assert.ThrowsException<ArgumentException>(() => calculator.Calc(a, b, op));
        }
    }
}
