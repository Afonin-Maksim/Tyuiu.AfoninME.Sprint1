using Tyuiu.AfoninME.Sprint1.Task4.V12.Lib;
namespace Tyuiu.AfoninME.Sprint1.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double expected = 0.286;
            double result = ds.Calculate(0.5, 9);
            Assert.AreEqual(expected, result);
        }
    }
}