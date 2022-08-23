namespace Calc
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool f = true;
            int a = 1;
            int b = 2;
            Assert.AreEqual(a,a);
            //Assert.AreNotEqual(a,a);
            //Assert.AreSame(a,a);
            //Assert.AreNotSame(a,b);
            //Assert.IsFalse(f);
            //Assert.IsTrue(f);
            //Assert.IsNull(a);
            //Assert.IsNotNull(b);
            //Assert.IsInstanceOfType(a, typeof(int));
            //Assert.IsNotInstanceOfType(a, typeof(string));
            ////Assert.ThrowsException();
            //Assert.Fail();
        }

        Calc calc = new Calc(2);

        [TestMethod]
        public void CalcMultiplyTest()
        {
            int i1 = calc.Multiply(2);//i1 = 4
            int i2 = calc.Multiply(2);//i2 = 8
            int i3 = calc.Multiply(2);//i3 = 16
            int i4 = calc.Multiply(2);//i4 = 32

            Assert.AreEqual(4,i1);
            Assert.AreEqual(8,i2);
            Assert.AreEqual(16,i3);
            Assert.AreEqual(32, i4);
               
        }
        [TestMethod]
        public void CalcDivideTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() =>
            {
                calc.Divide(0);
            });
        }
    }
}