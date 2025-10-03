using Tyuiu.AfoninME.Sprint1.Task7.V27.Lib;
namespace Tyuiu.AfoninME.Sprint1.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double expected = 0.530;
            double result = ds.Calculate(1, 2);
            Assert.AreEqual(expected, result);
        }
    }
}
